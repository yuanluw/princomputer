using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prinComputer
{
    public class tool
    {

        /// <summary>
        /// 字符串转十六进制
        /// </summary>
        /// <param name="tb"></param>
        public static void stringToOxTool(TextBox tb)
        {
            StringBuilder sb = new StringBuilder();
            Encoding gb = Encoding.GetEncoding("GB2312");
            byte[] values = gb.GetBytes(tb.Text);

            foreach (byte item in values)
            {
                int value = Convert.ToInt32(item);
                string newstr = String.Format("{0:X}", value) + " ";
                sb.Append(newstr);
            }
            tb.Text = sb.ToString();
        }

        /// <summary>
        /// 十六进制转字符串
        /// </summary>
        /// <param name="tb"></param>
        public static void oxToStringTool(TextBox tb)
        {
            List<byte> list = new List<byte>();
            StringBuilder sb = new StringBuilder();
            String[] str = tb.Text.Split(' ');
            Encoding gb = Encoding.GetEncoding("GB2312");

            foreach (String item in str)
            {
                if (item == " ")
                {
                    list.Add(0x20);
                }
                else if (item == "\r")
                {
                    list.Add(0x0d);
                }
                else if (item == "\n")
                {
                    list.Add(0x0a);
                }
                else
                {
                    try
                    {
                        byte value = Convert.ToByte(item, 16);
                        list.Add(value);
                    }
                    catch
                    {
                        list.AddRange((gb.GetBytes(item)));
                    }
                }

            }
            tb.Text = gb.GetString(list.ToArray());
        }

             
    }
}
