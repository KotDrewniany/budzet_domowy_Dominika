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
	}
}
