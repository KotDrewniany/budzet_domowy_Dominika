using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using budzet_domowy.Enum;

namespace budzet_domowy
{
    public partial class FormualrzGlowny : Form
    {
        public FormualrzGlowny()
        {
            InitializeComponent();

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            var newForm = new FormularzDodaj();
            newForm.Show();
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            var NewForm = new FormularzUzytkownik();
            NewForm.Show();
        }

        private void toolStripLabel8_Click(object sender, EventArgs e)
        {
            FormularzUzytkownik fu = new FormularzUzytkownik();
            fu.ShowDialog();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            FormularzDodaj dodaj = new FormularzDodaj(this);
            dodaj.ShowDialog();
        }


        //public FormualrzGlowny()
        //{
        //    InitializeComponent();
        //}

        //private void Form1_Load(object sender, EventArgs e)
        //{
        //    db.uzytkownicy.InsertOnSubmit(new uzytkownicy()
        //    {
        //        imie = IMIE.Text,
        //        nazwisko = "Karys",
        //    });
        //    db.SubmitChanges();

        //    Convert.ToDouble(kwota.Text);
        //}
    }
}
