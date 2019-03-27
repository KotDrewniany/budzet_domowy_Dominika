using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace budzet_domowy
{
    public partial class FormularzDodaj : Form
    {
        private int otwarty = 0;
        public int otwarty_uc_dodaj_kategorie
        {
            get
            {
                return otwarty;
            }
            set
            {
                otwarty = value;
            }
        }

        DataClasses1DataContext db = new DataClasses1DataContext();
        FormualrzGlowny other;
        public FormularzDodaj()
        {
            InitializeComponent();
            using (var context = new DataClasses1DataContext())
            {
                DataTable dt = new DataTable(
                     (from o in context.uzytkownicy
                      select o
                     ).ToList().ToString()
             );

                comboBox1.DataSource = dt;
                comboBox1.DisplayMember = "imie";
            }
        }
            public FormularzDodaj(FormualrzGlowny other)
            {
                InitializeComponent();
                this.other = other;
            }
            private void button3_Click(object sender, EventArgs e)
            {
                textBox1.Text = "";
                richTextBox1.Text = "";
                cb_format.Text = string.Empty;
            }
            public void wczytaj_kategorie()
            {
                treeView1.Nodes.Clear();
                treeView1.Nodes.Add("wydatek", "Wydatek");
                treeView1.Nodes.Add("przychod", "Przychód");
                var databaseResult = db.kategoria
                    .Where(t => t.id_nadkategoria == null).ToList();
                foreach (var item in databaseResult)
                {
                    if (item.typ == "wydatek")
                    {
                        treeView1.Nodes["wydatek"].Nodes.Add(item.nazwa, item.nazwa);
                    }
                    else
                    {
                        treeView1.Nodes["przychod"].Nodes.Add(item.nazwa, item.nazwa);
                    }
                }
                var query = from op in db.kategoria
                            join op1 in db.kategoria on op.id_kategoria equals op1.id_nadkategoria
                            select new { op, op1 };
                foreach (var n in query)
                {
                    if (n.op.typ == "wydatek")
                    {
                        treeView1.Nodes["wydatek"].Nodes[n.op.nazwa].Nodes.Add(n.op1.nazwa);
                    }
                    else
                    {
                        treeView1.Nodes["przychod"].Nodes[n.op.nazwa].Nodes.Add(n.op1.nazwa);
                    }
                }
                treeView1.ExpandAll();
            }
            private void FormularzDodaj_Load(object sender, EventArgs e)
            {
                cb_format.Items.Add(new KeyValuePair<string, string>("Gotówka", "0"));
                cb_format.Items.Add(new KeyValuePair<string, string>("Przelew", "1"));

                cb_format.DisplayMember = "key";
                cb_format.ValueMember = "value";
                wczytaj_kategorie();
            }

            private void dodajToolStripMenuItem_Click(object sender, EventArgs e)
            {
                int id;
                string tekst = "";
                if (treeView1.SelectedNode != null)
                {
                    if (treeView1.SelectedNode.Level == 0)
                    {
                        id = -1;
                        if (treeView1.SelectedNode.Name == "wydatek")
                        {
                            tekst = "wydatek";
                        }
                        else
                        {
                            tekst = "przychod";
                        }
                    }
                    else if (treeView1.SelectedNode.Level == 1) // dodaj kat jak kliknie na nadkategorie
                    {
                        var query = db.kategoria.Where(t => t.nazwa == treeView1.SelectedNode.Text);
                        id = query.FirstOrDefault().id_kategoria;
                    }
                    else
                    {
                        var query = db.kategoria.Where(t => t.nazwa == treeView1.SelectedNode.Parent.Text);
                        id = query.FirstOrDefault().id_kategoria;
                    }
                    Point p = this.PointToClient(Cursor.Position);
                    uc_dodaj_kategorię uDK = new uc_dodaj_kategorię(this, 0, id, tekst);
                    uDK.Size = new Size(121, 90);
                    uDK.Location = new Point(p.X + 121, p.Y);
                    this.Controls.Add(uDK);
                    uDK.BringToFront();
                }
            }

            private void btn_dodaj_kategorie_Click(object sender, EventArgs e)
            {
                /* 
                if (txt_dodaj_kategorie.Text != "")
                {
                    kategoria nowa = new kategoria();
                    if (treeView1.SelectedNode.Level == 0)
                    {
                        //dodaj kat jak kliknie na wydatek lub przychod
                        if (treeView1.SelectedNode.Name == "wydatek")
                        {
                            nowa.nazwa = txt_dodaj_kategorie.Text;
                            nowa.id_nadkategoria = null;
                            nowa.typ = "wydatek";
                        }
                        else
                        {

                            nowa.nazwa = txt_dodaj_kategorie.Text;
                            nowa.id_nadkategoria = null;
                            nowa.typ = "przychod";

                        }
                    }
                    else if (treeView1.SelectedNode.Level == 1) // dodaj kat jak kliknie na nadkategorie
                    {
                        var query = db.kategoria.Where(t => t.nazwa == treeView1.SelectedNode.Text);
                        nowa.nazwa = txt_dodaj_kategorie.Text;
                        nowa.id_nadkategoria = query.FirstOrDefault().id_kategoria;
                        nowa.typ = null;

                    }
                    else
                    {
                        var query = db.kategoria.Where(t => t.nazwa == treeView1.SelectedNode.Parent.Text);
                        nowa.nazwa = txt_dodaj_kategorie.Text;
                        nowa.id_nadkategoria = query.FirstOrDefault().id_kategoria;
                        nowa.typ = null;
                    }
                    db.kategoria.InsertOnSubmit(nowa);
                    db.SubmitChanges();
                    txt_dodaj_kategorie.Clear();
                    wczytaj_kategorie();
                }
                */
            }

            private void zmieńToolStripMenuItem_Click(object sender, EventArgs e)
            {
                if (otwarty_uc_dodaj_kategorie == 0)
                {
                    if (treeView1.SelectedNode != null && treeView1.SelectedNode.Level > 0)
                    {
                        otwarty_uc_dodaj_kategorie = 1;
                        Point p = this.PointToClient(Cursor.Position);
                        uc_dodaj_kategorię uDK = new uc_dodaj_kategorię(this, 1, treeView1.SelectedNode.Text);
                        uDK.Size = new Size(121, 90);
                        uDK.Location = new Point(p.X, p.Y);
                        this.Controls.Add(uDK);
                        uDK.BringToFront();
                        uDK.Tekst = treeView1.SelectedNode.Text;

                    }
                }
            }

            private void dodajToolStripMenuItem_Click_1(object sender, EventArgs e)
            {
                if (otwarty_uc_dodaj_kategorie == 0)
                {
                    int id;
                    string tekst = "";
                    if (treeView1.SelectedNode != null)
                    {
                        if (treeView1.SelectedNode.Level == 0)
                        {
                            id = -1;
                            if (treeView1.SelectedNode.Name == "wydatek")
                            {
                                tekst = "wydatek";
                            }
                            else
                            {
                                tekst = "przychod";
                            }
                        }
                        else if (treeView1.SelectedNode.Level == 1) // dodaj kat jak kliknie na nadkategorie
                        {
                            var query = db.kategoria.Where(t => t.nazwa == treeView1.SelectedNode.Text);
                            id = query.FirstOrDefault().id_kategoria;
                        }
                        else
                        {
                            var query = db.kategoria.Where(t => t.nazwa == treeView1.SelectedNode.Parent.Text);
                            id = query.FirstOrDefault().id_kategoria;
                        }
                        Point p = this.PointToClient(Cursor.Position);
                        uc_dodaj_kategorię uDK = new uc_dodaj_kategorię(this, 0, id, tekst);
                        uDK.Size = new Size(121, 90);
                        uDK.Location = new Point(p.X - 121, p.Y);
                        this.Controls.Add(uDK);
                        uDK.BringToFront();
                    }
                }
            }

            private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
            {
                using (var context = new DataClasses1DataContext())
                {
                    DataTable dt = context.DataTable(
                         (from o in context.uzytkownicy
                          select o
                         ).ToString()
                 );

                    comboBox1.DataSource = dt;
                    comboBox1.DisplayMember = "imie";


                }
            }
        }
    }