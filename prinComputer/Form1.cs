using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace prinComputer
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        //记录发送和接收字节数
        int rxLength = 0;
        int txLength = 0;

        public Form1()
        {
            InitializeComponent();

        }
        /// <summary>
        /// 窗口加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            init();
            System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = false;
            
            timer1.Interval = 1000;
            timer1.Start();

            refreshCurrentTime.Interval = 1000;
            refreshCurrentTime.Start();
            currentTime.Text = "当前时间为: " + DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
            txLengthlabel.Text = "发送字节: " + txLength;
            rxLengthLable.Text = "接收字节: " + rxLength;
        }
        /// <summary>
        /// init
        /// </summary>
        private void init()
        {
            //添加事件处理程序
            serialPort1.DataReceived += new SerialDataReceivedEventHandler(serialPort1_DataReceived);
            //串口配置
            comboBox2.Text = config.Default.portBps;  
            sendDataBox.Text = config.Default.sendDataText;
            stopBox.Text = config.Default.portStop;
            dataBox.Text = config.Default.portData;
            checkoutBox.Text = config.Default.portCheck;
            comboBox1.Items.Add(config.Default.com);
            comboBox1.Text = config.Default.com;

            sendPeriodValue.Text = config.Default.periodValue.ToString();
            sendNewLineBox.Checked = config.Default.sendNewLineFlag;
            send_0x.Checked = config.Default.hexSendFlag;
            hexShowBox.Checked = config.Default.hexSendFlag;
            timeTickBox.Checked = config.Default.timeTickFlag;
            checkBox2.Checked = config.Default.rxBoxBkColor;

        }
        /// <summary>
        /// 打开或关闭串口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {

            if (btnOpen.Text.Equals("打开串口"))
            {
                try
                {
                    serialPort1.BaudRate = Convert.ToInt32(comboBox2.Text);
                    serialPort1.PortName = comboBox1.Text;
                    serialPort1.StopBits = (StopBits)Convert.ToInt32(stopBox.Text);
                    serialPort1.DataBits = Convert.ToInt32(dataBox.Text);
                    serialPort1.Parity = (Parity)0;
                    //解决中文乱码的问题
                    serialPort1.Encoding = System.Text.Encoding.GetEncoding("GB2312");
                    serialPort1.Open();
                    btnOpen.Text = "关闭串口";
                }
                catch
                {
                    MessageBox.Show("串口打开失败");
                }
            }
            else
            {
                try
                {
                    serialPort1.Close();
                    btnOpen.Text = "打开串口";
                }
                catch
                {
                    MessageBox.Show("出现意外,串口关闭失败");
                }
            }
        }
        /// <summary>
        /// 清空接收区
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            rxTextBox.Text = "";
            rxLength = 0;
            rxLengthLable.Text = "接收字节: " + rxLength;

        }
        /// <summary>
        /// 发送数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            if (!btnOpen.Text.Equals("关闭串口"))
            {
                MessageBox.Show("请打开串口");
                return;
            }
            Thread t = new Thread(sendDataThread);
            t.Start();
        }
        /// <summary>
        /// 发送数据线程
        /// </summary>
        private void sendDataThread()
        {
            String str = sendDataBox.Text;
            #region 发送十六进制
            if (send_0x.Checked)
            {
                TextBox t = new TextBox();
                t.Text = sendDataBox.Text;
                tool.oxToStringTool(t);
                str = t.Text;
            }
            #endregion
            #region 发送字符串
            {
                String[] data = str.Split('\n');

                for (int i = 0; i < data.Length; i++)
                {
                    int pos = data[i].LastIndexOf('\r');
                    if (pos != -1)
                    {
                        sendData(data[i].Remove(pos));
                    }
                    else
                    {
                        sendData(data[i]);
                    }
                    Thread.Sleep(20);
                }
            }
            #endregion

        }
        /// <summary>
        /// 清空发送区
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            sendDataBox.Text = "";
            txLength = 0;
            txLengthlabel.Text = "发送字节: " + txLength;
        }
        /// <summary>
        /// 获取可用串口
        /// </summary>
        private void getComPort() 
        {
            string[] ports = SerialPort.GetPortNames();//获得可用串口列表 
            string selectCom = comboBox1.Text;

            //更新可用串口列表
            if (comboBox1.Items.Count > 0)
            {
                for(int i=0; i< comboBox1.Items.Count; i++)
                {
                    comboBox1.Items.RemoveAt(i);
                }
            }

            foreach (string port in ports)  
            {
                comboBox1.Items.Add(port);
                if (port.Equals(selectCom))
                {
                    comboBox1.Text = selectCom;
                }
            }
            //如果有可用列表 则可用打开串口
            if(comboBox1.Items.Count > 0)
            {
                btnOpen.Enabled = true;
            }
            else
            {
                comboBox1.Text = "";
                btnOpen.Text = "打开串口";
                btnOpen.Enabled = false;
                if(serialPort1.IsOpen)
                {
                    serialPort1.Close();
                }
              
            }

        }
        /// <summary>
        /// 修改端口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            config.Default.com = comboBox1.Text;
            config.Default.Save();
        }
        /// <summary>
        /// 定时任务 一秒刷新一次可用串口列表
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            getComPort();
           
        }
        /// <summary>
        /// 是否十六进制发送
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void send_0x_CheckedChanged(object sender, EventArgs e)
        {
            if (send_0x.Checked == true)
            {
                tool.stringToOxTool(sendDataBox);
            }
            else
            {
                tool.oxToStringTool(sendDataBox);
            }
        }
        /// <summary>
        /// 接收区是否十六进制显示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void hexShowBox_CheckedChanged(object sender, EventArgs e)
        {
            if (hexShowBox.Checked == true)
            {
                tool.stringToOxTool(rxTextBox);
            }
            else
            {
                 tool.oxToStringTool(rxTextBox);
            }
        }
        /// <summary>
        /// 用于定时发送数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer2_Tick(object sender, EventArgs e)
        {
            sendData(sendDataBox.Text);
        }
        /// <summary>
        /// 定时发送
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBox1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                try
                {
                    int time = Convert.ToInt32(sendPeriodValue.Text);
                    timer2.Interval = time;
                    timer2.Start();
                 
                }
                catch
                {
                    MessageBox.Show("请输入正确的发送周期");
                    checkBox1.Checked = false;
                    sendPeriodValue.Text = "1000";
                }
            }
            else
            {
                timer2.Stop();
                
            }
        }
        /// <summary>
        /// 修改定时发送周期
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                timer2.Stop();
                try
                {
                    int time = Convert.ToInt32(sendPeriodValue.Text);
                    timer2.Interval = time;
                    timer2.Start();
                    sendPeriodValue.Enabled = true;
                    
                }
                catch
                {
                    checkBox1.Checked = false;
                    sendPeriodValue.Text = "1000";
                    MessageBox.Show("请输入正确的发送周期");
                }
            }
            
        }
        /// <summary>
        /// 判断是否输入为十六进制格式
        /// </summary>
        /// <param name="tb"></param>
        /// <param name="length"></param>
        private void judgeOx(TextBox tb,int length)
        {
            if (send_0x.Checked == true)
            {
                char[] arr = tb.Text.ToCharArray();

                string str = tb.Text;

                if (arr.Length == 0)
                {
                    return;
                }

                char newchar = arr[arr.Length - 1];

                if (!(newchar >= 'a' && newchar <= 'f'))
                {
                    if (!(newchar >= 'A' && newchar <= 'F'))
                    {
                        if (!(newchar >= '0' && newchar <= '9'))
                        {
                            if(newchar != ' ')
                            {
                                MessageBox.Show("请输入0-9 a-z A-Z之间的值");

                                length = tb.Text.Length - length;

                                tb.Text = str.Remove(str.Length - length, length);
                                //光标停留在最后
                                tb.SelectionStart = tb.Text.Length;
                            }
                           
                        }
                    }
                }
            }
        }
        /// <summary>
        /// 记录发送区数据长度
        /// </summary>
        private int lastSize = 0;
        /// <summary>
        /// 待发送数据区数据改变
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sendDataBox_TextChanged(object sender, EventArgs e)
        {
            judgeOx(sendDataBox, lastSize);
            lastSize = sendDataBox.Text.Length;
            
        }
        /// <summary>
        /// 改变显示面板颜色
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox2.Checked)
            {
                rxTextBox.BackColor = Color.White;
                rxTextBox.ForeColor = Color.Black;
            }
            else
            {
                rxTextBox.BackColor = Color.Black;
                rxTextBox.ForeColor = Color.White;
            }
           
        }
        /// <summary>
        /// 串口接收函数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string str = serialPort1.ReadExisting();//字符串方式读
            rxLength += str.Length;
            rxLengthLable.Text = "接收字节: " + rxLength;
            
            //添加时间戳
            if(timeTickBox.Checked)
            {
                int position = str.IndexOf("\r\n");
                if(position != -1)
                {
                    str =  str.Insert(position,"["+ DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss")+"]");
                }
            }
           
            //转换为十六进制
            if(hexShowBox.Checked)
            {
                TextBox t1 = new TextBox();
                t1.Text = rxTextBox.Text;
                tool.oxToStringTool(t1);
                t1.AppendText(str);
                tool.stringToOxTool(t1);
                rxTextBox.Text = t1.Text;
            }
            else
            {
                rxTextBox.AppendText(str);
            }
        }
        /// <summary>
        /// 发送数据
        /// </summary>
        /// <param name="str"></param>
        private void sendData(string str)
        {
            if (!btnOpen.Text.Equals("关闭串口"))
            {
                checkBox1.Checked = false;
                timer2.Stop();
                MessageBox.Show("请打开串口");
            }
            else
            {
                if (!str.Equals(""))
                {
                    if (sendNewLineBox.Checked)
                    {
                        str += "\r\n"; //以0x0d 0x0a结尾
                    }
                    try
                    {
                        serialPort1.WriteLine(str);
                        txLength += str.Length;
                        txLengthlabel.Text = "发送字节: " + txLength;
                    }
                    catch
                    {
                        serialPort1.Close();
                    }
                }
            }
        }
        /// <summary>
        /// 获取当前时间
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void refreshCurrentTime_Tick(object sender, EventArgs e)
        {
           currentTime.Text = "当前时间为: " + DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
        }
        /// <summary>
        /// 程序退出
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(serialPort1.IsOpen)
            {
                serialPort1.Close();
            }
            Application.Exit();
        }
        /// <summary>
        /// 调用计算器
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 计算器ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("calc");
        }
        /// <summary>
        /// 保存文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click_1(object sender, EventArgs e)
        {
            
            SaveFileDialog fileDialog = new SaveFileDialog();
            //选择文件类型
            fileDialog.Filter = "txt files(*.txt)|*.txt";
            //设置默认名
            fileDialog.FileName = "data";
            //添加扩展名
            fileDialog.AddExtension = true;
            //记录上次打开的目录
            fileDialog.RestoreDirectory = true;

            DialogResult result = fileDialog.ShowDialog();
            if(result == DialogResult.OK)
            {
                String localFilePath = fileDialog.FileName.ToString();
                //获取文件名
                //String fileName = localFilePath.Substring(localFilePath.LastIndexOf("\\")+1);
                //String filePath = localFilePath.Substring(0, localFilePath.LastIndexOf("\\"));

                FileStream file = new FileStream(localFilePath, FileMode.Create);
                //按照GB2312的格式编码
                Encoding gb = Encoding.GetEncoding("GB2312");
                byte[] data = gb.GetBytes(rxTextBox.Text);

               
                file.Write(data, 0, data.Length);
                file.Flush();
                file.Close();
            }


        }
        /// <summary>
        /// 选择发送文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openFileBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();

            fileDialog.Filter = "txt files(*.txt)|*.txt";
            fileDialog.RestoreDirectory = true;
            fileDialog.Title = "选择文件";
            if(fileDialog.ShowDialog() == DialogResult.OK)
            {
                sendFilePathBox.Text= fileDialog.FileName;
                
            }

        }
        /// <summary>
        /// 文件发送标志
        /// </summary>
        Boolean sendFileFlag = false;
        /// <summary>
        /// 开始发送文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sendFileBtn_Click(object sender, EventArgs e)
        {
            if (!btnOpen.Text.Equals("关闭串口"))
            {
                MessageBox.Show("请打开串口");
                return;
            }
            //启动发送线程
            Thread t = new Thread(sendFileThread);
            t.Start();
        }
        /// <summary>
        /// 发送文件线程
        /// </summary>
        private void sendFileThread()
        {
            StreamReader sr = new StreamReader(sendFilePathBox.Text, Encoding.Default);
            List<String> list = new List<string>();
            String line;
            while ((line = sr.ReadLine()) != null)
            {
                //使能了发送新行
                if(sendNewLineBox.Checked)
                {
                    if (line.IndexOf("\r\n") == -1)
                    {
                        line = line.Insert(line.Length, "\r\n");
                    }
                }
                list.Add(line);
            }
            String[] data = list.ToArray();
            progressBar1.Maximum = data.Length;
            progressBar1.Value = 0;
            for (int i = 0; i < data.Length; i++)
            {
                if (sendFileFlag)
                {
                    sendFileFlag = false;
                    break;
                }
                sendData(data[i]);
                progressBar1.Value++;
                sendFilePercentage.Text = (int)((progressBar1.Value * 100 )/ progressBar1.Maximum) + "%";
                Thread.Sleep(20);
            }
            progressBar1.Value = 0;
            sr.Close();
            sendFilePercentage.Text = "0%";
        }
        /// <summary>
        /// 停止文件发送
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void stopFileBtn_Click(object sender, EventArgs e)
        {
            sendFileFlag = true;
        }
        /// <summary>
        /// 关闭窗体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //是否发送十六进制
            config.Default.hexSendFlag = send_0x.Checked;
            //是否显示十六进制
            config.Default.hexShowFlag = hexShowBox.Checked;
            //是否发送新行
            config.Default.sendNewLineFlag = sendNewLineBox.Checked;
            //是否添加时间戳
            config.Default.timeTickFlag = timeTickBox.Checked;
            //是否修改背景色
            config.Default.rxBoxBkColor = checkBox2.Checked;
            //保存发送区数据
            config.Default.sendDataText = sendDataBox.Text;
            //定时周期
            config.Default.periodValue = Convert.ToInt32(sendPeriodValue.Text); 
            //串口配置
            config.Default.portCheck = checkoutBox.Text;
            config.Default.portData = dataBox.Text;
            config.Default.portStop = stopBox.Text;
            config.Default.portBps = comboBox2.Text;
            
            //保存数据
            config.Default.Save();
           
        }
        /// <summary>
        /// 恢复默认设置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 恢复默认设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            send_0x.Checked = defaultSetting.Default.hexSendFlag;
            comboBox1.Text = defaultSetting.Default.com;
            comboBox2.Text = defaultSetting.Default.portBps;
            stopBox.Text = defaultSetting.Default.portStop;
            dataBox.Text = defaultSetting.Default.portData;
            checkoutBox.Text = defaultSetting.Default.portCheck;

            sendDataBox.Text = defaultSetting.Default.sendDataText;
            sendPeriodValue.Text = defaultSetting.Default.periodValue.ToString();
            sendNewLineBox.Checked = defaultSetting.Default.sendNewLineFlag;
           
 
            hexShowBox.Checked = defaultSetting.Default.hexSendFlag;
            timeTickBox.Checked = defaultSetting.Default.timeTickFlag;
            checkBox2.Checked = defaultSetting.Default.rxBoxBkColor;
        }
    }
}
