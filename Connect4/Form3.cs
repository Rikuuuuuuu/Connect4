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
    public partial class Form3 : Form
    {
        int pelaaja = 1;
        Label[] labels = new Label[42];

        string[,] napit = new string[6, 7]
        {
            {"n", "n", "n", "n", "n", "n", "n"},
            {"n", "n", "n", "n", "n", "n", "n"},
            {"n", "n", "n", "n", "n", "n", "n"},
            {"n", "n", "n", "n", "n", "n", "n"},
            {"n", "n", "n", "n", "n", "n", "n"},
            {"n", "n", "n", "n", "n", "n", "n"}
        };
        public Form3()
        {
            InitializeComponent();
            for (int i = 0; i < labels.Length; i++)
            {
                labels[i] = new Label();
                labels[i].Text = "n";
                this.BackColor = Color.LightSteelBlue;
                labels[i].Location = new Point(0 + (i * 91), 0 + (i * 0));
                labels[i].Width = 80;
                labels[i].Height = 80;
                labels[i].BorderStyle = BorderStyle.None;
                labels[i].TextAlign = ContentAlignment.MiddleCenter;
                labels[i].ForeColor = Color.White;
                labels[i].BackColor = Color.LightSteelBlue;
                labels[i].Font = new Font("Webdings", 48);
                labels[i].Click += new EventHandler(Label_click);
                labels[i].Width = 80;
                labels[i].Name = i.ToString();
                Controls.Add(labels[i]);


                if (i >= 7)
                {
                    labels[i].Location = new Point(-637 + (i * 91), 91 + (i * 0));
                }
                if (i >= 14)
                {
                    labels[i].Location = new Point(-1274 + (i * 91), 182 + (i * 0));
                }
                if (i >= 21)
                {
                    labels[i].Location = new Point(-1911 + (i * 91), 273 + (i * 0));
                }
                if (i >= 28)
                {
                    labels[i].Location = new Point(-2548 + (i * 91), 364 + (i * 0));
                }
                if (i >= 35)
                {
                    labels[i].Location = new Point(-3185 + (i * 91), 455 + (i * 0));
                }
            }
        }
        private void Label_click(object sender, EventArgs e)
        {          
            Label valittu = sender as Label;
            Tarkistus(valittu);
            Pysty(valittu);
            Vaaka(valittu);
            RistiVasenOikea(valittu);
            RistiOikeaVasen(valittu);
        }
        //nappien tiputus
        public void Tarkistus(Label label)
        {
            //Rivin selvitys
            int i = Convert.ToInt32(label.Name);
            if (i == 0 || i == 7 || i == 14 || i == 21 || i == 28 || i == 35)
            {
                 i = 0;
            }
            if (i == 1 || i == 8 || i == 15 || i == 22 || i == 29 || i == 36)
            {
                i = 1;
            }
            if (i == 2 || i == 9 || i == 16 || i == 23 || i == 30 || i == 37)
            {
                i = 2;
            }
            if (i == 3 || i == 10 || i == 17 || i == 24 || i == 31 || i == 38)
            {
                i = 3;
            }
            if (i == 4 || i == 11 || i == 18 || i == 25 || i == 32 || i == 39)
            {
                i = 4;
            }
            if (i == 5 || i == 12 || i == 19 || i == 26 || i == 33 || i == 40)
            {
                i = 5;
            }
            if (i == 6 || i == 13 || i == 20 || i == 27 || i == 34 || i == 41)
            {
                i = 6;
            }
            if (labels[i + 7].ForeColor != Color.White)
            {
                if (labels[i].ForeColor == Color.White)
                {
                    if (pelaaja == 1)
                    {
                        labels[i].ForeColor = Color.Red;
                        pelaaja++;
                    }
                    else if (pelaaja == 2)
                    {
                        labels[i].ForeColor = Color.Yellow;
                        pelaaja = 1;
                    }
                }
            }    
            else if (labels[i + 7].ForeColor == Color.White)
            {
                if (labels[i + 14].ForeColor != Color.White)
                {
                    if (pelaaja == 1)
                    {
                        labels[i + 7].ForeColor = Color.Red;
                        pelaaja++;
                    }
                    else if (pelaaja == 2)
                    {
                        labels[i + 7].ForeColor = Color.Yellow;
                        pelaaja = 1;
                    }
                }
                else if (labels[i + 14].ForeColor == Color.White)
                {
                    if (labels[i + 21].ForeColor != Color.White)
                    {
                        if (pelaaja == 1)
                        {
                            labels[i + 14].ForeColor = Color.Red;
                            pelaaja++;
                        }
                        else if (pelaaja == 2)
                        {
                            labels[i + 14].ForeColor = Color.Yellow;
                            pelaaja = 1;
                        }
                    }
                    else if (labels[i + 21].ForeColor == Color.White)
                    {
                        if (labels[i + 28].ForeColor != Color.White)
                        {
                            if (pelaaja == 1)
                            {
                                labels[i + 21].ForeColor = Color.Red;
                                pelaaja++;
                            }
                            else if (pelaaja == 2)
                            {
                                labels[i + 21].ForeColor = Color.Yellow;
                                pelaaja = 1;
                            }
                        }
                        else if (labels[i + 28].ForeColor == Color.White)
                        {
                            if (labels[i + 35].ForeColor != Color.White)
                            {
                                if (pelaaja == 1)
                                {
                                    labels[i + 28].ForeColor = Color.Red;
                                    pelaaja++;
                                }
                                else if (pelaaja == 2)
                                {
                                    labels[i + 28].ForeColor = Color.Yellow;
                                    pelaaja = 1;
                                }
                            }
                            else if (labels[i + 35].ForeColor == Color.White)
                            {
                                if (pelaaja == 1)
                                {
                                    labels[i + 35].ForeColor = Color.Red;
                                    pelaaja++;
                                }
                                else if (pelaaja == 2)
                                {
                                    labels[i + 35].ForeColor = Color.Yellow;
                                    pelaaja = 1;
                                }
                            }
                        }
                    }
                }
            }
        }
        //Voiton tarkistus
        public void Pysty(Label label)
        {
            int i = Convert.ToInt32(label.Name);
            if (i == 0 || i == 7 || i == 14 || i == 21 || i == 28 || i == 35)
            {
                i = 0;
            }
            if (i == 1 || i == 8 || i == 15 || i == 22 || i == 29 || i == 36)
            {
                i = 1;
            }
            if (i == 2 || i == 9 || i == 16 || i == 23 || i == 30 || i == 37)
            {
                i = 2;
            }
            if (i == 3 || i == 10 || i == 17 || i == 24 || i == 31 || i == 38)
            {
                i = 3;
            }
            if (i == 4 || i == 11 || i == 18 || i == 25 || i == 32 || i == 39)
            {
                i = 4;
            }
            if (i == 5 || i == 12 || i == 19 || i == 26 || i == 33 || i == 40)
            {
                i = 5;
            }
            if (i == 6 || i == 13 || i == 20 || i == 27 || i == 34 || i == 41)
            {
                i = 6;
            }
            //Punainen
            if(labels[i+35].ForeColor == Color.Red && labels[i+28].ForeColor == Color.Red && labels[i + 21].ForeColor == Color.Red && labels[i + 14].ForeColor == Color.Red)
            {
                MessageBox.Show("Punainen voitti pelin!");
            }
            if (labels[i + 28].ForeColor == Color.Red && labels[i + 21].ForeColor == Color.Red && labels[i + 14].ForeColor == Color.Red && labels[i + 7].ForeColor == Color.Red)
            {
                MessageBox.Show("Punainen voitti pelin!");
            }
            if (labels[i + 21].ForeColor == Color.Red && labels[i + 14].ForeColor == Color.Red && labels[i + 7].ForeColor == Color.Red && labels[i].ForeColor == Color.Red)
            {
                MessageBox.Show("Punainen voitti pelin!");
            }
            //Keltainen
            if (labels[i + 35].ForeColor == Color.Yellow && labels[i + 28].ForeColor == Color.Yellow && labels[i + 21].ForeColor == Color.Yellow && labels[i + 14].ForeColor == Color.Yellow)
            {
                MessageBox.Show("Keltainen voitti pelin!");
            }
            if (labels[i + 28].ForeColor == Color.Yellow && labels[i + 21].ForeColor == Color.Yellow && labels[i + 14].ForeColor == Color.Yellow && labels[i + 7].ForeColor == Color.Yellow)
            {
                MessageBox.Show("Keltainen voitti pelin!");
            }
            if (labels[i + 21].ForeColor == Color.Yellow && labels[i + 14].ForeColor == Color.Yellow && labels[i + 7].ForeColor == Color.Yellow && labels[i].ForeColor == Color.Yellow)
            {
                MessageBox.Show("Keltainen voitti pelin!");
            }

        }
        public void Vaaka(Label label)
        {
            int i = Convert.ToInt32(label.Name);
            if (i == 0 || i == 7 || i == 14 || i == 21 || i == 28 || i == 35)
            {
                i = 0;
            }
            if (i == 1 || i == 8 || i == 15 || i == 22 || i == 29 || i == 36)
            {
                i = 1;
            }
            if (i == 2 || i == 9 || i == 16 || i == 23 || i == 30 || i == 37)
            {
                i = 2;
            }
            if (i == 3 || i == 10 || i == 17 || i == 24 || i == 31 || i == 38)
            {
                i = 3;
            }
            if (i == 4 || i == 11 || i == 18 || i == 25 || i == 32 || i == 39)
            {
                i = 4;
            }
            if (i == 5 || i == 12 || i == 19 || i == 26 || i == 33 || i == 40)
            {
                i = 5;
            }
            if (i == 6 || i == 13 || i == 20 || i == 27 || i == 34 || i == 41)
            {
                i = 6;
            }
            if (i == 0)
            {   
                //Punainen
                if (labels[i + 35].ForeColor == Color.Red && labels[i + 36].ForeColor == Color.Red && labels[i + 37].ForeColor == Color.Red && labels[i + 38].ForeColor == Color.Red)
                {
                    MessageBox.Show("Punainen voitti pelin!");
                }
                //Keltainen
                if (labels[i + 35].ForeColor == Color.Yellow && labels[i + 36].ForeColor == Color.Yellow && labels[i + 37].ForeColor == Color.Yellow && labels[i + 38].ForeColor == Color.Yellow)
                {
                    MessageBox.Show("Keltainen voitti pelin!");
                }
            }
        }
        public void RistiVasenOikea(Label label)
        {
            int i = Convert.ToInt32(label.Name);

        }
        public void RistiOikeaVasen(Label label)
        {
            int i = Convert.ToInt32(label.Name);
        }
    }
}