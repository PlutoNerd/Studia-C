using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cwieczenie_2_Pluta
{
    public partial class Form1 : Form
    {
        double A, B, C, D, x0, F, Poch, eps, a, b;
        int i, n;
        string space;

        private void CLEAR_Click(object sender, EventArgs e)
        {
            LiczbaA.Text = "";
            LiczbaB.Text = "";
            LiczbaC.Text = "";
            LiczbaD.Text = "";
            X0.Text = "";
            ITERACJE.Clear();
            GrA.Value = 0;
            GrB.Value = 0;
        }    //czyszczenie kalkulatora
              

        public Form1()
        {
            InitializeComponent();
        } 

        private void Form1_Load(object sender, EventArgs e)
        {
            Czas.Text = DateTime.Now.ToString("HH:mm   dd-MM-yyyy");
            label5.Visible = true;
            X0.Visible = true;
            outA.Visible = false;
            OutB.Visible = false;
            GrA.Visible = false;
            GrB.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
        } //ustaawienie wartości początkowych

        private void GrA_ValueChanged(object sender, EventArgs e)
        {
            outA.Text = GrA.Value.ToString();
        }  //wyświetlanie zian suwaka a

        private void GrB_ValueChanged(object sender, EventArgs e)
        {
            OutB.Text = GrB.Value.ToString();
        }   //wyświetanie zmian suwaka b

        private void Newton_CheckedChanged(object sender, EventArgs e)
        {
            label5.Visible = true;
            X0.Visible = true;
            outA.Visible = false;
            OutB.Visible = false;
            GrA.Visible = false;
            GrB.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
        }  //ustawinie stanu dla Netwona

        private void Bisekcja_CheckedChanged(object sender, EventArgs e)
        {
            label5.Visible = false;
            X0.Visible = false;
            outA.Visible = true;
            OutB.Visible = true;
            GrA.Visible = true;
            GrB.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
        }  //ustalenie stanu dla Bisekcji

        private void Falsi_CheckedChanged(object sender, EventArgs e)
        {
            label5.Visible = false;
            X0.Visible = false;
            outA.Visible = true;
            OutB.Visible = true;
            GrA.Visible = true;
            GrB.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
        }  //ustalenie stanu dla Falsi

        private void OBLICZ_Click(object sender, EventArgs e)
        {
            space = "           ";
            ITERACJE.Clear();
            eps = Math.Pow(10, -6);
            if (LiczbaA.Text == "" || LiczbaB.Text == "" || LiczbaC.Text == "" || LiczbaD.Text == "" || X0.Text == "")
            {
                DialogResult result;
                result = MessageBox.Show("Brak którejś wartości  lub jest ona nieprawidłowa", "UWAGA", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }
            else
            {
                if (Newton.Checked)
                {
                    double xp, xn;
                    A = double.Parse(LiczbaA.Text);
                    B = double.Parse(LiczbaB.Text);
                    C = double.Parse(LiczbaC.Text);
                    D = double.Parse(LiczbaD.Text);
                    x0 = double.Parse(X0.Text);
                    i = 1;
                    n = 1;
                    F = (A * Math.Pow(x0, 3)) + (B * Math.Pow(x0, 2)) + (C * x0) + D;
                    Poch = (A * 3 * Math.Pow(x0, 2)) + (B * 2 * x0) + C;
                    xp = x0 - (F / Poch);
                    ITERACJE.Text += "Iteracja " + n + ":" + space + "x= " + xp + Environment.NewLine;
                    do
                    {
                        n++;
                        F = (A * Math.Pow(xp, 3)) + (B * Math.Pow(xp, 2)) + (C * xp) + D;
                        Poch = (A * 3 * Math.Pow(xp, 2)) + (B * 2 * xp) + C;
                        xn = xp - (F / Poch);
                        ITERACJE.Text += "Iteracja " + n + ":" + space + "x= " + xn + Environment.NewLine;
                        xp = xn;

                    }
                    while (Math.Abs(F) > eps);


                }  // metoda newtona
                if (Bisekcja.Checked)
                {
                    double xp, xn, Fa, Fb;
                    A = double.Parse(LiczbaA.Text);
                    B = double.Parse(LiczbaB.Text);
                    C = double.Parse(LiczbaC.Text);
                    D = double.Parse(LiczbaD.Text);
                    a = double.Parse(outA.Text);
                    b = double.Parse(OutB.Text);
                    n = 1;
                    x0 = (a + b) / 2;
                    F = (A * Math.Pow(x0, 3)) + (B * Math.Pow(x0, 2)) + (C * x0) + D;
                    if (Math.Abs(F) < eps)
                    {
                        ITERACJE.Text = "gratulacje odrazu znalazłeś/łaś miejsce zerowe funcji" + Environment.NewLine;
                        ITERACJE.Text += "Iteracja " + n + ":" + space + "x= " + x0 + space + "<" + a + "," + b + ">" + Environment.NewLine;
                    }
                    else
                    {
                        Fa = (A * Math.Pow(a, 3)) + (B * Math.Pow(a, 2)) + (C * a) + D;
                        Fb = (A * Math.Pow(b, 3)) + (B * Math.Pow(b, 2)) + (C * b) + D;
                        if (Fa * Fb > 0)
                        {
                            ITERACJE.Text = "Podany przedział znajduje się po tej samej stronie funkcji. Proszę podać inny." + Environment.NewLine;
                        }
                        else
                        {
                            ITERACJE.Text += "Iteracja " + n + ":" + space + "x= " + x0 + space + "<" + a + "," + b + ">" + Environment.NewLine;
                            xp = x0;
                            do
                            {
                                if (Fa * F < 0)
                                {
                                    n++;
                                    b = xp;
                                    Fa = (A * Math.Pow(a, 3)) + (B * Math.Pow(a, 2)) + (C * a) + D;
                                    Fb = (A * Math.Pow(b, 3)) + (B * Math.Pow(b, 2)) + (C * b) + D;
                                    xn = (a + b) / 2;
                                    ITERACJE.Text += "Iteracja " + n + ":" + space + "x= " + xn + space + "<" + a + "," + b + ">" +space + "<" + a + "," + b + ">" + Environment.NewLine;
                                    F = (A * Math.Pow(xn, 3)) + (B * Math.Pow(xn, 2)) + (C * xn) + D;
                                    xp = xn;

                                }
                                else
                                {
                                    n++;
                                    a = xp;
                                    Fa = (A * Math.Pow(a, 3)) + (B * Math.Pow(a, 2)) + (C * a) + D;
                                    Fb = (A * Math.Pow(b, 3)) + (B * Math.Pow(b, 2)) + (C * b) + D;
                                    xn = (a + b) / 2;
                                    ITERACJE.Text += "Iteracja " + n + ":" + space + "x= " + xn + space + "<" + a + "," + b + ">" + Environment.NewLine;
                                    F = (A * Math.Pow(xn, 3)) + (B * Math.Pow(xn, 2)) + (C * xn) + D;
                                    xp = xn;

                                }

                            }
                            while (Math.Abs(F) > eps);
                        }

                    }


                }  //metoda Bisekcji
                if (Falsi.Checked)
                {
                    double xp, xn, Fa, Fb;
                    A = double.Parse(LiczbaA.Text);
                    B = double.Parse(LiczbaB.Text);
                    C = double.Parse(LiczbaC.Text);
                    D = double.Parse(LiczbaD.Text);
                    a = double.Parse(outA.Text);
                    b = double.Parse(OutB.Text);
                    n = 1;
                    Fa = (A * Math.Pow(a, 3)) + (B * Math.Pow(a, 2)) + (C * a) + D;
                    Fb = (A * Math.Pow(b, 3)) + (B * Math.Pow(b, 2)) + (C * b) + D;
                    x0 = (a * Fb - b * Fa) / (Fb - Fa);
                    F = (A * Math.Pow(x0, 3)) + (B * Math.Pow(x0, 2)) + (C * x0) + D;
                    if (Fa * Fb > 0)
                    {
                        ITERACJE.Text = "Podany przedział znajduje się po tej samej stronie funkcji. Proszę podać inny." + Environment.NewLine;
                    }
                    else
                    {
                        ITERACJE.Text += "Iteracja " + n + ":" + space + "x= " + x0 + space + "<" + a + "," + b + ">" + Environment.NewLine;
                        xp = x0;
                        do
                        {
                            if (Fa * F < 0)
                            {
                                n++;
                                b = xp;
                                Fa = (A * Math.Pow(a, 3)) + (B * Math.Pow(a, 2)) + (C * a) + D;
                                Fb = (A * Math.Pow(b, 3)) + (B * Math.Pow(b, 2)) + (C * b) + D;
                                xn = (a * Fb - b * Fa) / (Fb - Fa);
                                ITERACJE.Text += "Iteracja " + n + ":" + space + "x= " + xn + space + "<" + a + "," + b + ">" + Environment.NewLine;
                                F = (A * Math.Pow(xn, 3)) + (B * Math.Pow(xn, 2)) + (C * xn) + D;
                                xp = xn;

                            }
                            else
                            {
                                n++;
                                a = xp;
                                Fa = (A * Math.Pow(a, 3)) + (B * Math.Pow(a, 2)) + (C * a) + D;
                                Fb = (A * Math.Pow(b, 3)) + (B * Math.Pow(b, 2)) + (C * b) + D;
                                xn = (a * Fb - b * Fa) / (Fb - Fa);
                                ITERACJE.Text += "Iteracja " + n + ":" + space + "x= " + xn + space + "<" + a + "," + b + ">" + Environment.NewLine;
                                F = (A * Math.Pow(xn, 3)) + (B * Math.Pow(xn, 2)) + (C * xn) + D;
                                xp = xn;

                            }

                        }
                        while (Math.Abs(F) > eps);

                    }
                }  //Metoda Falsi nieograniczona

            
            }
        }
    }
}
