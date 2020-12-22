using System;
using System.Windows.Forms;
using System.IO;
using System.Drawing;

namespace WindowsFormsApp1
{

    public partial class Model_material : Form
    {
        private SolidBrush SegBrush; //   功控填充颜色所用brush 
        /// <summary>
        /// //绘制边框
        /// </summary>
        /// <param name="g"></param>
        /// <param name="color">lable背景颜色</param>
        /// <param name="color">边框颜色</param>
        /// <param name="x">label宽度</param>
        /// <param name="y">label高度</param>
        private void DrawBorder(System.Drawing.Graphics g, Color color, Color bordercolor, int x, int y)
        {


            SegBrush = new SolidBrush(color);
            Pen pen = new Pen(SegBrush, 1);
            //e.Graphics.FillRectangle(SegBrush, RcTime);


            label1.BorderStyle = BorderStyle.None;
            label1.BackColor = color;

            pen.Color = Color.White;

            Rectangle myRectangle = new Rectangle(0, 0, x, y);
            ControlPaint.DrawBorder(g, myRectangle, bordercolor, ButtonBorderStyle.Solid);//画个边框
                                                                                          // g.DrawRectangle(pen, myRectangle);
                                                                                          //g.DrawEllipse(pen, myRectangle);
        }

        private void label1_Paint(object sender, PaintEventArgs e)
        {
            DrawBorder(e.Graphics, Color.Red, Color.Blue, label1.Width, label1.Height);
        }
     

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
            if (File.Exists(path))
            {
                for (int i = 0; i < 4; i++)
                {
                    material += (f[i] + " ");
                }
                material += ident;
                File.AppendAllText(path, material);
            }
            else
            {
                MessageBox.Show("不存在文件");
            }
            this.Dispose();
        }
    }
}
