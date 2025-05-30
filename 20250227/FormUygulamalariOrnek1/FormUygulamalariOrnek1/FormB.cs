﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormUygulamalariOrnek1
{
    public partial class FormB : Form
    {
        public FormB()
        {
            InitializeComponent();
        }

        private void FormB_Load(object sender, EventArgs e)
        {
            MessageBox.Show("FormB yükleniyor.");
        }

        private void FormB_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("FormB kapanıyor.");
        }

        private void FormB_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("FormB kapandı.");
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormB_Click(object sender, EventArgs e)
        {
            MessageBox.Show("FormB click olayı çalışıyor.");
        }
    }
}
