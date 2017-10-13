namespace prinComputer
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.rxTextBox = new System.Windows.Forms.TextBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.sendDataBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.stopBox = new System.Windows.Forms.ComboBox();
            this.dataLable = new System.Windows.Forms.Label();
            this.dataBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.checkoutBox = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.sendPeriodValue = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.send_0x = new System.Windows.Forms.CheckBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabpage1 = new System.Windows.Forms.TabPage();
            this.sendFilePercentage = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.stopFileBtn = new System.Windows.Forms.Button();
            this.sendFileBtn = new System.Windows.Forms.Button();
            this.openFileBtn = new System.Windows.Forms.Button();
            this.sendFilePathBox = new System.Windows.Forms.TextBox();
            this.sendNewLineBox = new System.Windows.Forms.CheckBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.hexShowBox = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.timeTickBox = new System.Windows.Forms.CheckBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.恢复默认设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.计算器ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.rxLengthLable = new System.Windows.Forms.ToolStripStatusLabel();
            this.txLengthlabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.currentTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.refreshCurrentTime = new System.Windows.Forms.Timer(this.components);
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripSplitButton();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabpage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "波特率";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.comboBox1.Location = new System.Drawing.Point(12, 14);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(157, 20);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.TabStop = false;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "115200"});
            this.comboBox2.Location = new System.Drawing.Point(66, 40);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(103, 20);
            this.comboBox2.TabIndex = 3;
            this.comboBox2.TabStop = false;
            // 
            // rxTextBox
            // 
            this.rxTextBox.BackColor = System.Drawing.SystemColors.InfoText;
            this.rxTextBox.ForeColor = System.Drawing.SystemColors.Control;
            this.rxTextBox.Location = new System.Drawing.Point(0, 3);
            this.rxTextBox.Multiline = true;
            this.rxTextBox.Name = "rxTextBox";
            this.rxTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.rxTextBox.Size = new System.Drawing.Size(560, 314);
            this.rxTextBox.TabIndex = 4;
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(66, 152);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(109, 23);
            this.btnOpen.TabIndex = 5;
            this.btnOpen.Text = "打开串口";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.button1_Click);
            // 
            // sendDataBox
            // 
            this.sendDataBox.Location = new System.Drawing.Point(6, 6);
            this.sendDataBox.Multiline = true;
            this.sendDataBox.Name = "sendDataBox";
            this.sendDataBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.sendDataBox.Size = new System.Drawing.Size(644, 72);
            this.sendDataBox.TabIndex = 6;
            this.sendDataBox.TabStop = false;
            this.sendDataBox.TextChanged += new System.EventHandler(this.sendDataBox_TextChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(656, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "发送";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(660, 205);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(81, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "清除接收";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(656, 55);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 9;
            this.button4.Text = "清除发送";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 10;
            this.label3.Text = "停止位";
            // 
            // stopBox
            // 
            this.stopBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.stopBox.FormattingEnabled = true;
            this.stopBox.Items.AddRange(new object[] {
            "1",
            "1.5",
            "2"});
            this.stopBox.Location = new System.Drawing.Point(66, 66);
            this.stopBox.Name = "stopBox";
            this.stopBox.Size = new System.Drawing.Size(103, 20);
            this.stopBox.TabIndex = 11;
            // 
            // dataLable
            // 
            this.dataLable.AutoSize = true;
            this.dataLable.Location = new System.Drawing.Point(6, 95);
            this.dataLable.Name = "dataLable";
            this.dataLable.Size = new System.Drawing.Size(41, 12);
            this.dataLable.TabIndex = 12;
            this.dataLable.Text = "数据位";
            // 
            // dataBox
            // 
            this.dataBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dataBox.FormattingEnabled = true;
            this.dataBox.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8"});
            this.dataBox.Location = new System.Drawing.Point(66, 92);
            this.dataBox.Name = "dataBox";
            this.dataBox.Size = new System.Drawing.Size(103, 20);
            this.dataBox.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 14;
            this.label4.Text = "奇偶校验";
            // 
            // checkoutBox
            // 
            this.checkoutBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.checkoutBox.FormattingEnabled = true;
            this.checkoutBox.Items.AddRange(new object[] {
            "无",
            "奇校验",
            "偶校验"});
            this.checkoutBox.Location = new System.Drawing.Point(66, 118);
            this.checkoutBox.Name = "checkoutBox";
            this.checkoutBox.Size = new System.Drawing.Size(103, 20);
            this.checkoutBox.TabIndex = 15;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.checkoutBox);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dataBox);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.dataLable);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.stopBox);
            this.groupBox1.Controls.Add(this.btnOpen);
            this.groupBox1.Location = new System.Drawing.Point(566, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(181, 196);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "串口选择";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 157);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 16;
            this.label8.Text = "串口操作";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(6, 96);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(72, 16);
            this.checkBox1.TabIndex = 16;
            this.checkBox1.Text = "定时发送";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.Click += new System.EventHandler(this.checkBox1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(90, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 17;
            this.label5.Text = "周期";
            // 
            // sendPeriodValue
            // 
            this.sendPeriodValue.Location = new System.Drawing.Point(125, 94);
            this.sendPeriodValue.Name = "sendPeriodValue";
            this.sendPeriodValue.Size = new System.Drawing.Size(55, 21);
            this.sendPeriodValue.TabIndex = 18;
            this.sendPeriodValue.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(186, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 16);
            this.label6.TabIndex = 19;
            this.label6.Text = "ms";
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // send_0x
            // 
            this.send_0x.AutoSize = true;
            this.send_0x.Location = new System.Drawing.Point(6, 121);
            this.send_0x.Name = "send_0x";
            this.send_0x.Size = new System.Drawing.Size(84, 16);
            this.send_0x.TabIndex = 22;
            this.send_0x.Text = "16进制发送";
            this.send_0x.UseVisualStyleBackColor = true;
            this.send_0x.CheckedChanged += new System.EventHandler(this.send_0x_CheckedChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabpage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 323);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(754, 176);
            this.tabControl1.TabIndex = 23;
            // 
            // tabpage1
            // 
            this.tabpage1.Controls.Add(this.sendFilePercentage);
            this.tabpage1.Controls.Add(this.progressBar1);
            this.tabpage1.Controls.Add(this.stopFileBtn);
            this.tabpage1.Controls.Add(this.sendFileBtn);
            this.tabpage1.Controls.Add(this.openFileBtn);
            this.tabpage1.Controls.Add(this.sendFilePathBox);
            this.tabpage1.Controls.Add(this.sendNewLineBox);
            this.tabpage1.Controls.Add(this.sendPeriodValue);
            this.tabpage1.Controls.Add(this.button4);
            this.tabpage1.Controls.Add(this.send_0x);
            this.tabpage1.Controls.Add(this.label5);
            this.tabpage1.Controls.Add(this.label6);
            this.tabpage1.Controls.Add(this.checkBox1);
            this.tabpage1.Controls.Add(this.sendDataBox);
            this.tabpage1.Controls.Add(this.button2);
            this.tabpage1.Location = new System.Drawing.Point(4, 22);
            this.tabpage1.Name = "tabpage1";
            this.tabpage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabpage1.Size = new System.Drawing.Size(746, 150);
            this.tabpage1.TabIndex = 0;
            this.tabpage1.Text = "数据发送";
            this.tabpage1.UseVisualStyleBackColor = true;
            // 
            // sendFilePercentage
            // 
            this.sendFilePercentage.AutoSize = true;
            this.sendFilePercentage.Location = new System.Drawing.Point(481, 125);
            this.sendFilePercentage.Name = "sendFilePercentage";
            this.sendFilePercentage.Size = new System.Drawing.Size(17, 12);
            this.sendFilePercentage.TabIndex = 28;
            this.sendFilePercentage.Text = "0%";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(216, 123);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(259, 21);
            this.progressBar1.TabIndex = 27;
            // 
            // stopFileBtn
            // 
            this.stopFileBtn.Location = new System.Drawing.Point(653, 92);
            this.stopFileBtn.Name = "stopFileBtn";
            this.stopFileBtn.Size = new System.Drawing.Size(75, 23);
            this.stopFileBtn.TabIndex = 26;
            this.stopFileBtn.Text = "停止发送";
            this.stopFileBtn.UseVisualStyleBackColor = true;
            this.stopFileBtn.Click += new System.EventHandler(this.stopFileBtn_Click);
            // 
            // sendFileBtn
            // 
            this.sendFileBtn.Location = new System.Drawing.Point(570, 92);
            this.sendFileBtn.Name = "sendFileBtn";
            this.sendFileBtn.Size = new System.Drawing.Size(75, 23);
            this.sendFileBtn.TabIndex = 25;
            this.sendFileBtn.Text = "发送文件";
            this.sendFileBtn.UseVisualStyleBackColor = true;
            this.sendFileBtn.Click += new System.EventHandler(this.sendFileBtn_Click);
            // 
            // openFileBtn
            // 
            this.openFileBtn.Location = new System.Drawing.Point(481, 93);
            this.openFileBtn.Name = "openFileBtn";
            this.openFileBtn.Size = new System.Drawing.Size(75, 23);
            this.openFileBtn.TabIndex = 24;
            this.openFileBtn.Text = "打开文件";
            this.openFileBtn.UseVisualStyleBackColor = true;
            this.openFileBtn.Click += new System.EventHandler(this.openFileBtn_Click);
            // 
            // sendFilePathBox
            // 
            this.sendFilePathBox.Location = new System.Drawing.Point(216, 96);
            this.sendFilePathBox.Name = "sendFilePathBox";
            this.sendFilePathBox.ReadOnly = true;
            this.sendFilePathBox.Size = new System.Drawing.Size(259, 21);
            this.sendFilePathBox.TabIndex = 17;
            // 
            // sendNewLineBox
            // 
            this.sendNewLineBox.AutoSize = true;
            this.sendNewLineBox.Location = new System.Drawing.Point(96, 121);
            this.sendNewLineBox.Name = "sendNewLineBox";
            this.sendNewLineBox.Size = new System.Drawing.Size(72, 16);
            this.sendNewLineBox.TabIndex = 23;
            this.sendNewLineBox.Text = "发送新行";
            this.sendNewLineBox.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(746, 150);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "关于作者";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(0, 6);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(737, 138);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(574, 205);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 23);
            this.button1.TabIndex = 24;
            this.button1.Text = "保存窗口";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // hexShowBox
            // 
            this.hexShowBox.AutoSize = true;
            this.hexShowBox.Location = new System.Drawing.Point(574, 244);
            this.hexShowBox.Name = "hexShowBox";
            this.hexShowBox.Size = new System.Drawing.Size(84, 16);
            this.hexShowBox.TabIndex = 25;
            this.hexShowBox.Text = "16进制显示";
            this.hexShowBox.UseVisualStyleBackColor = true;
            this.hexShowBox.CheckedChanged += new System.EventHandler(this.hexShowBox_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(657, 244);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(72, 16);
            this.checkBox2.TabIndex = 26;
            this.checkBox2.Text = "白底黑字";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // timeTickBox
            // 
            this.timeTickBox.AutoSize = true;
            this.timeTickBox.Location = new System.Drawing.Point(575, 275);
            this.timeTickBox.Name = "timeTickBox";
            this.timeTickBox.Size = new System.Drawing.Size(156, 16);
            this.timeTickBox.TabIndex = 27;
            this.timeTickBox.Text = "时间戳(以换行回车断帧)";
            this.timeTickBox.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.toolStripStatusLabel2,
            this.rxLengthLable,
            this.txLengthlabel,
            this.currentTime});
            this.statusStrip1.Location = new System.Drawing.Point(0, 500);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(756, 22);
            this.statusStrip1.TabIndex = 28;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.AutoSize = false;
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.恢复默认设置ToolStripMenuItem,
            this.计算器ToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(50, 20);
            this.toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            // 
            // 恢复默认设置ToolStripMenuItem
            // 
            this.恢复默认设置ToolStripMenuItem.Name = "恢复默认设置ToolStripMenuItem";
            this.恢复默认设置ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.恢复默认设置ToolStripMenuItem.Text = "恢复默认设置";
            this.恢复默认设置ToolStripMenuItem.Click += new System.EventHandler(this.恢复默认设置ToolStripMenuItem_Click);
            // 
            // 计算器ToolStripMenuItem
            // 
            this.计算器ToolStripMenuItem.Name = "计算器ToolStripMenuItem";
            this.计算器ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.计算器ToolStripMenuItem.Text = "计算器";
            this.计算器ToolStripMenuItem.Click += new System.EventHandler(this.计算器ToolStripMenuItem_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.AutoSize = false;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(255, 17);
            this.toolStripStatusLabel2.Text = "copyright 2017 matt";
            // 
            // rxLengthLable
            // 
            this.rxLengthLable.AutoSize = false;
            this.rxLengthLable.Name = "rxLengthLable";
            this.rxLengthLable.Size = new System.Drawing.Size(90, 17);
            this.rxLengthLable.Text = "接收字节";
            // 
            // txLengthlabel
            // 
            this.txLengthlabel.AutoSize = false;
            this.txLengthlabel.Name = "txLengthlabel";
            this.txLengthlabel.Size = new System.Drawing.Size(90, 17);
            this.txLengthlabel.Text = "发送字节";
            // 
            // currentTime
            // 
            this.currentTime.AutoSize = false;
            this.currentTime.Name = "currentTime";
            this.currentTime.Size = new System.Drawing.Size(256, 17);
            this.currentTime.Spring = true;
            this.currentTime.Text = "当前时间:";
            // 
            // refreshCurrentTime
            // 
            this.refreshCurrentTime.Tick += new System.EventHandler(this.refreshCurrentTime_Tick);
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(72, 21);
            this.toolStripStatusLabel3.Text = "清空计数";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 522);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.timeTickBox);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.hexShowBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.rxTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "串口调试助手V1.0";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabpage1.ResumeLayout(false);
            this.tabpage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

       
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox rxTextBox;
        private System.Windows.Forms.Button btnOpen;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.TextBox sendDataBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox stopBox;
        private System.Windows.Forms.Label dataLable;
        private System.Windows.Forms.ComboBox dataBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox checkoutBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox sendPeriodValue;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.CheckBox send_0x;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabpage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.CheckBox sendNewLineBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox hexShowBox;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox timeTickBox;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel currentTime;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem 恢复默认设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 计算器ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.Timer refreshCurrentTime;
        private System.Windows.Forms.ToolStripStatusLabel rxLengthLable;
        private System.Windows.Forms.ToolStripStatusLabel txLengthlabel;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button stopFileBtn;
        private System.Windows.Forms.Button sendFileBtn;
        private System.Windows.Forms.Button openFileBtn;
        private System.Windows.Forms.TextBox sendFilePathBox;
        private System.Windows.Forms.Label sendFilePercentage;
        private System.Windows.Forms.ToolStripSplitButton toolStripStatusLabel3;
        private System.Windows.Forms.TextBox textBox1;
    }
}

