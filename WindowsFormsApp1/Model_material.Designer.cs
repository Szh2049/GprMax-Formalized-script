
namespace WindowsFormsApp1
{
    partial class Model_material
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
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.f2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.f3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.f1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ident = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.f4 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("宋体", 11F);
            this.button1.Location = new System.Drawing.Point(298, 304);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 53);
            this.button1.TabIndex = 6;
            this.button1.Text = "确定并保存";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("SimSun-ExtB", 10.8F);
            this.label2.Location = new System.Drawing.Point(56, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 21);
            this.label2.TabIndex = 13;
            this.label2.Text = "电导率(S/m)：";
            // 
            // f2
            // 
            this.f2.Location = new System.Drawing.Point(201, 209);
            this.f2.Name = "f2";
            this.f2.Size = new System.Drawing.Size(100, 25);
            this.f2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("SimSun-ExtB", 10.8F);
            this.label3.Location = new System.Drawing.Point(400, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 21);
            this.label3.TabIndex = 11;
            this.label3.Text = "相对磁导率：";
            // 
            // f3
            // 
            this.f3.Location = new System.Drawing.Point(545, 161);
            this.f3.Name = "f3";
            this.f3.Size = new System.Drawing.Size(100, 25);
            this.f3.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("SimSun-ExtB", 10.8F);
            this.label1.Location = new System.Drawing.Point(56, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 21);
            this.label1.TabIndex = 9;
            this.label1.Text = "相对介电常数:";
            // 
            // f1
            // 
            this.f1.Location = new System.Drawing.Point(201, 159);
            this.f1.Name = "f1";
            this.f1.Size = new System.Drawing.Size(100, 25);
            this.f1.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("SimSun-ExtB", 10.8F);
            this.label6.Location = new System.Drawing.Point(197, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(469, 19);
            this.label6.TabIndex = 14;
            this.label6.Text = "模型的材料参数（可设置多种，用标识符来调用）：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Font = new System.Drawing.Font("SimSun-ExtB", 10.8F);
            this.label5.Location = new System.Drawing.Point(106, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 21);
            this.label5.TabIndex = 16;
            this.label5.Text = "标识符：";
            // 
            // ident
            // 
            this.ident.Location = new System.Drawing.Point(201, 113);
            this.ident.Name = "ident";
            this.ident.Size = new System.Drawing.Size(100, 25);
            this.ident.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("SimSun-ExtB", 10.8F);
            this.label4.Location = new System.Drawing.Point(350, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(191, 21);
            this.label4.TabIndex = 18;
            this.label4.Text = "磁损耗（欧姆/米）:";
            // 
            // f4
            // 
            this.f4.Location = new System.Drawing.Point(545, 209);
            this.f4.Name = "f4";
            this.f4.Size = new System.Drawing.Size(100, 25);
            this.f4.TabIndex = 5;
            // 
            // Model_material
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.f4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ident);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.f2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.f3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.f1);
            this.Controls.Add(this.button1);
            this.Name = "Model_material";
            this.Text = "Model_material";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox f2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox f3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox f1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ident;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox f4;
    }
}