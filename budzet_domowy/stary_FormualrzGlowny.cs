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
            HideAll();

        }

        private void HideAll()
        {
            userListView1.Hide();
            categoryListView.Hide();
            operationListView.Hide();
        }

        private void ChangeView(ViewType viewType)
        {
            HideAll();
            switch (viewType)
            {
                case ViewType.UserListView:
                    userListView1.Show();
                    break;
                case ViewType.CategoryListView:
                    categoryListView.Show();
                    break;
                case ViewType.OperationListView:
                    operationListView.Show();
                    break;
                default:
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ChangeView(ViewType.UserListView);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ChangeView(ViewType.CategoryListView);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ChangeView(ViewType.OperationListView);
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
