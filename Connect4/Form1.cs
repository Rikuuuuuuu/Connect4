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

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            this.Hide();
            f.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            this.Hide();
            f.ShowDialog();
        }
    }
}
