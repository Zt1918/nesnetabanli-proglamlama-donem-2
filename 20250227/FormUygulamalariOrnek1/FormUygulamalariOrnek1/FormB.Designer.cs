﻿namespace FormUygulamalariOrnek1
{
    partial class FormB
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
            this.btnHide = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnHide
            // 
            this.btnHide.Location = new System.Drawing.Point(137, 51);
            this.btnHide.Name = "btnHide";
            this.btnHide.Size = new System.Drawing.Size(92, 23);
            this.btnHide.TabIndex = 0;
            this.btnHide.Text = "Hide";
            this.btnHide.UseVisualStyleBackColor = true;
            this.btnHide.Click += new System.EventHandler(this.btnHide_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(137, 80);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(92, 23);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FormB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 211);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnHide);
            this.Name = "FormB";
            this.Text = "FormB";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormB_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormB_FormClosed);
            this.Load += new System.EventHandler(this.FormB_Load);
            this.Click += new System.EventHandler(this.FormB_Click);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnHide;
        private System.Windows.Forms.Button btnClose;
    }
}