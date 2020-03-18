using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace Connect4
{
    public partial class Form3 : Form
    {
        SqlConnection dbYhteys = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Pisteet;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;");
        string P1Nimi;
        string P2Nimi;
        int pelaaja = 1;
        Color P1Color;
        string vari1;
        Color P2Color;
        string vari2;
        Label[] labels = new Label[42];

        public Form3(string p1vari, string p2vari, string P1Name, string P2Name)
        {
            InitializeComponent();
            P1Nimi = P1Name;
            P2Nimi = P2Name;
            //Pelaaja1 väri
            if (p1vari == "Punainen")
            {
                P1Color = Color.Red;
                vari1 = "Punainen";
            }
            if (p1vari == "Keltainen")
            {
                P1Color = Color.Yellow;
                vari1 = "Keltainen";
            }
            if (p1vari == "Sininen")
            {
                P1Color = Color.Blue;
                vari1 = "Sininen";
            }
            if (p1vari == "Musta")
            {
                P1Color = Color.Black;
                vari1 = "Musta";
            }
            if (p1vari == "Vihreä")
            {
                P1Color = Color.Green;
                vari1 = "Vihreä";
            }
            if (p1vari == "Violetti")
            {
                P1Color = Color.Purple;
                vari1 = "Violetti";
            }
            if (p1vari == "Pinkki")
            {
                P1Color = Color.Pink;
                vari1 = "Pinkki";
            }
            if (p1vari == "Oranssi")
            {
                P1Color = Color.Orange;
                vari1 = "Oranssi";
            }
            if (p1vari == "Turkoosi")
            {
                P1Color = Color.Turquoise;
                vari1 = "Turkoosi";
            }
            //Pelaaja2 väri
            if (p2vari == "Keltainen")
            {
                P2Color = Color.Yellow;
                vari2 = "Keltainen";
            }
            if (p2vari == "Punainen")
            {
                P2Color = Color.Red;
                vari2 = "Punainen";
            }
            if (p2vari == "Sininen")
            {
                P2Color = Color.Blue;
                vari2 = "Sininen";
            }
            if (p2vari == "Musta")
            {
                P2Color = Color.Black; 
                vari2 = "Musta";
            }
            if (p2vari == "Vihreä")
            {
                P2Color = Color.Green;
                vari2 = "Vihreä";
            }
            if (p2vari == "Violetti")
            {
                P2Color = Color.Purple;
                vari2 = "Violetti";
            }
            if (p2vari == "Pinkki")
            {
                P2Color = Color.Pink;
                vari2 = "Pinkki";
            }
            if (p2vari == "Oranssi")
            {
                P2Color = Color.Orange;
                vari2 = "Oranssi";
            }
            if (p2vari == "Turkoosi")
            {
                P2Color = Color.Turquoise;
                vari2 = "Turkoosi";
            }
            NextPlayer.Text = vari1;
            //Pelilaudan luonti
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

                //Rivin vaihto 
                //>____o<"Quack!"
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
        //Sql
        public void Data1()
        {
            dbYhteys.Open();
            SqlCommand sc = new SqlCommand("INSERT INTO score(Nimi,Väri,Pvm)VALUES(@Nimi,@Vari,@Pvm)", dbYhteys);
            sc.Parameters.Add("@Nimi", SqlDbType.VarChar, 100).Value = P1Nimi;
            sc.Parameters.Add("@Vari", SqlDbType.VarChar, 100).Value = vari1;
            sc.Parameters.Add("@Pvm", SqlDbType.DateTime).Value = DateTime.Now;
            sc.ExecuteNonQuery();
            dbYhteys.Close();
            Pisteet f = new Pisteet();
            this.Hide();
            f.ShowDialog();
        }
        public void Data2()
        {
            dbYhteys.Open();
            SqlCommand sc = new SqlCommand("INSERT INTO score(Nimi,Väri,Pvm)VALUES(@Nimi,@Vari,@Pvm)", dbYhteys);
            sc.Parameters.Add("@Nimi", SqlDbType.VarChar, 100).Value = P2Nimi;
            sc.Parameters.Add("@Vari", SqlDbType.VarChar, 100).Value = vari2;
            sc.Parameters.Add("@Pvm", SqlDbType.DateTime).Value = DateTime.Now;
            sc.ExecuteNonQuery();
            dbYhteys.Close();
            Pisteet f = new Pisteet();
            this.Hide();
            f.ShowDialog();
        }
        //Valitun labelin tarkistus
        private void Label_click(object sender, EventArgs e)
        {          
            Label valittu = sender as Label;
            Tarkistus(valittu);
            Pysty(valittu);
            Vaaka(valittu);
            RistiVasenOikea(valittu);
            RistiOikeaVasen(valittu);
            Tasapeli(valittu);
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
            //Tarkistetaan onko valitun labelin alapuolella tyhjä paikka
            if (labels[i + 7].ForeColor != Color.White)
            {
                if (labels[i].ForeColor == Color.White)
                {
                    if (pelaaja == 1)
                    {
                        labels[i].ForeColor = P1Color;
                        pelaaja++;
                        NextPlayer.Text = vari2;
                    }
                    else if (pelaaja == 2)
                    {
                        labels[i].ForeColor = P2Color;
                        pelaaja = 1;
                        NextPlayer.Text = vari1;
                    }
                }
            }    
            else if (labels[i + 7].ForeColor == Color.White)
            {
                if (labels[i + 14].ForeColor != Color.White)
                {
                    if (pelaaja == 1)
                    {
                        labels[i + 7].ForeColor = P1Color;
                        pelaaja++;
                        NextPlayer.Text = vari2;
                    }
                    else if (pelaaja == 2)
                    {
                        labels[i + 7].ForeColor = P2Color;
                        pelaaja = 1;
                        NextPlayer.Text = vari1;
                    }
                }
                else if (labels[i + 14].ForeColor == Color.White)
                {
                    if (labels[i + 21].ForeColor != Color.White)
                    {
                        if (pelaaja == 1)
                        {
                            labels[i + 14].ForeColor = P1Color;
                            pelaaja++;
                            NextPlayer.Text = vari2;
                        }
                        else if (pelaaja == 2)
                        {
                            labels[i + 14].ForeColor = P2Color;
                            pelaaja = 1;
                            NextPlayer.Text = vari1;
                        }
                    }
                    else if (labels[i + 21].ForeColor == Color.White)
                    {
                        if (labels[i + 28].ForeColor != Color.White)
                        {
                            if (pelaaja == 1)
                            {
                                labels[i + 21].ForeColor = P1Color;
                                pelaaja++;
                                NextPlayer.Text = vari2;
                            }
                            else if (pelaaja == 2)
                            {
                                labels[i + 21].ForeColor = P2Color;
                                pelaaja = 1;
                                NextPlayer.Text = vari1;
                            }
                        }
                        else if (labels[i + 28].ForeColor == Color.White)
                        {
                            if (labels[i + 35].ForeColor != Color.White)
                            {
                                if (pelaaja == 1)
                                {
                                    labels[i + 28].ForeColor = P1Color;
                                    pelaaja++;
                                    NextPlayer.Text = vari2;
                                }
                                else if (pelaaja == 2)
                                {
                                    labels[i + 28].ForeColor = P2Color;
                                    pelaaja = 1;
                                    NextPlayer.Text = vari1;
                                }
                            }
                            else if (labels[i + 35].ForeColor == Color.White)
                            {
                                if (pelaaja == 1)
                                {
                                    labels[i + 35].ForeColor = P1Color;
                                    pelaaja++;
                                    NextPlayer.Text = vari2;
                                }
                                else if (pelaaja == 2)
                                {
                                    labels[i + 35].ForeColor = P2Color;
                                    pelaaja = 1;
                                    NextPlayer.Text = vari1;
                                }
                            }
                        }
                    }
                }
            }
        }
        //Voiton tarkistus
        //Pystysuuntaan tarkistus
        public void Pysty(Label label)
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
            //P1
            if(labels[i+35].ForeColor == P1Color && labels[i+28].ForeColor == P1Color && labels[i + 21].ForeColor == P1Color && labels[i + 14].ForeColor == P1Color)
            {
                MessageBox.Show(P1Nimi + " voitti pelin!");
                Data1();
            }
            if (labels[i + 28].ForeColor == P1Color && labels[i + 21].ForeColor == P1Color && labels[i + 14].ForeColor == P1Color && labels[i + 7].ForeColor == P1Color)
            {
                MessageBox.Show(P1Nimi + " voitti pelin!");
                Data1();
            }
            if (labels[i + 21].ForeColor == P1Color && labels[i + 14].ForeColor == P1Color && labels[i + 7].ForeColor == P1Color && labels[i].ForeColor == P1Color)
            {
                MessageBox.Show(P1Nimi + " voitti pelin!");
                Data1();
            }
            //P2
            if (labels[i + 35].ForeColor == P2Color && labels[i + 28].ForeColor == P2Color && labels[i + 21].ForeColor == P2Color && labels[i + 14].ForeColor == P2Color)
            {
                MessageBox.Show(P2Nimi + " voitti pelin!");
                Data2();
            }
            if (labels[i + 28].ForeColor == P2Color && labels[i + 21].ForeColor == P2Color && labels[i + 14].ForeColor == P2Color && labels[i + 7].ForeColor == P2Color)
            {
                MessageBox.Show(P2Nimi + " voitti pelin!");
                Data2();
            }
            if (labels[i + 21].ForeColor == P2Color && labels[i + 14].ForeColor == P2Color && labels[i + 7].ForeColor == P2Color && labels[i].ForeColor == P2Color)
            {
                MessageBox.Show(P2Nimi + " voitti pelin!");
                Data2();
            }

        }
        //Vaakasuuntaan tarkistus
        public void Vaaka(Label label)
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
            //Vasen reuna
            if (i == 0 || i == 1 || i == 2 || i == 3)
            {   
                //P1
                if (labels[i + 35].ForeColor == P1Color && labels[i + 36].ForeColor == P1Color && labels[i + 37].ForeColor == P1Color && labels[i + 38].ForeColor == P1Color || labels[i + 28].ForeColor == P1Color && labels[i + 29].ForeColor == P1Color && labels[i + 30].ForeColor == P1Color && labels[i + 31].ForeColor == P1Color || labels[i + 21].ForeColor == P1Color && labels[i + 22].ForeColor == P1Color && labels[i + 23].ForeColor == P1Color && labels[i + 24].ForeColor == P1Color || labels[i + 14].ForeColor == P1Color && labels[i + 15].ForeColor == P1Color && labels[i + 16].ForeColor == P1Color && labels[i + 17].ForeColor == P1Color || labels[i + 7].ForeColor == P1Color && labels[i + 8].ForeColor == P1Color && labels[i + 9].ForeColor == P1Color && labels[i + 10].ForeColor == P1Color || labels[i + 0].ForeColor == P1Color && labels[i + 1].ForeColor == P1Color && labels[i + 2].ForeColor == P1Color && labels[i + 3].ForeColor == P1Color)
                {
                    MessageBox.Show(P1Nimi + " voitti pelin!");
                    Data1();
                }
                //P2
                if (labels[i + 35].ForeColor == P2Color && labels[i + 36].ForeColor == P2Color && labels[i + 37].ForeColor == P2Color && labels[i + 38].ForeColor == P2Color || labels[i + 28].ForeColor == P2Color && labels[i + 29].ForeColor == P2Color && labels[i + 30].ForeColor == P2Color && labels[i + 31].ForeColor == P2Color || labels[i + 21].ForeColor == P2Color && labels[i + 22].ForeColor == P2Color && labels[i + 23].ForeColor == P2Color && labels[i + 24].ForeColor == P2Color || labels[i + 14].ForeColor == P2Color && labels[i + 15].ForeColor == P2Color && labels[i + 16].ForeColor == P2Color && labels[i + 17].ForeColor == P2Color || labels[i + 7].ForeColor == P2Color && labels[i + 8].ForeColor == P2Color && labels[i + 9].ForeColor == P2Color && labels[i + 10].ForeColor == P2Color || labels[i + 0].ForeColor == P2Color && labels[i + 1].ForeColor == P2Color && labels[i + 2].ForeColor == P2Color && labels[i + 3].ForeColor == P2Color)
                {
                    MessageBox.Show(P2Nimi + " voitti pelin!");
                    Data2();
                }
            }
            if (i == 1 || i == 2 || i == 3)
            {
                //P1
                if (labels[i + 34].ForeColor == P1Color && labels[i + 35].ForeColor == P1Color && labels[i + 36].ForeColor == P1Color && labels[i + 37].ForeColor == P1Color || labels[i + 27].ForeColor == P1Color && labels[i + 28].ForeColor == P1Color && labels[i + 29].ForeColor == P1Color && labels[i + 30].ForeColor == P1Color || labels[i + 20].ForeColor == P1Color && labels[i + 21].ForeColor == P1Color && labels[i + 22].ForeColor == P1Color && labels[i + 23].ForeColor == P1Color || labels[i + 13].ForeColor == P1Color && labels[i + 14].ForeColor == P1Color && labels[i + 15].ForeColor == P1Color && labels[i + 16].ForeColor == P1Color || labels[i + 6].ForeColor == P1Color && labels[i + 7].ForeColor == P1Color && labels[i + 8].ForeColor == P1Color && labels[i + 9].ForeColor == P1Color || labels[i - 1].ForeColor == P1Color && labels[i + 0].ForeColor == P1Color && labels[i + 1].ForeColor == P1Color && labels[i + 2].ForeColor == P1Color)
                {
                    MessageBox.Show(P1Nimi + " voitti pelin!");
                    Data1();
                }
                //P2
                if (labels[i + 34].ForeColor == P2Color && labels[i + 35].ForeColor == P2Color && labels[i + 36].ForeColor == P2Color && labels[i + 37].ForeColor == P2Color || labels[i + 27].ForeColor == P2Color && labels[i + 28].ForeColor == P2Color && labels[i + 29].ForeColor == P2Color && labels[i + 30].ForeColor == P2Color || labels[i + 20].ForeColor == P2Color && labels[i + 21].ForeColor == P2Color && labels[i + 22].ForeColor == P2Color && labels[i + 23].ForeColor == P2Color || labels[i + 13].ForeColor == P2Color && labels[i + 14].ForeColor == P2Color && labels[i + 15].ForeColor == P2Color && labels[i + 16].ForeColor == P2Color || labels[i + 6].ForeColor == P2Color && labels[i + 7].ForeColor == P2Color && labels[i + 8].ForeColor == P2Color && labels[i + 9].ForeColor == P2Color || labels[i - 1].ForeColor == P2Color && labels[i + 0].ForeColor == P2Color && labels[i + 1].ForeColor == P2Color && labels[i + 2].ForeColor == P2Color)
                {
                    MessageBox.Show(P2Nimi + " voitti pelin!");
                    Data2();
                }
            }
            if (i == 2 || i == 3)
            {
                //P1
                if (labels[i + 33].ForeColor == P1Color && labels[i + 34].ForeColor == P1Color && labels[i + 35].ForeColor == P1Color && labels[i + 36].ForeColor == P1Color || labels[i + 26].ForeColor == P1Color && labels[i + 27].ForeColor == P1Color && labels[i + 28].ForeColor == P1Color && labels[i + 29].ForeColor == P1Color || labels[i + 19].ForeColor == P1Color && labels[i + 20].ForeColor == P1Color && labels[i + 21].ForeColor == P1Color && labels[i + 22].ForeColor == P1Color || labels[i + 12].ForeColor == P1Color && labels[i + 13].ForeColor == P1Color && labels[i + 14].ForeColor == P1Color && labels[i + 15].ForeColor == P1Color || labels[i + 5].ForeColor == P1Color && labels[i + 6].ForeColor == P1Color && labels[i + 7].ForeColor == P1Color && labels[i + 8].ForeColor == P1Color || labels[i - 2].ForeColor == P1Color && labels[i - 1].ForeColor == P1Color && labels[i + 0].ForeColor == P1Color && labels[i + 1].ForeColor == P1Color)
                {
                    MessageBox.Show(P1Nimi + " voitti pelin!");
                    Data1();
                }
                //P2
                if (labels[i + 33].ForeColor == P2Color && labels[i + 34].ForeColor == P2Color && labels[i + 35].ForeColor == P2Color && labels[i + 36].ForeColor == P2Color || labels[i + 26].ForeColor == P2Color && labels[i + 27].ForeColor == P2Color && labels[i + 28].ForeColor == P2Color && labels[i + 29].ForeColor == P2Color || labels[i + 19].ForeColor == P2Color && labels[i + 20].ForeColor == P2Color && labels[i + 21].ForeColor == P2Color && labels[i + 22].ForeColor == P2Color || labels[i + 12].ForeColor == P2Color && labels[i + 13].ForeColor == P2Color && labels[i + 14].ForeColor == P2Color && labels[i + 15].ForeColor == P2Color || labels[i + 5].ForeColor == P2Color && labels[i + 6].ForeColor == P2Color && labels[i + 7].ForeColor == P2Color && labels[i + 8].ForeColor == P2Color || labels[i - 2].ForeColor == P2Color && labels[i - 1].ForeColor == P2Color && labels[i + 0].ForeColor == P2Color && labels[i + 1].ForeColor == P2Color)
                {
                    MessageBox.Show(P2Nimi + " voitti pelin!");
                    Data2();
                }
            }
            //Oikea reuna
            if (i == 6 || i == 5 || i == 4 || i == 3)
            {
                //P1
                if (labels[i + 35].ForeColor == P1Color && labels[i + 34].ForeColor == P1Color && labels[i + 33].ForeColor == P1Color && labels[i + 32].ForeColor == P1Color || labels[i + 28].ForeColor == P1Color && labels[i + 27].ForeColor == P1Color && labels[i + 26].ForeColor == P1Color && labels[i + 25].ForeColor == P1Color || labels[i + 21].ForeColor == P1Color && labels[i + 20].ForeColor == P1Color && labels[i + 19].ForeColor == P1Color && labels[i + 18].ForeColor == P1Color || labels[i + 14].ForeColor == P1Color && labels[i + 13].ForeColor == P1Color && labels[i + 12].ForeColor == P1Color && labels[i + 11].ForeColor == P1Color || labels[i + 7].ForeColor == P1Color && labels[i + 6].ForeColor == P1Color && labels[i + 5].ForeColor == P1Color && labels[i + 4].ForeColor == P1Color || labels[i + 0].ForeColor == P1Color && labels[i - 1].ForeColor == P1Color && labels[i - 2].ForeColor == P1Color && labels[i - 3].ForeColor == P1Color)
                {
                    MessageBox.Show(P1Nimi + " voitti pelin!");
                    Data1();
                }
                //P2
                if (labels[i + 35].ForeColor == P2Color && labels[i + 34].ForeColor == P2Color && labels[i + 33].ForeColor == P2Color && labels[i + 32].ForeColor == P2Color || labels[i + 28].ForeColor == P2Color && labels[i + 27].ForeColor == P2Color && labels[i + 26].ForeColor == P2Color && labels[i + 25].ForeColor == P2Color || labels[i + 21].ForeColor == P2Color && labels[i + 20].ForeColor == P2Color && labels[i + 19].ForeColor == P2Color && labels[i + 18].ForeColor == P2Color || labels[i + 14].ForeColor == P2Color && labels[i + 13].ForeColor == P2Color && labels[i + 12].ForeColor == P2Color && labels[i + 11].ForeColor == P2Color || labels[i + 7].ForeColor == P2Color && labels[i + 6].ForeColor == P2Color && labels[i + 5].ForeColor == P2Color && labels[i + 4].ForeColor == P2Color || labels[i + 0].ForeColor == P2Color && labels[i - 1].ForeColor == P2Color && labels[i - 2].ForeColor == P2Color && labels[i - 3].ForeColor == P2Color)
                {
                    MessageBox.Show(P2Nimi + " voitti pelin!");
                    Data2();
                }
            }
            if (i == 5 || i == 4 || i == 3)
            {
                //P1
                if (labels[i + 36].ForeColor == P1Color && labels[i + 35].ForeColor == P1Color && labels[i + 34].ForeColor == P1Color && labels[i + 33].ForeColor == P1Color || labels[i + 29].ForeColor == P1Color && labels[i + 28].ForeColor == P1Color && labels[i + 27].ForeColor == P1Color && labels[i + 26].ForeColor == P1Color || labels[i + 22].ForeColor == P1Color && labels[i + 21].ForeColor == P1Color && labels[i + 20].ForeColor == P1Color && labels[i + 19].ForeColor == P1Color || labels[i + 15].ForeColor == P1Color && labels[i + 14].ForeColor == P1Color && labels[i + 13].ForeColor == P1Color && labels[i + 12].ForeColor == P1Color || labels[i + 8].ForeColor == P1Color && labels[i + 7].ForeColor == P1Color && labels[i + 6].ForeColor == P1Color && labels[i + 5].ForeColor == P1Color || labels[i + 1].ForeColor == P1Color && labels[i + 0].ForeColor == P1Color && labels[i - 1].ForeColor == P1Color && labels[i - 2].ForeColor == P1Color)
                {
                    MessageBox.Show(P1Nimi + " voitti pelin!");
                    Data1();
                }
                //P2
                if (labels[i + 36].ForeColor == P2Color && labels[i + 35].ForeColor == P2Color && labels[i + 34].ForeColor == P2Color && labels[i + 33].ForeColor == P2Color || labels[i + 29].ForeColor == P2Color && labels[i + 28].ForeColor == P2Color && labels[i + 27].ForeColor == P2Color && labels[i + 26].ForeColor == P2Color || labels[i + 22].ForeColor == P2Color && labels[i + 21].ForeColor == P2Color && labels[i + 20].ForeColor == P2Color && labels[i + 19].ForeColor == P2Color || labels[i + 15].ForeColor == P2Color && labels[i + 14].ForeColor == P2Color && labels[i + 13].ForeColor == P2Color && labels[i + 12].ForeColor == P2Color || labels[i + 8].ForeColor == P2Color && labels[i + 7].ForeColor == P2Color && labels[i + 6].ForeColor == P2Color && labels[i + 5].ForeColor == P2Color || labels[i + 1].ForeColor == P2Color && labels[i + 0].ForeColor == P2Color && labels[i - 1].ForeColor == P2Color && labels[i - 2].ForeColor == P2Color)
                {
                    MessageBox.Show(P2Nimi + " voitti pelin!");
                    Data2();
                }
            }
            if (i == 4 || i == 3)
            {
                //P1
                if (labels[i + 37].ForeColor == P1Color && labels[i + 36].ForeColor == P1Color && labels[i + 35].ForeColor == P1Color && labels[i + 34].ForeColor == P1Color || labels[i + 30].ForeColor == P1Color && labels[i + 29].ForeColor == P1Color && labels[i + 28].ForeColor == P1Color && labels[i + 27].ForeColor == P1Color || labels[i + 23].ForeColor == P1Color && labels[i + 22].ForeColor == P1Color && labels[i + 21].ForeColor == P1Color && labels[i + 20].ForeColor == P1Color || labels[i + 16].ForeColor == P1Color && labels[i + 15].ForeColor == P1Color && labels[i + 14].ForeColor == P1Color && labels[i + 13].ForeColor == P1Color || labels[i + 9].ForeColor == P1Color && labels[i + 8].ForeColor == P1Color && labels[i + 7].ForeColor == P1Color && labels[i + 6].ForeColor == P1Color || labels[i + 2].ForeColor == P1Color && labels[i + 1].ForeColor == P1Color && labels[i + 0].ForeColor == P1Color && labels[i - 1].ForeColor == P1Color)
                {
                    MessageBox.Show(P1Nimi + " voitti pelin!");
                    Data1();
                }
                //P2
                if (labels[i + 37].ForeColor == P2Color && labels[i + 36].ForeColor == P2Color && labels[i + 35].ForeColor == P2Color && labels[i + 34].ForeColor == P2Color || labels[i + 30].ForeColor == P2Color && labels[i + 29].ForeColor == P2Color && labels[i + 28].ForeColor == P2Color && labels[i + 27].ForeColor == P2Color || labels[i + 23].ForeColor == P2Color && labels[i + 22].ForeColor == P2Color && labels[i + 21].ForeColor == P2Color && labels[i + 20].ForeColor == P2Color || labels[i + 16].ForeColor == P2Color && labels[i + 15].ForeColor == P2Color && labels[i + 14].ForeColor == P2Color && labels[i + 13].ForeColor == P2Color || labels[i + 9].ForeColor == P2Color && labels[i + 8].ForeColor == P2Color && labels[i + 7].ForeColor == P2Color && labels[i + 6].ForeColor == P2Color || labels[i + 2].ForeColor == P2Color && labels[i + 1].ForeColor == P2Color && labels[i + 0].ForeColor == P2Color && labels[i - 1].ForeColor == P2Color)
                {
                    MessageBox.Show(P2Nimi + " voitti pelin!");
                    Data2();
                }
            }
        }
        //Ristiin vasemmalta oikealle tarkistus
        public void RistiVasenOikea(Label label)
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
            //+0
            if (i == 0 || i == 1 || i == 2 || i == 3)
            {
                //P1
                if (labels[i].ForeColor == P1Color && labels[i + 8].ForeColor == P1Color && labels[i + 16].ForeColor == P1Color && labels[i + 24].ForeColor == P1Color)
                {
                    MessageBox.Show(P1Nimi + " voitti pelin!");
                    Data1();
                }
                //P2
                if (labels[i].ForeColor == P2Color && labels[i + 8].ForeColor == P2Color && labels[i + 16].ForeColor == P2Color && labels[i + 24].ForeColor == P2Color)
                {
                    MessageBox.Show(P2Nimi + " voitti pelin!");
                    Data2();
                }
                //P1
                if (labels[i + 7].ForeColor == P1Color && labels[i + 15].ForeColor == P1Color && labels[i + 23].ForeColor == P1Color && labels[i + 31].ForeColor == P1Color)
                {
                    MessageBox.Show(P1Nimi + " voitti pelin!");
                    Data1();
                }
                //P2
                if (labels[i + 7].ForeColor == P2Color && labels[i + 15].ForeColor == P2Color && labels[i + 23].ForeColor == P2Color && labels[i + 31].ForeColor == P2Color)
                {
                    MessageBox.Show(P2Nimi + " voitti pelin!");
                    Data2();
                }
                //P1
                if (labels[i + 14].ForeColor == P1Color && labels[i + 22].ForeColor == P1Color && labels[i + 30].ForeColor == P1Color && labels[i + 38].ForeColor == P1Color)
                {
                    MessageBox.Show(P1Nimi + " voitti pelin!");
                    Data1();
                }
                //P2
                if (labels[i + 14].ForeColor == P2Color && labels[i + 22].ForeColor == P2Color && labels[i + 30].ForeColor == P2Color && labels[i + 38].ForeColor == P2Color)
                {
                    MessageBox.Show(P2Nimi + " voitti pelin!");
                    Data2();
                }
            }
            //+1
            if (i == 1 || i == 2 || i == 3 || i == 4)
            {
                //P1
                if (labels[i - 1].ForeColor == P1Color && labels[i + 7].ForeColor == P1Color && labels[i + 15].ForeColor == P1Color && labels[i + 23].ForeColor == P1Color)
                {
                    MessageBox.Show(P1Nimi + " voitti pelin!");
                    Data1();
                }
                //P2
                if (labels[i - 1].ForeColor == P2Color && labels[i + 7].ForeColor == P2Color && labels[i + 15].ForeColor == P2Color && labels[i + 23].ForeColor == P2Color)
                {
                    MessageBox.Show(P2Nimi + " voitti pelin!");
                    Data2();
                }
                //P1
                if (labels[i + 6].ForeColor == P1Color && labels[i + 14].ForeColor == P1Color && labels[i + 22].ForeColor == P1Color && labels[i + 30].ForeColor == P1Color)
                {
                    MessageBox.Show(P1Nimi + " voitti pelin!");
                    Data1();
                }
                //P2
                if (labels[i + 6].ForeColor == P2Color && labels[i + 14].ForeColor == P2Color && labels[i + 22].ForeColor == P2Color && labels[i + 30].ForeColor == P2Color)
                {
                    MessageBox.Show(P2Nimi + " voitti pelin!");
                    Data2();
                }
                //P1
                if (labels[i + 13].ForeColor == P1Color && labels[i + 21].ForeColor == P1Color && labels[i + 29].ForeColor == P1Color && labels[i + 37].ForeColor == P1Color)
                {
                    MessageBox.Show(P1Nimi + " voitti pelin!");
                    Data1();
                }
                //P2
                if (labels[i + 13].ForeColor == P2Color && labels[i + 21].ForeColor == P2Color && labels[i + 29].ForeColor == P2Color && labels[i + 37].ForeColor == P2Color)
                {
                    MessageBox.Show(P2Nimi + " voitti pelin!");
                    Data2();
                }
            }
            //+2
            if (i == 2 || i == 3 || i == 4 || i == 5)
            {
                //P1
                if (labels[i - 2].ForeColor == P1Color && labels[i + 6].ForeColor == P1Color && labels[i + 14].ForeColor == P1Color && labels[i + 22].ForeColor == P1Color)
                {
                    MessageBox.Show(P1Nimi + " voitti pelin!");
                    Data1();
                }
                //P2
                if (labels[i - 2].ForeColor == P2Color && labels[i + 6].ForeColor == P2Color && labels[i + 14].ForeColor == P2Color && labels[i + 22].ForeColor == P2Color)
                {
                    MessageBox.Show(P2Nimi + " voitti pelin!");
                    Data2();
                }
                //P1
                if (labels[i + 5].ForeColor == P1Color && labels[i + 13].ForeColor == P1Color && labels[i + 21].ForeColor == P1Color && labels[i + 29].ForeColor == P1Color)
                {
                    MessageBox.Show(P1Nimi + " voitti pelin!");
                    Data1();
                }
                //P2
                if (labels[i + 5].ForeColor == P2Color && labels[i + 13].ForeColor == P2Color && labels[i + 21].ForeColor == P2Color && labels[i + 29].ForeColor == P2Color)
                {
                    MessageBox.Show(P2Nimi + " voitti pelin!");
                    Data2();
                }
                //P1
                if (labels[i + 12].ForeColor == P1Color && labels[i + 20].ForeColor == P1Color && labels[i + 28].ForeColor == P1Color && labels[i + 36].ForeColor == P1Color)
                {
                    MessageBox.Show(P1Nimi + " voitti pelin!");
                    Data1();
                }
                //P2
                if (labels[i + 12].ForeColor == P2Color && labels[i + 20].ForeColor == P2Color && labels[i + 28].ForeColor == P2Color && labels[i + 36].ForeColor == P2Color)
                {
                    MessageBox.Show(P2Nimi + " voitti pelin!");
                    Data2();
                }
            }
            //+3
            if (i == 3 || i == 4 || i == 5 || i == 6)
            {
                //P1
                if (labels[i - 3].ForeColor == P1Color && labels[i + 5].ForeColor == P1Color && labels[i + 13].ForeColor == P1Color && labels[i + 21].ForeColor == P1Color)
                {
                    MessageBox.Show(P1Nimi + " voitti pelin!");
                    Data1();
                }
                //P2
                if (labels[i - 3].ForeColor == P2Color && labels[i + 5].ForeColor == P2Color && labels[i + 13].ForeColor == P2Color && labels[i + 21].ForeColor == P2Color)
                {
                    MessageBox.Show(P2Nimi + " voitti pelin!");
                    Data2();
                }
                //P1
                if (labels[i + 4].ForeColor == P1Color && labels[i + 12].ForeColor == P1Color && labels[i + 20].ForeColor == P1Color && labels[i + 28].ForeColor == P1Color)
                {
                    MessageBox.Show(P1Nimi + " voitti pelin!");
                    Data1();
                }
                //P2
                if (labels[i + 4].ForeColor == P2Color && labels[i + 12].ForeColor == P2Color && labels[i + 20].ForeColor == P2Color && labels[i + 28].ForeColor == P2Color)
                {
                    MessageBox.Show(P2Nimi + " voitti pelin!");
                    Data2();
                }
                //P1
                if (labels[i + 11].ForeColor == P1Color && labels[i + 19].ForeColor == P1Color && labels[i + 27].ForeColor == P1Color && labels[i + 35].ForeColor == P1Color)
                {
                    MessageBox.Show(P1Nimi + " voitti pelin!");
                    Data1();
                }
                //P2
                if (labels[i + 11].ForeColor == P2Color && labels[i + 19].ForeColor == P2Color && labels[i + 27].ForeColor == P2Color && labels[i + 35].ForeColor == P2Color)
                {
                    MessageBox.Show(P2Nimi + " voitti pelin!");
                    Data2();
                }
            }
        }
        //Ristiin oikealta vasemalle tarkistus
        public void RistiOikeaVasen(Label label)
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
            //+0
            if (i == 3 || i == 4 || i == 5 || i == 6)
            {
                //P1
                if (labels[i].ForeColor == P1Color && labels[i + 6].ForeColor == P1Color && labels[i + 12].ForeColor == P1Color && labels[i + 18].ForeColor == P1Color)
                {
                    MessageBox.Show(P1Nimi + " voitti pelin!");
                    Data1();
                }
                //P2
                if (labels[i].ForeColor == P2Color && labels[i + 6].ForeColor == P2Color && labels[i + 12].ForeColor == P2Color && labels[i + 18].ForeColor == P2Color)
                {
                    MessageBox.Show(P2Nimi + " voitti pelin!");
                    Data2();
                }
                //P1
                if (labels[i + 7].ForeColor == P1Color && labels[i + 13].ForeColor == P1Color && labels[i + 19].ForeColor == P1Color && labels[i + 25].ForeColor == P1Color)
                {
                    MessageBox.Show(P1Nimi + " voitti pelin!");
                    Data1();
                }
                //P2
                if (labels[i + 7].ForeColor == P2Color && labels[i + 13].ForeColor == P2Color && labels[i + 19].ForeColor == P2Color && labels[i + 25].ForeColor == P2Color)
                {
                    MessageBox.Show(P2Nimi + " voitti pelin!");
                    Data2();
                }
                //P1
                if (labels[i + 14].ForeColor == P1Color && labels[i + 20].ForeColor == P1Color && labels[i + 26].ForeColor == P1Color && labels[i + 32].ForeColor == P1Color)
                {
                    MessageBox.Show(P1Nimi + " voitti pelin!");
                    Data1();
                }
                //P2
                if (labels[i + 14].ForeColor == P2Color && labels[i + 20].ForeColor == P2Color && labels[i + 26].ForeColor == P2Color && labels[i + 32].ForeColor == P2Color)
                {
                    MessageBox.Show(P2Nimi + " voitti pelin!");
                    Data2();
                }
            }
            //+1
            if (i == 2 || i == 3 || i == 4 || i == 5)
            {
                //P1
                if (labels[i + 1].ForeColor == P1Color && labels[i + 7].ForeColor == P1Color && labels[i + 13].ForeColor == P1Color && labels[i + 19].ForeColor == P1Color)
                {
                    MessageBox.Show(P1Nimi + " voitti pelin!");
                    Data1();
                }
                //P2
                if (labels[i + 1].ForeColor == P2Color && labels[i + 7].ForeColor == P2Color && labels[i + 13].ForeColor == P2Color && labels[i + 19].ForeColor == P2Color)
                {
                    MessageBox.Show(P2Nimi + " voitti pelin!");
                    Data2();
                }
                //P1
                if (labels[i + 8].ForeColor == P1Color && labels[i + 14].ForeColor == P1Color && labels[i + 20].ForeColor == P1Color && labels[i + 26].ForeColor == P1Color)
                {
                    MessageBox.Show(P1Nimi + " voitti pelin!");
                    Data1();
                }
                //P2
                if (labels[i + 8].ForeColor == P2Color && labels[i + 14].ForeColor == P2Color && labels[i + 20].ForeColor == P2Color && labels[i + 26].ForeColor == P2Color)
                {
                    MessageBox.Show(P2Nimi + " voitti pelin!");
                    Data2();
                }
                //P1
                if (labels[i + 15].ForeColor == P1Color && labels[i + 21].ForeColor == P1Color && labels[i + 27].ForeColor == P1Color && labels[i + 33].ForeColor == P1Color)
                {
                    MessageBox.Show(P1Nimi + " voitti pelin!");
                    Data1();
                }
                //P2
                if (labels[i + 15].ForeColor == P2Color && labels[i + 21].ForeColor == P2Color && labels[i + 27].ForeColor == P2Color && labels[i + 33].ForeColor == P2Color)
                {
                    MessageBox.Show(P2Nimi + " voitti pelin!");
                    Data2();
                }
            }
            //+2
            if (i == 1 || i == 2 || i == 3 || i == 4)
            {
                //P1
                if (labels[i + 2].ForeColor == P1Color && labels[i + 8].ForeColor == P1Color && labels[i + 14].ForeColor == P1Color && labels[i + 20].ForeColor == P1Color)
                {
                    MessageBox.Show(P1Nimi + " voitti pelin!");
                    Data1();
                }
                //P2
                if (labels[i + 2].ForeColor == P2Color && labels[i + 8].ForeColor == P2Color && labels[i + 14].ForeColor == P2Color && labels[i + 20].ForeColor == P2Color)
                {
                    MessageBox.Show(P2Nimi + " voitti pelin!");
                    Data2();
                }
                //P1
                if (labels[i + 9].ForeColor == P1Color && labels[i + 15].ForeColor == P1Color && labels[i + 21].ForeColor == P1Color && labels[i + 27].ForeColor == P1Color)
                {
                    MessageBox.Show(P1Nimi + " voitti pelin!");
                    Data1();
                }
                //P2
                if (labels[i + 9].ForeColor == P2Color && labels[i + 15].ForeColor == P2Color && labels[i + 21].ForeColor == P2Color && labels[i + 27].ForeColor == P2Color)
                {
                    MessageBox.Show(P2Nimi + " voitti pelin!");
                    Data2();
                }
                //P1
                if (labels[i + 16].ForeColor == P1Color && labels[i + 22].ForeColor == P1Color && labels[i + 28].ForeColor == P1Color && labels[i + 34].ForeColor == P1Color)
                {
                    MessageBox.Show(P1Nimi + " voitti pelin!");
                    Data1();
                }
                //P2
                if (labels[i + 16].ForeColor == P2Color && labels[i + 22].ForeColor == P2Color && labels[i + 28].ForeColor == P2Color && labels[i + 34].ForeColor == P2Color)
                {
                    MessageBox.Show(P2Nimi + " voitti pelin!");
                    Data2();
                }
            }
            //+3
            if (i == 0 || i == 1 || i == 2 || i == 3)
            {
                //P1
                if (labels[i + 3].ForeColor == P1Color && labels[i + 9].ForeColor == P1Color && labels[i + 15].ForeColor == P1Color && labels[i + 21].ForeColor == P1Color)
                {
                    MessageBox.Show(P1Nimi + " voitti pelin!");
                    Data1();
                }
                //P2
                if (labels[i + 3].ForeColor == P2Color && labels[i + 9].ForeColor == P2Color && labels[i + 15].ForeColor == P2Color && labels[i + 21].ForeColor == P2Color)
                {
                    MessageBox.Show(P2Nimi + " voitti pelin!");
                    Data2();
                }
                //P1
                if (labels[i + 10].ForeColor == P1Color && labels[i + 16].ForeColor == P1Color && labels[i + 22].ForeColor == P1Color && labels[i + 28].ForeColor == P1Color)
                {
                    MessageBox.Show(P1Nimi + " voitti pelin!");
                    Data1();
                }
                //P2
                if (labels[i + 10].ForeColor == P2Color && labels[i + 16].ForeColor == P2Color && labels[i + 22].ForeColor == P2Color && labels[i + 28].ForeColor == P2Color)
                {
                    MessageBox.Show(P2Nimi + " voitti pelin!");
                    Data2();
                }
                //P1
                if (labels[i + 17].ForeColor == P1Color && labels[i + 23].ForeColor == P1Color && labels[i + 29].ForeColor == P1Color && labels[i + 35].ForeColor == P1Color)
                {
                    MessageBox.Show(P1Nimi + " voitti pelin!");
                    Data1();
                }
                //P2
                if (labels[i + 17].ForeColor == P2Color && labels[i + 23].ForeColor == P2Color && labels[i + 29].ForeColor == P2Color && labels[i + 35].ForeColor == P2Color)
                {
                    MessageBox.Show(P2Nimi + " voitti pelin!");
                    Data2();
                }
            }
        }
        //Tasapelin tarkistus
        public void Tasapeli(Label label)
        {
            if (labels[0].ForeColor != Color.White && labels[1].ForeColor != Color.White && labels[2].ForeColor != Color.White && labels[3].ForeColor != Color.White && labels[4].ForeColor != Color.White && labels[5].ForeColor != Color.White && labels[6].ForeColor != Color.White)
            {
                MessageBox.Show("Tasapeli!");
                dbYhteys.Open();
                SqlCommand sc = new SqlCommand("INSERT INTO score(Nimi,Väri,Pvm)VALUES(@Nimi,@Vari,@Pvm)", dbYhteys);
                sc.Parameters.Add("@Nimi", SqlDbType.VarChar, 100).Value = "Tasapeli";
                sc.Parameters.Add("@Vari", SqlDbType.VarChar, 100).Value = "Tasapeli";
                sc.Parameters.Add("@Pvm", SqlDbType.DateTime).Value = DateTime.Now;
                sc.ExecuteNonQuery();
                dbYhteys.Close();
                Pisteet f = new Pisteet();
                this.Hide();
                f.ShowDialog();
            }
        }
    }
}