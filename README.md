# Studia-C
Moje projekty na studia UMG

Projekty zrealizownano w programie Visual Studio 2022

Ćwiczenie 1. Napisać program, który będzie liczył metodą iteacji pierwiastek kwadratowy, exponentę, sinusa oraz cosinusa  podanej przez użytkownika wartości X.

mój kod:


namespace Cwiczenie1_Pluta
{
 public partial class Form1 : Form
    {
        double x, s, m, y, yn, yp, K, eps, W, rad, i;
        int l, n;
        string x_str;

        private void wartosc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar == ',' || e.KeyChar == (char)Keys.Back)        //blokada na wprowadanie tylko liczb i ","
            {
                base.OnKeyPress(e);
            }
            else
            {
                e.Handled = true;
            }
        }

        

        private void button1_Click_2(object sender, EventArgs e)
        {
            interacje.Clear();
            wynik.Text = "Wynik to:";
            wartosc.Text = "";

        }

       

        private void label1_Click(object sender, EventArgs e)
        {

        }

        


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            interacje.Clear();
            wynik.Text = "Wynik to:";
            eps = Math.Pow(10, -6);          //deklatacja stałej dokłądności iteracji


            if (wartosc.Text == "")        //sprawdzanie czy jest podany x
            {
                DialogResult result;
                result = MessageBox.Show("Brak wartości X lub jest na nieprawidłowa", "UWAGA", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }
            else
            {

                x = double.Parse(wartosc.Text);
                if (x < 0)                  //sprawdzanie czy x nie jest ujmeny
                {
                    DialogResult result;
                    result = MessageBox.Show("Wartość X nie może być ujemna", "UWAGA", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                }
                else
                {
                    if (sqrt.Checked)               // warunek i pętla dla pierwiastka
                    {
                        x = double.Parse(wartosc.Text);
                        x_str = x.ToString();              //obliczanie długości x
                        l = x_str.Length;
                        if (l % 2 == 0)                 //obliczanie m i sprawdzanie parzystości mod2
                        {
                            m = (l - 2) / 2;
                        }
                        else
                            m = (l - 1) / 2;                     
                            y = 2 * Math.Pow(10, m);      //obliczenie y0
                            n = 1;
                            yp = 0.5 * ((x / y) + y);    //obliczenie y1
                            interacje.Text += "iteracja " + n + ":   " + yn + Environment.NewLine;
                        do
                        {
                                n++;
                                yn = 0.5 * ((x / yp) + yp);
                                interacje.Text += "iteracja " + n + ":   " + yn + Environment.NewLine;    
                                K = Math.Abs(yp-yn);    
                                yp = yn;
                               
                            }
                            while (K > eps);
                            W = Math.Sqrt(x);
                            wynik.Text += "" + W;   //zakończenie pętli dla pierwiastka
                        

                    }
                    if (exp.Checked)
                    {
                        W = Math.Exp(x);    //obliczenie porównawczego wyniku
                        yp = 1+x;         // oblicenie 1 iteracji i jej wyświetlenie
                        n = 1;
                        interacje.Text += "iteracja " + n + ":   " + yp + Environment.NewLine;
                        s = 1;
                        i = 1;
                        do                                            //pętla wykonwcza
                        {
                            n++;
                            i++;
                            m = i*s;
                            yn = yp + Math.Pow(x, n)/(m);
                            K = Math.Abs(yn) - Math.Abs(yp);
                            s = m;
                            interacje.Text += "iteracja " + n + ":   " + yn + Environment.NewLine;
                            yp = yn;
                        }
                        while (Math.Abs(K)>eps);
                        wynik.Text += "" + W;   //zakończenie pętli dla pierwiastka
                    }
                    if (sinus.Checked)
                    {
                        rad = (x * Math.PI) / 180;   // zamiana stopni na radiany
                        W = Math.Sin(rad);       
                        yp = rad;
                        n = 1;
                        interacje.Text += "iteracja " + n + ":   " + yp + Environment.NewLine;  //pierwsza iteracja
                        s = 1;  //zmienna potęgi
                        m = 1;  //zmienna silni
                        i = 1; //wynik 1 silni
                        do
                        {
                            n++;
                            s++; s++; 
                            m = i * (s-1) * s;

                            if (n % 2 == 0)
                            {
                                yn = yp - (Math.Pow(rad, s)/m);
                                interacje.Text += "iteracja " + n + ":   " + yn + Environment.NewLine;
                            }
                            else
                            {
                                yn = yp + (Math.Pow(rad, s)/m);
                                interacje.Text += "iteracja " + n + ":   " + yn + Environment.NewLine;
                            }
                            
                            K = Math.Abs(yn) - Math.Abs(yp);
                            yp = yn;
                            i = m;
                        }
                        while (Math.Abs(K) > eps);
                        wynik.Text += " " + W;
                    }
                    if (cosinus.Checked)
                    {
                        rad = (x * Math.PI) / 180;   // zamiana stopni na radiany
                        W = Math.Cos(rad);
                        yp = 1;
                        n = 1;
                        interacje.Text += "iteracja " + n + ":   " + yp + Environment.NewLine;  //pierwsza iteracja
                        s = 0;  //zmienna potęgi
                        m = 1;  //zmienna silni
                        i = 1; //wynik 1 silni
                        do
                        {
                            n++;
                            s++; s++;
                            m = i * (s - 1) * s;

                            if (n % 2 == 0)
                            {
                                yn = yp - (Math.Pow(rad, s) / m);
                                interacje.Text += "iteracja " + n + ":   " + yn + Environment.NewLine;
                            }
                            else
                            {
                                yn = yp + (Math.Pow(rad, s) / m);
                                interacje.Text += "iteracja " + n + ":   " + yn + Environment.NewLine;
                            }

                            K = Math.Abs(yn) - Math.Abs(yp);
                            yp = yn;
                            i = m;
                        }
                        while (Math.Abs(K) > eps);
                        wynik.Text += " " + W;
                    }
                }

            }
        }

        private void sqrt_CheckedChanged(object sender, EventArgs e)
        {

        }

        
    }
 }
