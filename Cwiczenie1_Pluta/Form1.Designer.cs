
namespace Cwiczenie1_Pluta
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
            this.sqrt = new System.Windows.Forms.RadioButton();
            this.sinus = new System.Windows.Forms.RadioButton();
            this.exp = new System.Windows.Forms.RadioButton();
            this.cosinus = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.interacje = new System.Windows.Forms.RichTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.wynik = new System.Windows.Forms.Label();
            this.oblicz = new System.Windows.Forms.Button();
            this.wartosc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // sqrt
            // 
            this.sqrt.AutoSize = true;
            this.sqrt.Location = new System.Drawing.Point(9, 29);
            this.sqrt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.sqrt.Name = "sqrt";
            this.sqrt.Size = new System.Drawing.Size(98, 24);
            this.sqrt.TabIndex = 0;
            this.sqrt.TabStop = true;
            this.sqrt.Text = "y =sqrt(x)";
            this.sqrt.UseVisualStyleBackColor = true;
            this.sqrt.CheckedChanged += new System.EventHandler(this.sqrt_CheckedChanged);
            // 
            // sinus
            // 
            this.sinus.AutoSize = true;
            this.sinus.Location = new System.Drawing.Point(9, 103);
            this.sinus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.sinus.Name = "sinus";
            this.sinus.Size = new System.Drawing.Size(95, 24);
            this.sinus.TabIndex = 1;
            this.sinus.TabStop = true;
            this.sinus.Text = "y = sin(x)";
            this.sinus.UseVisualStyleBackColor = true;
            // 
            // exp
            // 
            this.exp.AutoSize = true;
            this.exp.Location = new System.Drawing.Point(9, 65);
            this.exp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.exp.Name = "exp";
            this.exp.Size = new System.Drawing.Size(100, 24);
            this.exp.TabIndex = 2;
            this.exp.TabStop = true;
            this.exp.Text = "y = exp(x)";
            this.exp.UseVisualStyleBackColor = true;
            // 
            // cosinus
            // 
            this.cosinus.AutoSize = true;
            this.cosinus.Location = new System.Drawing.Point(9, 138);
            this.cosinus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cosinus.Name = "cosinus";
            this.cosinus.Size = new System.Drawing.Size(100, 24);
            this.cosinus.TabIndex = 3;
            this.cosinus.TabStop = true;
            this.cosinus.Text = "y = cos(x)";
            this.cosinus.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.sqrt);
            this.groupBox1.Controls.Add(this.cosinus);
            this.groupBox1.Controls.Add(this.sinus);
            this.groupBox1.Controls.Add(this.exp);
            this.groupBox1.Location = new System.Drawing.Point(13, 101);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(165, 185);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Funkcje";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // interacje
            // 
            this.interacje.Location = new System.Drawing.Point(9, 29);
            this.interacje.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.interacje.Name = "interacje";
            this.interacje.Size = new System.Drawing.Size(497, 280);
            this.interacje.TabIndex = 5;
            this.interacje.Text = "";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.wynik);
            this.groupBox2.Controls.Add(this.interacje);
            this.groupBox2.Location = new System.Drawing.Point(185, 33);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(514, 360);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Interacje";
            // 
            // wynik
            // 
            this.wynik.AutoSize = true;
            this.wynik.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.wynik.Location = new System.Drawing.Point(7, 314);
            this.wynik.Name = "wynik";
            this.wynik.Size = new System.Drawing.Size(121, 29);
            this.wynik.TabIndex = 11;
            this.wynik.Text = " Wynik to: ";
            // 
            // oblicz
            // 
            this.oblicz.Cursor = System.Windows.Forms.Cursors.Hand;
            this.oblicz.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.oblicz.Location = new System.Drawing.Point(22, 313);
            this.oblicz.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.oblicz.Name = "oblicz";
            this.oblicz.Size = new System.Drawing.Size(85, 42);
            this.oblicz.TabIndex = 7;
            this.oblicz.Text = "OBLICZ";
            this.oblicz.UseVisualStyleBackColor = true;
            this.oblicz.Click += new System.EventHandler(this.button1_Click);
            // 
            // wartosc
            // 
            this.wartosc.Location = new System.Drawing.Point(57, 21);
            this.wartosc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.wartosc.Name = "wartosc";
            this.wartosc.Size = new System.Drawing.Size(68, 26);
            this.wartosc.TabIndex = 8;
            this.wartosc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.wartosc_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "X =";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.wartosc);
            this.groupBox3.Location = new System.Drawing.Point(16, 33);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(162, 60);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Dane";
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(115, 313);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 42);
            this.button1.TabIndex = 11;
            this.button1.Tag = "";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 398);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.oblicz);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ćwiczenie 1 - Pluta";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton sqrt;
        private System.Windows.Forms.RadioButton sinus;
        private System.Windows.Forms.RadioButton exp;
        private System.Windows.Forms.RadioButton cosinus;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox interacje;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button oblicz;
        private System.Windows.Forms.TextBox wartosc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label wynik;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button1;
    }
}

