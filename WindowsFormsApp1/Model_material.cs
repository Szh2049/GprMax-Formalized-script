using System;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class Model_material : Form
    {
        public Model_material()
        {
            InitializeComponent();
        }
        public string path= null;

        private void button1_Click(object sender, EventArgs e)
        {
            string[] f = new string[4];
            f[0] = this.f1.Text;
            f[1] = this.f2.Text;
            f[2] = this.f3.Text;
            f[3] = this.f4.Text;
            string ident = this.ident.Text;
            string material = "\n" + "#material: ";
            for (int i = 0;i<4;i++)
            {
                material += (f[i] + " ");
            }
            material += ident;
            File.AppendAllText(path,material);
            this.Dispose();
        }
    }
}
