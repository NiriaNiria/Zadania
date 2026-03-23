using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void sprawdzCene_Click(object sender, EventArgs e)
        {
            if (pocztowka.Checked)
            {
                zdjecie.Image = Properties.Resources.pocztow;
                cena.Text = "Cena:1 zł";
            }
            else if(list.Checked)
            {
                zdjecie.Image = Properties.Resources.pocztow;
                cena.Text = "Cena:1,5 zł";
            }
            else if (paczka.Checked)
            {
                zdjecie.Image = Properties.Resources.pocztow;
                cena.Text = "Cena:10 zł";
            } 
        }

        private void zatwierdz_Click(object sender, EventArgs e)
        {
            string kodp = textBox2.Text;
            if(kodp.Length != 5)
            {
                MessageBox.Show("Nieprawidlowa liczba cyfr w" +
                    " kodzie pocztowym");
                return;
            }
            foreach (char z in kodp)
            {
                if (!char.IsDigit(z))
                {
                    MessageBox.Show("kod pocztowy" +
                        "powinien sie skladac z samych cyfr");
                    return;
                }
            }
            MessageBox.Show("Dane przesylki zostaly wprowadzone");
        }

        private void zdjecie_Click(object sender, EventArgs e)
        {

        }

        private void cena_Click(object sender, EventArgs e)
        {

        }

        private void rodzaj_Enter(object sender, EventArgs e)
        {

        }

        private void dane_Enter(object sender, EventArgs e)
        {

        }

        private void pocztowka_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void list_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void paczka_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
