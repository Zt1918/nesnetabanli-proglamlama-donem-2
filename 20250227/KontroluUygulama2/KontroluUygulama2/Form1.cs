﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KontroluUygulama2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            decimal tabanFiyat = 500;
            decimal cpuFiyat = 0;
            if (rbCpul7.Checked)
                cpuFiyat = 300;
            else if (rbCpul5.Checked)
                cpuFiyat = 200;
            else if (rbCpul3.Checked)
                cpuFiyat = 13;
            else if (rbCpuR5.Checked)
                cpuFiyat = 250;
            else if (rbCpuR3.Checked)
                cpuFiyat = 150;
            tabanFiyat += cpuFiyat;

            decimal ramFiyat = 0;
            if (rbRam16.Checked)
                ramFiyat = 125;
            if (rbRam8.Checked)
                ramFiyat = 75;
            if (rbRam4.Checked)
                ramFiyat = 45;
            tabanFiyat += ramFiyat;
            MessageBox.Show(string.Format("toplam fiyat={0:C}", tabanFiyat));

        }
    }
}
