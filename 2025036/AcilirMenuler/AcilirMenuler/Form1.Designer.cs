namespace AcilirMenuler
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
            this.components = new System.ComponentModel.Container();
            this.txtEditor = new System.Windows.Forms.RichTextBox();
            this.cmDuzen = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.kesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kopyalaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yapıştırToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDosya = new System.Windows.Forms.ToolStripMenuItem();
            this.menuYeni = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAc = new System.Windows.Forms.ToolStripMenuItem();
            this.menuKaydet = new System.Windows.Forms.ToolStripMenuItem();
            this.menuYazdir = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDuzen = new System.Windows.Forms.ToolStripMenuItem();
            this.menuKes = new System.Windows.Forms.ToolStripMenuItem();
            this.menuKopya = new System.Windows.Forms.ToolStripMenuItem();
            this.menuYapistir = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCikis = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuYaziTipi = new System.Windows.Forms.ToolStripMenuItem();
            this.belge = new System.Drawing.Printing.PrintDocument();
            this.menuRenk = new System.Windows.Forms.ToolStripMenuItem();
            this.cmDuzen.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtEditor
            // 
            this.txtEditor.ContextMenuStrip = this.cmDuzen;
            this.txtEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtEditor.Location = new System.Drawing.Point(0, 24);
            this.txtEditor.Name = "txtEditor";
            this.txtEditor.Size = new System.Drawing.Size(800, 426);
            this.txtEditor.TabIndex = 1;
            this.txtEditor.Text = "";
            // 
            // cmDuzen
            // 
            this.cmDuzen.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kesToolStripMenuItem,
            this.kopyalaToolStripMenuItem,
            this.yapıştırToolStripMenuItem});
            this.cmDuzen.Name = "cmDuzen";
            this.cmDuzen.Size = new System.Drawing.Size(117, 70);
            // 
            // kesToolStripMenuItem
            // 
            this.kesToolStripMenuItem.Name = "kesToolStripMenuItem";
            this.kesToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.kesToolStripMenuItem.Text = "Kes";
            this.kesToolStripMenuItem.Click += new System.EventHandler(this.kesToolStripMenuItem_Click);
            // 
            // kopyalaToolStripMenuItem
            // 
            this.kopyalaToolStripMenuItem.Name = "kopyalaToolStripMenuItem";
            this.kopyalaToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.kopyalaToolStripMenuItem.Text = "Kopyala";
            this.kopyalaToolStripMenuItem.Click += new System.EventHandler(this.kopyalaToolStripMenuItem_Click);
            // 
            // yapıştırToolStripMenuItem
            // 
            this.yapıştırToolStripMenuItem.Name = "yapıştırToolStripMenuItem";
            this.yapıştırToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.yapıştırToolStripMenuItem.Text = "Yapıştır";
            this.yapıştırToolStripMenuItem.Click += new System.EventHandler(this.yapıştırToolStripMenuItem_Click);
            // 
            // menuDosya
            // 
            this.menuDosya.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuYeni,
            this.menuAc,
            this.menuKaydet,
            this.menuYazdir});
            this.menuDosya.Name = "menuDosya";
            this.menuDosya.Size = new System.Drawing.Size(51, 20);
            this.menuDosya.Text = "Dosya";
            // 
            // menuYeni
            // 
            this.menuYeni.Name = "menuYeni";
            this.menuYeni.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.menuYeni.Size = new System.Drawing.Size(180, 22);
            this.menuYeni.Text = "Yeni";
            // 
            // menuAc
            // 
            this.menuAc.Name = "menuAc";
            this.menuAc.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.menuAc.Size = new System.Drawing.Size(180, 22);
            this.menuAc.Text = "Aç";
            this.menuAc.Click += new System.EventHandler(this.menuAc_Click);
            // 
            // menuKaydet
            // 
            this.menuKaydet.Name = "menuKaydet";
            this.menuKaydet.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.menuKaydet.Size = new System.Drawing.Size(180, 22);
            this.menuKaydet.Text = "Kaydet";
            this.menuKaydet.Click += new System.EventHandler(this.menuKaydet_Click);
            // 
            // menuYazdir
            // 
            this.menuYazdir.Name = "menuYazdir";
            this.menuYazdir.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.menuYazdir.Size = new System.Drawing.Size(180, 22);
            this.menuYazdir.Text = "Yazdır";
            this.menuYazdir.Click += new System.EventHandler(this.menuYazdir_Click);
            // 
            // menuDuzen
            // 
            this.menuDuzen.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuKes,
            this.menuKopya,
            this.menuYapistir});
            this.menuDuzen.Name = "menuDuzen";
            this.menuDuzen.Size = new System.Drawing.Size(52, 20);
            this.menuDuzen.Text = "Düzen";
            // 
            // menuKes
            // 
            this.menuKes.Name = "menuKes";
            this.menuKes.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.menuKes.Size = new System.Drawing.Size(158, 22);
            this.menuKes.Text = "Kes";
            this.menuKes.Click += new System.EventHandler(this.menuKes_Click);
            // 
            // menuKopya
            // 
            this.menuKopya.Name = "menuKopya";
            this.menuKopya.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.menuKopya.Size = new System.Drawing.Size(158, 22);
            this.menuKopya.Text = "Kopyala";
            this.menuKopya.Click += new System.EventHandler(this.menuKopya_Click);
            // 
            // menuYapistir
            // 
            this.menuYapistir.Name = "menuYapistir";
            this.menuYapistir.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.menuYapistir.Size = new System.Drawing.Size(158, 22);
            this.menuYapistir.Text = "Yapıştır";
            this.menuYapistir.Click += new System.EventHandler(this.menuYapistir_Click);
            // 
            // menuCikis
            // 
            this.menuCikis.Name = "menuCikis";
            this.menuCikis.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.menuCikis.Size = new System.Drawing.Size(44, 20);
            this.menuCikis.Text = "Çıkış";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuDosya,
            this.menuDuzen,
            this.menuYaziTipi,
            this.menuRenk,
            this.menuCikis});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuYaziTipi
            // 
            this.menuYaziTipi.Name = "menuYaziTipi";
            this.menuYaziTipi.Size = new System.Drawing.Size(61, 20);
            this.menuYaziTipi.Text = "Yazı Tipi";
            this.menuYaziTipi.Click += new System.EventHandler(this.menuYaziTipi_Click);
            // 
            // belge
            // 
            this.belge.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // menuRenk
            // 
            this.menuRenk.Name = "menuRenk";
            this.menuRenk.Size = new System.Drawing.Size(49, 20);
            this.menuRenk.Text = "Biçim";
            this.menuRenk.Click += new System.EventHandler(this.menuRenk_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtEditor);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.cmDuzen.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox txtEditor;
        private System.Windows.Forms.ToolStripMenuItem menuDosya;
        private System.Windows.Forms.ToolStripMenuItem menuYeni;
        private System.Windows.Forms.ToolStripMenuItem menuAc;
        private System.Windows.Forms.ToolStripMenuItem menuKaydet;
        private System.Windows.Forms.ToolStripMenuItem menuYazdir;
        private System.Windows.Forms.ToolStripMenuItem menuDuzen;
        private System.Windows.Forms.ToolStripMenuItem menuKes;
        private System.Windows.Forms.ToolStripMenuItem menuKopya;
        private System.Windows.Forms.ToolStripMenuItem menuYapistir;
        private System.Windows.Forms.ToolStripMenuItem menuCikis;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ContextMenuStrip cmDuzen;
        private System.Windows.Forms.ToolStripMenuItem kesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kopyalaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yapıştırToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuYaziTipi;
        private System.Drawing.Printing.PrintDocument belge;
        private System.Windows.Forms.ToolStripMenuItem menuRenk;
    }
}

