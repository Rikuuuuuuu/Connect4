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
    public partial class Form2 : Form
    {
        int pelaaja = 1;
        List<Label> Punainen = new List<Label>();
        List<Label> Keltainen = new List<Label>();
        public Form2()
        {
            InitializeComponent();
        }
        private void RiviA_Click(object sender, EventArgs e)
        {
            if (A6.ForeColor == Color.White)
            {
                if (pelaaja == 1)
                {
                    A6.ForeColor = Color.Red;
                    pelaaja++;
                    Punainen.Add(A6);
                }
                else if (pelaaja == 2)
                {
                    A6.ForeColor = Color.Yellow;
                    pelaaja = 1;
                    Keltainen.Add(A6);
                }

            }
            else if (A6.ForeColor != Color.White)
            {
                if (A5.ForeColor == Color.White)
                {
                    if (pelaaja == 1)
                    {
                        A5.ForeColor = Color.Red;
                        pelaaja++;
                        Punainen.Add(A5);
                    }
                    else if (pelaaja == 2)
                    {
                        A5.ForeColor = Color.Yellow;
                        pelaaja = 1;
                        Keltainen.Add(A5);
                    }
                }
                else if (A5.ForeColor != Color.White)
                {
                    if (A4.ForeColor == Color.White)
                    {
                        if (pelaaja == 1)
                        {
                            A4.ForeColor = Color.Red;
                            pelaaja++;
                            Punainen.Add(A4);
                        }
                        else if (pelaaja == 2)
                        {
                            A4.ForeColor = Color.Yellow;
                            pelaaja = 1;
                            Keltainen.Add(A4);
                        }
                    }
                    else if (A4.ForeColor != Color.White)
                    {
                        if (A3.ForeColor == Color.White)
                        {
                            if (pelaaja == 1)
                            {
                                A3.ForeColor = Color.Red;
                                pelaaja++;
                                Punainen.Add(A3);
                            }
                            else if (pelaaja == 2)
                            {
                                A3.ForeColor = Color.Yellow;
                                pelaaja = 1;
                                Keltainen.Add(A3);
                            }
                        }
                        else if (A3.ForeColor != Color.White)
                        {
                            if (A2.ForeColor == Color.White)
                            {
                                if (pelaaja == 1)
                                {
                                    A2.ForeColor = Color.Red;
                                    pelaaja++;
                                    Punainen.Add(A2);
                                }
                                else if (pelaaja == 2)
                                {
                                    A2.ForeColor = Color.Yellow;
                                    pelaaja = 1;
                                    Keltainen.Add(A2);
                                }
                            }
                            else if (A2.ForeColor != Color.White)
                            {
                                if (A1.ForeColor == Color.White)
                                {
                                    if (pelaaja == 1)
                                    {
                                        A1.ForeColor = Color.Red;
                                        pelaaja++;
                                        Punainen.Add(A1);
                                    }
                                    else if (pelaaja == 2)
                                    {
                                        A1.ForeColor = Color.Yellow;
                                        pelaaja = 1;
                                        Keltainen.Add(A1);
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private void RiviB_Click(object sender, EventArgs e)
        {
            if (B6.ForeColor == Color.White)
            {
                if (pelaaja == 1)
                {
                    B6.ForeColor = Color.Red;
                    pelaaja++;
                }
                else if (pelaaja == 2)
                {
                    B6.ForeColor = Color.Yellow;
                    pelaaja = 1;
                }

            }
            else if (B6.ForeColor != Color.White)
            {
                if (B5.ForeColor == Color.White)
                {
                    if (pelaaja == 1)
                    {
                        B5.ForeColor = Color.Red;
                        pelaaja++;
                    }
                    else if (pelaaja == 2)
                    {
                        B5.ForeColor = Color.Yellow;
                        pelaaja = 1;
                    }
                }
                else if (B5.ForeColor != Color.White)
                {
                    if (B4.ForeColor == Color.White)
                    {
                        if (pelaaja == 1)
                        {
                            B4.ForeColor = Color.Red;
                            pelaaja++;
                        }
                        else if (pelaaja == 2)
                        {
                            B4.ForeColor = Color.Yellow;
                            pelaaja = 1;
                        }
                    }
                    else if (B4.ForeColor != Color.White)
                    {
                        if (B3.ForeColor == Color.White)
                        {
                            if (pelaaja == 1)
                            {
                                B3.ForeColor = Color.Red;
                                pelaaja++;
                            }
                            else if (pelaaja == 2)
                            {
                                B3.ForeColor = Color.Yellow;
                                pelaaja = 1;
                            }
                        }
                        else if (B3.ForeColor != Color.White)
                        {
                            if (B2.ForeColor == Color.White)
                            {
                                if (pelaaja == 1)
                                {
                                    B2.ForeColor = Color.Red;
                                    pelaaja++;
                                }
                                else if (pelaaja == 2)
                                {
                                    B2.ForeColor = Color.Yellow;
                                    pelaaja = 1;
                                }
                            }
                            else if (B2.ForeColor != Color.White)
                            {
                                if (B1.ForeColor == Color.White)
                                {
                                    if (pelaaja == 1)
                                    {
                                        B1.ForeColor = Color.Red;
                                        pelaaja++;
                                    }
                                    else if (pelaaja == 2)
                                    {
                                        B1.ForeColor = Color.Yellow;
                                        pelaaja = 1;
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private void RiviC_Click(object sender, EventArgs e)
        {
            if (C6.ForeColor == Color.White)
            {
                if (pelaaja == 1)
                {
                    C6.ForeColor = Color.Red;
                    pelaaja++;
                }
                else if (pelaaja == 2)
                {
                    C6.ForeColor = Color.Yellow;
                    pelaaja = 1;
                }

            }
            else if (C6.ForeColor != Color.White)
            {
                if (C5.ForeColor == Color.White)
                {
                    if (pelaaja == 1)
                    {
                        C5.ForeColor = Color.Red;
                        pelaaja++;
                    }
                    else if (pelaaja == 2)
                    {
                        C5.ForeColor = Color.Yellow;
                        pelaaja = 1;
                    }
                }
                else if (C5.ForeColor != Color.White)
                {
                    if (C4.ForeColor == Color.White)
                    {
                        if (pelaaja == 1)
                        {
                            C4.ForeColor = Color.Red;
                            pelaaja++;
                        }
                        else if (pelaaja == 2)
                        {
                            C4.ForeColor = Color.Yellow;
                            pelaaja = 1;
                        }
                    }
                    else if (C4.ForeColor != Color.White)
                    {
                        if (C3.ForeColor == Color.White)
                        {
                            if (pelaaja == 1)
                            {
                                C3.ForeColor = Color.Red;
                                pelaaja++;
                            }
                            else if (pelaaja == 2)
                            {
                                C3.ForeColor = Color.Yellow;
                                pelaaja = 1;
                            }
                        }
                        else if (C3.ForeColor != Color.White)
                        {
                            if (C2.ForeColor == Color.White)
                            {
                                if (pelaaja == 1)
                                {
                                    C2.ForeColor = Color.Red;
                                    pelaaja++;
                                }
                                else if (pelaaja == 2)
                                {
                                    C2.ForeColor = Color.Yellow;
                                    pelaaja = 1;
                                }
                            }
                            else if (C2.ForeColor != Color.White)
                            {
                                if (C1.ForeColor == Color.White)
                                {
                                    if (pelaaja == 1)
                                    {
                                        C1.ForeColor = Color.Red;
                                        pelaaja++;
                                    }
                                    else if (pelaaja == 2)
                                    {
                                        C1.ForeColor = Color.Yellow;
                                        pelaaja = 1;
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        private void RiviD_Click(object sender, EventArgs e)
        {
            if (D6.ForeColor == Color.White)
            {
                if (pelaaja == 1)
                {
                    D6.ForeColor = Color.Red;
                    pelaaja++;
                }
                else if (pelaaja == 2)
                {
                    D6.ForeColor = Color.Yellow;
                    pelaaja = 1;
                }

            }
            else if (D6.ForeColor != Color.White)
            {
                if (D5.ForeColor == Color.White)
                {
                    if (pelaaja == 1)
                    {
                        D5.ForeColor = Color.Red;
                        pelaaja++;
                    }
                    else if (pelaaja == 2)
                    {
                        D5.ForeColor = Color.Yellow;
                        pelaaja = 1;
                    }
                }
                else if (D5.ForeColor != Color.White)
                {
                    if (D4.ForeColor == Color.White)
                    {
                        if (pelaaja == 1)
                        {
                            D4.ForeColor = Color.Red;
                            pelaaja++;
                        }
                        else if (pelaaja == 2)
                        {
                            D4.ForeColor = Color.Yellow;
                            pelaaja = 1;
                        }
                    }
                    else if (D4.ForeColor != Color.White)
                    {
                        if (D3.ForeColor == Color.White)
                        {
                            if (pelaaja == 1)
                            {
                                D3.ForeColor = Color.Red;
                                pelaaja++;
                            }
                            else if (pelaaja == 2)
                            {
                                D3.ForeColor = Color.Yellow;
                                pelaaja = 1;
                            }
                        }
                        else if (D3.ForeColor != Color.White)
                        {
                            if (D2.ForeColor == Color.White)
                            {
                                if (pelaaja == 1)
                                {
                                    D2.ForeColor = Color.Red;
                                    pelaaja++;
                                }
                                else if (pelaaja == 2)
                                {
                                    D2.ForeColor = Color.Yellow;
                                    pelaaja = 1;
                                }
                            }
                            else if (D2.ForeColor != Color.White)
                            {
                                if (D1.ForeColor == Color.White)
                                { 
                                    if (pelaaja == 1)
                                    {
                                        D1.ForeColor = Color.Red;
                                        pelaaja++;
                                    }
                                    else if (pelaaja == 2)
                                    {
                                        D1.ForeColor = Color.Yellow;
                                        pelaaja = 1;
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private void RiviE_Click(object sender, EventArgs e)
        {
            if (E6.ForeColor == Color.White)
            {
                if (pelaaja == 1)
                {
                    E6.ForeColor = Color.Red;
                    pelaaja++;
                }
                else if (pelaaja == 2)
                {
                    E6.ForeColor = Color.Yellow;
                    pelaaja = 1;
                }

            }
            else if (E6.ForeColor != Color.White)
            {
                if (E5.ForeColor == Color.White)
                {
                    if (pelaaja == 1)
                    {
                        E5.ForeColor = Color.Red;
                        pelaaja++;
                    }
                    else if (pelaaja == 2)
                    {
                        E5.ForeColor = Color.Yellow;
                        pelaaja = 1;
                    }
                }
                else if (E5.ForeColor != Color.White)
                {
                    if (E4.ForeColor == Color.White)
                    {
                        if (pelaaja == 1)
                        {
                            E4.ForeColor = Color.Red;
                            pelaaja++;
                        }
                        else if (pelaaja == 2)
                        {
                            E4.ForeColor = Color.Yellow;
                            pelaaja = 1;
                        }
                    }
                    else if (E4.ForeColor != Color.White)
                    {
                        if (E3.ForeColor == Color.White)
                        {
                            if (pelaaja == 1)
                            {
                                E3.ForeColor = Color.Red;
                                pelaaja++;
                            }
                            else if (pelaaja == 2)
                            {
                                E3.ForeColor = Color.Yellow;
                                pelaaja = 1;
                            }
                        }
                        else if (E3.ForeColor != Color.White)
                        {
                            if (E2.ForeColor == Color.White)
                            {
                                if (pelaaja == 1)
                                {
                                    E2.ForeColor = Color.Red;
                                    pelaaja++;
                                }
                                else if (pelaaja == 2)
                                {
                                    E2.ForeColor = Color.Yellow;
                                    pelaaja = 1;
                                }
                            }
                            else if (E2.ForeColor != Color.White)
                            {
                                if (E1.ForeColor == Color.White)
                                {
                                    if (pelaaja == 1)
                                    {
                                        E1.ForeColor = Color.Red;
                                        pelaaja++;
                                    }
                                    else if (pelaaja == 2)
                                    {
                                        E1.ForeColor = Color.Yellow;
                                        pelaaja = 1;
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private void RiviF_Click(object sender, EventArgs e)
        {
            if (F6.ForeColor == Color.White)
            {
                if (pelaaja == 1)
                {
                    F6.ForeColor = Color.Red;
                    pelaaja++;
                }
                else if (pelaaja == 2)
                {
                    F6.ForeColor = Color.Yellow;
                    pelaaja = 1;
                }

            }
            else if (F6.ForeColor != Color.White)
            {
                if (F5.ForeColor == Color.White)
                {
                    if (pelaaja == 1)
                    {
                        F5.ForeColor = Color.Red;
                        pelaaja++;
                    }
                    else if (pelaaja == 2)
                    {
                        F5.ForeColor = Color.Yellow;
                        pelaaja = 1;
                    }
                }
                else if (F5.ForeColor != Color.White)
                {
                    if (F4.ForeColor == Color.White)
                    {
                        if (pelaaja == 1)
                        {
                            F4.ForeColor = Color.Red;
                            pelaaja++;
                        }
                        else if (pelaaja == 2)
                        {
                            F4.ForeColor = Color.Yellow;
                            pelaaja = 1;
                        }
                    }
                    else if (F4.ForeColor != Color.White)
                    {
                        if (F3.ForeColor == Color.White)
                        {
                            if (pelaaja == 1)
                            {
                                F3.ForeColor = Color.Red;
                                pelaaja++;
                            }
                            else if (pelaaja == 2)
                            {
                                F3.ForeColor = Color.Yellow;
                                pelaaja = 1;
                            }
                        }
                        else if (F3.ForeColor != Color.White)
                        {
                            if (F2.ForeColor == Color.White)
                            {
                                if (pelaaja == 1)
                                {
                                    F2.ForeColor = Color.Red;
                                    pelaaja++;
                                }
                                else if (pelaaja == 2)
                                {
                                    F2.ForeColor = Color.Yellow;
                                    pelaaja = 1;
                                }
                            }
                            else if (F2.ForeColor != Color.White)
                            {
                                if (F1.ForeColor == Color.White)
                                {
                                    if (pelaaja == 1)
                                    {
                                        F1.ForeColor = Color.Red;
                                        pelaaja++;
                                    }
                                    else if (pelaaja == 2)
                                    {
                                        F1.ForeColor = Color.Yellow;
                                        pelaaja = 1;
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private void RiviG_Click(object sender, EventArgs e)
        {
            if (G6.ForeColor == Color.White)
            {
                if (pelaaja == 1)
                {
                    G6.ForeColor = Color.Red;
                    pelaaja++;
                }
                else if (pelaaja == 2)
                {
                    G6.ForeColor = Color.Yellow;
                    pelaaja = 1;
                }

            }
            else if (G6.ForeColor != Color.White)
            {
                if (G5.ForeColor == Color.White)
                {
                    if (pelaaja == 1)
                    {
                        G5.ForeColor = Color.Red;
                        pelaaja++;
                    }
                    else if (pelaaja == 2)
                    {
                        G5.ForeColor = Color.Yellow;
                        pelaaja = 1;
                    }
                }
                else if (G5.ForeColor != Color.White)
                {
                    if (G4.ForeColor == Color.White)
                    {
                        if (pelaaja == 1)
                        {
                            G4.ForeColor = Color.Red;
                            pelaaja++;
                        }
                        else if (pelaaja == 2)
                        {
                            G4.ForeColor = Color.Yellow;
                            pelaaja = 1;
                        }
                    }
                    else if (G4.ForeColor != Color.White)
                    {
                        if (G3.ForeColor == Color.White)
                        {
                            if (pelaaja == 1)
                            {
                                G3.ForeColor = Color.Red;
                                pelaaja++;
                            }
                            else if (pelaaja == 2)
                            {
                                G3.ForeColor = Color.Yellow;
                                pelaaja = 1;
                            }
                        }
                        else if (G3.ForeColor != Color.White)
                        {
                            if (G2.ForeColor == Color.White)
                            {
                                if (pelaaja == 1)
                                {
                                    G2.ForeColor = Color.Red;
                                    pelaaja++;
                                }
                                else if (pelaaja == 2)
                                {
                                    G2.ForeColor = Color.Yellow;
                                    pelaaja = 1;
                                }
                            }
                            else if (G2.ForeColor != Color.White)
                            {
                                if (G1.ForeColor == Color.White)
                                {
                                    if (pelaaja == 1)
                                    {
                                        G1.ForeColor = Color.Red;
                                        pelaaja++;
                                    }
                                    else if (pelaaja == 2)
                                    {
                                        G1.ForeColor = Color.Yellow;
                                        pelaaja = 1;
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        private void Voitto(object sender, EventArgs e)
        {
            //RiviA pysty
            if (A1.ForeColor == Color.Red && A2.ForeColor == Color.Red && A3.ForeColor == Color.Red && A4.ForeColor == Color.Red)
            {
                MessageBox.Show("Punainen voitti pelin!");
                Menu f = new Menu();
                this.Hide();
                f.ShowDialog();
            }
            if (A2.ForeColor == Color.Red && A3.ForeColor == Color.Red && A4.ForeColor == Color.Red && A5.ForeColor == Color.Red)
            {
                MessageBox.Show("Punainen voitti pelin!");
                Menu f = new Menu();
                this.Hide();
                f.ShowDialog();
            }
            if (A3.ForeColor == Color.Red && A4.ForeColor == Color.Red && A5.ForeColor == Color.Red && A6.ForeColor == Color.Red)
            {
                MessageBox.Show("Punainen voitti pelin!");
                Menu f = new Menu();
                this.Hide();
                f.ShowDialog();
            }
            if (A1.ForeColor == Color.Yellow && A2.ForeColor == Color.Yellow && A3.ForeColor == Color.Yellow && A4.ForeColor == Color.Yellow)
            {
                MessageBox.Show("Keltainen voitti pelin!");
                Menu f = new Menu();
                this.Hide();
                f.ShowDialog();
            }
            if (A2.ForeColor == Color.Yellow && A3.ForeColor == Color.Yellow && A4.ForeColor == Color.Yellow && A5.ForeColor == Color.Yellow)
            {
                MessageBox.Show("Keltainen voitti pelin!");
                Menu f = new Menu();
                this.Hide();
                f.ShowDialog();
            }
            if (A3.ForeColor == Color.Yellow && A4.ForeColor == Color.Yellow && A5.ForeColor == Color.Yellow && A6.ForeColor == Color.Yellow)
            {
                MessageBox.Show("Keltainen voitti pelin!");
                Menu f = new Menu();
                this.Hide();
                f.ShowDialog();
            }
            //RiviB pysty
            if (B1.ForeColor == Color.Red && B2.ForeColor == Color.Red && B3.ForeColor == Color.Red && B4.ForeColor == Color.Red)
            {
                MessageBox.Show("Punainen voitti pelin!");
                Menu f = new Menu();
                this.Hide();
                f.ShowDialog();
            }
            if (B2.ForeColor == Color.Red && B3.ForeColor == Color.Red && B4.ForeColor == Color.Red && B5.ForeColor == Color.Red)
            {
                MessageBox.Show("Punainen voitti pelin!");
                Menu f = new Menu();
                this.Hide();
                f.ShowDialog();
            }
            if (B3.ForeColor == Color.Red && B4.ForeColor == Color.Red && B5.ForeColor == Color.Red && B6.ForeColor == Color.Red)
            {
                MessageBox.Show("Punainen voitti pelin!");
                Menu f = new Menu();
                this.Hide();
                f.ShowDialog();
            }
            if (B1.ForeColor == Color.Yellow && B2.ForeColor == Color.Yellow && B3.ForeColor == Color.Yellow && B4.ForeColor == Color.Yellow)
            {
                MessageBox.Show("Keltainen voitti pelin!");
                Menu f = new Menu();
                this.Hide();
                f.ShowDialog();
            }
            if (B2.ForeColor == Color.Yellow && B3.ForeColor == Color.Yellow && B4.ForeColor == Color.Yellow && B5.ForeColor == Color.Yellow)
            {
                MessageBox.Show("Keltainen voitti pelin!");
                Menu f = new Menu();
                this.Hide();
                f.ShowDialog();
            }
            if (B3.ForeColor == Color.Yellow && B4.ForeColor == Color.Yellow && B5.ForeColor == Color.Yellow && B6.ForeColor == Color.Yellow)
            {
                MessageBox.Show("Keltainen voitti pelin!");
                Menu f = new Menu();
                this.Hide();
                f.ShowDialog();
            }
        }
    }
}