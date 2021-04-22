﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TVPProjekat.bioskop;
using TVPProjekat.forms.pomocne;
using TVPProjekat.korisnik;

namespace TVPProjekat
{
    public partial class FormAdmin : Form
    {
        private delegate Korisnik posaljiKorisnika(Korisnik korisnik, string lozinka);
        public delegate void Osvezi(bool osvezi);
        Osvezi osvezavanje = FormLogin.osvezi;
        
        public Form frmLogin;

        private Form frmDodajAdmina;
        private Form frmDodajKupca;
        private Form frmDodajFilm;
        private Form frmDodajSalu;
        private Form frmDodajProjekciju;
        private Form frmIzmena;

        private List<Korisnik> administratori;
        private List<Korisnik> kupci;

        private List<Film> filmovi;
        private List<Projekcija> projekcije;
        private List<Sala> sale;

        private List<Rezervacija> rezervacije;

        private static Administrator admin;
        private object selectedItem;

        private bool activeAdminList = false, activeUserList = false, activeSalaList = false, activeRepertoarList = false, activeProjekcijeList = false;

        private string sifra;
        public FormAdmin()
        {
            InitializeComponent();
            osvezavanje(true);
            lvAdminPrikaz.View = View.Details;
        }

        public static Korisnik PrihvatiKorisnika(Korisnik administrator)
        {
            admin = administrator as Administrator;
            Debug.WriteLine(DateTime.Now.ToString("(HH:mm:ss)") + " " + "[INFO]: Prijavljivanje administratora sa UUID: " + admin.AdminUUID);
            return administrator;
        }

        private void loadAdminPanel(object sender, EventArgs e)
        {
            stripUser.Text += admin.Ime;
            stripStatus.Text += "Administrator";
        }


        private void odjaviSe(object sender, EventArgs e)
        {
            admin = null;
            if (administratori != null)
            {
                administratori.Clear();
            }

            

            osvezavanje(false);

            frmLogin.Show();
            this.Dispose(); //Potrebno da bi se svi resursi ove forme oslobodili, u suprotnom izaziva StackOverflowExepction
            this.Close();
        }

        private void zatvoriProgram(object sender, FormClosedEventArgs e)
        {
            frmLogin.Close();
        }

        private void prikaziKorisnike(object sender, EventArgs e)
        {
            activeUserList = true; activeAdminList = false; activeSalaList = false; activeProjekcijeList = false; activeRepertoarList = false;
            changeUpdate(sender, e);
            kupci = new List<Korisnik>();

            ocistiLV();

            lvAdminPrikaz.Columns.Add("UUID", 40);
            lvAdminPrikaz.Columns.Add("Ime", 80);
            lvAdminPrikaz.Columns.Add("Prezime", 80);
            lvAdminPrikaz.Columns.Add("Pol", 30);
            lvAdminPrikaz.Columns.Add("Telefon", 80);
            lvAdminPrikaz.Columns.Add("E-mail", 90);
            lvAdminPrikaz.Columns.Add("Korisnicko ime", 100);
            lvAdminPrikaz.Columns.Add("Sifra", 60);
            lvAdminPrikaz.Columns.Add("Datum rodjenja", 90);
            lvAdminPrikaz.Columns.Add("Rezervacije", 70);

            LocalFileManager.JSONDeserialize(kupci, "kupci");

            for (int i = 0; i < kupci.Count; i++)
            {
                if (kupci[i] is Administrator)
                {
                    kupci.Remove(kupci[i]);
                    i--;
                }
                else
                {
                    Kupac k = kupci[i] as Kupac;
                    sifra = "";
                    for (int j = 0; j < k.Sifra.Length; j++)
                    {
                        sifra += "*";
                    }
                    ListViewItem item = new ListViewItem(new[] { k.KupacUUID, k.Ime, k.Prezime, k.StrPol(), k.Telefon, k.Email, k.KorisnickoIme, sifra, k.DatumRodjenja.ToString("dd/MM/yyyy"), });

                    lvAdminPrikaz.Items.Add(item);
                }
            }
        }
        private void prikaziSale(object sender, EventArgs e)
        {
            activeUserList = false; activeAdminList = false; activeSalaList = true; activeProjekcijeList = false; activeRepertoarList = false;
            changeUpdate(sender, e);
            sale = new List<Sala>();
            ocistiLV();

            lvAdminPrikaz.Columns.Add("ID Sale", 60);
            lvAdminPrikaz.Columns.Add("Broj sale");
            lvAdminPrikaz.Columns.Add("Ukupan broj sedista", 125);

            LocalFileManager.JSONDeserialize(sale, "sale");

            for (int i = 0; i < sale.Count; i++)
            {
                Sala s = sale[i];
                ListViewItem item = new ListViewItem(new[] { s.Uid, "Sala " + s.BrojSale, s.UkupanBrojSedista.ToString() });
                lvAdminPrikaz.Items.Add(item);
            }
            
        }
        private void prikaziFilmove(object sender, EventArgs e)
        {
            activeUserList = false; activeAdminList = false; activeSalaList = false; activeProjekcijeList = false; activeRepertoarList = true;
            changeUpdate(sender, e);
            
            filmovi = new List<Film>();
            
            string granica = "";
            ocistiLV();

            lvAdminPrikaz.Columns.Add("ID Filma");
            lvAdminPrikaz.Columns.Add("Ime filma", 150);
            lvAdminPrikaz.Columns.Add("Trajanje", 60);
            lvAdminPrikaz.Columns.Add("Zanr", 100);
            lvAdminPrikaz.Columns.Add("Granica godina", 100);

            LocalFileManager.JSONDeserialize(filmovi, "filmovi");

            for (int i = 0; i < filmovi.Count; i++)
            {
                Film f = filmovi[i];
                switch (f.Granica)
                {
                    case (int)Film.granicaGodina.G:
                        granica = Film.granicaGodina.G.ToString();
                        break;
                    case (int)Film.granicaGodina.PG:
                        granica = Film.granicaGodina.PG.ToString();
                        break;
                    case (int)Film.granicaGodina.PG13:
                        granica = Film.granicaGodina.PG13.ToString();
                        break;
                    case (int)Film.granicaGodina.R:
                        granica = Film.granicaGodina.R.ToString();
                        break;
                    case (int)Film.granicaGodina.NC17:
                        granica = Film.granicaGodina.NC17.ToString();
                        break;
                    default:
                        break;
                }
                ListViewItem item = new ListViewItem(new[] { f.Id, f.ImeFilma, f.Trajanje.ToString() + " min", f.Zanr, granica });
                lvAdminPrikaz.Items.Add(item);
            }
        }
        private void prikaziProjekcije(object sender, EventArgs e)
        {
            activeUserList = false; activeAdminList = false; activeSalaList = false; activeProjekcijeList = true; activeRepertoarList = false;
            changeUpdate(sender, e);
            projekcije = new List<Projekcija>();
            filmovi = new List<Film>();
            sale = new List<Sala>();

            string filmIme = "", brojSale = "";

            ocistiLV();

            lvAdminPrikaz.Columns.Add("ID Projekcije", 110);
            lvAdminPrikaz.Columns.Add("Datum i vreme projekcije", 200);
            lvAdminPrikaz.Columns.Add("Sala", 60);
            lvAdminPrikaz.Columns.Add("Cena karte", 90);
            lvAdminPrikaz.Columns.Add("Film", 150);
            lvAdminPrikaz.Columns.Add("Dostupna mesta");

            LocalFileManager.JSONDeserialize(projekcije, "projekcije");
            LocalFileManager.JSONDeserialize(sale, "sale");
            LocalFileManager.JSONDeserialize(filmovi, "filmovi");

            for (int i = 0; i < projekcije.Count; i++)
            {
                Projekcija p = projekcije[i];
                ListViewItem item = new ListViewItem(new[] { p.Uid, p.DatumProjekcije.ToString("dd/MM/yyyy") + " " + p.VremeProjekcije.ToString("HH:mm"), "Sala " + p.Sala, p.CenaKarte + " RSD", p.Film.ImeFilma, p.DostupnaMesta.ToString() });
                lvAdminPrikaz.Items.Add(item);
            }
        }
        private void ocistiLV()
        {
            if (lvAdminPrikaz.Columns.Count != 0)
            {
                for (int i = 0; i < lvAdminPrikaz.Columns.Count; i++)
                {
                    lvAdminPrikaz.Columns.RemoveAt(i);
                    lvAdminPrikaz.Items.Clear();
                    i--;
                }
            }
        }

        private void selektujObjekat(object sender, EventArgs e)
        {
            statusUUID.Text = "Selektovan ID ";
            string selektovanUUID = "";
            foreach (ListViewItem item in lvAdminPrikaz.SelectedItems)
            {
                selektovanUUID = item.SubItems[0].Text; //Uzima UUID
                if (item.SubItems.Count > 7)
                {
                    sifra = item.SubItems[7].Text;
                }
            }
            
            statusUUID.Text += selektovanUUID;
            kontrola(selektovanUUID);

            if (selektovanUUID.Equals(""))
            {
                btnIzmeni.Enabled = false;
                btnObrisi.Enabled = false;
                btnDetalji.Enabled = false;
            }
            else
            {
                btnIzmeni.Enabled = true;
                btnObrisi.Enabled = true;
                if (selektovanUUID == "-1" || selektovanUUID.Length == 14 || selektovanUUID.Length == 16)
                {
                    btnDetalji.Enabled = true;
                }
                else
                {
                    btnDetalji.Enabled = false;
                }
            }
        }

        private void dodajAdmina()
        {
            frmDodajAdmina = new FormDodajAdmina();
            frmDodajAdmina.Show();
        }

        private void dodajKupca()
        {
            frmDodajKupca = new FormDodajKupca();
            frmDodajKupca.Show();
        }
        private void dodajFilm()
        {
            frmDodajFilm = new FormDodajFilm();
            frmDodajFilm.Show();
        }
        private void dodajSalu()
        {
            frmDodajSalu = new FormDodajSalu();
            frmDodajSalu.Show();
        }
        private void dodajProjekciju()
        {
            frmDodajProjekciju = new FormDodajProjekciju();
            frmDodajProjekciju.Show();
        }

        private void dodajStavku(object sender, EventArgs e)
        {
            if (activeAdminList) { dodajAdmina(); }
            if (activeUserList) { dodajKupca(); }
            if (activeSalaList) { dodajSalu(); }
            if (activeRepertoarList) { dodajFilm(); }
            if (activeProjekcijeList) { dodajProjekciju(); }
        }

        private void changeUpdate(object sender, EventArgs e)
        {
            if (activeRepertoarList || activeAdminList || activeSalaList || activeProjekcijeList || activeUserList)
            {
                btnDodaj.Enabled = true;
            }
        }

        

        private void kontrola(string uuid)
        {
            if (uuid.Length == 20 || uuid.Length == 21 || uuid.Length == 22)
            {
                foreach (Administrator admin in administratori)
                {
                    if (admin.AdminUUID.Equals(uuid))
                    {
                        selectedItem = admin;
                        Debug.WriteLine(DateTime.Now.ToString("(HH:mm:ss)") + " " + "Selektovan UUID: " + admin.AdminUUID);
                        break;
                    }
                }
            }
            else if(uuid.Length == 2 || uuid.Length == 14 || uuid.Length == 16)
            {
                foreach (Kupac kupac in kupci)
                {
                    if (kupac.KupacUUID.Equals(uuid))
                    {
                        selectedItem = kupac;
                        Debug.WriteLine(DateTime.Now.ToString("(HH:mm:ss)") + " " + "Selektovan UUID: " + kupac.KupacUUID);
                        break;
                    }
                }
            }
            else if (uuid.Length == 4)
            {
                if (uuid.Contains("-"))
                {
                    foreach (Sala sala in sale)
                    {
                        if (sala.Uid.Equals(uuid))
                        {
                            selectedItem = sala;
                            Debug.WriteLine(DateTime.Now.ToString("(HH:mm:ss)") + " " + "Selektovan UUID: " + sala.Uid);
                            break;
                        }
                    }
                }
                else
                {
                    foreach (Film film in filmovi)
                    {
                        if (film.Id.Equals(uuid))
                        {
                            selectedItem = film;
                            Debug.WriteLine(DateTime.Now.ToString("(HH:mm:ss)") + " " + "Selektovan UUID: " + film.Id);
                            break;
                        }
                    }
                }
            }
            else if (uuid.Length == 5)
            {
                foreach (Projekcija projekcija in projekcije)
                {
                    if (projekcija.Uid.Equals(uuid))
                    {
                        selectedItem = projekcija;
                        Debug.WriteLine(DateTime.Now.ToString("(HH:mm:ss)") + " " + "Selektovan UUID: " + projekcija.Uid);
                        break;
                    }
                }
            }
        }

        private void obrisiStavku(object sender, EventArgs e)
        {
            DialogResult konacno = MessageBox.Show("Da li ste sigurni da zelite da obrisete izabranu stavku? Obrisane stavke ne mogu da se povrate!", "Brisanje", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (konacno == DialogResult.Yes)
            {
                LocalFileManager.JSONDelete(selectedItem);
                if (selectedItem is Administrator)
                {
                    prikaziAdmine(sender, e);
                }
                else if (selectedItem is Kupac)
                {
                    prikaziKorisnike(sender, e);
                }
                else if (selectedItem is Film)
                {
                    prikaziFilmove(sender, e);
                }
                else if (selectedItem is Sala)
                {
                    prikaziSale(sender, e);
                }
                else if (selectedItem is Projekcija)
                {
                    prikaziProjekcije(sender, e);
                }
            }
        }

        private void izmeniOdabrano(object sender, EventArgs e)
        {
            if (selectedItem is Korisnik)
            {
                frmIzmena = new FormIzmenaKorisnik();

                posaljiKorisnika posalji = FormIzmenaKorisnik.prihvatiKorisnika;
                posalji(selectedItem as Korisnik, sifra);

                frmIzmena.Show();
            }
        }

        private void prikaziAdmine(object sender, EventArgs e)
        {
            
            activeUserList = false; activeAdminList = true; activeSalaList = false; activeProjekcijeList = false; activeRepertoarList = false;
            changeUpdate(sender, e);

            administratori = new List<Korisnik>();

            ocistiLV();

            lvAdminPrikaz.Columns.Add("UUID", 40);
            lvAdminPrikaz.Columns.Add("Ime", 80);
            lvAdminPrikaz.Columns.Add("Prezime", 80);
            lvAdminPrikaz.Columns.Add("Pol", 30);
            lvAdminPrikaz.Columns.Add("Telefon", 80);
            lvAdminPrikaz.Columns.Add("E-mail", 100);
            lvAdminPrikaz.Columns.Add("Korisnicko ime", 100);
            lvAdminPrikaz.Columns.Add("Sifra", 100);
            lvAdminPrikaz.Columns.Add("Datum rodjenja", 100);

            LocalFileManager.JSONDeserialize(administratori, "administratori");

            foreach (Administrator administrator in administratori)
            {
                sifra = "";
                for (int j = 0; j < administrator.Sifra.Length; j++)
                {
                    sifra += "*";
                }
                ListViewItem item = new ListViewItem(new[] { administrator.AdminUUID, administrator.Ime, administrator.Prezime, administrator.StrPol(), administrator.Telefon, administrator.Email, administrator.KorisnickoIme, sifra, administrator.DatumRodjenja.ToString("dd/MM/yyyy") });

                lvAdminPrikaz.Items.Add(item);
            }
        }
    }
}