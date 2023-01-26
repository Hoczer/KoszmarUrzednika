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

namespace KoszmarUrzednika
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LiczButton_Click(object sender, EventArgs e)
        {
            decimal b = 0;
            decimal c = 0;
            decimal d = 0;
            decimal f = 0;
            decimal n = 1;
            decimal m = 1;
            decimal a = 0;

            string sb = BTextBox.Text.Replace(".", ",");
            string sc = CTextBox.Text.Replace(".", ",");
            string sd = DTextBox.Text.Replace(".", ",");
            string sf = FTextBox.Text.Replace(".", ",");
            string sn = NTextBox.Text.Replace(".", ",");
            string sm = MTextBox.Text.Replace(".", ",");

            if (Decimal.TryParse(sb, out b) && b > 0)
            {
            }
            else
            {
                MessageBox.Show("Błędna wartość 'b'", "Błąd");
                return;
            }
            if (Decimal.TryParse(sc, out c) && c > 0)
            {
            }
            else
            {
                MessageBox.Show("Błędna wartość 'c'", "Błąd");
                return;
            }
            if (Decimal.TryParse(sd, out d) && d > 0)
            {
            }
            else
            {
                MessageBox.Show("Błędna wartość 'd'", "Błąd");
                return;
            }
            if (Decimal.TryParse(sf, out f) && f > 0)
            {
            }
            else
            {
                MessageBox.Show("Błędna wartość 'f'", "Błąd");
                return;
            }
            if (Decimal.TryParse(sn, out n) && n > 0)
            {
            }
            else
            {
                MessageBox.Show("Błędna wartość 'b'", "Błąd");
                return;
            }
            if (Decimal.TryParse(sm, out m) && m > 0)
            {
            }
            else
            {
                MessageBox.Show("Błędna wartość 'm'", "Błąd");
                return;
            }

            decimal licznik = (c * d) / f;
            Debug.Write("licznik:"+licznik);
            decimal mianownik=0;
            Debug.Write("Mianownik:" + mianownik);
            for (int i = 1; i <= m; i++)
            {
                Debug.Write("i:" + i);
                decimal licznikSigma = c * i * d * i;
                Debug.Write("licznikSigma:" + licznikSigma);
                decimal mianownikSigma = f * i;
                Debug.Write("mianownikSigma" + mianownikSigma);
                mianownik += licznikSigma / mianownikSigma;
                Debug.Write("mianownik:" + mianownik);

            }
            a = b * (licznik / mianownik);
            WynikALabel.Text = a.ToString();
        }
    }
}
