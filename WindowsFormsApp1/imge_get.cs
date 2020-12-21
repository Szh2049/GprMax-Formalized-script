using System;
using System.Diagnostics;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class imge_get : Form
    {
        public imge_get()
        {
            InitializeComponent();
        }

        public string path = null;
        public string sourcepath = null;
        public string name = null;

        private void A_scan2_Click(object sender, EventArgs e)
        {
            // 弹出新窗口
            Command_window_display f = new Command_window_display();

            status_bar.Text = "正在初始化！";
            Process p = new Process();
            p.StartInfo.FileName = "cmd.exe";     //设置要启动的应用程序       
            p.StartInfo.UseShellExecute = false;   //是否使用操作系统shell启动        
            p.StartInfo.RedirectStandardInput = true;   // 接受来自调用程序的输入信息        
            p.StartInfo.RedirectStandardOutput = true;  //输出信息            
            p.StartInfo.RedirectStandardError = true;  // 输出错误          
            p.StartInfo.CreateNoWindow = true;  //不显示程序窗口

            //启动程序
            p.Start();

            // A扫描绘图
            string strInput1 = "activate  gprmax";
            path += ".out";
            string strInput2 = "python -m tools.plot_Ascan " + path;

            Application.DoEvents();
            status_bar.Text = "正在生成！";
            //向cmd窗口发送输入信息
            p.StandardInput.WriteLine(strInput1);
            p.StandardInput.WriteLine(strInput2 + "&exit");

            //p.StandardInput.WriteLine("exit");

            p.StandardInput.AutoFlush = true;

            string strOuput = p.StandardOutput.ReadToEnd(); //获取输出信息

            p.WaitForExit();    //等待程序执行完退出进程
            p.Close();

            Application.DoEvents();
            status_bar.Text = "图像生成成功！";

            f.richTextBox1.Text = strOuput;
            f.ShowDialog();

        }

        private void A_scan1_Click(object sender, EventArgs e)
        {
            // 弹出新窗口
            Command_window_display f = new Command_window_display();

            status_bar.Text = "正在初始化！";
            Process p = new Process();
            p.StartInfo.FileName = "cmd.exe";     //设置要启动的应用程序       
            p.StartInfo.UseShellExecute = false;   //是否使用操作系统shell启动        
            p.StartInfo.RedirectStandardInput = true;   // 接受来自调用程序的输入信息        
            p.StartInfo.RedirectStandardOutput = true;  //输出信息            
            p.StartInfo.RedirectStandardError = true;  // 输出错误          
            p.StartInfo.CreateNoWindow = true;  //不显示程序窗口

            //启动程序
            p.Start();

            // A扫描
            string strInput1 = "activate  gprmax";
            string path1 = path + ".in";
            string strInput2 = "python -m gprMax " + path1;

            Application.DoEvents();  //多次导入
            status_bar.Text = "正在导入！";
            //向cmd窗口发送输入信息
            p.StandardInput.WriteLine(strInput1);
            p.StandardInput.WriteLine(strInput2 + "&exit");

            //p.StandardInput.WriteLine("exit");

            p.StandardInput.AutoFlush = true;

            string strOuput = p.StandardOutput.ReadToEnd(); //获取输出信息

            p.WaitForExit();    //等待程序执行完退出进程
            p.Close();

            Application.DoEvents();
            status_bar.Text = "导入成功！";

            f.richTextBox1.Text = strOuput;
            f.ShowDialog();
        }
        public int File_Copy1(string link)
        {
            //如果目标路径不存在,则创建目标路径
            string subPath = path + "/";
            if (!System.IO.Directory.Exists(subPath))
            {
                //创建文件夹
                System.IO.Directory.CreateDirectory(subPath);
            }

            
            //得到原文件根目录下的所有文件
            FileInfo fi1 = new FileInfo(path + ".in");
            FileInfo fi2 = new FileInfo(link);
            
            try
            {
                // Create the source file.
                // using (FileStream fs = fi1.Create()) { }
                //Ensure that the target file does not exist.
                if (File.Exists(link))
                {
                    fi2.Delete();
                }
                //Copy the file.f
                fi1.CopyTo(link);
                Console.WriteLine("{0} was copied to {1}.", path + ".in", link);
                return 1;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return 0;
            }
        }

        private void B_scan1_Click(object sender, EventArgs e)
        {
            // 弹出新窗口
            Command_window_display f = new Command_window_display();

            status_bar.Text = "正在初始化！";
            Process p = new Process();
            p.StartInfo.FileName = "cmd.exe";     //设置要启动的应用程序       
            p.StartInfo.UseShellExecute = false;   //是否使用操作系统shell启动        
            p.StartInfo.RedirectStandardInput = true;   // 接受来自调用程序的输入信息        
            p.StartInfo.RedirectStandardOutput = true;  //输出信息            
            p.StartInfo.RedirectStandardError = true;  // 输出错误          
            p.StartInfo.CreateNoWindow = true;  //不显示程序窗口

            //启动程序
            p.Start();

            //如果目标路径不存在,则创建目标路径           
            string subPath = System.IO.Path.Combine("{0}", "{1}", path, name + ".in");
            File_Copy1(subPath);

            // B扫描
            string strInput1 = "activate  gprmax";
            string strInput2 = "python -m gprMax " + subPath + " -n 60";

            Application.DoEvents();
            status_bar.Text = "正在生成文件，大概需要2分钟！";
            //向cmd窗口发送输入信息
            p.StandardInput.WriteLine(strInput1);
            p.StandardInput.WriteLine(strInput2 + "&exit");

            //p.StandardInput.WriteLine("exit");

            p.StandardInput.AutoFlush = true;

            string strOuput = p.StandardOutput.ReadToEnd(); //获取输出信息

            p.WaitForExit();    //等待程序执行完退出进程
            p.Close();

            Application.DoEvents();
            status_bar.Text = "导入成功！";

            f.richTextBox1.Text = strOuput;
            f.ShowDialog();
        }

        private void B_scan2_Click(object sender, EventArgs e)
        {
            // 弹出新窗口
            Command_window_display f = new Command_window_display();

            status_bar.Text = "正在初始化！";
            Process p = new Process();
            p.StartInfo.FileName = "cmd.exe";     //设置要启动的应用程序       
            p.StartInfo.UseShellExecute = false;   //是否使用操作系统shell启动        
            p.StartInfo.RedirectStandardInput = true;   // 接受来自调用程序的输入信息        
            p.StartInfo.RedirectStandardOutput = true;  //输出信息            
            p.StartInfo.RedirectStandardError = true;  // 输出错误          
            p.StartInfo.CreateNoWindow = true;  //不显示程序窗口

            //启动程序
            p.Start();

            //如果目标路径不存在,则创建目标路径           
            string subPath = System.IO.Path.Combine("{0}", "{1}", path, name + "_merged.out");

            // B扫描绘图
            string strInput1 = "activate  gprmax";
            string strInput2 = "python -m tools.plot_Bscan " + subPath + " Ez";

            Application.DoEvents();
            status_bar.Text = "正在导入！";
            //向cmd窗口发送输入信息
            p.StandardInput.WriteLine(strInput1);
            p.StandardInput.WriteLine(strInput2 + "&exit");

            //p.StandardInput.WriteLine("exit");

            p.StandardInput.AutoFlush = true;

            string strOuput = p.StandardOutput.ReadToEnd(); //获取输出信息

            p.WaitForExit();    //等待程序执行完退出进程
            p.Close();

            Application.DoEvents();
            status_bar.Text = "图像显示成功！";

            f.richTextBox1.Text = strOuput;
            f.ShowDialog();
        }

        private void combined_Click(object sender, EventArgs e)
        {
            // 弹出新窗口
            Command_window_display f = new Command_window_display();

            status_bar.Text = "正在初始化！";
            Process p = new Process();
            p.StartInfo.FileName = "cmd.exe";     //设置要启动的应用程序       
            p.StartInfo.UseShellExecute = false;   //是否使用操作系统shell启动        
            p.StartInfo.RedirectStandardInput = true;   // 接受来自调用程序的输入信息        
            p.StartInfo.RedirectStandardOutput = true;  //输出信息            
            p.StartInfo.RedirectStandardError = true;  // 输出错误          
            p.StartInfo.CreateNoWindow = true;  //不显示程序窗口

            //启动程序
            p.Start();

            //如果目标路径不存在,则创建目标路径           
            string subPath = System.IO.Path.Combine("{0}", "{1}", path, name);

            // B扫描绘图合成（不删）
            string strInput1 = "activate  gprmax";
            string strInput2 = "python -m tools.outputfiles_merge " + subPath;

            Application.DoEvents();
            status_bar.Text = "正在合成！";

            //向cmd窗口发送输入信息
            p.StandardInput.WriteLine(strInput1);
            p.StandardInput.WriteLine(strInput2 + "&exit");

            //p.StandardInput.WriteLine("exit");

            p.StandardInput.AutoFlush = true;

            string strOuput = p.StandardOutput.ReadToEnd(); //获取输出信息

            p.WaitForExit();    //等待程序执行完退出进程
            p.Close();

            Application.DoEvents();
            status_bar.Text = "合成成功！";

            f.richTextBox1.Text = strOuput;
            f.ShowDialog();
        }

        private void combined2_Click(object sender, EventArgs e)
        {
            // 弹出新窗口
            Command_window_display f = new Command_window_display();

            status_bar.Text = "正在初始化！";
            Process p = new Process();
            p.StartInfo.FileName = "cmd.exe";     //设置要启动的应用程序       
            p.StartInfo.UseShellExecute = false;   //是否使用操作系统shell启动        
            p.StartInfo.RedirectStandardInput = true;   // 接受来自调用程序的输入信息        
            p.StartInfo.RedirectStandardOutput = true;  //输出信息            
            p.StartInfo.RedirectStandardError = true;  // 输出错误          
            p.StartInfo.CreateNoWindow = true;  //不显示程序窗口

            //启动程序
            p.Start();

            //如果目标路径不存在,则创建目标路径           
            string subPath = System.IO.Path.Combine("{0}", "{1}", path, name);

            // B扫描绘图合成（删除）
            string strInput1 = "activate  gprmax";
            string strInput2 = "python -m tools.outputfiles_merge " + subPath + " --remove-files";

            Application.DoEvents();
            status_bar.Text = "正在合成！";

            //向cmd窗口发送输入信息
            p.StandardInput.WriteLine(strInput1);
            p.StandardInput.WriteLine(strInput2 + "&exit");

            //p.StandardInput.WriteLine("exit");

            p.StandardInput.AutoFlush = true;

            string strOuput = p.StandardOutput.ReadToEnd(); //获取输出信息

            p.WaitForExit();    //等待程序执行完退出进程
            p.Close();

            Application.DoEvents();
            status_bar.Text = "合成成功！";

            f.richTextBox1.Text = strOuput;
            f.ShowDialog();
        }

        private void A_scans_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
