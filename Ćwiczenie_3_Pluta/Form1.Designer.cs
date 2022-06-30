namespace Ćwiczenie_3_Pluta
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.wykres = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.OBLICZ = new System.Windows.Forms.Button();
            this.liczbax0 = new System.Windows.Forms.TextBox();
            this.liczbah = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.liczbatend = new System.Windows.Forms.TextBox();
            this.czysc = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.wykres)).BeginInit();
            this.SuspendLayout();
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(384, 853);
            this.splitter1.TabIndex = 0;
            this.splitter1.TabStop = false;
            // 
            // wykres
            // 
            chartArea1.Name = "obszar";
            this.wykres.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.wykres.Legends.Add(legend1);
            this.wykres.Location = new System.Drawing.Point(390, 0);
            this.wykres.Name = "wykres";
            series1.ChartArea = "obszar";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.MarkerBorderColor = System.Drawing.Color.Blue;
            series1.Name = "Euler Cauch’yego";
            series2.ChartArea = "obszar";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "Dokładna funkcja";
            series3.ChartArea = "obszar";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Legend = "Legend1";
            series3.Name = "Euler";
            this.wykres.Series.Add(series1);
            this.wykres.Series.Add(series2);
            this.wykres.Series.Add(series3);
            this.wykres.Size = new System.Drawing.Size(906, 634);
            this.wykres.TabIndex = 0;
            this.wykres.Text = "wykres";
            // 
            // OBLICZ
            // 
            this.OBLICZ.Location = new System.Drawing.Point(12, 327);
            this.OBLICZ.Name = "OBLICZ";
            this.OBLICZ.Size = new System.Drawing.Size(154, 46);
            this.OBLICZ.TabIndex = 4;
            this.OBLICZ.Text = "OBLICZ";
            this.OBLICZ.UseVisualStyleBackColor = true;
            this.OBLICZ.Click += new System.EventHandler(this.OBLICZ_Click);
            // 
            // liczbax0
            // 
            this.liczbax0.Location = new System.Drawing.Point(117, 166);
            this.liczbax0.Name = "liczbax0";
            this.liczbax0.Size = new System.Drawing.Size(224, 26);
            this.liczbax0.TabIndex = 1;
            // 
            // liczbah
            // 
            this.liczbah.Location = new System.Drawing.Point(117, 217);
            this.liczbah.Name = "liczbah";
            this.liczbah.Size = new System.Drawing.Size(224, 26);
            this.liczbah.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(40, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "dt";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(70, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(258, 29);
            this.label3.TabIndex = 0;
            this.label3.Text = "= t * exp(-t * t) - 2 * t  * x";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(35, 22);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(38, 29);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.Text = "dx";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(35, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(322, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "x =  exp(-t ^2) - (0,5 * t * t + C)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(25, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 29);
            this.label4.TabIndex = 11;
            this.label4.Text = "x";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(41, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(55, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 29);
            this.label6.TabIndex = 13;
            this.label6.Text = "=";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(25, 216);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 25);
            this.label7.TabIndex = 14;
            this.label7.Text = "Krok h =";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(25, 270);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(246, 25);
            this.label8.TabIndex = 15;
            this.label8.Text = "Przedział całkowity od 0 do";
            // 
            // liczbatend
            // 
            this.liczbatend.Location = new System.Drawing.Point(298, 269);
            this.liczbatend.Name = "liczbatend";
            this.liczbatend.Size = new System.Drawing.Size(43, 26);
            this.liczbatend.TabIndex = 3;
            // 
            // czysc
            // 
            this.czysc.Location = new System.Drawing.Point(172, 327);
            this.czysc.Name = "czysc";
            this.czysc.Size = new System.Drawing.Size(169, 46);
            this.czysc.TabIndex = 5;
            this.czysc.Text = "WYCZYŚĆ";
            this.czysc.UseVisualStyleBackColor = true;
            this.czysc.Click += new System.EventHandler(this.czysc_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1297, 853);
            this.Controls.Add(this.czysc);
            this.Controls.Add(this.liczbatend);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.liczbah);
            this.Controls.Add(this.liczbax0);
            this.Controls.Add(this.OBLICZ);
            this.Controls.Add(this.wykres);
            this.Controls.Add(this.splitter1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Ćwiczenie 3 Pluta";
            ((System.ComponentModel.ISupportInitialize)(this.wykres)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.DataVisualization.Charting.Chart wykres;
        private System.Windows.Forms.Button OBLICZ;
        private System.Windows.Forms.TextBox liczbax0;
        private System.Windows.Forms.TextBox liczbah;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox liczbatend;
        private System.Windows.Forms.Button czysc;
    }
}

