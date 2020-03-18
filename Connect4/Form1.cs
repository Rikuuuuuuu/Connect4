using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Connect4
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }
        //Pelin ohjeet
        private void Ohjeet_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Peliä pelataan 7 sarakkeen ja 6 rivin kokoisella pelilaudalla." +
                " Molemmilla pelaajilla on käytössään 21 kiekkoa, jotka erottuvat toisistaan kahdella eri värillä." +
                " Kiekkoja pudotetaan vuorotellen täyttämättömiin sarakkeisiin, jolloin kiekko varaa itselleen tyhjästä kohdasta sijansa." +
                " Voittaakseen pelin täytyy pelaajan asettaa omia kiekkojaan niin, että muodostuu joko pystysuorassa, vaakasuorassa tai poikittain neljän kiekon suora." +
                " Jos pelilauta täyttyy ilman voittajaa, syntyy tasapeli.");
        }
        private void database_Click(object sender, EventArgs e)
        {
            Pisteet f = new Pisteet();
            this.Hide();
            f.ShowDialog();
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (P1Name.Text != "" && P2Name.Text != "")
            {
                string nP1nimi = P1Name.Text;
                string nP2nimi = P2Name.Text;
                string nP1vari = P1vari.Text;
                string nP2vari = P2vari.Text;
                Form3 f = new Form3(nP1vari, nP2vari, nP1nimi, nP2nimi);
                this.Hide();
                f.Show();
            }
            if (P1Name.Text == "" || P2Name.Text == "")
            {
                MessageBox.Show("Pelaajan nimi kenttä ei saa olla tyhjä!");
            }
        }
        private void P1Name_Click(object sender, EventArgs e)
        {
            P1Name.Text = "";
        }
        private void P2Name_Click(object sender, EventArgs e)
        {
            P2Name.Text = "";
        }
    }
}
