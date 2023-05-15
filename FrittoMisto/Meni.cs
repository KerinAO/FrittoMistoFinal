using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrittoMisto
{
    public partial class Meni : Form
    {

        private PregledNarudzbe _pregledNarudzbe;

        public Meni()
        {
            InitializeComponent();
            _pregledNarudzbe = new PregledNarudzbe();
        }

        private void btnNazad_Click(object sender, EventArgs e)
        {
            Narudzba narudzba = new Narudzba();
            narudzba.Show();
            this.Close();
        }

        private void btnDalje_Click(object sender, EventArgs e)
        {
            _pregledNarudzbe.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("FrittoMisto je dodano na narudžbu", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

            _pregledNarudzbe.FrittoMistoCounter++;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("PesceCane je dodano na narudžbu", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

            _pregledNarudzbe.PesceCaneCounter++;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Mare-Scoglio je dodano na narudžbu", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

            _pregledNarudzbe.MareScoglioCounter++;
        }
    }
}
