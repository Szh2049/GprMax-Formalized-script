using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class model_in : Form
    {
        public model_in()
        {
            InitializeComponent();
        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
        string[] fillit(string str,int num)
        {
            int i = 0;
            string str1 = "";
            string[] model = new string[num];
            ////先将窗体上所有的控件遍历出来。
            foreach (Control item in this.Controls)
            {
                for (i = 1; i <= num; i++)
                { 
                    str1 = str + i.ToString();
                    //查找字串中指定字符或字串首次出现的位置,返首索引值;
                    if (item is TextBox && item.Name.IndexOf(str1) == 0)
                    {
                        model[i-1] = ((TextBox)item).Text;//获取文本框的值                       
                    }
                }
            }
            return model;
        }

        public string path = null;
        private void c_button_Click(object sender, EventArgs e)
        {   
            //圆柱体
            string[] f = new string[7];
            f = fillit("c", 7);

            string c_str = this.c_str.Text;
            string cylinder = "\n" + "#cylinder: ";
            for (int i = 0; i < 7; i++)
            {
                cylinder += (f[i] + " ");
            }
            cylinder += c_str;
            File.AppendAllText(path, cylinder);

            //清空textbox
            foreach (var item in this.Controls)
            {
                if (item is TextBox)
                {
                    TextBox tb = item as TextBox;
                    tb.Text = "";
                }
            }
        }

        private void t_button_Click(object sender, EventArgs e)
        {
            //三角形
            string[] f = new string[10];
            f = fillit("t", 10);

            string t_str = this.t_str.Text;
            string triangle = "\n" + "#triangle: ";
            for (int i = 0; i < 10; i++)
            {
                triangle += (f[i] + " ");
            }
            triangle += t_str;
            File.AppendAllText(path, triangle);

            //清空textbox
            foreach (var item in this.Controls)
            {
                if (item is TextBox)
                {
                    TextBox tb = item as TextBox;
                    tb.Text = "";
                }
            }

            /*
            Form tempChild = this.ActiveMdiChild;

            if (tempChild != null)
            {
                //遍历所有控件
                foreach (Control control in tempChild.Controls)
                {
                    if (control is TextBox)
                    {
                        //清掉含有TexBox控件上的内容
                        control.Text = "";
                    }
                    /*  //以下方法同上也能实现
                        TextBox textbox= control  as TextBox;
                        if (textbox!= null)
                        {
                            //清掉含有TexBox控件上的内容
                            textbox.Text = "";
                        }     
                    
                }
            }*/
        }

        private void s_button_Click(object sender, EventArgs e)
        {
            //球
            string[] f = new string[4];
            f = fillit("t", 4);

            string s_str = this.s_str.Text;
            string sphere = "\n" + "#sphere: ";
            for (int i = 0; i < 4; i++)
            {
                sphere += (f[i] + " ");
            }
            sphere += s_str;
            File.AppendAllText(path, sphere);

            //清空textbox
            foreach (var item in this.Controls)
            {
                if (item is TextBox)
                {
                    TextBox tb = item as TextBox;
                    tb.Text = "";
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
