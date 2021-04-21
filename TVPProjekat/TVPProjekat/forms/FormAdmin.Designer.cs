﻿
namespace TVPProjekat
{
    partial class FormAdmin
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
            this.btnShowUsers = new System.Windows.Forms.Button();
            this.btnShowAdmins = new System.Windows.Forms.Button();
            this.btnShowTheaters = new System.Windows.Forms.Button();
            this.btnShowMovies = new System.Windows.Forms.Button();
            this.statusnaLinija = new System.Windows.Forms.StatusStrip();
            this.stripUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.stripStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusUUID = new System.Windows.Forms.ToolStripStatusLabel();
            this.lvAdminPrikaz = new System.Windows.Forms.ListView();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.btnIzmeni = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnExportCSV = new System.Windows.Forms.Button();
            this.btnUcitajCSV = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnDodajAdmina = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.statusnaLinija.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnShowUsers
            // 
            this.btnShowUsers.Location = new System.Drawing.Point(183, 12);
            this.btnShowUsers.Name = "btnShowUsers";
            this.btnShowUsers.Size = new System.Drawing.Size(165, 25);
            this.btnShowUsers.TabIndex = 0;
            this.btnShowUsers.Text = "Prikaži listu korisnika";
            this.btnShowUsers.UseVisualStyleBackColor = true;
            this.btnShowUsers.Click += new System.EventHandler(this.prikaziKorisnike);
            // 
            // btnShowAdmins
            // 
            this.btnShowAdmins.Location = new System.Drawing.Point(12, 12);
            this.btnShowAdmins.Name = "btnShowAdmins";
            this.btnShowAdmins.Size = new System.Drawing.Size(165, 25);
            this.btnShowAdmins.TabIndex = 1;
            this.btnShowAdmins.Text = "Prikaži listu administratora";
            this.btnShowAdmins.UseVisualStyleBackColor = true;
            this.btnShowAdmins.Click += new System.EventHandler(this.btnShowAdmins_Click);
            // 
            // btnShowTheaters
            // 
            this.btnShowTheaters.Location = new System.Drawing.Point(354, 12);
            this.btnShowTheaters.Name = "btnShowTheaters";
            this.btnShowTheaters.Size = new System.Drawing.Size(165, 25);
            this.btnShowTheaters.TabIndex = 2;
            this.btnShowTheaters.Text = "Prikaži listu bioskopa";
            this.btnShowTheaters.UseVisualStyleBackColor = true;
            // 
            // btnShowMovies
            // 
            this.btnShowMovies.Location = new System.Drawing.Point(525, 12);
            this.btnShowMovies.Name = "btnShowMovies";
            this.btnShowMovies.Size = new System.Drawing.Size(165, 25);
            this.btnShowMovies.TabIndex = 3;
            this.btnShowMovies.Text = "Prikaži repertoar filmova";
            this.btnShowMovies.UseVisualStyleBackColor = true;
            // 
            // statusnaLinija
            // 
            this.statusnaLinija.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stripUser,
            this.stripStatus,
            this.statusUUID});
            this.statusnaLinija.Location = new System.Drawing.Point(0, 408);
            this.statusnaLinija.Name = "statusnaLinija";
            this.statusnaLinija.Size = new System.Drawing.Size(895, 22);
            this.statusnaLinija.TabIndex = 7;
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
            // 
            // statusUUID
            // 
            this.statusUUID.Margin = new System.Windows.Forms.Padding(350, 3, 0, 2);
            this.statusUUID.Name = "statusUUID";
            this.statusUUID.Size = new System.Drawing.Size(84, 17);
            this.statusUUID.Text = "Selektovan ID: ";
            // 
            // lvAdminPrikaz
            // 
            this.lvAdminPrikaz.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lvAdminPrikaz.AllowColumnReorder = true;
            this.lvAdminPrikaz.FullRowSelect = true;
            this.lvAdminPrikaz.GridLines = true;
            this.lvAdminPrikaz.HideSelection = false;
            this.lvAdminPrikaz.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lvAdminPrikaz.Location = new System.Drawing.Point(12, 43);
            this.lvAdminPrikaz.MultiSelect = false;
            this.lvAdminPrikaz.Name = "lvAdminPrikaz";
            this.lvAdminPrikaz.Size = new System.Drawing.Size(729, 355);
            this.lvAdminPrikaz.TabIndex = 8;
            this.lvAdminPrikaz.UseCompatibleStateImageBehavior = false;
            this.lvAdminPrikaz.SelectedIndexChanged += new System.EventHandler(this.selektujObjekat);
            // 
            // btnObrisi
            // 
            this.btnObrisi.Enabled = false;
            this.btnObrisi.Location = new System.Drawing.Point(747, 105);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(141, 25);
            this.btnObrisi.TabIndex = 9;
            this.btnObrisi.Text = "Obrisi stavku";
            this.btnObrisi.UseVisualStyleBackColor = true;
            // 
            // btnIzmeni
            // 
            this.btnIzmeni.Enabled = false;
            this.btnIzmeni.Location = new System.Drawing.Point(747, 74);
            this.btnIzmeni.Name = "btnIzmeni";
            this.btnIzmeni.Size = new System.Drawing.Size(141, 25);
            this.btnIzmeni.TabIndex = 10;
            this.btnIzmeni.Text = "Izmeni selektovano";
            this.btnIzmeni.UseVisualStyleBackColor = true;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Enabled = false;
            this.btnDodaj.Location = new System.Drawing.Point(747, 43);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(141, 25);
            this.btnDodaj.TabIndex = 11;
            this.btnDodaj.Text = "Dodaj novu stavku";
            this.btnDodaj.UseVisualStyleBackColor = true;
            // 
            // btnExportCSV
            // 
            this.btnExportCSV.Location = new System.Drawing.Point(747, 313);
            this.btnExportCSV.Name = "btnExportCSV";
            this.btnExportCSV.Size = new System.Drawing.Size(141, 25);
            this.btnExportCSV.TabIndex = 12;
            this.btnExportCSV.Text = "Eksportuj u CSV";
            this.btnExportCSV.UseVisualStyleBackColor = true;
            // 
            // btnUcitajCSV
            // 
            this.btnUcitajCSV.Location = new System.Drawing.Point(747, 282);
            this.btnUcitajCSV.Name = "btnUcitajCSV";
            this.btnUcitajCSV.Size = new System.Drawing.Size(141, 25);
            this.btnUcitajCSV.TabIndex = 13;
            this.btnUcitajCSV.Text = "Ucitaj CSV";
            this.btnUcitajCSV.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(747, 373);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(141, 25);
            this.btnLogout.TabIndex = 14;
            this.btnLogout.Text = "Odjavi se";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.odjaviSe);
            // 
            // btnDodajAdmina
            // 
            this.btnDodajAdmina.Location = new System.Drawing.Point(747, 181);
            this.btnDodajAdmina.Name = "btnDodajAdmina";
            this.btnDodajAdmina.Size = new System.Drawing.Size(141, 44);
            this.btnDodajAdmina.TabIndex = 15;
            this.btnDodajAdmina.Text = "Dodaj novog administratora";
            this.btnDodajAdmina.UseVisualStyleBackColor = true;
            this.btnDodajAdmina.Click += new System.EventHandler(this.dodajAdmina);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(696, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(192, 25);
            this.button1.TabIndex = 16;
            this.button1.Text = "Prikazi projekcije";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 430);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnDodajAdmina);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnUcitajCSV);
            this.Controls.Add(this.btnExportCSV);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.btnIzmeni);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.lvAdminPrikaz);
            this.Controls.Add(this.statusnaLinija);
            this.Controls.Add(this.btnShowMovies);
            this.Controls.Add(this.btnShowTheaters);
            this.Controls.Add(this.btnShowAdmins);
            this.Controls.Add(this.btnShowUsers);
            this.Name = "FormAdmin";
            this.Text = "Administratorski panel";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.zatvoriProgram);
            this.Load += new System.EventHandler(this.loadAdminPanel);
            this.statusnaLinija.ResumeLayout(false);
            this.statusnaLinija.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnShowUsers;
        private System.Windows.Forms.Button btnShowAdmins;
        private System.Windows.Forms.Button btnShowTheaters;
        private System.Windows.Forms.Button btnShowMovies;
        private System.Windows.Forms.StatusStrip statusnaLinija;
        private System.Windows.Forms.ToolStripStatusLabel stripStatus;
        private System.Windows.Forms.ToolStripStatusLabel stripUser;
        private System.Windows.Forms.ListView lvAdminPrikaz;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Button btnIzmeni;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnExportCSV;
        private System.Windows.Forms.Button btnUcitajCSV;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.ToolStripStatusLabel statusUUID;
        private System.Windows.Forms.Button btnDodajAdmina;
        private System.Windows.Forms.Button button1;
    }
}