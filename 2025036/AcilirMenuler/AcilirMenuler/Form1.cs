using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AcilirMenuler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void menuKes_Click(object sender, EventArgs e)
        {
            txtEditor.Cut();
        }

        private void menuKopya_Click(object sender, EventArgs e)
        {
            txtEditor.Copy();
        }

        private void menuYapistir_Click(object sender, EventArgs e)
        {
            txtEditor.Paste();
        }

        private void kesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtEditor.Cut();
        }

        private void kopyalaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtEditor.Copy();
        }

        private void yapıştırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtEditor.Paste();
        }

        private void menuKaydet_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd=new SaveFileDialog();
            sfd.Filter = "text dosyası|*.txt|resim dosyalar*.jpg;png|tüm dosylar|*.*";
            DialogResult cevap = sfd.ShowDialog();
            if(cevap == DialogResult.OK)
            {
                txtEditor.SaveFile(sfd.FileName,RichTextBoxStreamType.PlainText);
            }
        }

        private void menuAc_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd=new OpenFileDialog();
            ofd.Filter  = "text dosyaları|*.txt";
            DialogResult cevap=ofd.ShowDialog();
            if(cevap==DialogResult.OK)
            {
                txtEditor.LoadFile(ofd.FileName,RichTextBoxStreamType.PlainText);
            }
        }

        private void menuYazdir_Click(object sender, EventArgs e)
        {
            PrintDialog pd=new PrintDialog();
            DialogResult cevap = pd.ShowDialog();
            if(cevap == DialogResult.OK)
            {
                belge.Print();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

        }

        private void yazıTipiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void renkToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void menuYaziTipi_Click(object sender, EventArgs e)
        {
            FontDialog fd=new FontDialog();
            if(fd.ShowDialog() == DialogResult.OK)
            {
                txtEditor.Font = fd.Font;
            }
        }

        private void menuRenk_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
            {
                txtEditor.SelectionColor = cd.Color;
            }
        }
    }
}
