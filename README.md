## Zawartość

- [Ćwiczenie 1](#Ćwiczenie-1)
- [Ćwiczenie 2](#Ćwiczenie-2)
- [Ćwiczenie 3](#Ćwiczenie-3)

Projekty zrealizownano w programie Visual Studio 2022

# Ćwiczenie 1[➥](#-zawartość)
Napisać program, który będzie liczył metodą iteacji pierwiastek kwadratowy, exponentę, sinusa oraz cosinusa  podanej przez użytkownika wartości X.

mój kod:

```cpp
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
```

# Ćwiczenie 2[➥](#-zawartość)
Npisać program liczący funkcję y=ax^3 + bx^2 + cx + d 3 metodami iteracyjnymi Newtona, bisekcji oraz Falsi. Użytkownik podaje wartości a,b,c,d. Wyświetlać kolejne iteracje w polu tekstowym.

```cpp
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

```

# Ćwiczenie 3[➥](#-zawartość)

```cpp
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
```
