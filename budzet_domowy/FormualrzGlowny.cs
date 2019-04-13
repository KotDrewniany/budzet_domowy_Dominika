using System;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace budzet_domowy
{
	public partial class FormualrzGlowny : Form
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        public FormularzDodaj AddEditOperationForm { get; set; }

		public FormualrzGlowny()
        {
            InitializeComponent();
            AddEditOperationForm = new FormularzDodaj(this);
            Series s = new Series();
            s.ChartType = SeriesChartType.Pie;
            s.Points.AddY(5);
            s.Points.AddY(5);
            s.Points.AddY(15);
            chart1.Series.Add(s);

            

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
	        AddEditOperationForm.ShowDialog();
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
	        AddEditOperationForm.ResetForm();
			AddEditOperationForm.ShowDialog();
		}

		private void FormualrzGlowny_Load(object sender, EventArgs e)
		{
			UpdateOperationList();
            wczytajeDane();
            wyswietlDaty();
        }

		public void UpdateOperationList()
		{
			// TODO: This line of code loads data into the 'baza_danychDataSet.operacje' table. You can move, or remove it, as needed.
			this.operacjeTableAdapter.Fill(this.baza_danychDataSet.operacje);
		}

		private void EditOperation_Click(object sender, EventArgs e)
		{
			var rows = dataGridViewOperations.SelectedRows;
			if (rows.Count > 0)
			{
				DataGridViewRow row = rows[0]; 
				AddEditOperationForm.SetEditedItem((int)row.Cells[0].Value);
				AddEditOperationForm.ShowDialog();
			}
			else
			{
				MessageBox.Show("You need to choose operation first!");
			}

		}

		private void DeleteOperation_Click(object sender, EventArgs e)
		{
			var rows = dataGridViewOperations.SelectedRows;
			if (rows.Count > 0)
			{
				var confirmResult = MessageBox.Show("Are you sure to delete this item ??",
					"Confirm Delete!!",
					MessageBoxButtons.YesNo);
				if (confirmResult == DialogResult.Yes)
				{
					using (var context = new DataClasses1DataContext())
					{
						foreach (DataGridViewRow row in rows)
						{
							var operation =
								context.operacje.FirstOrDefault(x => x.id_operacji == (int) row.Cells[0].Value);
							context.operacje.DeleteOnSubmit(operation ?? throw new InvalidOperationException());
						}
						context.SubmitChanges();
						UpdateOperationList();
					}
				}
			}
			else
			{
				MessageBox.Show("You need to choose operation first!");
			}
			
		}
        void wczytajeDane()
        {
            LV_operacje.Items.Clear();
            var query = from o in db.operacje
                        join u in db.uzytkownicy on o.id_uzytkownika equals u.id_uzytkownika
                        join fp in db.forma_platnosci on o.id_forma_platnosci equals fp.id_forma_platnosci
                        join k_pod in db.kategoria on o.id_kategoria equals k_pod.id_kategoria
                        join k_nad in db.kategoria on k_pod.id_nadkategoria equals k_nad.id_kategoria
                        select new
                        {
                            data = o.data,
                            nadkategoria = k_nad.nazwa,
                            podkategoria = k_pod.nazwa,
                            kwota = o.kwota,
                            opis = o.opis,
                            forma_plat = fp.nazwa,
                            typ = k_nad.typ,
                            imie = u.imie,
                            nazwisko = u.nazwisko,


                        };
            foreach (var row in query)
            {
                // MessageBox.Show(row.data.Month.ToString());
                ListViewItem nowy_rekord = new ListViewItem();
                nowy_rekord = LV_operacje.Items.Add(row.data.ToShortDateString());
                nowy_rekord.SubItems.Add(row.kwota.ToString());
                nowy_rekord.SubItems.Add(row.imie + ' ' + row.nazwisko);
                nowy_rekord.SubItems.Add(row.typ);
                nowy_rekord.SubItems.Add(row.nadkategoria);
                nowy_rekord.SubItems.Add(row.podkategoria);
                nowy_rekord.SubItems.Add(row.forma_plat);
                nowy_rekord.SubItems.Add(row.opis);
            }
        }
        void wczytaj_dane_filtruj(string rok = "%", string miesiac = "%", string dzien = "%")
        {
            LV_operacje.Items.Clear();
            var query = from o in db.operacje
                        join u in db.uzytkownicy on o.id_uzytkownika equals u.id_uzytkownika
                        join fp in db.forma_platnosci on o.id_forma_platnosci equals fp.id_forma_platnosci
                        join k_pod in db.kategoria on o.id_kategoria equals k_pod.id_kategoria
                        join k_nad in db.kategoria on k_pod.id_nadkategoria equals k_nad.id_kategoria
                        where (rok == "%" && miesiac == "%" && dzien == "%")
                              || (o.data.Year.ToString() == rok && miesiac == "%" && dzien == "%")
                              || (o.data.Year.ToString() == rok && o.data.Month.ToString() == miesiac && dzien == "%")
                              || (o.data.Year.ToString() == rok && o.data.Month.ToString() == miesiac && o.data.Day.ToString() == dzien)
                        select new
                        {
                            data = o.data,
                            nadkategoria = k_nad.nazwa,
                            podkategoria = k_pod.nazwa,
                            kwota = o.kwota,
                            opis = o.opis,
                            forma_plat = fp.nazwa,
                            typ = k_nad.typ,
                            imie = u.imie,
                            nazwisko = u.nazwisko,
                        };
            foreach (var row in query)
            {
                ListViewItem nowy_rekord = new ListViewItem();
                nowy_rekord = LV_operacje.Items.Add(row.data.ToShortDateString());
                nowy_rekord.SubItems.Add(row.kwota.ToString());
                nowy_rekord.SubItems.Add(row.imie + ' ' + row.nazwisko);
                nowy_rekord.SubItems.Add(row.typ);
                nowy_rekord.SubItems.Add(row.nadkategoria);
                nowy_rekord.SubItems.Add(row.podkategoria);
                nowy_rekord.SubItems.Add(row.forma_plat);
                nowy_rekord.SubItems.Add(row.opis);
            }

        }
        void wyswietlDaty()
        {
            tW_daty.Nodes.Add("(Wszystkie daty)", "(Wszystkie daty)");
            var query = db.operacje.Select(r => r.data.Date).Distinct();

            foreach (var r in query)
            {
                if (tW_daty.Nodes[r.Year.ToString()] == null)
                {
                    tW_daty.Nodes.Add(r.Year.ToString(), r.Year.ToString());
                }
                if (tW_daty.Nodes[r.Year.ToString()].Nodes[r.Month.ToString()] == null)
                {
                    tW_daty.Nodes[r.Year.ToString()].Nodes.Add(r.Month.ToString(), r.Month.ToString());
                }
                if (tW_daty.Nodes[r.Year.ToString()].Nodes[r.Month.ToString()].Nodes[r.Day.ToString()] == null)
                {
                    tW_daty.Nodes[r.Year.ToString()].Nodes[r.Month.ToString()].Nodes.Add(r.Day.ToString(), r.Day.ToString());
                }
            }
        }

        private void tW_daty_DoubleClick(object sender, EventArgs e)
        {
            if (tW_daty.SelectedNode != null)
            {
                if (tW_daty.SelectedNode.Name == "(Wszystkie daty)")
                {
                    wczytaj_dane_filtruj();
                }
                else if (tW_daty.SelectedNode.Level == 0)
                {
                    wczytaj_dane_filtruj(tW_daty.SelectedNode.Name);

                }
                else if (tW_daty.SelectedNode.Level == 1)
                {
                    wczytaj_dane_filtruj(tW_daty.SelectedNode.Parent.Name, tW_daty.SelectedNode.Name);
                }
                else
                {
                    wczytaj_dane_filtruj(tW_daty.SelectedNode.Parent.Parent.Name, tW_daty.SelectedNode.Parent.Name, tW_daty.SelectedNode.Name);
                }
            }
        }
    }
}
