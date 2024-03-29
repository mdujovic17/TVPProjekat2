﻿
namespace TVPProjekat2.Proizvod.Proizvodjac
{
    partial class FormListaProizvodjaca
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnIzmeni = new System.Windows.Forms.Button();
            this.btnZatvori = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.dataProizvodjaci = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPretraga = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataProizvodjaci)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIzmeni
            // 
            this.btnIzmeni.Location = new System.Drawing.Point(467, 54);
            this.btnIzmeni.Name = "btnIzmeni";
            this.btnIzmeni.Size = new System.Drawing.Size(169, 23);
            this.btnIzmeni.TabIndex = 9;
            this.btnIzmeni.Text = "Izmeni";
            this.btnIzmeni.UseVisualStyleBackColor = true;
            this.btnIzmeni.Click += new System.EventHandler(this.izmeniProizvodjaca);
            // 
            // btnZatvori
            // 
            this.btnZatvori.Location = new System.Drawing.Point(467, 406);
            this.btnZatvori.Name = "btnZatvori";
            this.btnZatvori.Size = new System.Drawing.Size(169, 23);
            this.btnZatvori.TabIndex = 8;
            this.btnZatvori.Text = "Zatvori";
            this.btnZatvori.UseVisualStyleBackColor = true;
            this.btnZatvori.Click += new System.EventHandler(this.close);
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(467, 112);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(169, 23);
            this.btnObrisi.TabIndex = 7;
            this.btnObrisi.Text = "Obriši";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.obrisiProizvodjaca);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(467, 25);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(169, 23);
            this.btnDodaj.TabIndex = 6;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.dodajProizvodjaca);
            // 
            // dataProizvodjaci
            // 
            this.dataProizvodjaci.AllowUserToAddRows = false;
            this.dataProizvodjaci.AllowUserToDeleteRows = false;
            this.dataProizvodjaci.AllowUserToResizeRows = false;
            this.dataProizvodjaci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataProizvodjaci.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataProizvodjaci.Location = new System.Drawing.Point(12, 51);
            this.dataProizvodjaci.MultiSelect = false;
            this.dataProizvodjaci.Name = "dataProizvodjaci";
            this.dataProizvodjaci.ReadOnly = true;
            this.dataProizvodjaci.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataProizvodjaci.ShowCellErrors = false;
            this.dataProizvodjaci.ShowCellToolTips = false;
            this.dataProizvodjaci.ShowEditingIcon = false;
            this.dataProizvodjaci.ShowRowErrors = false;
            this.dataProizvodjaci.Size = new System.Drawing.Size(449, 378);
            this.dataProizvodjaci.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(467, 83);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(169, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Aktiviraj / Deaktiviraj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.statusAktivnosti);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Brza pretraga (ID, Naziv, Država)";
            // 
            // txtPretraga
            // 
            this.txtPretraga.Location = new System.Drawing.Point(13, 25);
            this.txtPretraga.Name = "txtPretraga";
            this.txtPretraga.Size = new System.Drawing.Size(448, 20);
            this.txtPretraga.TabIndex = 14;
            this.txtPretraga.TextChanged += new System.EventHandler(this.pretraga);
            // 
            // FormListaProizvodjaca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 441);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPretraga);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnIzmeni);
            this.Controls.Add(this.btnZatvori);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.dataProizvodjaci);
            this.Name = "FormListaProizvodjaca";
            this.Text = "Lista proizvođača";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormListaProizvodjaca_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dataProizvodjaci)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIzmeni;
        private System.Windows.Forms.Button btnZatvori;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.DataGridView dataProizvodjaci;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPretraga;
    }
}