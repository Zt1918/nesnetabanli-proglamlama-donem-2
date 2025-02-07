using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
         List<Derss> list = new List<Derss>();
        private void btnHesapla_Click(object sender, EventArgs e)
        {
            string dersAdi=txtDersAdi.Text;
            int dersSaati=Convert.ToInt32(txtDersSaati.Text);
            double not1=Convert.ToInt32(txtNot1.Text);
            double not2=Convert.ToInt32(txtNot2.Text);

            int Not1, Not2;
            double ortalama;
            Not1 = Convert.ToInt32(txtNot1.Text);
            Not2 = Convert.ToInt32(txtNot2.Text);
            ortalama = (Not1 + Not2) / 2.0;
            MessageBox.Show("Ortalamanız: " + ortalama);




            Derss derss=new Derss(dersAdi, dersSaati, not1, not2);
            list.Add(derss);


            Listele();
            Temizle();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dgvDers.CurrentRow != null)
            {
                int index = dgvDers.CurrentRow.Index; 
                list.RemoveAt(index);
                Listele();
            }
        }
        void Listele()
        {
            dgvDers.DataSource = null;
            dgvDers.DataSource = list.ToList();
        }
        void Temizle()
        {
           txtDersAdi.Clear();
           txtDersSaati.Clear();
           txtNot1.Clear();
           txtNot2.Clear();
        }

        string OzetYazdir()
        {
            double toplam = 0;
            string ozet = "";
            for (int i = 0; i < dgvDers.Rows.Count; ++i)
            {
                toplam += Convert.ToInt32(dgvDers.Rows[i].Cells[4].Value);
            }
            ozet = $"Toplam: {toplam}\nKDV: {toplam * 0.1}\nToplam Ödenecek Tutar: {toplam *1.1}";
            return ozet;
        }

        private void dgvDers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Derss derss1 = new Derss("edebiyat", 4, 55, 50);
            list.Add(derss1);
            Listele();
        }

        private void lblOrt_Click(object sender, EventArgs e)
        {

        }
    }
}
