
namespace WindowsFormsApp1
{
    partial class Imge_get
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Imge_get));
            this.A_scan1 = new System.Windows.Forms.Button();
            this.B_scan1 = new System.Windows.Forms.Button();
            this.A_scan2 = new System.Windows.Forms.Button();
            this.B_scan2 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.A_scans = new System.Windows.Forms.Button();
            this.combined = new System.Windows.Forms.Button();
            this.combined2 = new System.Windows.Forms.Button();
            this.status_bar1 = new System.Windows.Forms.Label();
            this.status_bar = new System.Windows.Forms.TextBox();
            this.n = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // A_scan1
            // 
            this.A_scan1.Font = new System.Drawing.Font("SimSun-ExtB", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.A_scan1.Location = new System.Drawing.Point(23, 118);
            this.A_scan1.Name = "A_scan1";
            this.A_scan1.Size = new System.Drawing.Size(120, 51);
            this.A_scan1.TabIndex = 35;
            this.A_scan1.Text = "A扫描";
            this.A_scan1.UseVisualStyleBackColor = true;
            this.A_scan1.Click += new System.EventHandler(this.A_scan1_Click);
            // 
            // B_scan1
            // 
            this.B_scan1.Font = new System.Drawing.Font("SimSun-ExtB", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.B_scan1.Location = new System.Drawing.Point(1074, 118);
            this.B_scan1.Name = "B_scan1";
            this.B_scan1.Size = new System.Drawing.Size(120, 51);
            this.B_scan1.TabIndex = 36;
            this.B_scan1.Text = "B扫描";
            this.B_scan1.UseVisualStyleBackColor = true;
            this.B_scan1.Click += new System.EventHandler(this.B_scan1_Click);
            // 
            // A_scan2
            // 
            this.A_scan2.Font = new System.Drawing.Font("SimSun-ExtB", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.A_scan2.Location = new System.Drawing.Point(23, 213);
            this.A_scan2.Name = "A_scan2";
            this.A_scan2.Size = new System.Drawing.Size(120, 51);
            this.A_scan2.TabIndex = 37;
            this.A_scan2.Text = "A扫描绘图";
            this.A_scan2.UseVisualStyleBackColor = true;
            this.A_scan2.Click += new System.EventHandler(this.A_scan2_Click);
            // 
            // B_scan2
            // 
            this.B_scan2.Font = new System.Drawing.Font("SimSun-ExtB", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.B_scan2.Location = new System.Drawing.Point(1074, 213);
            this.B_scan2.Name = "B_scan2";
            this.B_scan2.Size = new System.Drawing.Size(120, 51);
            this.B_scan2.TabIndex = 38;
            this.B_scan2.Text = "B扫描绘图";
            this.B_scan2.UseVisualStyleBackColor = true;
            this.B_scan2.Click += new System.EventHandler(this.B_scan2_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.richTextBox1.Location = new System.Drawing.Point(176, 118);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(860, 253);
            this.richTextBox1.TabIndex = 39;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // A_scans
            // 
            this.A_scans.Font = new System.Drawing.Font("SimSun-ExtB", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.A_scans.Location = new System.Drawing.Point(806, 430);
            this.A_scans.Name = "A_scans";
            this.A_scans.Size = new System.Drawing.Size(120, 51);
            this.A_scans.TabIndex = 40;
            this.A_scans.Text = "退出";
            this.A_scans.UseVisualStyleBackColor = true;
            this.A_scans.Click += new System.EventHandler(this.A_scans_Click);
            // 
            // combined
            // 
            this.combined.Font = new System.Drawing.Font("SimSun-ExtB", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.combined.Location = new System.Drawing.Point(404, 430);
            this.combined.Name = "combined";
            this.combined.Size = new System.Drawing.Size(120, 51);
            this.combined.TabIndex = 41;
            this.combined.Text = "文件合并";
            this.combined.UseVisualStyleBackColor = true;
            this.combined.Click += new System.EventHandler(this.Combined_Click);
            // 
            // combined2
            // 
            this.combined2.Font = new System.Drawing.Font("SimSun-ExtB", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.combined2.Location = new System.Drawing.Point(589, 430);
            this.combined2.Name = "combined2";
            this.combined2.Size = new System.Drawing.Size(120, 51);
            this.combined2.TabIndex = 42;
            this.combined2.Text = "文件合并2";
            this.combined2.UseVisualStyleBackColor = true;
            this.combined2.Click += new System.EventHandler(this.Combined2_Click);
            // 
            // status_bar1
            // 
            this.status_bar1.AllowDrop = true;
            this.status_bar1.AutoSize = true;
            this.status_bar1.Font = new System.Drawing.Font("SimSun-ExtB", 14.8F);
            this.status_bar1.Location = new System.Drawing.Point(471, 61);
            this.status_bar1.Name = "status_bar1";
            this.status_bar1.Size = new System.Drawing.Size(116, 25);
            this.status_bar1.TabIndex = 43;
            this.status_bar1.Text = "状态框：";
            // 
            // status_bar
            // 
            this.status_bar.Location = new System.Drawing.Point(578, 54);
            this.status_bar.Multiline = true;
            this.status_bar.Name = "status_bar";
            this.status_bar.Size = new System.Drawing.Size(213, 42);
            this.status_bar.TabIndex = 44;
            this.status_bar.Text = "显示操作状态信息。";
            // 
            // n
            // 
            this.n.Location = new System.Drawing.Point(1088, 66);
            this.n.Name = "n";
            this.n.Size = new System.Drawing.Size(100, 25);
            this.n.TabIndex = 45;
            this.n.Text = "198";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1098, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 15);
            this.label1.TabIndex = 46;
            this.label1.Text = "B扫描次数";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(41, 493);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(326, 41);
            this.progressBar1.TabIndex = 47;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F);
            this.label2.Location = new System.Drawing.Point(139, 444);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 20);
            this.label2.TabIndex = 48;
            this.label2.Text = "B扫描进度";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(263, 448);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 49;
            this.label3.Text = "进度";
            // 
            // timer1
            // 
            this.timer1.Interval = 300;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // Imge_get
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1242, 577);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.n);
            this.Controls.Add(this.status_bar);
            this.Controls.Add(this.status_bar1);
            this.Controls.Add(this.combined2);
            this.Controls.Add(this.combined);
            this.Controls.Add(this.A_scans);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.B_scan2);
            this.Controls.Add(this.A_scan2);
            this.Controls.Add(this.B_scan1);
            this.Controls.Add(this.A_scan1);
            this.Name = "Imge_get";
            this.Text = "imge_get";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button A_scan1;
        private System.Windows.Forms.Button B_scan1;
        private System.Windows.Forms.Button A_scan2;
        private System.Windows.Forms.Button B_scan2;
        private System.Windows.Forms.Button A_scans;
        private System.Windows.Forms.Button combined;
        private System.Windows.Forms.Button combined2;
        private System.Windows.Forms.Label status_bar1;
        public System.Windows.Forms.RichTextBox richTextBox1;
        public System.Windows.Forms.TextBox status_bar;
        private System.Windows.Forms.TextBox n;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer1;
    }
}