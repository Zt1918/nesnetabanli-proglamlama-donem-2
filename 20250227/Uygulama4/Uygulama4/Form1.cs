using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uygulama4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            int adet = Convert.ToInt32(txtAdet.Text);

            for (int i = 1; i <= adet; i++)
            {
                TextBox yeniTextBox = new TextBox();
                yeniTextBox.Name = "txtSayi" + i;
                yeniTextBox.Width = 150;
                flowLayoutPanel1.Controls.Add(yeniTextBox);
            }
            Button btn = new Button();
            btn.Name = "btnTopla";
            btn.Text = "topla";
            btn.Size = new Size(150, 40);

            flowLayoutPanel1.Controls.Add(btn);
            btn.Click += Btn_Click;
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
