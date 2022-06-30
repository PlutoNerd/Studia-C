namespace Cwieczenie_2_Pluta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.DANE = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.X0 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LiczbaC = new System.Windows.Forms.TextBox();
            this.LiczbaD = new System.Windows.Forms.TextBox();
            this.LiczbaB = new System.Windows.Forms.TextBox();
            this.LiczbaA = new System.Windows.Forms.TextBox();
            this.OPERACJA = new System.Windows.Forms.GroupBox();
            this.Falsi = new System.Windows.Forms.RadioButton();
            this.Bisekcja = new System.Windows.Forms.RadioButton();
            this.Newton = new System.Windows.Forms.RadioButton();
            this.WARUNEK = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.OutB = new System.Windows.Forms.Label();
            this.outA = new System.Windows.Forms.Label();
            this.GrB = new System.Windows.Forms.TrackBar();
            this.GrA = new System.Windows.Forms.TrackBar();
            this.ITERACJE = new System.Windows.Forms.RichTextBox();
            this.OBLICZ = new System.Windows.Forms.Button();
            this.CLEAR = new System.Windows.Forms.Button();
            this.INFO = new System.Windows.Forms.StatusStrip();
            this.Czas = new System.Windows.Forms.ToolStripStatusLabel();
            this.DANE.SuspendLayout();
            this.OPERACJA.SuspendLayout();
            this.WARUNEK.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrA)).BeginInit();
            this.INFO.SuspendLayout();
            this.SuspendLayout();
            // 
            // DANE
            // 
            this.DANE.Controls.Add(this.label5);
            this.DANE.Controls.Add(this.X0);
            this.DANE.Controls.Add(this.label4);
            this.DANE.Controls.Add(this.label3);
            this.DANE.Controls.Add(this.label2);
            this.DANE.Controls.Add(this.label1);
            this.DANE.Controls.Add(this.LiczbaC);
            this.DANE.Controls.Add(this.LiczbaD);
            this.DANE.Controls.Add(this.LiczbaB);
            this.DANE.Controls.Add(this.LiczbaA);
            this.DANE.Location = new System.Drawing.Point(13, 13);
            this.DANE.Name = "DANE";
            this.DANE.Size = new System.Drawing.Size(649, 113);
            this.DANE.TabIndex = 0;
            this.DANE.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(532, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 29);
            this.label5.TabIndex = 9;
            this.label5.Text = "x0 =";
            // 
            // X0
            // 
            this.X0.Location = new System.Drawing.Point(595, 55);
            this.X0.Name = "X0";
            this.X0.Size = new System.Drawing.Size(42, 26);
            this.X0.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(356, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 29);
            this.label4.TabIndex = 7;
            this.label4.Text = "x +";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(244, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "x^2 +";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(135, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "x^3 +";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(43, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "y=";
            // 
            // LiczbaC
            // 
            this.LiczbaC.Location = new System.Drawing.Point(308, 55);
            this.LiczbaC.Name = "LiczbaC";
            this.LiczbaC.Size = new System.Drawing.Size(42, 26);
            this.LiczbaC.TabIndex = 3;
            // 
            // LiczbaD
            // 
            this.LiczbaD.Location = new System.Drawing.Point(397, 55);
            this.LiczbaD.Name = "LiczbaD";
            this.LiczbaD.Size = new System.Drawing.Size(42, 26);
            this.LiczbaD.TabIndex = 2;
            // 
            // LiczbaB
            // 
            this.LiczbaB.Location = new System.Drawing.Point(196, 55);
            this.LiczbaB.Name = "LiczbaB";
            this.LiczbaB.Size = new System.Drawing.Size(42, 26);
            this.LiczbaB.TabIndex = 1;
            // 
            // LiczbaA
            // 
            this.LiczbaA.Location = new System.Drawing.Point(87, 55);
            this.LiczbaA.Name = "LiczbaA";
            this.LiczbaA.Size = new System.Drawing.Size(42, 26);
            this.LiczbaA.TabIndex = 0;
            // 
            // OPERACJA
            // 
            this.OPERACJA.Controls.Add(this.Falsi);
            this.OPERACJA.Controls.Add(this.Bisekcja);
            this.OPERACJA.Controls.Add(this.Newton);
            this.OPERACJA.Location = new System.Drawing.Point(13, 132);
            this.OPERACJA.Name = "OPERACJA";
            this.OPERACJA.Size = new System.Drawing.Size(648, 89);
            this.OPERACJA.TabIndex = 1;
            this.OPERACJA.TabStop = false;
            // 
            // Falsi
            // 
            this.Falsi.AutoSize = true;
            this.Falsi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Falsi.Location = new System.Drawing.Point(459, 32);
            this.Falsi.Name = "Falsi";
            this.Falsi.Size = new System.Drawing.Size(177, 33);
            this.Falsi.TabIndex = 2;
            this.Falsi.Text = "Metoda Falsi";
            this.Falsi.UseVisualStyleBackColor = true;
            this.Falsi.CheckedChanged += new System.EventHandler(this.Falsi_CheckedChanged);
            // 
            // Bisekcja
            // 
            this.Bisekcja.AutoSize = true;
            this.Bisekcja.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Bisekcja.Location = new System.Drawing.Point(244, 32);
            this.Bisekcja.Name = "Bisekcja";
            this.Bisekcja.Size = new System.Drawing.Size(209, 33);
            this.Bisekcja.TabIndex = 1;
            this.Bisekcja.Text = "Metoda Bisekcji";
            this.Bisekcja.UseVisualStyleBackColor = true;
            this.Bisekcja.CheckedChanged += new System.EventHandler(this.Bisekcja_CheckedChanged);
            // 
            // Newton
            // 
            this.Newton.AutoSize = true;
            this.Newton.Checked = true;
            this.Newton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Newton.Location = new System.Drawing.Point(17, 32);
            this.Newton.Name = "Newton";
            this.Newton.Size = new System.Drawing.Size(221, 33);
            this.Newton.TabIndex = 0;
            this.Newton.TabStop = true;
            this.Newton.Text = "Metoda Newtona";
            this.Newton.UseVisualStyleBackColor = true;
            this.Newton.CheckedChanged += new System.EventHandler(this.Newton_CheckedChanged);
            // 
            // WARUNEK
            // 
            this.WARUNEK.Controls.Add(this.label7);
            this.WARUNEK.Controls.Add(this.label6);
            this.WARUNEK.Controls.Add(this.OutB);
            this.WARUNEK.Controls.Add(this.outA);
            this.WARUNEK.Controls.Add(this.GrB);
            this.WARUNEK.Controls.Add(this.GrA);
            this.WARUNEK.Location = new System.Drawing.Point(667, 13);
            this.WARUNEK.Name = "WARUNEK";
            this.WARUNEK.Size = new System.Drawing.Size(311, 209);
            this.WARUNEK.TabIndex = 2;
            this.WARUNEK.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(6, 119);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 29);
            this.label7.TabIndex = 13;
            this.label7.Text = "b = ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(7, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 29);
            this.label6.TabIndex = 12;
            this.label6.Text = "a = ";
            // 
            // OutB
            // 
            this.OutB.AutoSize = true;
            this.OutB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.OutB.Location = new System.Drawing.Point(55, 119);
            this.OutB.Name = "OutB";
            this.OutB.Size = new System.Drawing.Size(26, 29);
            this.OutB.TabIndex = 11;
            this.OutB.Text = "0";
            // 
            // outA
            // 
            this.outA.AutoSize = true;
            this.outA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.outA.Location = new System.Drawing.Point(55, 51);
            this.outA.Name = "outA";
            this.outA.Size = new System.Drawing.Size(26, 29);
            this.outA.TabIndex = 10;
            this.outA.Text = "0";
            // 
            // GrB
            // 
            this.GrB.Location = new System.Drawing.Point(87, 115);
            this.GrB.Maximum = 20;
            this.GrB.Minimum = -20;
            this.GrB.Name = "GrB";
            this.GrB.Size = new System.Drawing.Size(191, 69);
            this.GrB.TabIndex = 1;
            this.GrB.ValueChanged += new System.EventHandler(this.GrB_ValueChanged);
            // 
            // GrA
            // 
            this.GrA.Location = new System.Drawing.Point(87, 44);
            this.GrA.Maximum = 20;
            this.GrA.Minimum = -20;
            this.GrA.Name = "GrA";
            this.GrA.Size = new System.Drawing.Size(191, 69);
            this.GrA.TabIndex = 0;
            this.GrA.ValueChanged += new System.EventHandler(this.GrA_ValueChanged);
            // 
            // ITERACJE
            // 
            this.ITERACJE.Location = new System.Drawing.Point(15, 228);
            this.ITERACJE.Name = "ITERACJE";
            this.ITERACJE.ReadOnly = true;
            this.ITERACJE.Size = new System.Drawing.Size(1110, 374);
            this.ITERACJE.TabIndex = 3;
            this.ITERACJE.Text = "";
            // 
            // OBLICZ
            // 
            this.OBLICZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.OBLICZ.Location = new System.Drawing.Point(984, 28);
            this.OBLICZ.Name = "OBLICZ";
            this.OBLICZ.Size = new System.Drawing.Size(141, 80);
            this.OBLICZ.TabIndex = 4;
            this.OBLICZ.Text = "OBLICZ";
            this.OBLICZ.UseVisualStyleBackColor = true;
            this.OBLICZ.Click += new System.EventHandler(this.OBLICZ_Click);
            // 
            // CLEAR
            // 
            this.CLEAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CLEAR.Location = new System.Drawing.Point(984, 128);
            this.CLEAR.Name = "CLEAR";
            this.CLEAR.Size = new System.Drawing.Size(141, 80);
            this.CLEAR.TabIndex = 5;
            this.CLEAR.Text = "CZYŚĆ";
            this.CLEAR.UseVisualStyleBackColor = true;
            this.CLEAR.Click += new System.EventHandler(this.CLEAR_Click);
            // 
            // INFO
            // 
            this.INFO.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.INFO.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Czas});
            this.INFO.Location = new System.Drawing.Point(0, 621);
            this.INFO.Name = "INFO";
            this.INFO.Size = new System.Drawing.Size(1138, 22);
            this.INFO.TabIndex = 6;
            this.INFO.Text = "statusStrip1";
            // 
            // Czas
            // 
            this.Czas.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Czas.Name = "Czas";
            this.Czas.Size = new System.Drawing.Size(0, 15);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1138, 643);
            this.Controls.Add(this.INFO);
            this.Controls.Add(this.CLEAR);
            this.Controls.Add(this.OBLICZ);
            this.Controls.Add(this.ITERACJE);
            this.Controls.Add(this.WARUNEK);
            this.Controls.Add(this.OPERACJA);
            this.Controls.Add(this.DANE);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Ćwiczenie 2 - Krzysztof Pluta";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.DANE.ResumeLayout(false);
            this.DANE.PerformLayout();
            this.OPERACJA.ResumeLayout(false);
            this.OPERACJA.PerformLayout();
            this.WARUNEK.ResumeLayout(false);
            this.WARUNEK.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrA)).EndInit();
            this.INFO.ResumeLayout(false);
            this.INFO.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox DANE;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox X0;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox LiczbaC;
        private System.Windows.Forms.TextBox LiczbaD;
        private System.Windows.Forms.TextBox LiczbaB;
        private System.Windows.Forms.TextBox LiczbaA;
        private System.Windows.Forms.GroupBox OPERACJA;
        private System.Windows.Forms.RadioButton Falsi;
        private System.Windows.Forms.RadioButton Bisekcja;
        private System.Windows.Forms.RadioButton Newton;
        private System.Windows.Forms.GroupBox WARUNEK;
        private System.Windows.Forms.RichTextBox ITERACJE;
        private System.Windows.Forms.Button OBLICZ;
        private System.Windows.Forms.Button CLEAR;
        private System.Windows.Forms.TrackBar GrB;
        private System.Windows.Forms.TrackBar GrA;
        private System.Windows.Forms.StatusStrip INFO;
        private System.Windows.Forms.ToolStripStatusLabel Czas;
        private System.Windows.Forms.Label OutB;
        private System.Windows.Forms.Label outA;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}

