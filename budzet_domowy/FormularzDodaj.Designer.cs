namespace budzet_domowy
{
    partial class FormularzDodaj
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.components = new System.ComponentModel.Container();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.buttonSave = new System.Windows.Forms.Button();
			this.buttonReset = new System.Windows.Forms.Button();
			this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.label11 = new System.Windows.Forms.Label();
			this.comboBoxUsers = new System.Windows.Forms.ComboBox();
			this.comboBoxSubcategory = new System.Windows.Forms.ComboBox();
			this.comboBoxCategory = new System.Windows.Forms.ComboBox();
			this.comboBoxOperationForm = new System.Windows.Forms.ComboBox();
			this.textBoxPrice = new System.Windows.Forms.TextBox();
			this.richTextBoxDescription = new System.Windows.Forms.RichTextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.radioButtonIncome = new System.Windows.Forms.RadioButton();
			this.radioButtonExpense = new System.Windows.Forms.RadioButton();
			this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.btn_dodaj_kategorie = new System.Windows.Forms.Button();
			this.txt_dodaj_kategorie = new System.Windows.Forms.TextBox();
			this.treeView1 = new System.Windows.Forms.TreeView();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.dodajToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.zmieńToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.usuńToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.contextMenuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// buttonCancel
			// 
			this.buttonCancel.Location = new System.Drawing.Point(40, 567);
			this.buttonCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(259, 58);
			this.buttonCancel.TabIndex = 15;
			this.buttonCancel.Text = "ANULUJ";
			this.buttonCancel.UseVisualStyleBackColor = true;
			this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
			// 
			// buttonSave
			// 
			this.buttonSave.Location = new System.Drawing.Point(328, 567);
			this.buttonSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.Size = new System.Drawing.Size(259, 58);
			this.buttonSave.TabIndex = 16;
			this.buttonSave.Text = "ZAPISZ";
			this.buttonSave.UseVisualStyleBackColor = true;
			this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
			// 
			// buttonReset
			// 
			this.buttonReset.Location = new System.Drawing.Point(615, 567);
			this.buttonReset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.buttonReset.Name = "buttonReset";
			this.buttonReset.Size = new System.Drawing.Size(259, 58);
			this.buttonReset.TabIndex = 17;
			this.buttonReset.Text = "RESETUJ";
			this.buttonReset.UseVisualStyleBackColor = true;
			this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
			// 
			// tabControl1
			// 
			this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Right;
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Location = new System.Drawing.Point(36, 12);
			this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tabControl1.Multiline = true;
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(1232, 528);
			this.tabControl1.TabIndex = 18;
			// 
			// tabPage1
			// 
			this.tabPage1.BackColor = System.Drawing.Color.Transparent;
			this.tabPage1.Controls.Add(this.label11);
			this.tabPage1.Controls.Add(this.comboBoxUsers);
			this.tabPage1.Controls.Add(this.comboBoxSubcategory);
			this.tabPage1.Controls.Add(this.comboBoxCategory);
			this.tabPage1.Controls.Add(this.comboBoxOperationForm);
			this.tabPage1.Controls.Add(this.textBoxPrice);
			this.tabPage1.Controls.Add(this.richTextBoxDescription);
			this.tabPage1.Controls.Add(this.label8);
			this.tabPage1.Controls.Add(this.label7);
			this.tabPage1.Controls.Add(this.radioButtonIncome);
			this.tabPage1.Controls.Add(this.radioButtonExpense);
			this.tabPage1.Controls.Add(this.dateTimePickerDate);
			this.tabPage1.Controls.Add(this.label6);
			this.tabPage1.Controls.Add(this.label5);
			this.tabPage1.Controls.Add(this.label4);
			this.tabPage1.Controls.Add(this.label3);
			this.tabPage1.Controls.Add(this.label2);
			this.tabPage1.Controls.Add(this.label1);
			this.tabPage1.Location = new System.Drawing.Point(4, 4);
			this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tabPage1.Size = new System.Drawing.Size(1203, 520);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Operacja";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(133, 59);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(78, 17);
			this.label11.TabIndex = 39;
			this.label11.Text = "Użytkownik";
			// 
			// comboBoxUsers
			// 
			this.comboBoxUsers.FormattingEnabled = true;
			this.comboBoxUsers.Location = new System.Drawing.Point(244, 52);
			this.comboBoxUsers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.comboBoxUsers.Name = "comboBoxUsers";
			this.comboBoxUsers.Size = new System.Drawing.Size(257, 24);
			this.comboBoxUsers.TabIndex = 38;
			// 
			// comboBoxSubcategory
			// 
			this.comboBoxSubcategory.FormattingEnabled = true;
			this.comboBoxSubcategory.Location = new System.Drawing.Point(244, 263);
			this.comboBoxSubcategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.comboBoxSubcategory.Name = "comboBoxSubcategory";
			this.comboBoxSubcategory.Size = new System.Drawing.Size(257, 24);
			this.comboBoxSubcategory.TabIndex = 37;
			// 
			// comboBoxCategory
			// 
			this.comboBoxCategory.FormattingEnabled = true;
			this.comboBoxCategory.Location = new System.Drawing.Point(244, 222);
			this.comboBoxCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.comboBoxCategory.Name = "comboBoxCategory";
			this.comboBoxCategory.Size = new System.Drawing.Size(257, 24);
			this.comboBoxCategory.TabIndex = 36;
			this.comboBoxCategory.SelectedIndexChanged += new System.EventHandler(this.comboBoxCategory_SelectedIndexChanged);
			// 
			// comboBoxOperationForm
			// 
			this.comboBoxOperationForm.FormattingEnabled = true;
			this.comboBoxOperationForm.Location = new System.Drawing.Point(244, 178);
			this.comboBoxOperationForm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.comboBoxOperationForm.Name = "comboBoxOperationForm";
			this.comboBoxOperationForm.Size = new System.Drawing.Size(257, 24);
			this.comboBoxOperationForm.TabIndex = 35;
			// 
			// textBoxPrice
			// 
			this.textBoxPrice.Location = new System.Drawing.Point(244, 310);
			this.textBoxPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.textBoxPrice.Name = "textBoxPrice";
			this.textBoxPrice.Size = new System.Drawing.Size(257, 22);
			this.textBoxPrice.TabIndex = 34;
			// 
			// richTextBoxDescription
			// 
			this.richTextBoxDescription.Location = new System.Drawing.Point(244, 352);
			this.richTextBoxDescription.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.richTextBoxDescription.Name = "richTextBoxDescription";
			this.richTextBoxDescription.Size = new System.Drawing.Size(563, 146);
			this.richTextBoxDescription.TabIndex = 33;
			this.richTextBoxDescription.Text = "";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(119, 270);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(92, 17);
			this.label8.TabIndex = 32;
			this.label8.Text = "Podkategoria";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(141, 228);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(69, 17);
			this.label7.TabIndex = 31;
			this.label7.Text = "Kategoria";
			// 
			// radioButtonIncome
			// 
			this.radioButtonIncome.AutoSize = true;
			this.radioButtonIncome.Location = new System.Drawing.Point(413, 140);
			this.radioButtonIncome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.radioButtonIncome.Name = "radioButtonIncome";
			this.radioButtonIncome.Size = new System.Drawing.Size(88, 21);
			this.radioButtonIncome.TabIndex = 30;
			this.radioButtonIncome.TabStop = true;
			this.radioButtonIncome.Text = "Przychód";
			this.radioButtonIncome.UseVisualStyleBackColor = true;
			// 
			// radioButtonExpense
			// 
			this.radioButtonExpense.AutoSize = true;
			this.radioButtonExpense.Location = new System.Drawing.Point(244, 140);
			this.radioButtonExpense.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.radioButtonExpense.Name = "radioButtonExpense";
			this.radioButtonExpense.Size = new System.Drawing.Size(84, 21);
			this.radioButtonExpense.TabIndex = 29;
			this.radioButtonExpense.TabStop = true;
			this.radioButtonExpense.Text = "Wydatek";
			this.radioButtonExpense.UseVisualStyleBackColor = true;
			// 
			// dateTimePickerDate
			// 
			this.dateTimePickerDate.Location = new System.Drawing.Point(244, 97);
			this.dateTimePickerDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dateTimePickerDate.Name = "dateTimePickerDate";
			this.dateTimePickerDate.Size = new System.Drawing.Size(257, 22);
			this.dateTimePickerDate.TabIndex = 28;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(37, 352);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(173, 17);
			this.label6.TabIndex = 27;
			this.label6.Text = "Szczegółowy opis operacji";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(141, 310);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(70, 17);
			this.label5.TabIndex = 26;
			this.label5.Text = "Kwota (zł)";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(109, 185);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(102, 17);
			this.label4.TabIndex = 25;
			this.label4.Text = "Forma operacji";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(125, 144);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(86, 17);
			this.label3.TabIndex = 24;
			this.label3.Text = "Typ operacji";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(125, 102);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(92, 17);
			this.label2.TabIndex = 23;
			this.label2.Text = "Data operacji";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label1.Location = new System.Drawing.Point(44, 14);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(167, 20);
			this.label1.TabIndex = 22;
			this.label1.Text = "Dane ogólne operacji";
			// 
			// tabPage2
			// 
			this.tabPage2.BackColor = System.Drawing.Color.Transparent;
			this.tabPage2.Controls.Add(this.btn_dodaj_kategorie);
			this.tabPage2.Controls.Add(this.txt_dodaj_kategorie);
			this.tabPage2.Controls.Add(this.treeView1);
			this.tabPage2.Controls.Add(this.textBox3);
			this.tabPage2.Controls.Add(this.textBox2);
			this.tabPage2.Controls.Add(this.label9);
			this.tabPage2.Controls.Add(this.label10);
			this.tabPage2.Controls.Add(this.label14);
			this.tabPage2.Location = new System.Drawing.Point(4, 4);
			this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tabPage2.Size = new System.Drawing.Size(1203, 520);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Kategoria";
			// 
			// btn_dodaj_kategorie
			// 
			this.btn_dodaj_kategorie.Location = new System.Drawing.Point(96, 411);
			this.btn_dodaj_kategorie.Margin = new System.Windows.Forms.Padding(4);
			this.btn_dodaj_kategorie.Name = "btn_dodaj_kategorie";
			this.btn_dodaj_kategorie.Size = new System.Drawing.Size(161, 28);
			this.btn_dodaj_kategorie.TabIndex = 61;
			this.btn_dodaj_kategorie.Text = "Dodaj kategorię";
			this.btn_dodaj_kategorie.UseVisualStyleBackColor = true;
			// 
			// txt_dodaj_kategorie
			// 
			this.txt_dodaj_kategorie.Location = new System.Drawing.Point(96, 374);
			this.txt_dodaj_kategorie.Margin = new System.Windows.Forms.Padding(4);
			this.txt_dodaj_kategorie.Name = "txt_dodaj_kategorie";
			this.txt_dodaj_kategorie.Size = new System.Drawing.Size(160, 22);
			this.txt_dodaj_kategorie.TabIndex = 60;
			// 
			// treeView1
			// 
			this.treeView1.ContextMenuStrip = this.contextMenuStrip1;
			this.treeView1.Location = new System.Drawing.Point(432, 144);
			this.treeView1.Margin = new System.Windows.Forms.Padding(4);
			this.treeView1.Name = "treeView1";
			this.treeView1.Size = new System.Drawing.Size(347, 317);
			this.treeView1.TabIndex = 57;
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajToolStripMenuItem,
            this.zmieńToolStripMenuItem,
            this.usuńToolStripMenuItem});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(121, 76);
			// 
			// dodajToolStripMenuItem
			// 
			this.dodajToolStripMenuItem.Name = "dodajToolStripMenuItem";
			this.dodajToolStripMenuItem.Size = new System.Drawing.Size(120, 24);
			this.dodajToolStripMenuItem.Text = "Dodaj";
			this.dodajToolStripMenuItem.Click += new System.EventHandler(this.dodajToolStripMenuItem_Click);
			// 
			// zmieńToolStripMenuItem
			// 
			this.zmieńToolStripMenuItem.Name = "zmieńToolStripMenuItem";
			this.zmieńToolStripMenuItem.Size = new System.Drawing.Size(120, 24);
			this.zmieńToolStripMenuItem.Text = "Zmień";
			this.zmieńToolStripMenuItem.Click += new System.EventHandler(this.zmieńToolStripMenuItem_Click);
			// 
			// usuńToolStripMenuItem
			// 
			this.usuńToolStripMenuItem.Name = "usuńToolStripMenuItem";
			this.usuńToolStripMenuItem.Size = new System.Drawing.Size(120, 24);
			this.usuńToolStripMenuItem.Text = "Usuń";
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(229, 113);
			this.textBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(257, 22);
			this.textBox3.TabIndex = 51;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(229, 73);
			this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(257, 22);
			this.textBox2.TabIndex = 50;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(105, 113);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(92, 17);
			this.label9.TabIndex = 46;
			this.label9.Text = "Podkategoria";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(128, 76);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(69, 17);
			this.label10.TabIndex = 45;
			this.label10.Text = "Kategoria";
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label14.Location = new System.Drawing.Point(44, 14);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(264, 20);
			this.label14.TabIndex = 38;
			this.label14.Text = "Dodawanie kategorii i podkategorii";
			// 
			// FormularzDodaj
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1323, 649);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.buttonReset);
			this.Controls.Add(this.buttonSave);
			this.Controls.Add(this.buttonCancel);
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "FormularzDodaj";
			this.Text = "FormularzDodaj";
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			this.contextMenuStrip1.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonReset;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ComboBox comboBoxSubcategory;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.ComboBox comboBoxOperationForm;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.RichTextBox richTextBoxDescription;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton radioButtonIncome;
        private System.Windows.Forms.RadioButton radioButtonExpense;
        private System.Windows.Forms.DateTimePicker dateTimePickerDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboBoxUsers;
        private System.Windows.Forms.Button btn_dodaj_kategorie;
        private System.Windows.Forms.TextBox txt_dodaj_kategorie;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dodajToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zmieńToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuńToolStripMenuItem;
    }
}