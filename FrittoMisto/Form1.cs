using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrittoMisto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnNarudzba_Click(object sender, EventArgs e)
        {
            Narudzba narudzba = new Narudzba();
            narudzba.Show();
        }

        private void btnPoziv_Click(object sender, EventArgs e)
        {
            string phoneNumber = "1234567890"; 
            Process.Start("tel:" + phoneNumber);
        }
    }
}
