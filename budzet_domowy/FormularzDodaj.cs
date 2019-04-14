using budzet_domowy.Model;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using static System.Decimal;

namespace budzet_domowy
{
	public partial class FormularzDodaj : Form
	{
		public FormualrzGlowny MainForm { get; set; }
		public int OtwartyUcDodajKategorie { get; set; }
		public int EditedId { get; set; }
		public bool IsEditMode => EditedId != 0;
		public OperationDto OperationDto { get; set; }

		public FormularzDodaj(FormualrzGlowny mainForm)
		{
			InitializeComponent();
			InitializeComboBoxes();
			radioButtonExpense.Checked = true;
			MainForm = mainForm;
		}

		public void SetEditedItem(int editedId)
		{
			EditedId = editedId;
			if (IsEditMode)
				ReadEditedOperation();
			else
				ResetForm();
		}

		private void ReadEditedOperation()
		{
			using (var context = new DataClasses1DataContext())
			{
				var operation = context.operacje.FirstOrDefault(x => x.id_operacji == EditedId);
				if (operation == null)
					throw new ArgumentException("No operation with given id in the database");

				OperationDto = new OperationDto()
				{
					Id = operation.id_operacji,
					Data = operation.data,
					Price = operation.kwota,
					CategoryId = operation.id_kategoria,
					UserId = operation.id_uzytkownika,
					PaymentFormId = operation.id_forma_platnosci,
					Description = operation.opis,
				};
			}
			SetEditedOperationData();
		}

		private void SetEditedOperationData()
		{
			//comboBoxUsers.SelectedIndex = OperationDto.UserId;
			//comboBoxCategory.SelectedIndex = OperationDto.CategoryId;
			//comboBoxSubcategory.SelectedValue = ;
			dateTimePickerDate.Value = OperationDto.Data;
			//radioButtonExpense.Checked = ;
			//comboBoxOperationForm.Text = ;
			textBoxPrice.Text = OperationDto.Price.ToString("0.00");
			richTextBoxDescription.Text = OperationDto.Description;
		}

		private void InitializeComboBoxes()
		{
			using (var context = new DataClasses1DataContext())
			{
				var users = context.uzytkownicy.Select(x => new ComboboxModel
				{ DisplayMember = x.imie + x.nazwisko, Id = x.id_uzytkownika }).ToArray();
				var categories = context.kategoria.Where(x => x.id_nadkategoria == null).Select(x => new ComboboxModel
				{ DisplayMember = x.nazwa, Id = x.id_kategoria }).ToArray();
				var operationForms = context.forma_platnosci.Select(x => new ComboboxModel
				{ DisplayMember = x.nazwa, Id = x.id_forma_platnosci }).ToArray();

				comboBoxUsers.Items.AddRange(users);
				comboBoxCategory.Items.AddRange(categories);
				comboBoxOperationForm.Items.AddRange(operationForms);
			}
			comboBoxUsers.DisplayMember = "DisplayMember";
			comboBoxUsers.ValueMember = "Id";

			comboBoxCategory.DisplayMember = "DisplayMember";
			comboBoxCategory.ValueMember = "Id";

			comboBoxSubcategory.DisplayMember = "DisplayMember";
			comboBoxSubcategory.ValueMember = "Id";

			comboBoxOperationForm.DisplayMember = "DisplayMember";
			comboBoxOperationForm.ValueMember = "Id";

			wczytaj_kategorie();
		}



		public void wczytaj_kategorie()
		{
			treeView1.Nodes.Clear();
			treeView1.Nodes.Add("wydatek", "Wydatek");
			treeView1.Nodes.Add("przychod", "Przychód");
			using (var context = new DataClasses1DataContext())
			{
				var databaseResult = context.kategoria
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
				var query = from op in context.kategoria
							join op1 in context.kategoria on op.id_kategoria equals op1.id_nadkategoria
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
			};
			treeView1.ExpandAll();
		}

		private void dodajToolStripMenuItem_Click(object sender, EventArgs e)
		{
            /*
			var text = string.Empty;
			if (treeView1.SelectedNode != null)
			{
				int id;
				using (var context = new DataClasses1DataContext())
				{
					if (treeView1.SelectedNode.Level == 0)
					{
						id = -1;
						if (treeView1.SelectedNode.Name == "wydatek")
						{
							text = "wydatek";
						}
						else
						{
							text = "przychod";
						}
					}

					else if (treeView1.SelectedNode.Level == 1) // dodaj kat jak kliknie na nadkategorie
					{
						var query = context.kategoria.Where(t => t.nazwa == treeView1.SelectedNode.Text);
						id = query.FirstOrDefault().id_kategoria;
					}
					else
					{
						var query = context.kategoria.Where(t => t.nazwa == treeView1.SelectedNode.Parent.Text);
						id = query.FirstOrDefault().id_kategoria;
					}
				}

				var p = this.PointToClient(Cursor.Position);
				var uDK = new uc_dodaj_kategorię(this, 0, id, text)
				{
					Size = new Size(121, 90),
					Location = new Point(p.X + 121, p.Y)
				};
				this.Controls.Add(uDK);
				uDK.BringToFront();
			}
            */
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
            /*
			if (OtwartyUcDodajKategorie == 0)
			{
				if (treeView1.SelectedNode != null && treeView1.SelectedNode.Level > 0)
				{
					OtwartyUcDodajKategorie = 1;
					var p = this.PointToClient(Cursor.Position);
					var uDK = new uc_dodaj_kategorię(this, 1, treeView1.SelectedNode.Text);
					uDK.Size = new Size(121, 90);
					uDK.Location = new Point(p.X, p.Y);
					this.Controls.Add(uDK);
					uDK.BringToFront();
					uDK.Tekst = treeView1.SelectedNode.Text;
				}
			}
            */
		}

		private void dodajToolStripMenuItem_Click_1(object sender, EventArgs e)
		{
            /*
			if (OtwartyUcDodajKategorie == 0)
			{
				int? id;
				string text = "";
				if (treeView1.SelectedNode != null)
				{
					using (var context = new DataClasses1DataContext())
					{
						if (treeView1.SelectedNode.Level == 0)
						{
							id = -1;
							if (treeView1.SelectedNode.Name == "wydatek")
							{
								text = "wydatek";
							}
							else
							{
								text = "przychod";
							}
						}
						else if (treeView1.SelectedNode.Level == 1) // dodaj kat jak kliknie na nadkategorie
						{
							var query = context.kategoria.Where(t => t.nazwa == treeView1.SelectedNode.Text);
							id = query.FirstOrDefault()?.id_kategoria;
						}
						else
						{
							var query = context.kategoria.Where(t => t.nazwa == treeView1.SelectedNode.Parent.Text);
							id = query.FirstOrDefault()?.id_kategoria;
						}
					}

					var p = this.PointToClient(Cursor.Position);
					var uDK = new uc_dodaj_kategorię(this, 0, id ?? 0, text)
					{
						Size = new Size(121, 90),
						Location = new Point(p.X - 121, p.Y)
					};
					this.Controls.Add(uDK);
					uDK.BringToFront();
				}
			}
            */
		}

		private void comboBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
		{
			using (var context = new DataClasses1DataContext())
			{
				comboBoxSubcategory.SelectedIndex = -1;
				comboBoxSubcategory.Items.Clear();

				if (comboBoxCategory.SelectedIndex != -1)
				{
					var selectedItem = (ComboboxModel)comboBoxCategory.Items[comboBoxCategory.SelectedIndex];
					var subcategories = context.kategoria.Where(x => x.id_nadkategoria.Value == selectedItem.Id).Select(x => new ComboboxModel
					{ DisplayMember = x.nazwa, Id = x.id_kategoria }).ToArray();

					comboBoxSubcategory.Items.AddRange(subcategories);
				}
			}
		}

		private void buttonCancel_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void buttonSave_Click(object sender, EventArgs e)
		{
			using (var context = new DataClasses1DataContext())
			{
				var userId = comboBoxUsers.SelectedIndex != -1
					? ((ComboboxModel)comboBoxUsers.Items[comboBoxUsers.SelectedIndex]).Id
					: 0;
				var categoryId = comboBoxCategory.SelectedIndex != -1
					? ((ComboboxModel)comboBoxCategory.Items[comboBoxCategory.SelectedIndex]).Id
					: 0;
				var subcategoryId = comboBoxSubcategory.SelectedIndex != -1
					? ((ComboboxModel)comboBoxSubcategory.Items[comboBoxSubcategory.SelectedIndex]).Id
					: 0;
				var operationFormId = comboBoxOperationForm.SelectedIndex != -1
					? ((ComboboxModel)comboBoxOperationForm.Items[comboBoxOperationForm.SelectedIndex]).Id
					: 0;

				if (IsEditMode)
				{
					var operation = context.operacje.FirstOrDefault(x => x.id_operacji == OperationDto.Id);
					if (operation != null)
					{
						operation.data = dateTimePickerDate.Value;
						operation.kwota = TryParse(textBoxPrice.Text, out var price) ? price : 0;
						operation.id_uzytkownika = userId;
						operation.id_kategoria = categoryId;
						//id_forma_platnosci = operationFormId,
						operation.opis = richTextBoxDescription.Text;
					}
				}
				else
				{
					context.operacje.InsertOnSubmit(new operacje()
					{
						data = dateTimePickerDate.Value,
						kwota = TryParse(textBoxPrice.Text, out var price) ? price : 0,
						id_uzytkownika = userId,
						id_kategoria = categoryId,
						//id_forma_platnosci = operationFormId,
						opis = richTextBoxDescription.Text
					});
				}
				
				context.SubmitChanges();
			}
			MainForm.UpdateOperationList();
			Close();
		}

		private void buttonReset_Click(object sender, EventArgs e)
		{
			ResetForm();
		}

		public void ResetForm()
		{
			comboBoxUsers.SelectedIndex = -1;
			comboBoxCategory.SelectedIndex = -1;
			comboBoxSubcategory.SelectedIndex = -1;
			dateTimePickerDate.Value = DateTime.Now;
			radioButtonExpense.Checked = true;
			comboBoxOperationForm.Text = "";
			textBoxPrice.Text = "";
			richTextBoxDescription.Text = "";
		}
	}
}