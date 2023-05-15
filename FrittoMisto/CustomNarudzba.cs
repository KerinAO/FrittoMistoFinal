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
    public partial class CustomNarudzba : Form
    {
        private PregledNarudzbe _pregledNarudzbe;

        public CustomNarudzba()
        {
            InitializeComponent();
            _pregledNarudzbe = new PregledNarudzbe();
        }

        private void btnDalje_Click(object sender, EventArgs e)
        {
            _pregledNarudzbe.Show();
            this.Close();
        }

        private void btnNazad_Click(object sender, EventArgs e)
        {
            Narudzba narudzba = new Narudzba();
            narudzba.Show();
            this.Close();
        }

        private int counter1 = 0;
        private int counter2 = 0;
        private int counter3 = 0;
        private int counter4 = 0;
        private int counter5 = 0;
        private int counter6 = 0;
        private int counter7 = 0;
        private int counter8 = 0;
        private int counter9 = 0;
        private int counter10 = 0;
        private int counter11 = 0;
        private int counter12 = 0;
        private int counter13 = 0;
        private int counter14 = 0;
        private int counter15 = 0;
        private int counter16 = 0;

        private void btnOrada_Click(object sender, EventArgs e)
        {
            _pregledNarudzbe.OradaCounter++;

            counter1++;
            string text1 = "Orada x" + counter1.ToString();
            int start = rtbIspis.Find("Orada x");
            if (start >= 0)
            {
                int length = ("Orada x" + counter1.ToString()).Length;
                rtbIspis.Select(start, length);
                rtbIspis.SelectedText = text1 + "   ";
            }
            else
            {
                rtbIspis.SelectedText = text1 + Environment.NewLine;
            }

        }

        private void btnBrancin_Click(object sender, EventArgs e)
        {
            _pregledNarudzbe.BrancinCounter++;

            counter2++;
            string text2 = "Brancin x" + counter2.ToString();
            int start = rtbIspis.Find("Brancin x");
            if (start >= 0)
            {
                int length = ("Brancin x" + counter2.ToString()).Length;
                rtbIspis.Select(start, length);
                rtbIspis.SelectedText = text2 + "   ";
            }
            else
            {
                rtbIspis.SelectedText = text2 + Environment.NewLine;
            }
        }

        private void btnCipal_Click(object sender, EventArgs e)
        {
            _pregledNarudzbe.CipalCounter++;

            counter3++;
            string text3 = "Cipal x" + counter3.ToString();
            int start = rtbIspis.Find("Cipal x");
            if (start >= 0)
            {
                int length = ("Cipal x" + counter3.ToString()).Length;
                rtbIspis.Select(start, length);
                rtbIspis.SelectedText = text3 + "   ";
            }
            else
            {
                rtbIspis.SelectedText = text3 + Environment.NewLine;
            }
        }

        private void btnSkusa_Click(object sender, EventArgs e)
        {
            _pregledNarudzbe.SkusaCounter++;

            counter4++;
            string text4 = "Skuša x" + counter4.ToString();
            int start = rtbIspis.Find("Skuša x");
            if (start >= 0)
            {
                int length = ("Skuša x" + counter4.ToString()).Length;
                rtbIspis.Select(start, length);
                rtbIspis.SelectedText = text4 + "   ";
            }
            else
            {
                rtbIspis.SelectedText = text4 + Environment.NewLine;
            }
        }

        private void btnOslic_Click(object sender, EventArgs e)
        {
            _pregledNarudzbe.OslicCounter++;

            counter5++;
            string text5 = "Oslić x" + counter5.ToString();
            int start = rtbIspis.Find("Oslić x");
            if (start >= 0)
            {
                int length = ("Oslić x" + counter5.ToString()).Length;
                rtbIspis.Select(start, length);
                rtbIspis.SelectedText = text5 + "   ";
            }
            else
            {
                rtbIspis.SelectedText = text5 + Environment.NewLine;
            }
        }

        private void btnTuna_Click(object sender, EventArgs e)
        {
            _pregledNarudzbe.TunaCounter++;

            counter6++;
            string text6 = "Tuna x" + counter6.ToString();
            int start = rtbIspis.Find("Tuna x");
            if (start >= 0)
            {
                int length = ("Tuna x" + counter6.ToString()).Length;
                rtbIspis.Select(start, length);
                rtbIspis.SelectedText = text6 + "   ";
            }
            else
            {
                rtbIspis.SelectedText = text6 + Environment.NewLine;
            }
        }

        private void btnSkampi_Click(object sender, EventArgs e)
        {
            _pregledNarudzbe.SkampiCounter++;

            counter7++;
            string text7 = "Škampi x" + counter7.ToString();
            int start = rtbIspis.Find("Škampi x");
            if (start >= 0)
            {
                int length = ("Škampi x" + counter7.ToString()).Length;
                rtbIspis.Select(start, length);
                rtbIspis.SelectedText = text7 + "   ";
            }
            else
            {
                rtbIspis.SelectedText = text7 + Environment.NewLine;
            }
        }

        private void btnKozice_Click(object sender, EventArgs e)
        {
            _pregledNarudzbe.KoziceCounter++;

            counter8++;
            string text8 = "Kozice x" + counter8.ToString();
            int start = rtbIspis.Find("Kozice x");
            if (start >= 0)
            {
                int length = ("Kozice x" + counter8.ToString()).Length;
                rtbIspis.Select(start, length);
                rtbIspis.SelectedText = text8 + "   ";
            }
            else
            {
                rtbIspis.SelectedText = text8 + Environment.NewLine;
            }
        }

        private void btnJastog_Click(object sender, EventArgs e)
        {
            _pregledNarudzbe.JastogCounter++;

            counter9++;
            string text9 = "Jastog x" + counter9.ToString();
            int start = rtbIspis.Find("Jastog x");
            if (start >= 0)
            {
                int length = ("Jastog x" + counter9.ToString()).Length;
                rtbIspis.Select(start, length);
                rtbIspis.SelectedText = text9 + "   ";
            }
            else
            {
                rtbIspis.SelectedText = text9 + Environment.NewLine;
            }
        }

        private void btnDagnje_Click(object sender, EventArgs e)
        {
            _pregledNarudzbe.DagnjeCounter++;

            counter10++;
            string text10 = "Dagnje x" + counter10.ToString();
            int start = rtbIspis.Find("Dagnje x");
            if (start >= 0)
            {
                int length = ("Dagnje x" + counter10.ToString()).Length;
                rtbIspis.Select(start, length);
                rtbIspis.SelectedText = text10 + "   ";
            }
            else
            {
                rtbIspis.SelectedText = text10 + Environment.NewLine;
            }
        }

        private void btnKamenice_Click(object sender, EventArgs e)
        {
            _pregledNarudzbe.KameniceCounter++;

            counter11++;
            string text11 = "Kamenice x" + counter11.ToString();
            int start = rtbIspis.Find("Kamenice x");
            if (start >= 0)
            {
                int length = ("Kamenice x" + counter11.ToString()).Length;
                rtbIspis.Select(start, length);
                rtbIspis.SelectedText = text11 + "   ";
            }
            else
            {
                rtbIspis.SelectedText = text11 + Environment.NewLine;
            }
        }

        private void btnVongole_Click(object sender, EventArgs e)
        {
            _pregledNarudzbe.VongoleCounter++;

            counter12++;
            string text12 = "Vongole x" + counter12.ToString();
            int start = rtbIspis.Find("Vongole x");
            if (start >= 0)
            {
                int length = ("Vongole x" + counter12.ToString()).Length;
                rtbIspis.Select(start, length);
                rtbIspis.SelectedText = text12 + "   ";
            }
            else
            {
                rtbIspis.SelectedText = text12 + Environment.NewLine;
            }
        }

        private void btnKapesante_Click(object sender, EventArgs e)
        {
            _pregledNarudzbe.KapesanteCounter++;

            counter13++;
            string text13 = "Kapesante x" + counter13.ToString();
            int start = rtbIspis.Find("Kapesante x");
            if (start >= 0)
            {
                int length = ("Kapesante x" + counter13.ToString()).Length;
                rtbIspis.Select(start, length);
                rtbIspis.SelectedText = text13 + "   ";
            }
            else
            {
                rtbIspis.SelectedText = text13 + Environment.NewLine;
            }
        }

        private void btnJegulja_Click(object sender, EventArgs e)
        {
            _pregledNarudzbe.JeguljaCounter++;

            counter14++;
            string text14 = "Jegulja x" + counter14.ToString();
            int start = rtbIspis.Find("Jegulja x");
            if (start >= 0)
            {
                int length = ("Jegulja x" + counter14.ToString()).Length;
                rtbIspis.Select(start, length);
                rtbIspis.SelectedText = text14 + "   ";
            }
            else
            {
                rtbIspis.SelectedText = text14 + Environment.NewLine;
            }
        }

        private void btnLignjeZar_Click(object sender, EventArgs e)
        {
            _pregledNarudzbe.LignjeNaZaruCounter++;

            counter15++;
            string text15 = "Lignje na žaru x" + counter15.ToString();
            int start = rtbIspis.Find("Lignje na žaru x");
            if (start >= 0)
            {
                int length = ("Lignje na žaru x" + counter15.ToString()).Length;
                rtbIspis.Select(start, length);
                rtbIspis.SelectedText = text15 + "   ";
            }
            else
            {
                rtbIspis.SelectedText = text15 + Environment.NewLine;
            }
        }

        private void btnLignjePrzene_Click(object sender, EventArgs e)
        {
            _pregledNarudzbe.PrzeneLignjeCounter++;

            counter16++;
            string text16 = "Pržene lignje x" + counter16.ToString();
            int start = rtbIspis.Find("Pržene lignje x");
            if (start >= 0)
            {
                int length = ("Pržene lignje x" + counter16.ToString()).Length;
                rtbIspis.Select(start, length);
                rtbIspis.SelectedText = text16 + "   ";
            }
            else
            {
                rtbIspis.SelectedText = text16 + Environment.NewLine;
            }
        }
    }
}
