namespace KontroluUygulama2
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.rbCpul7 = new System.Windows.Forms.RadioButton();
            this.rbCpul5 = new System.Windows.Forms.RadioButton();
            this.rbCpul3 = new System.Windows.Forms.RadioButton();
            this.rbCpuR5 = new System.Windows.Forms.RadioButton();
            this.rbCpuR3 = new System.Windows.Forms.RadioButton();
            this.rbRam16 = new System.Windows.Forms.RadioButton();
            this.rbRam8 = new System.Windows.Forms.RadioButton();
            this.rbRam4 = new System.Windows.Forms.RadioButton();
            this.rbHdd1000 = new System.Windows.Forms.RadioButton();
            this.rbHdd500 = new System.Windows.Forms.RadioButton();
            this.rbHdd320 = new System.Windows.Forms.RadioButton();
            this.cbDvd = new System.Windows.Forms.CheckBox();
            this.cbWebCam = new System.Windows.Forms.CheckBox();
            this.cbWfi = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbCpuR3);
            this.groupBox1.Controls.Add(this.rbCpuR5);
            this.groupBox1.Controls.Add(this.rbCpul3);
            this.groupBox1.Controls.Add(this.rbCpul5);
            this.groupBox1.Controls.Add(this.rbCpul7);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(9, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 186);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "İşlemciler";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbRam4);
            this.groupBox2.Controls.Add(this.rbRam8);
            this.groupBox2.Controls.Add(this.rbRam16);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(218, 10);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(208, 118);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ram Bellek";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbHdd320);
            this.groupBox3.Controls.Add(this.rbHdd500);
            this.groupBox3.Controls.Add(this.rbHdd1000);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.Location = new System.Drawing.Point(434, 11);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(216, 117);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sabit Disk";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cbWfi);
            this.groupBox4.Controls.Add(this.cbWebCam);
            this.groupBox4.Controls.Add(this.cbDvd);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox4.Location = new System.Drawing.Point(12, 202);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 123);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Ek Donanımlar";
            // 
            // btnHesapla
            // 
            this.btnHesapla.BackColor = System.Drawing.Color.OldLace;
            this.btnHesapla.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHesapla.Location = new System.Drawing.Point(237, 224);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(236, 88);
            this.btnHesapla.TabIndex = 4;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = false;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // rbCpul7
            // 
            this.rbCpul7.AutoSize = true;
            this.rbCpul7.Location = new System.Drawing.Point(6, 32);
            this.rbCpul7.Name = "rbCpul7";
            this.rbCpul7.Size = new System.Drawing.Size(107, 20);
            this.rbCpul7.TabIndex = 0;
            this.rbCpul7.TabStop = true;
            this.rbCpul7.Text = "Intel Core i7";
            this.rbCpul7.UseVisualStyleBackColor = true;
            // 
            // rbCpul5
            // 
            this.rbCpul5.AutoSize = true;
            this.rbCpul5.Location = new System.Drawing.Point(7, 59);
            this.rbCpul5.Name = "rbCpul5";
            this.rbCpul5.Size = new System.Drawing.Size(107, 20);
            this.rbCpul5.TabIndex = 1;
            this.rbCpul5.TabStop = true;
            this.rbCpul5.Text = "Intel Core i5";
            this.rbCpul5.UseVisualStyleBackColor = true;
            // 
            // rbCpul3
            // 
            this.rbCpul3.AutoSize = true;
            this.rbCpul3.Location = new System.Drawing.Point(7, 85);
            this.rbCpul3.Name = "rbCpul3";
            this.rbCpul3.Size = new System.Drawing.Size(107, 20);
            this.rbCpul3.TabIndex = 2;
            this.rbCpul3.TabStop = true;
            this.rbCpul3.Text = "Intel Core i3";
            this.rbCpul3.UseVisualStyleBackColor = true;
            // 
            // rbCpuR5
            // 
            this.rbCpuR5.AutoSize = true;
            this.rbCpuR5.Location = new System.Drawing.Point(7, 112);
            this.rbCpuR5.Name = "rbCpuR5";
            this.rbCpuR5.Size = new System.Drawing.Size(117, 20);
            this.rbCpuR5.TabIndex = 3;
            this.rbCpuR5.TabStop = true;
            this.rbCpuR5.Text = "AMD Ryzen 5";
            this.rbCpuR5.UseVisualStyleBackColor = true;
            // 
            // rbCpuR3
            // 
            this.rbCpuR3.AutoSize = true;
            this.rbCpuR3.Location = new System.Drawing.Point(7, 139);
            this.rbCpuR3.Name = "rbCpuR3";
            this.rbCpuR3.Size = new System.Drawing.Size(117, 20);
            this.rbCpuR3.TabIndex = 4;
            this.rbCpuR3.TabStop = true;
            this.rbCpuR3.Text = "AMD Ryzen 3";
            this.rbCpuR3.UseVisualStyleBackColor = true;
            // 
            // rbRam16
            // 
            this.rbRam16.AutoSize = true;
            this.rbRam16.Location = new System.Drawing.Point(7, 22);
            this.rbRam16.Name = "rbRam16";
            this.rbRam16.Size = new System.Drawing.Size(70, 20);
            this.rbRam16.TabIndex = 0;
            this.rbRam16.TabStop = true;
            this.rbRam16.Text = "16  GB";
            this.rbRam16.UseVisualStyleBackColor = true;
            // 
            // rbRam8
            // 
            this.rbRam8.AutoSize = true;
            this.rbRam8.Location = new System.Drawing.Point(7, 49);
            this.rbRam8.Name = "rbRam8";
            this.rbRam8.Size = new System.Drawing.Size(58, 20);
            this.rbRam8.TabIndex = 1;
            this.rbRam8.TabStop = true;
            this.rbRam8.Text = "8 GB";
            this.rbRam8.UseVisualStyleBackColor = true;
            // 
            // rbRam4
            // 
            this.rbRam4.AutoSize = true;
            this.rbRam4.Location = new System.Drawing.Point(6, 75);
            this.rbRam4.Name = "rbRam4";
            this.rbRam4.Size = new System.Drawing.Size(58, 20);
            this.rbRam4.TabIndex = 2;
            this.rbRam4.TabStop = true;
            this.rbRam4.Text = "4 GB";
            this.rbRam4.UseVisualStyleBackColor = true;
            // 
            // rbHdd1000
            // 
            this.rbHdd1000.AutoSize = true;
            this.rbHdd1000.Location = new System.Drawing.Point(7, 23);
            this.rbHdd1000.Name = "rbHdd1000";
            this.rbHdd1000.Size = new System.Drawing.Size(57, 20);
            this.rbHdd1000.TabIndex = 0;
            this.rbHdd1000.TabStop = true;
            this.rbHdd1000.Text = "1 TB";
            this.rbHdd1000.UseVisualStyleBackColor = true;
            // 
            // rbHdd500
            // 
            this.rbHdd500.AutoSize = true;
            this.rbHdd500.Location = new System.Drawing.Point(7, 50);
            this.rbHdd500.Name = "rbHdd500";
            this.rbHdd500.Size = new System.Drawing.Size(74, 20);
            this.rbHdd500.TabIndex = 1;
            this.rbHdd500.TabStop = true;
            this.rbHdd500.Text = "500 GB";
            this.rbHdd500.UseVisualStyleBackColor = true;
            // 
            // rbHdd320
            // 
            this.rbHdd320.AutoSize = true;
            this.rbHdd320.Location = new System.Drawing.Point(7, 74);
            this.rbHdd320.Name = "rbHdd320";
            this.rbHdd320.Size = new System.Drawing.Size(74, 20);
            this.rbHdd320.TabIndex = 2;
            this.rbHdd320.TabStop = true;
            this.rbHdd320.Text = "320 GB";
            this.rbHdd320.UseVisualStyleBackColor = true;
            // 
            // cbDvd
            // 
            this.cbDvd.AutoSize = true;
            this.cbDvd.Location = new System.Drawing.Point(6, 30);
            this.cbDvd.Name = "cbDvd";
            this.cbDvd.Size = new System.Drawing.Size(87, 20);
            this.cbDvd.TabIndex = 3;
            this.cbDvd.Text = "DVD RW";
            this.cbDvd.UseVisualStyleBackColor = true;
            // 
            // cbWebCam
            // 
            this.cbWebCam.AutoSize = true;
            this.cbWebCam.Location = new System.Drawing.Point(6, 54);
            this.cbWebCam.Name = "cbWebCam";
            this.cbWebCam.Size = new System.Drawing.Size(93, 20);
            this.cbWebCam.TabIndex = 4;
            this.cbWebCam.Text = "Web Cam";
            this.cbWebCam.UseVisualStyleBackColor = true;
            // 
            // cbWfi
            // 
            this.cbWfi.AutoSize = true;
            this.cbWfi.Location = new System.Drawing.Point(6, 76);
            this.cbWfi.Name = "cbWfi";
            this.cbWfi.Size = new System.Drawing.Size(118, 20);
            this.cbWfi.TabIndex = 5;
            this.cbWfi.Text = "Wireless Kart";
            this.cbWfi.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Plum;
            this.ClientSize = new System.Drawing.Size(696, 450);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rbCpuR3;
        private System.Windows.Forms.RadioButton rbCpuR5;
        private System.Windows.Forms.RadioButton rbCpul3;
        private System.Windows.Forms.RadioButton rbCpul5;
        private System.Windows.Forms.RadioButton rbCpul7;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.RadioButton rbRam4;
        private System.Windows.Forms.RadioButton rbRam8;
        private System.Windows.Forms.RadioButton rbRam16;
        private System.Windows.Forms.RadioButton rbHdd320;
        private System.Windows.Forms.RadioButton rbHdd500;
        private System.Windows.Forms.RadioButton rbHdd1000;
        private System.Windows.Forms.CheckBox cbWfi;
        private System.Windows.Forms.CheckBox cbWebCam;
        private System.Windows.Forms.CheckBox cbDvd;
    }
}

