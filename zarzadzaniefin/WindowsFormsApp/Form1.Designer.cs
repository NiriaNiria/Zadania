namespace WindowsFormsApp5
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
            this.txtNazwa = new System.Windows.Forms.TextBox();
            this.txtKwota = new System.Windows.Forms.TextBox();
            this.cmbKategoria = new System.Windows.Forms.ComboBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnUsun = new System.Windows.Forms.Button();
            this.btnZapisz = new System.Windows.Forms.Button();
            this.dgvWydatki = new System.Windows.Forms.DataGridView();
            this.lblSuma = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbFiltr = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnFiltruj = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWydatki)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNazwa
            // 
            this.txtNazwa.Location = new System.Drawing.Point(266, 354);
            this.txtNazwa.Name = "txtNazwa";
            this.txtNazwa.Size = new System.Drawing.Size(100, 22);
            this.txtNazwa.TabIndex = 0;
            this.txtNazwa.TextChanged += new System.EventHandler(this.txtNazwa_TextChanged);
            // 
            // txtKwota
            // 
            this.txtKwota.Location = new System.Drawing.Point(62, 354);
            this.txtKwota.Name = "txtKwota";
            this.txtKwota.Size = new System.Drawing.Size(100, 22);
            this.txtKwota.TabIndex = 1;
            this.txtKwota.TextChanged += new System.EventHandler(this.txtKwota_TextChanged);
            // 
            // cmbKategoria
            // 
            this.cmbKategoria.FormattingEnabled = true;
            this.cmbKategoria.Location = new System.Drawing.Point(479, 354);
            this.cmbKategoria.Name = "cmbKategoria";
            this.cmbKategoria.Size = new System.Drawing.Size(121, 24);
            this.cmbKategoria.TabIndex = 2;
            this.cmbKategoria.SelectedIndexChanged += new System.EventHandler(this.cmbKategoria_SelectedIndexChanged);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(171, 399);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(75, 23);
            this.btnDodaj.TabIndex = 3;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnUsun
            // 
            this.btnUsun.Location = new System.Drawing.Point(487, 399);
            this.btnUsun.Name = "btnUsun";
            this.btnUsun.Size = new System.Drawing.Size(75, 23);
            this.btnUsun.TabIndex = 4;
            this.btnUsun.Text = "Usun";
            this.btnUsun.UseVisualStyleBackColor = true;
            this.btnUsun.Click += new System.EventHandler(this.btnUsun_Click);
            // 
            // btnZapisz
            // 
            this.btnZapisz.Location = new System.Drawing.Point(326, 399);
            this.btnZapisz.Name = "btnZapisz";
            this.btnZapisz.Size = new System.Drawing.Size(75, 23);
            this.btnZapisz.TabIndex = 5;
            this.btnZapisz.Text = "Zapisz";
            this.btnZapisz.UseVisualStyleBackColor = true;
            this.btnZapisz.Click += new System.EventHandler(this.btnZapisz_Click);
            // 
            // dgvWydatki
            // 
            this.dgvWydatki.AllowUserToAddRows = false;
            this.dgvWydatki.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWydatki.Location = new System.Drawing.Point(40, 62);
            this.dgvWydatki.Name = "dgvWydatki";
            this.dgvWydatki.RowHeadersWidth = 51;
            this.dgvWydatki.RowTemplate.Height = 24;
            this.dgvWydatki.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvWydatki.Size = new System.Drawing.Size(676, 286);
            this.dgvWydatki.TabIndex = 6;
            // 
            // lblSuma
            // 
            this.lblSuma.AutoSize = true;
            this.lblSuma.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSuma.Location = new System.Drawing.Point(242, 30);
            this.lblSuma.Name = "lblSuma";
            this.lblSuma.Size = new System.Drawing.Size(301, 29);
            this.lblSuma.TabIndex = 7;
            this.lblSuma.Text = "Zarzadzanie wydatkami";
            this.lblSuma.Click += new System.EventHandler(this.lblSuma_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 357);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "liczba";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(216, 357);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "nazwa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(409, 357);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "kategoria";
            // 
            // cmbFiltr
            // 
            this.cmbFiltr.FormattingEnabled = true;
            this.cmbFiltr.Location = new System.Drawing.Point(632, 385);
            this.cmbFiltr.Name = "cmbFiltr";
            this.cmbFiltr.Size = new System.Drawing.Size(121, 24);
            this.cmbFiltr.TabIndex = 11;
            this.cmbFiltr.SelectedIndexChanged += new System.EventHandler(this.cmbFiltr_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(646, 363);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "filtr";
            // 
            // btnFiltruj
            // 
            this.btnFiltruj.Location = new System.Drawing.Point(649, 416);
            this.btnFiltruj.Name = "btnFiltruj";
            this.btnFiltruj.Size = new System.Drawing.Size(75, 23);
            this.btnFiltruj.TabIndex = 13;
            this.btnFiltruj.Text = "filtruj";
            this.btnFiltruj.UseVisualStyleBackColor = true;
            this.btnFiltruj.Click += new System.EventHandler(this.btnFiltruj_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnFiltruj);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbFiltr);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSuma);
            this.Controls.Add(this.dgvWydatki);
            this.Controls.Add(this.btnZapisz);
            this.Controls.Add(this.btnUsun);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.cmbKategoria);
            this.Controls.Add(this.txtKwota);
            this.Controls.Add(this.txtNazwa);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvWydatki)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNazwa;
        private System.Windows.Forms.TextBox txtKwota;
        private System.Windows.Forms.ComboBox cmbKategoria;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnUsun;
        private System.Windows.Forms.Button btnZapisz;
        private System.Windows.Forms.DataGridView dgvWydatki;
        private System.Windows.Forms.Label lblSuma;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbFiltr;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnFiltruj;
    }
}

