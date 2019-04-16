using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace budzet_domowy
{
    public partial class FormularzUzytkownik : Form
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        private string w_imie = "",w_nazwisko = "";
        private string zm_imie, zm_nazwisko;
        public FormularzUzytkownik()
        {
            InitializeComponent();
            wczytaj();
        }

        private void wczytaj()
        {
            var query = from u in db.uzytkownicy
                        select new
                        {
                            uzytkownik = u.imie + " " + u.nazwisko,
                            id = u.id_uzytkownika
                        };
            lb_uzytkownicy.DisplayMember = "uzytkownik";
            lb_uzytkownicy.ValueMember = "id";
            lb_uzytkownicy.DataSource = query;
        }
        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            var query = db.uzytkownicy.Where(t => t.id_uzytkownika.ToString() == lb_uzytkownicy.SelectedValue.ToString());
            foreach (uzytkownicy u in query)
            {
                u.imie = w_imie;
                u.nazwisko = w_nazwisko;
            }
            try
            {
                db.SubmitChanges();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
            }
            wczytaj();
            txt_imie.Text = "";
            txt_nazwisko.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var query = db.uzytkownicy.Where(t => t.id_uzytkownika.ToString() == lb_uzytkownicy.SelectedValue.ToString());
            if (w_nazwisko != "" && w_imie != "" && query.FirstOrDefault().imie != txt_imie.Text && query.FirstOrDefault().nazwisko != txt_nazwisko.Text)
            {
                uzytkownicy nowy = new uzytkownicy
                    {
                        imie = w_imie,
                        nazwisko = w_nazwisko
                    };
                    db.uzytkownicy.InsertOnSubmit(nowy);
                    try
                    {
                        db.SubmitChanges();
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show(error.ToString());
                    }
            }
            else
            {
                MessageBox.Show("Podany użytkownik istnieje!");
            }
            wczytaj();
            txt_imie.Text = "";
            txt_nazwisko.Text = "";
        }

        private void zmieńToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lb_uzytkownicy.SelectedItem != null)
            {
                var query = db.uzytkownicy.Where(t => t.id_uzytkownika.ToString() == lb_uzytkownicy.SelectedValue.ToString());
                zm_imie = query.FirstOrDefault().imie;
                zm_nazwisko = query.FirstOrDefault().nazwisko;
                txt_imie.Text = zm_imie;
                txt_nazwisko.Text = zm_nazwisko;
            }
        }

        private void btn_usun_Click(object sender, EventArgs e)
        {
            var query = db.uzytkownicy.Where(t => t.id_uzytkownika.ToString() == lb_uzytkownicy.SelectedValue.ToString());
            foreach (var u in query)
            {
                db.uzytkownicy.DeleteOnSubmit(u);
            }
            try
            {
                db.SubmitChanges();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
            }
            wczytaj();
            txt_imie.Text = "";
            txt_nazwisko.Text = "";
        }

        private void usuńToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(lb_uzytkownicy.SelectedItem != null)
            {
                var query = db.uzytkownicy.Where(t => t.id_uzytkownika.ToString() == lb_uzytkownicy.SelectedValue.ToString());
                foreach (var u in query)
                {
                    db.uzytkownicy.DeleteOnSubmit(u);
                }
                try
                {
                    db.SubmitChanges();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.ToString());
                }
                wczytaj();
                txt_imie.Text = "";
                txt_nazwisko.Text = "";
            }
        }

        private void txt_nazwisko_TextChanged(object sender, EventArgs e)
        {
            w_nazwisko = txt_nazwisko.Text;
        }

        private void txt_imie_TextChanged(object sender, EventArgs e)
        {
            w_imie = txt_imie.Text;
        }
    }
}
