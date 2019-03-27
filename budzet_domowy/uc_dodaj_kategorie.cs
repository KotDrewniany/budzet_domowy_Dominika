using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace budzet_domowy
{

    public partial class uc_dodaj_kategorię : UserControl
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        private FormularzDodaj other;
        private int rodzaj, id_nadkat;
        private string tekst;
        public string Tekst
        {
            set
            {
                tekst = value;
            }
            get
            {
                return tekst;
            }
        }
        public uc_dodaj_kategorię()
        {
            InitializeComponent();
        }
        public uc_dodaj_kategorię(FormularzDodaj other, int p, int id, string t)
        {
            InitializeComponent();
            rodzaj = p;
            id_nadkat = id;
            tekst = t;
            if (rodzaj == 0)
            {
                btn.Text = "Dodaj";
            }
            else if (rodzaj == 1)
            {
                btn.Text = "Zmień";
            }
            this.other = other;
            other.OtwartyUcDodajKategorie = 1;
        }
        public uc_dodaj_kategorię(FormularzDodaj other, int p, string t)
        {
            InitializeComponent();
            rodzaj = p;
            if (rodzaj == 0)
            {
                btn.Text = "Dodaj";
            }
            else if (rodzaj == 1)
            {
                btn.Text = "Zmień";
                tekst = t;
                txt_tekst.Text = t;
            }
            this.other = other;
            other.OtwartyUcDodajKategorie = 1;
        }

        private void btn_anuluj_Click(object sender, EventArgs e)
        {
            other.OtwartyUcDodajKategorie = 0;
            this.Parent.Controls.Remove(this);
        }

        private void btn_Click(object sender, EventArgs e)
        {
            if (rodzaj == 0)
            {

                if (txt_tekst.Text != "")
                {

                    kategoria nowa = new kategoria();
                    if (id_nadkat == -1)
                    {
                        if (tekst == "wydatek")
                        {
                            nowa.nazwa = txt_tekst.Text;
                            nowa.id_nadkategoria = null;
                            nowa.typ = "wydatek";
                        }
                        else
                        {
                            nowa.nazwa = txt_tekst.Text;
                            nowa.id_nadkategoria = null;
                            nowa.typ = "przychod";
                        }
                    }
                    else
                    {
                        nowa.nazwa = txt_tekst.Text;
                        nowa.id_nadkategoria = id_nadkat;
                        nowa.typ = null;
                    }

                    db.kategoria.InsertOnSubmit(nowa);
                    db.SubmitChanges();
                    txt_tekst.Clear();
                }

            }
            else if (rodzaj == 1)
            {
                var kat = from k in db.kategoria
                          where k.nazwa == tekst
                          select k;

                foreach (var u in kat)
                {
                    MessageBox.Show(u.nazwa);
                    u.nazwa = txt_tekst.Text;
                    MessageBox.Show(u.nazwa);
                }
                db.SubmitChanges();
            }
            other.wczytaj_kategorie();
            other.OtwartyUcDodajKategorie = 0;
            this.Parent.Controls.Remove(this);
        }
    }
}