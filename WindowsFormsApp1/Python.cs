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
    public partial class Python : Form
    {
        public Python()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            //清空Richtextbox
            foreach (object item in this.Controls)
            {
                if (item is RichTextBox)
                {
                    RichTextBox tb = item as RichTextBox;
                    tb.Text = "";
                }
            }
        }
        public string path = null;
        private void Button1_Click(object sender, EventArgs e)
        {
            string content = "\n" + this.python_code.Text;
            if(File.Exists(path))
            { 
                File.AppendAllText(path, content, Encoding.Default);
            }
            else
            {
                MessageBox.Show("不存在文件");
            }
            this.Dispose();
        }
    }
}
