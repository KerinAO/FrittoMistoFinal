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
    public partial class PregledNarudzbe : Form
    {

        public int FrittoMistoCounter { get; set; } = 0;
        public int PesceCaneCounter { get; set; } = 0;
        public int MareScoglioCounter { get; set; } = 0;
        public int OradaCounter { get; set; } = 0;
        public int BrancinCounter { get; set; } = 0;
        public int CipalCounter { get; set; } = 0;
        public int SkusaCounter { get; set; } = 0;
        public int OslicCounter { get; set; } = 0;
        public int TunaCounter { get; set; } = 0;
        public int SkampiCounter { get; set; } = 0;
        public int KoziceCounter { get; set; } = 0;
        public int JastogCounter { get; set; } = 0;
        public int DagnjeCounter { get; set; } = 0;
        public int KameniceCounter { get; set; } = 0;
        public int VongoleCounter { get; set; } = 0;
        public int KapesanteCounter { get; set; } = 0;
        public int JeguljaCounter { get; set; } = 0;
        public int LignjeNaZaruCounter { get; set; } = 0;
        public int PrzeneLignjeCounter { get; set; } = 0;

        public PregledNarudzbe()
        {
            InitializeComponent();
            btnOdustani.Click += button2_Click;
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            UpdateCounters();
        }

        int FrittoMistoCijena = 7;
        int PesceCaneCijena = 35;
        int MareScoglioCijena = 20;
        int OradaCijena = 7;
        int BrancinCijena = 8;
        int CipalCijena = 4;
        int SkusaCijena = 5;
        int OslicCijena = 5;
        int TunaCijena = 14;
        int SkampiCijena = 31;
        int KoziceCijena = 16;
        int JastogCijena = 100;
        int DagnjeCijena = 2;
        int KameniceCijena = 6;
        int VongoleCijena = 7;
        int KapesanteCijena = 16;
        int JeguljaCijena = 16;
        int LignjeNaZaruCijena = 19;
        int PrzeneLignjeCijena = 19;

        private int CalculateFrittoMistoPrice()
        {
            return FrittoMistoCounter * FrittoMistoCijena;
        }
        private int CalculatePesceCanePrice()
        {
            return PesceCaneCounter * PesceCaneCijena;
        }
        private int CalculateMareScoglioPrice()
        {
            return MareScoglioCounter * MareScoglioCijena;
        }
        private int CalculateOradaPrice()
        {
            return OradaCounter * OradaCijena;
        }
        private int CalculateBrancinPrice()
        {
            return BrancinCounter * BrancinCijena;
        }
        private int CalculateCipalPrice()
        {
            return CipalCounter * CipalCijena;
        }
        private int CalculateSkusaPrice()
        {
            return SkusaCounter * SkusaCijena;
        }
        private int CalculateOslicPrice()
        {
            return OslicCounter * OslicCijena;
        }
        private int CalculateTunaPrice()
        {
            return TunaCounter * TunaCijena;
        }
        private int CalculateSkampiPrice()
        {
            return SkampiCounter * SkampiCijena;
        }
        private int CalculateKozicePrice()
        {
            return KoziceCounter * KoziceCijena;
        }
        private int CalculateJastogPrice()
        {
            return JastogCounter * JastogCijena;
        }
        private int CalculateDagnjePrice()
        {
            return DagnjeCounter * DagnjeCijena;
        }
        private int CalculateKamenicePrice()
        {
            return KameniceCounter * KameniceCijena;
        }
        private int CalculateVongolePrice()
        {
            return VongoleCounter * VongoleCijena;
        }
        private int CalculateKapesantePrice()
        {
            return KapesanteCounter * KapesanteCijena;
        }
        private int CalculateJeguljaPrice()
        {
            return JeguljaCounter * JeguljaCijena;
        }
        private int CalculateLignjeNaZaruPrice()
        {
            return LignjeNaZaruCounter * LignjeNaZaruCijena;
        }
        private int CalculatePrzeneLignjePrice()
        {
            return PrzeneLignjeCounter * PrzeneLignjeCijena;
        }

        private int CalculateTotal()
        {
            return CalculateFrittoMistoPrice() + CalculatePesceCanePrice() + CalculateMareScoglioPrice() + CalculateOradaPrice()
                + CalculateBrancinPrice() + CalculateCipalPrice() + CalculateSkusaPrice() + CalculateOslicPrice() + CalculateTunaPrice() +
                CalculateSkampiPrice() + CalculateKozicePrice() + CalculateJastogPrice() + CalculateDagnjePrice() + CalculateKamenicePrice() +
                CalculateVongolePrice() + CalculateKapesantePrice() + CalculateJeguljaPrice() + CalculateLignjeNaZaruPrice() + CalculatePrzeneLignjePrice();
        }

        private void UpdateCounters()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Fritto Misto x{FrittoMistoCounter}" + " - " + CalculateFrittoMistoPrice().ToString() + "€");
            sb.AppendLine($"PesceCane x{PesceCaneCounter}" + " - " + CalculatePesceCanePrice().ToString() + "€");
            sb.AppendLine($"Mare-Scoglio x{MareScoglioCounter}" + " - " + CalculateMareScoglioPrice().ToString() + "€");
            sb.AppendLine($"Orada x{OradaCounter}" + " - " + CalculateOradaPrice().ToString() + "€");
            sb.AppendLine($"Brancin x{BrancinCounter}" + " - " + CalculateBrancinPrice().ToString() + "€");
            sb.AppendLine($"Cipal x{CipalCounter}" + " - " + CalculateCipalPrice().ToString() + "€");
            sb.AppendLine($"Skuša x{SkusaCounter}" + " - " + CalculateSkusaPrice().ToString() + "€");
            sb.AppendLine($"Oslić x{OslicCounter}" + " - " + CalculateOslicPrice().ToString() + "€");
            sb.AppendLine($"Tuna x{TunaCounter}" + " - " + CalculateTunaPrice().ToString() + "€");
            sb.AppendLine($"Škampi x{SkampiCounter}" + " - " + CalculateSkampiPrice().ToString() + "€");
            sb.AppendLine($"Kozice x{KoziceCounter}" + " - " + CalculateKozicePrice().ToString() + "€");
            sb.AppendLine($"Jastog x{JastogCounter}" + " - " + CalculateJastogPrice().ToString() + "€");
            sb.AppendLine($"Dagnje x{DagnjeCounter}" + " - " + CalculateDagnjePrice().ToString() + "€");
            sb.AppendLine($"Kamenice x{KameniceCounter}" + " - " + CalculateKamenicePrice().ToString() + "€");
            sb.AppendLine($"Vongole x{VongoleCounter}" + " - " + CalculateVongolePrice().ToString() + "€");
            sb.AppendLine($"Kapesante x{KapesanteCounter}" + " - " + CalculateKapesantePrice().ToString() + "€");
            sb.AppendLine($"Jegulja x{JeguljaCounter}" + " - " + CalculateJeguljaPrice().ToString() + "€");
            sb.AppendLine($"Lignje na žaru x{LignjeNaZaruCounter}" + " - " + CalculateLignjeNaZaruPrice().ToString() + "€");
            sb.AppendLine($"Pržene lignje x{PrzeneLignjeCounter}" + " - " + CalculatePrzeneLignjePrice().ToString() + "€");
            sb.AppendLine(Environment.NewLine);
            sb.AppendLine($"Ukupna cijena: " + CalculateTotal().ToString() + "€");
            rtbPregledNarudzbe.Text = sb.ToString();
        }

        private void UpdateFrittoMistoCounter()
        {
            rtbPregledNarudzbe.Text = $"Fritto Misto x{FrittoMistoCounter}";
        }

        private void UpdatePesceCaneCounter()
        {
            rtbPregledNarudzbe.Text = $"PesceCane x{PesceCaneCounter}";
        }

        private void UpdateMareScoglioCounter()
        {
            rtbPregledNarudzbe.Text = $"Mare-Scoglio x{MareScoglioCounter}";
        }

        private void UpdateOradaCounter()
        {
            rtbPregledNarudzbe.Text = $"Orada x{OradaCounter}";
        }
        private void UpdateBrancinCounter()
        {
            rtbPregledNarudzbe.Text = $"Brancin x{BrancinCounter}";
        }
        private void UpdateCipalCounter()
        {
            rtbPregledNarudzbe.Text = $"Cipal x{CipalCounter}";
        }
        private void UpdateSkusaCounter()
        {
            rtbPregledNarudzbe.Text = $"Skuša x{SkusaCounter}";
        }
        private void UpdateOslicCounter()
        {
            rtbPregledNarudzbe.Text = $"Oslić x{OslicCounter}";
        }
        private void UpdateTunaCounter()
        {
            rtbPregledNarudzbe.Text = $"Tuna x{TunaCounter}";
        }
        private void UpdateSkampiCounter()
        {
            rtbPregledNarudzbe.Text = $"Škampi x{SkampiCounter}";
        }
        private void UpdateKoziceCounter()
        {
            rtbPregledNarudzbe.Text = $"Kozice x{KoziceCounter}";
        }
        private void UpdateJastogCounter()
        {
            rtbPregledNarudzbe.Text = $"Jastog x{JastogCounter}";
        }
        private void UpdateDagnjeCounter()
        {
            rtbPregledNarudzbe.Text = $"Dagnje x{DagnjeCounter}";
        }
        private void UpdateKameniceCounter()
        {
            rtbPregledNarudzbe.Text = $"Kamenice x{KameniceCounter}";
        }
        private void UpdateVongoleCounterr()
        {
            rtbPregledNarudzbe.Text = $"Vongole x{VongoleCounter}";
        }
        private void UpdateKapesanteCounter()
        {
            rtbPregledNarudzbe.Text = $"Kapesante x{KapesanteCounter}";
        }
        private void UpdateJeguljaCounter()
        {
            rtbPregledNarudzbe.Text = $"Jegulja x{JeguljaCounter}";
        }
        private void UpdateLignjeNaZaruCounter()
        {
            rtbPregledNarudzbe.Text = $"LignjeNaZaru x{LignjeNaZaruCounter}";
        }
        private void UpdatePrzeneLignjeCounter()
        {
            rtbPregledNarudzbe.Text = $"PrzeneLignje x{PrzeneLignjeCounter}";
        }

        public void UpdateRichTextBox(string text)
        {
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (rbKartica.Checked)
            {
                grpBox.Visible = true;
            }
            else
            {
                grpBox.Visible = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrittoMistoCounter = 0;
            PesceCaneCounter = 0;
            MareScoglioCounter = 0;
            OradaCounter = 0;
            BrancinCounter = 0;
            CipalCounter = 0;
            SkusaCounter = 0;
            OslicCounter = 0;
            TunaCounter = 0;
            SkampiCounter = 0;
            KoziceCounter = 0;
            JastogCounter = 0;
            DagnjeCounter = 0;
            KameniceCounter = 0;
            VongoleCounter = 0;
            KapesanteCounter = 0;
            JeguljaCounter = 0;
            LignjeNaZaruCounter = 0;
            PrzeneLignjeCounter = 0;
            UpdateCounters();
            this.Close();
        }

        private void rtbPregledNarudzbe_TextChanged(object sender, EventArgs e)
        {

        }

        private void PregledNarudzbe_Load(object sender, EventArgs e)
        {

        }

        private void btnNaruci_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Narudžba je upisana!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
