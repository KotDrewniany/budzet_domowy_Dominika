using System;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

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

		private void FormualrzGlowny_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'baza_danychDataSet.operacje' table. You can move, or remove it, as needed.
			this.operacjeTableAdapter.Fill(this.baza_danychDataSet.operacje);
		}
	}
}
