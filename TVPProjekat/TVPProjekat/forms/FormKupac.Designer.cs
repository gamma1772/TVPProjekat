﻿
namespace TVPProjekat
{
    partial class FormKupac
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnDetalji = new System.Windows.Forms.Button();
            this.btnOtkazi = new System.Windows.Forms.Button();
            this.btnRezervacija = new System.Windows.Forms.Button();
            this.lvRezervacije = new System.Windows.Forms.ListView();
            this.idRezervacije = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.film = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bioskop = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.datumVreme = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.brojSedista = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.stripUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.stripStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnOdjava = new System.Windows.Forms.Button();
            this.btnNalog = new System.Windows.Forms.Button();
            this.btnPrikazi = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Vaše rezervacije";
            // 
            // btnDetalji
            // 
            this.btnDetalji.Location = new System.Drawing.Point(661, 81);
            this.btnDetalji.Name = "btnDetalji";
            this.btnDetalji.Size = new System.Drawing.Size(126, 23);
            this.btnDetalji.TabIndex = 2;
            this.btnDetalji.Text = "Detalji rezervacije";
            this.btnDetalji.UseVisualStyleBackColor = true;
            // 
            // btnOtkazi
            // 
            this.btnOtkazi.Location = new System.Drawing.Point(661, 110);
            this.btnOtkazi.Name = "btnOtkazi";
            this.btnOtkazi.Size = new System.Drawing.Size(126, 23);
            this.btnOtkazi.TabIndex = 3;
            this.btnOtkazi.Text = "Otkaži rezervaciju";
            this.btnOtkazi.UseVisualStyleBackColor = true;
            // 
            // btnRezervacija
            // 
            this.btnRezervacija.Location = new System.Drawing.Point(661, 53);
            this.btnRezervacija.Name = "btnRezervacija";
            this.btnRezervacija.Size = new System.Drawing.Size(126, 23);
            this.btnRezervacija.TabIndex = 4;
            this.btnRezervacija.Text = "Nova rezervacija";
            this.btnRezervacija.UseVisualStyleBackColor = true;
            this.btnRezervacija.Click += new System.EventHandler(this.btnRezervacija_Click);
            // 
            // lvRezervacije
            // 
            this.lvRezervacije.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idRezervacije,
            this.film,
            this.bioskop,
            this.datumVreme,
            this.brojSedista});
            this.lvRezervacije.HideSelection = false;
            this.lvRezervacije.Location = new System.Drawing.Point(12, 24);
            this.lvRezervacije.Name = "lvRezervacije";
            this.lvRezervacije.Size = new System.Drawing.Size(644, 218);
            this.lvRezervacije.TabIndex = 5;
            this.lvRezervacije.UseCompatibleStateImageBehavior = false;
            this.lvRezervacije.View = System.Windows.Forms.View.Details;
            // 
            // idRezervacije
            // 
            this.idRezervacije.Text = "ID Rezervacije";
            this.idRezervacije.Width = 85;
            // 
            // film
            // 
            this.film.Text = "Naziv filma";
            this.film.Width = 190;
            // 
            // bioskop
            // 
            this.bioskop.Text = "Bioskopska sala";
            this.bioskop.Width = 133;
            // 
            // datumVreme
            // 
            this.datumVreme.Text = "Datum i vreme";
            this.datumVreme.Width = 164;
            // 
            // brojSedista
            // 
            this.brojSedista.Text = "Broj sedista";
            this.brojSedista.Width = 68;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stripUser,
            this.stripStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 251);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // stripUser
            // 
            this.stripUser.Name = "stripUser";
            this.stripUser.Size = new System.Drawing.Size(71, 17);
            this.stripUser.Text = "Dobrodosli, ";
            // 
            // stripStatus
            // 
            this.stripStatus.Name = "stripStatus";
            this.stripStatus.Size = new System.Drawing.Size(84, 17);
            this.stripStatus.Text = "Status naloga: ";
            this.stripStatus.Click += new System.EventHandler(this.nalogInfo);
            // 
            // btnOdjava
            // 
            this.btnOdjava.Location = new System.Drawing.Point(662, 219);
            this.btnOdjava.Name = "btnOdjava";
            this.btnOdjava.Size = new System.Drawing.Size(126, 23);
            this.btnOdjava.TabIndex = 7;
            this.btnOdjava.Text = "Odjavite se";
            this.btnOdjava.UseVisualStyleBackColor = true;
            this.btnOdjava.Click += new System.EventHandler(this.btnOdjava_Click);
            // 
            // btnNalog
            // 
            this.btnNalog.Location = new System.Drawing.Point(662, 190);
            this.btnNalog.Name = "btnNalog";
            this.btnNalog.Size = new System.Drawing.Size(126, 23);
            this.btnNalog.TabIndex = 8;
            this.btnNalog.Text = "Detalji naloga";
            this.btnNalog.UseVisualStyleBackColor = true;
            // 
            // btnPrikazi
            // 
            this.btnPrikazi.Location = new System.Drawing.Point(662, 24);
            this.btnPrikazi.Name = "btnPrikazi";
            this.btnPrikazi.Size = new System.Drawing.Size(125, 23);
            this.btnPrikazi.TabIndex = 9;
            this.btnPrikazi.Text = "Prikazi rezervacije";
            this.btnPrikazi.UseVisualStyleBackColor = true;
            // 
            // FormKupac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 273);
            this.Controls.Add(this.btnPrikazi);
            this.Controls.Add(this.btnNalog);
            this.Controls.Add(this.btnOdjava);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.lvRezervacije);
            this.Controls.Add(this.btnRezervacija);
            this.Controls.Add(this.btnOtkazi);
            this.Controls.Add(this.btnDetalji);
            this.Controls.Add(this.label1);
            this.Name = "FormKupac";
            this.Text = "FormKupac";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.izlaz);
            this.Load += new System.EventHandler(this.loadKupacPanel);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDetalji;
        private System.Windows.Forms.Button btnOtkazi;
        private System.Windows.Forms.Button btnRezervacija;
        private System.Windows.Forms.ListView lvRezervacije;
        private System.Windows.Forms.ColumnHeader idRezervacije;
        private System.Windows.Forms.ColumnHeader film;
        private System.Windows.Forms.ColumnHeader bioskop;
        private System.Windows.Forms.ColumnHeader datumVreme;
        private System.Windows.Forms.ColumnHeader brojSedista;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel stripStatus;
        private System.Windows.Forms.Button btnOdjava;
        private System.Windows.Forms.ToolStripStatusLabel stripUser;
        private System.Windows.Forms.Button btnNalog;
        private System.Windows.Forms.Button btnPrikazi;
    }
}