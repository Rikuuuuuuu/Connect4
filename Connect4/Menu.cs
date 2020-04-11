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
        //Avaa piste formin
        private void database_Click(object sender, EventArgs e)
        {
            Pisteet f = new Pisteet();
            this.Hide();
            f.ShowDialog();
        }
        //Formin sulkeminen menu stripin kautta
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //Lähettää pelaajien nimet ja värit peli formiin
            if (P1Name.Text != "" && P2Name.Text != "")
            {
                string nP1nimi = P1Name.Text;
                string nP2nimi = P2Name.Text;
                string nP1vari = P1vari.Text;
                string nP2vari = P2vari.Text;
                Peli f = new Peli(nP1vari, nP2vari, nP1nimi, nP2nimi);
                this.Hide();
                f.Show();
            }
            //Tarkistetaan että pelaajan nimi kenttä ei  ole tyhjä
            if (P1Name.Text == "" || P2Name.Text == "")
            {
                MessageBox.Show("Pelaajan nimi kenttä ei saa olla tyhjä!");
            }
        }
        //Tyhjentää textboxin jos siitä clikataan
        private void P1Name_Click(object sender, EventArgs e)
        {
            if (P1Name.Text == "Pelaaja1")
            {
                P1Name.Text = "";
            }
        }
        //Tyhjentää textboxin jos siitä clikataan
        private void P2Name_Click(object sender, EventArgs e)
        {
            if (P2Name.Text == "Pelaaja2")
            {
                P2Name.Text = "";
            }
        }
        //Formin sulkeminen rastista painamalla
        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Application.Exit();
        }
    }
}
