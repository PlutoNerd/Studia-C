using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Ćwiczenie_3_Pluta
{
    public partial class Form1 : Form
    {
        double  n, tend, h, x0;        //deklaracja zmiennych
        int roz;
        double[] tabt;                //lista t
        double[] xEuler;              //wyniki x dla Eulera
        double[] xCaouchy;             //wyniki x dla Eulera Cauchego
        double[] xFunkcja;            //wyniki x dla normalnej funkcji
        double poch(double x, double t)     // liczeie pochodnej dx/dt
        {
            return (t * Math.Pow(Math.E, (-t * t))) - (2 * t * x);
        }
        double wzor(double t, double C)               //wzór ogólny funkcji
        {           
            return Math.Pow(Math.E,-(Math.Pow(t,2))) * (0.5*(Math.Pow(t,2)) + C);            
        }
        public Form1()
        {
            InitializeComponent();
        }
        public void clear()               //czyszczenie wykresu
        {
            wykres.Series["Euler"].Points.Clear();
            wykres.Series["Euler Cauch’yego"].Points.Clear();
            wykres.Series["Dokładna funkcja"].Points.Clear();
        }
        public void Przedzial()            //liczenie przedziału i rozmiaru tablic
        {
            h = double.Parse(liczbah.Text);
            x0 = double.Parse(liczbax0.Text);
            tend = double.Parse(liczbatend.Text);
            n = tend / h;
            roz = (int)Math.Round(n)-1;
            tabt = new double[roz];
            xEuler = new double[roz];
            xCaouchy = new double[roz];
            xFunkcja = new double[roz];
            tabt[0] = h;
            for (int i = 1; i < roz; i++)
            {
                tabt[i] = h + tabt[i - 1];
            }
        }
        public void Euler()               //liczenie x  Eulera
        {

            xEuler[0] = x0;
            wykres.Series["Euler"].Points.AddXY(0, xEuler[0]);
            for (int i = 1; i < roz; i++)
            {
                xEuler[i] = xEuler[i - 1] + (h * poch(xEuler[i - 1], tabt[i - 1]));
            }
        }
        public void Cauch()              //liczenie x Caouchyego
        {

            xCaouchy[0] = x0;
            wykres.Series["Euler Cauch’yego"].Points.AddXY(0, xCaouchy[0]);
            for (int i = 1; i < roz; i++)
            {
                double fxt = poch(xCaouchy[i - 1], tabt[i - 1]);
                double fall = poch(xCaouchy[i - 1] + (h/2) * fxt, tabt[i - 1] + (h / 2));
                xCaouchy[i] = xCaouchy[i - 1] + h * fall;         
            }
        }
        public void Funkcja()           //liczenie x funkcji
        {            
            xFunkcja[0] = 0;
            wykres.Series["Dokładna funkcja"].Points.AddXY(0, x0);
            for (int i = 1; i < roz; i++)
            {

                xFunkcja[i] = wzor(tabt[i], x0);
            }

        }
        public void Rysuj()             //Rysowanie funkcji z tabel
        {
                
            for(int i = 1; i < roz; i++)
            {
                wykres.Series["Dokładna funkcja"].Points.AddXY(tabt[i], xFunkcja[i]);
                wykres.Series["Euler"].Points.AddXY(tabt[i], xEuler[i]);
                wykres.Series["Euler Cauch’yego"].Points.AddXY(tabt[i], xCaouchy[i]);
                
            }
        }
        private void czysc_Click(object sender, EventArgs e)
        {
            clear();
        }
        private void OBLICZ_Click(object sender, EventArgs e)
        {
            if (liczbah.Text == "" ||  liczbatend.Text == ""  || liczbax0.Text == ""  )        //sprawdzanie czy jest podany x
            {
                DialogResult result;
                result = MessageBox.Show("Brak jednej z wartości lub jest na nieprawidłowa", "UWAGA", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }
            else
                clear();
            Przedzial();
            Funkcja();
            Euler();
            Cauch();
            Rysuj();
            


        }
    }
}
