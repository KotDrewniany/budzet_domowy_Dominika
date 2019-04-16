using System;
using System.Data;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;


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
            /*
            Series s = new Series();
            s.ChartType = SeriesChartType.Pie;
            s.Points.AddY(5);
            s.Points.AddY(5);
            s.Points.AddY(15);
            chart1.Series.Add(s);
            */


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
            wczytaj_uzytkownikow();
            wyswietlDaty();
            wczytaj_kategorie();
            ustaw_wszystko_na_checked(tW_daty.Nodes);
            ustaw_wszystko_na_checked(tW_kategorie.Nodes);
            wczytajeDane();
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
                                context.operacje.FirstOrDefault(x => x.id_operacji == (int)row.Cells[0].Value);
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
        void wczytaj_uzytkownikow()
        {
            
                var query = from u in db.uzytkownicy
                            select new
                            {
                                uzytkownik = u.imie + " " + u.nazwisko,
                                id = u.id_uzytkownika
                            };
            clb_uzytkownicy.DataSource = query;
            clb_uzytkownicy.DisplayMember = "uzytkownik";
            clb_uzytkownicy.ValueMember = "id";
            for (int i = 0; i < clb_uzytkownicy.Items.Count; i++)
            {
                clb_uzytkownicy.SetItemChecked(i, true);
            }

        }
        /* useless
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
        */
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
            tW_daty.ExpandAll();
        }
        /*
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
        */


        public void wczytaj_kategorie()
        {
            tW_kategorie.Nodes.Clear();
            tW_kategorie.Nodes.Add("wydatek", "Wydatek");
            tW_kategorie.Nodes.Add("przychod", "Przychód");
            var databaseResult = db.kategoria
                .Where(t => t.id_nadkategoria == null).ToList();
            foreach (var item in databaseResult)
            {
                if (item.typ == "wydatek")
                {
                    tW_kategorie.Nodes["wydatek"].Nodes.Add(item.nazwa, item.nazwa);
                }
                else
                {
                    tW_kategorie.Nodes["przychod"].Nodes.Add(item.nazwa, item.nazwa);
                }
            }
            var query = from op in db.kategoria
                        join op1 in db.kategoria on op.id_kategoria equals op1.id_nadkategoria
                        select new { op, op1 };
            foreach (var n in query)
            {
                if (n.op.typ == "wydatek")
                {
                    tW_kategorie.Nodes["wydatek"].Nodes[n.op.nazwa].Nodes.Add(n.op1.nazwa);
                }
                else
                {
                    tW_kategorie.Nodes["przychod"].Nodes[n.op.nazwa].Nodes.Add(n.op1.nazwa);
                }
            }
            tW_kategorie.ExpandAll();
        }
        Point p;

        public int OtwartyUcDodajKategorie { get; set; }

        private void dodajToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var text = string.Empty;
            if (tW_kategorie.SelectedNode != null)
            {
                int id;
                using (var context = new DataClasses1DataContext())
                {
                    if (tW_kategorie.SelectedNode.Level == 0)
                    {
                        id = -1;
                        if (tW_kategorie.SelectedNode.Name == "wydatek")
                        {
                            text = "wydatek";
                        }
                        else
                        {
                            text = "przychod";
                        }
                    }

                    else if (tW_kategorie.SelectedNode.Level == 1) // dodaj kat jak kliknie na nadkategorie
                    {
                        var query = context.kategoria.Where(t => t.nazwa == tW_kategorie.SelectedNode.Text);
                        id = query.FirstOrDefault().id_kategoria;
                    }
                    else
                    {
                        var query = context.kategoria.Where(t => t.nazwa == tW_kategorie.SelectedNode.Parent.Text);
                        id = query.FirstOrDefault().id_kategoria;
                    }
                }
                var uDK = new uc_dodaj_kategorię(this, 0, id, text)
                {
                    Size = new Size(121, 90),
                    Location = new Point(3, 250)
                };
                this.Controls.Add(uDK);
                uDK.BringToFront();
            }
        }

        private void zmieńToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (OtwartyUcDodajKategorie == 0)
            {
                if (tW_kategorie.SelectedNode != null && tW_kategorie.SelectedNode.Level > 0)
                {
                    OtwartyUcDodajKategorie = 1;
                    var uDK = new uc_dodaj_kategorię(this, 1, tW_kategorie.SelectedNode.Text);
                    uDK.Size = new Size(121, 90);
                    uDK.Location = new Point(p.X-50, p.Y-90);
                    this.Controls.Add(uDK);
                    uDK.BringToFront();
                    uDK.Tekst = tW_kategorie.SelectedNode.Text;
                }
            }
        }
        void ustaw_wszystko_na_checked(TreeNodeCollection aNode)
        {
            foreach(TreeNode wezel in aNode)
            {
                wezel.Checked = true;
                CheckAllChildNodes(wezel, true);
            }
        }
        public void GetUsers(List<int> chk_uzytkownicy)
        {
            List<dynamic> list = new List<dynamic>
            {
                new { Item = 1, Description = "1: Item1"},
                new { Item = 2, Description = "2: Item2"}
            };
            var checkedItems = clb_uzytkownicy.CheckedItems;
            foreach (dynamic checkedItem in checkedItems)
            {
                chk_uzytkownicy.Add(checkedItem.id);
            }
        }
        void stworz_liste()
        {
            List<string> chk_kategorie = new List<string>();
            List<DateTime> chk_daty = new List<DateTime>();
            List<int> chk_uzytkownicy = new List<int>();
            GetCheckedNodes(tW_kategorie.Nodes, chk_kategorie);
            GetDates(tW_daty.Nodes, chk_daty);
            GetUsers(chk_uzytkownicy);
            LV_operacje.Items.Clear();
            var query = from o in db.operacje
                        join u in db.uzytkownicy on o.id_uzytkownika equals u.id_uzytkownika
                        join fp in db.forma_platnosci on o.id_forma_platnosci equals fp.id_forma_platnosci
                        join k_pod in db.kategoria on o.id_kategoria equals k_pod.id_kategoria
                        join k_nad in db.kategoria on k_pod.id_nadkategoria equals k_nad.id_kategoria
                        where (chk_kategorie.Contains(k_pod.nazwa) || chk_kategorie.Contains(k_nad.nazwa))
                        && chk_daty.Contains(o.data)
                        && chk_uzytkownicy.Contains(o.id_uzytkownika)
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
        public void GetDates(TreeNodeCollection nodes, List<DateTime> chk_daty)
        {

            foreach (System.Windows.Forms.TreeNode aNode in nodes)
            {
                //edit
                if (aNode.Checked && aNode.Level == 2)
                    chk_daty.Add(DateTime.Parse(aNode.Name+"."+aNode.Parent.Name+"-"+aNode.Parent.Parent.Name+" 00:00:00"));

                if (aNode.Nodes.Count != 0)
                    GetDates(aNode.Nodes, chk_daty);
            }
        }


        public void  GetCheckedNodes(TreeNodeCollection nodes, List<string> chk_kategorie)
        {

            foreach (System.Windows.Forms.TreeNode aNode in nodes)
            {
                //edit
                if (aNode.Checked)
                    chk_kategorie.Add(aNode.Text);

                if (aNode.Nodes.Count != 0)
                    GetCheckedNodes(aNode.Nodes, chk_kategorie);
            }
        }
        private void CheckAllChildNodes(TreeNode treeNode, bool nodeChecked)
        {
            foreach (TreeNode node in treeNode.Nodes)
            {
                node.Checked = nodeChecked;
                if (node.Nodes.Count > 0)
                {
                    // If the current node has child nodes, call the CheckAllChildsNodes method recursively.
                    this.CheckAllChildNodes(node, nodeChecked);
                }
            }
        }
        private void toolStripLabel7_Click(object sender, EventArgs e)
        {
        }

        private void tW_kategorie_AfterCheck(object sender, TreeViewEventArgs e)
        {
            if (e.Action != TreeViewAction.Unknown)
            {
                if (e.Node.Nodes.Count > 0)
                {
                    this.CheckAllChildNodes(e.Node, e.Node.Checked);
                }
            }
            stworz_liste();
        }

        private void tW_daty_AfterCheck(object sender, TreeViewEventArgs e)
        {
            if (e.Action != TreeViewAction.Unknown)
            {
                if (e.Node.Name == "(Wszystkie daty)")
                {
                    ustaw_wszystko_na_checked(tW_daty.Nodes);
                }
                else if (e.Node.Nodes.Count > 0)
                {
                    this.CheckAllChildNodes(e.Node, e.Node.Checked);
                }
            }
            stworz_liste();
        }

        private void clb_uzytkownicy_SelectedIndexChanged(object sender, EventArgs e)
        {
            stworz_liste();
        }
    }
}
