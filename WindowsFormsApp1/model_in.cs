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
    public partial class Model_in : Form
    {
        public Model_in()
        {
            InitializeComponent();
        }
        private void TextBox4_TextChanged(object sender, EventArgs e)
        {

        }
        string[] Fillit(string str,int num)
        {
            
            string[] model = new string[num];
            ////先将窗体上所有的控件遍历出来。
            foreach (Control item in this.Controls)
            {
                for (int i = 1; i <= num; i++)
                { 
                    string str1 = str + i.ToString();
                    //查找字串中指定字符或字串首次出现的位置,返首索引值;
                    if (item is TextBox box && item.Name.IndexOf(str1) == 0)
                    {
                        model[i-1] = box.Text;//获取文本框的值                       
                    }
                }
            }
            return model;
        }

        public string path = null;
        private void C_button_Click(object sender, EventArgs e)
        {
            //圆柱体
            string[] f = new string[7];
            f = Fillit("c", 7);

            string c_str = this.c_str.Text;
            string cylinder = "\n" + "#cylinder: ";
            try
            {
                if (File.Exists(path))
                {
                    for (int i = 0; i < 7; i++)
                    {
                        cylinder += (f[i] + " ");
                    }
                    cylinder += c_str;
                    File.AppendAllText(path, cylinder);
                }
                else
                { 
                    MessageBox.Show("不存在文件");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //清空textbox
            foreach (object item in this.Controls)
                {
                    if (item is TextBox)
                    {
                        TextBox tb = item as TextBox;
                        tb.Text = "";
                    }
                }
            
        
        }

        private void Button_Click(object sender, EventArgs e)
        {
            //三角形
            string[] f = new string[10];
            f = Fillit("t", 10);

            string t_str = this.t_str.Text;
            string triangle = "\n" + "#triangle: ";
            if (File.Exists(path))
            {
                for (int i = 0; i < 10; i++)
                {
                        triangle += (f[i] + " ");
                }
                triangle += t_str;
                File.AppendAllText(path, triangle);
            }
            else
            {
                MessageBox.Show("不存在文件");
            }

            //清空textbox
            foreach (object item in this.Controls)
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
            f = Fillit("t", 4);

            string s_str = this.s_str.Text;
            string sphere = "\n" + "#sphere: ";
            if (File.Exists(path))
            {
                for (int i = 0; i < 4; i++)
                {
                    sphere += (f[i] + " ");
                }
                sphere += s_str;
                File.AppendAllText(path, sphere);
            }
            else
            {
                MessageBox.Show("不存在文件");
            }

            //清空textbox
            foreach (object item in this.Controls)
            {
                if (item is TextBox)
                {
                    TextBox tb = item as TextBox;
                    tb.Text = "";
                }
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
