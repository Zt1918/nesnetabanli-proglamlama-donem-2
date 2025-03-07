using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VeriDogrulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ErrorProvider ep=new ErrorProvider();

        private void txtNumara_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNumara_Validating(object sender, CancelEventArgs e)
        {
            if(int.TryParse(txtNumara.Text, out int sonuc))
            {
                ep.SetError(txtNumara, "");
            }
            else
            {
                e.Cancel = true;
                ep.SetError(txtNumara, "numara giriş hatalı");
            }
        }

        private void txtAdSoyad_Validating(object sender, CancelEventArgs e)
        {
            if (txtAdSoyad.Text == "")
            {
                e.Cancel=true;
                ep.SetError(txtAdSoyad, "adı ve soyad giriniz");
            }
            else
            {
                ep.SetError(txtAdSoyad, "");
            }
        }

        private void txtDersNotu_Validating(object sender, CancelEventArgs e)
        {
            int dersNotu;
            if(int.TryParse(txtDersNotu.Text, out dersNotu))
            {
                if (dersNotu < 0 || dersNotu > 100)
                {
                    e.Cancel = true;
                    ep.SetError(txtDersNotu, "0-100 arasında değer giriniz.");
                }
                else
                {
                    ep.SetError(txtDersNotu, "");
                }
            }
            else
            {
                e.Cancel=true;
                ep.SetError(txtDersNotu, "sayısal değer giriniz");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
