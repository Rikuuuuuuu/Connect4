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

            for (int i = 0; i < napit.Length; i++)
            {
                this.BackColor = Color.LightSteelBlue;
                Label esim = new Label();
                esim.Location = new Point(0 + (i * 91), 0 + (i * 0));
                esim.Width = 80;
                esim.Height = 80;
                esim.BorderStyle = BorderStyle.None;
                esim.TextAlign = ContentAlignment.MiddleCenter;
                esim.ForeColor = Color.White;
                esim.BackColor = Color.LightSteelBlue;
                esim.Font = new Font("Webdings", 48);
                esim.Click += new EventHandler(Label_click);
                esim.Name = i.ToString();
                    
                esim.Text = "n";
                Controls.Add(esim);
                
                if (i >= 7)
                {
                    esim.Location = new Point(-637 + (i * 91), 91 + (i * 0));
                }
                if (i >= 14)
                {
                    esim.Location = new Point(-1274 + (i * 91), 182 + (i * 0));
                }
                if (i >= 21)
                {
                    esim.Location = new Point(-1911 + (i * 91), 273 + (i * 0));
                }
                if (i >= 28)
                {
                    esim.Location = new Point(-2548 + (i * 91), 364 + (i * 0));
                }
                if (i >= 35)
                {
                    esim.Location = new Point(-3185 + (i * 91), 455 + (i * 0));
                }
            }
        }
        private void Label_click(object sender, EventArgs e)
        {
            Label valittu = sender as Label;
            int alempi = Convert.ToInt32(valittu.Name) + 7;

            if (valittu.ForeColor == Color.White)
            {


                if (pelaaja == 1)
                {
                    valittu.ForeColor = Color.Red;
                    pelaaja++;
                }
                else if (pelaaja == 2)
                {
                    valittu.ForeColor = Color.Yellow;
                    pelaaja = 1;
                }
            }
        }
    }
}