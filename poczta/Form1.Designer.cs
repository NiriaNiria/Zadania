namespace WindowsFormsApp4
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
            this.zatwierdz = new System.Windows.Forms.Button();
            this.sprawdzCene = new System.Windows.Forms.Button();
            this.kod = new System.Windows.Forms.Label();
            this.cena = new System.Windows.Forms.Label();
            this.miasto = new System.Windows.Forms.Label();
            this.pocztowka = new System.Windows.Forms.RadioButton();
            this.list = new System.Windows.Forms.RadioButton();
            this.paczka = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.rodzaj = new System.Windows.Forms.GroupBox();
            this.dane = new System.Windows.Forms.GroupBox();
            this.zdjecie = new System.Windows.Forms.PictureBox();
            this.ulica = new System.Windows.Forms.Label();
            this.rodzaj.SuspendLayout();
            this.dane.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zdjecie)).BeginInit();
            this.SuspendLayout();
            // 
            // zatwierdz
            // 
            this.zatwierdz.Location = new System.Drawing.Point(124, 408);
            this.zatwierdz.Name = "zatwierdz";
            this.zatwierdz.Size = new System.Drawing.Size(563, 37);
            this.zatwierdz.TabIndex = 0;
            this.zatwierdz.Text = "zatwierdz";
            this.zatwierdz.UseVisualStyleBackColor = true;
            this.zatwierdz.Click += new System.EventHandler(this.zatwierdz_Click);
            // 
            // sprawdzCene
            // 
            this.sprawdzCene.Location = new System.Drawing.Point(42, 287);
            this.sprawdzCene.Name = "sprawdzCene";
            this.sprawdzCene.Size = new System.Drawing.Size(204, 23);
            this.sprawdzCene.TabIndex = 1;
            this.sprawdzCene.Text = "sprawdz cene";
            this.sprawdzCene.UseVisualStyleBackColor = true;
            this.sprawdzCene.Click += new System.EventHandler(this.sprawdzCene_Click);
            // 
            // kod
            // 
            this.kod.AutoSize = true;
            this.kod.Location = new System.Drawing.Point(49, 90);
            this.kod.Name = "kod";
            this.kod.Size = new System.Drawing.Size(89, 16);
            this.kod.TabIndex = 2;
            this.kod.Text = "kod pocztowy";
            // 
            // cena
            // 
            this.cena.AutoSize = true;
            this.cena.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cena.Location = new System.Drawing.Point(167, 343);
            this.cena.Name = "cena";
            this.cena.Size = new System.Drawing.Size(41, 16);
            this.cena.TabIndex = 3;
            this.cena.Text = "cena";
            this.cena.Click += new System.EventHandler(this.cena_Click);
            // 
            // miasto
            // 
            this.miasto.AutoSize = true;
            this.miasto.Location = new System.Drawing.Point(49, 143);
            this.miasto.Name = "miasto";
            this.miasto.Size = new System.Drawing.Size(47, 16);
            this.miasto.TabIndex = 4;
            this.miasto.Text = "miasto";
            // 
            // pocztowka
            // 
            this.pocztowka.AutoSize = true;
            this.pocztowka.Checked = true;
            this.pocztowka.Location = new System.Drawing.Point(30, 52);
            this.pocztowka.Name = "pocztowka";
            this.pocztowka.Size = new System.Drawing.Size(92, 20);
            this.pocztowka.TabIndex = 5;
            this.pocztowka.TabStop = true;
            this.pocztowka.Text = "pocztowka";
            this.pocztowka.UseVisualStyleBackColor = true;
            this.pocztowka.CheckedChanged += new System.EventHandler(this.pocztowka_CheckedChanged);
            // 
            // list
            // 
            this.list.AutoSize = true;
            this.list.Location = new System.Drawing.Point(30, 78);
            this.list.Name = "list";
            this.list.Size = new System.Drawing.Size(44, 20);
            this.list.TabIndex = 6;
            this.list.Text = "list";
            this.list.UseVisualStyleBackColor = true;
            this.list.CheckedChanged += new System.EventHandler(this.list_CheckedChanged);
            // 
            // paczka
            // 
            this.paczka.AutoSize = true;
            this.paczka.Location = new System.Drawing.Point(30, 116);
            this.paczka.Name = "paczka";
            this.paczka.Size = new System.Drawing.Size(72, 20);
            this.paczka.TabIndex = 7;
            this.paczka.Text = "paczka";
            this.paczka.UseVisualStyleBackColor = true;
            this.paczka.CheckedChanged += new System.EventHandler(this.paczka_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(52, 56);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 8;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(52, 109);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 9;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(52, 162);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 10;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // rodzaj
            // 
            this.rodzaj.Controls.Add(this.pocztowka);
            this.rodzaj.Controls.Add(this.list);
            this.rodzaj.Controls.Add(this.paczka);
            this.rodzaj.Location = new System.Drawing.Point(12, 90);
            this.rodzaj.Name = "rodzaj";
            this.rodzaj.Size = new System.Drawing.Size(294, 191);
            this.rodzaj.TabIndex = 11;
            this.rodzaj.TabStop = false;
            this.rodzaj.Text = "Rodzaj przesylki";
            this.rodzaj.Enter += new System.EventHandler(this.rodzaj_Enter);
            // 
            // dane
            // 
            this.dane.Controls.Add(this.ulica);
            this.dane.Controls.Add(this.textBox1);
            this.dane.Controls.Add(this.textBox2);
            this.dane.Controls.Add(this.miasto);
            this.dane.Controls.Add(this.textBox3);
            this.dane.Controls.Add(this.kod);
            this.dane.Location = new System.Drawing.Point(426, 84);
            this.dane.Name = "dane";
            this.dane.Size = new System.Drawing.Size(337, 243);
            this.dane.TabIndex = 12;
            this.dane.TabStop = false;
            this.dane.Text = "Dane adresowe";
            this.dane.Enter += new System.EventHandler(this.dane_Enter);
            // 
            // zdjecie
            // 
            this.zdjecie.Location = new System.Drawing.Point(42, 326);
            this.zdjecie.Name = "zdjecie";
            this.zdjecie.Size = new System.Drawing.Size(100, 50);
            this.zdjecie.TabIndex = 13;
            this.zdjecie.TabStop = false;
            this.zdjecie.Click += new System.EventHandler(this.zdjecie_Click);
            // 
            // ulica
            // 
            this.ulica.AutoSize = true;
            this.ulica.Location = new System.Drawing.Point(49, 37);
            this.ulica.Name = "ulica";
            this.ulica.Size = new System.Drawing.Size(103, 16);
            this.ulica.TabIndex = 14;
            this.ulica.Text = "ulica z numerem";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.zdjecie);
            this.Controls.Add(this.dane);
            this.Controls.Add(this.rodzaj);
            this.Controls.Add(this.cena);
            this.Controls.Add(this.sprawdzCene);
            this.Controls.Add(this.zatwierdz);
            this.Name = "Form1";
            this.Text = "Form1";
            this.rodzaj.ResumeLayout(false);
            this.rodzaj.PerformLayout();
            this.dane.ResumeLayout(false);
            this.dane.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zdjecie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button zatwierdz;
        private System.Windows.Forms.Button sprawdzCene;
        private System.Windows.Forms.Label kod;
        private System.Windows.Forms.Label cena;
        private System.Windows.Forms.Label miasto;
        private System.Windows.Forms.RadioButton pocztowka;
        private System.Windows.Forms.RadioButton list;
        private System.Windows.Forms.RadioButton paczka;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.GroupBox rodzaj;
        private System.Windows.Forms.GroupBox dane;
        private System.Windows.Forms.Label ulica;
        private System.Windows.Forms.PictureBox zdjecie;
    }
}

