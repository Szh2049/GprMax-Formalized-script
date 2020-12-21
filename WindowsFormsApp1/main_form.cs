using System;
using System.Diagnostics;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace WindowsFormsApp1
{
    public partial class main_form : Form
    {
        public main_form()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 使用说明，弹出新窗口
            instructions f = new instructions();
            f.ShowDialog();
        }


        private void button4_Click(object sender, EventArgs e)
        {   //传递path地址
            string model_name = this.text_name.Text;
            string catalog = @comboBox1.SelectedItem.ToString();
            string path = System.IO.Path.Combine("{0}", "{1}", catalog, model_name);

            // 材料的弹出新窗口
            Model_material f = new Model_material();
            f.path = path;
            f.ShowDialog();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            //实现打开一个文件夹的功能
            FolderBrowserDialog FolderBrowserDialog = new FolderBrowserDialog();//声明并初始化FolderBrowserDialog类
            FolderBrowserDialog.Description = "请选择想要保存的文件夹";
            string path = "";
            if (FolderBrowserDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                path = FolderBrowserDialog.SelectedPath;   // "e:/go"
            }
            comboBox1.Items.Add(path);
            comboBox1.Text = path;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);  //退出
        }


        private void button2_Click(object sender, EventArgs e)
        {
            string model_name = this.text_name.Text;
            // 参数确定
            string title = this.title.Text;
            // iterations = input("请输入模型时间窗口的迭代次数：")
            // domain
            string[] xyz = new string[3];
            xyz[0] = this.domain_x.Text;
            xyz[1] = this.domain_y.Text;
            xyz[2] = this.domain_z.Text;

            // dx_dy_dz
            string[] dx_dy_dz = new string[3];
            //printf("\n请指定x，y和z方向上的空间离散（即∆𝑥，∆𝑦，∆𝑧）。")
            dx_dy_dz[0] = this.dx.Text;
            dx_dy_dz[1] = this.dy.Text;
            dx_dy_dz[2] = this.dz.Text;

            string time_window = this.time_window.Text;
            /*
            // f1,f2,f3,f4
            string f1 = this.f1.Text;
            string f2 = this.f2.Text;
            string f3 = this.f3.Text;
            string f4 = this.f4.Text;
            */
            // 获得保存的地址
            string catalog = @comboBox1.SelectedItem.ToString();

            //文件路径
            string filePath = @catalog;

            //检测文件夹是否存在，不存在则创建
            /*
            if (System.IO.File.Exists(@"c:\\window\system32\test.exe")) //判断文件存在
            {
                //文件存在
            }
            */
            if (!(System.IO.Directory.Exists(filePath)))//判断文件夹存在
            {
                //文件夹不存在
                System.IO.Directory.CreateDirectory(filePath); //创建文件夹
            }

            //创建一个空白文件
            //将两个路径合成一个路径，自动处理路径分隔符的问题
            string path = System.IO.Path.Combine("{0}", "{1}", filePath, model_name + ".in");
            System.IO.File.Create(path).Dispose();//创建后要释放

            /*
            //定义编码方式，text1.Text为文本框控件中的内容
            byte[] mybyte = Encoding.UTF8.GetBytes(path);
            string mystr1 = Encoding.UTF8.GetString(mybyte);
            

            //写入文件
            //File.WriteAllBytes(filePath,mybyte);//写入新文件
            //File.WriteAllText(filePath, mystr1);//写入新文件
            File.AppendAllText(filePath, mystr1);//添加至文件
            */

            //true就持续增加，false会覆盖掉第一次的
            StreamWriter sw = new StreamWriter(path, true, System.Text.Encoding.Default);
            if (title.Length > 0)
            {
                sw.WriteLine("#title:" + " " + title);
            }
            sw.Close(); //关闭文件

            if (xyz.Length > 2)
            {
                File.AppendAllText(path, "#domain:" + " ");

                for (int i = 0; i < 3; i++)
                {
                    //输入后自动直接关闭文件
                    File.AppendAllText(path, xyz[i].ToString() + " ");
                }
                File.AppendAllText(path, "\n");
            }

            if (dx_dy_dz.Length > 2)
            {
                File.AppendAllText(path, "#dx_dy_dz:" + " ");

                for (int i = 0; i < 3; i++)
                {
                    //输入后自动直接关闭文件
                    File.AppendAllText(path, dx_dy_dz[i].ToString() + " ");
                }
                File.AppendAllText(path, "\n");
            }

            if (time_window.Length > 0)
            {
                File.AppendAllText(path, "#time_window:" + " " + time_window);
            }

            if(model_name.Length > 1)
                textBox10.Text = "创建模型成功！";
            else
            {
                textBox10.Text = "创建了一个无名模型！";
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {
            // 弹出新窗口
            Command_window_display f = new Command_window_display();

            /*
            Console.WriteLine("请输入要执行的命令:");
            string strInput = Console.ReadLine();
            */
            Thread.Sleep(500);//睡眠500毫秒，也就是0.5秒
            textBox10.Text = "";

            textBox10.Text = "正在初始化！";
            Process p = new Process();
            //设置要启动的应用程序
            p.StartInfo.FileName = "cmd.exe";
            //是否使用操作系统shell启动
            p.StartInfo.UseShellExecute = false;
            // 接受来自调用程序的输入信息
            p.StartInfo.RedirectStandardInput = true;
            //输出信息
            p.StartInfo.RedirectStandardOutput = true;
            // 输出错误
            p.StartInfo.RedirectStandardError = true;
            //不显示程序窗口
            p.StartInfo.CreateNoWindow = true;


            Thread.Sleep(500);//睡眠500毫秒，也就是0.5秒
            textBox10.Text = "";


            //启动程序
            p.Start();

            string model_name = this.text_name.Text;
            string catalog = @comboBox1.SelectedItem.ToString();

            string strInput1 = "activate  gprmax";
            string path = System.IO.Path.Combine("{0}", "{1}", catalog, model_name + ".in");
            string strInput2 = "python -m gprMax " + path + " --geometry-only";


            textBox10.Text = "初始化成功，正在导入！";
            Thread.Sleep(500);//睡眠500毫秒，也就是0.5秒
            textBox10.Text = "";

            //向cmd窗口发送输入信息
            p.StandardInput.WriteLine(strInput1);
            p.StandardInput.WriteLine(strInput2 + "&exit");

            //p.StandardInput.WriteLine("exit");

            p.StandardInput.AutoFlush = true;

            //获取输出信息
            string strOuput = p.StandardOutput.ReadToEnd();
            //等待程序执行完退出进程
            p.WaitForExit();
            p.Close();

            textBox10.Text = "导入成功！！";
            
            f.richTextBox1.Text = strOuput;
            f.ShowDialog();
            /*
            Console.WriteLine(strOuput);
            Console.ReadKey();
            */

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedItem.ToString()) //获取选择的内容
            {

                case "D:\\Temp": MessageBox.Show("请不要重复添加！"); break;

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //传递path地址
            string model_name = this.text_name.Text;
            string catalog = @comboBox1.SelectedItem.ToString();
            string path = System.IO.Path.Combine("{0}", "{1}", catalog, model_name + ".in");

            model_in f = new model_in();
            f.path = path;
            f.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //传递path地址
            string model_name = this.text_name.Text;
            string catalog = @comboBox1.SelectedItem.ToString();
            string path = System.IO.Path.Combine("{0}", "{1}", catalog, model_name + ".in");

            // 材料的弹出新窗口
            Python f = new Python();
            f.path = path;
            f.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //传递path地址
            string model_name = this.text_name.Text;
            string catalog = @comboBox1.SelectedItem.ToString();
            string path = System.IO.Path.Combine("{0}", "{1}", catalog, model_name);
            

            // 材料的弹出新窗口
            imge_get f = new imge_get();
            f.path = path;
            f.name = model_name;
            f.sourcepath = catalog;
            f.ShowDialog();

        }
    }
}
