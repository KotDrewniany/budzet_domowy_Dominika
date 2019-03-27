namespace budzet_domowy
{
    partial class FormularzUzytkownik
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
            this.label11 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_imie = new System.Windows.Forms.TextBox();
            this.txt_nazwisko = new System.Windows.Forms.TextBox();
            this.btn_zmien = new System.Windows.Forms.Button();
            this.btn_dodaj = new System.Windows.Forms.Button();
            this.btn_anuluj = new System.Windows.Forms.Button();
            this.lb_uzytkownicy = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.zmieńToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuńToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_usun = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(11, 40);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(26, 13);
            this.label11.TabIndex = 55;
            this.label11.Text = "Imię";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 73);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 41;
            this.label2.Text = "Nazwisko";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(23, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 17);
            this.label1.TabIndex = 40;
            this.label1.Text = "Dodaj nowego użytkownika";
            // 
            // txt_imie
            // 
            this.txt_imie.Location = new System.Drawing.Point(68, 40);
            this.txt_imie.Margin = new System.Windows.Forms.Padding(2);
            this.txt_imie.Name = "txt_imie";
            this.txt_imie.Size = new System.Drawing.Size(149, 20);
            this.txt_imie.TabIndex = 56;
            this.txt_imie.TextChanged += new System.EventHandler(this.txt_imie_TextChanged);
            // 
            // txt_nazwisko
            // 
            this.txt_nazwisko.Location = new System.Drawing.Point(68, 73);
            this.txt_nazwisko.Margin = new System.Windows.Forms.Padding(2);
            this.txt_nazwisko.Name = "txt_nazwisko";
            this.txt_nazwisko.Size = new System.Drawing.Size(149, 20);
            this.txt_nazwisko.TabIndex = 57;
            this.txt_nazwisko.TextChanged += new System.EventHandler(this.txt_nazwisko_TextChanged);
            // 
            // btn_zmien
            // 
            this.btn_zmien.Location = new System.Drawing.Point(11, 149);
            this.btn_zmien.Margin = new System.Windows.Forms.Padding(2);
            this.btn_zmien.Name = "btn_zmien";
            this.btn_zmien.Size = new System.Drawing.Size(206, 33);
            this.btn_zmien.TabIndex = 60;
            this.btn_zmien.Text = "ZMIEŃ";
            this.btn_zmien.UseVisualStyleBackColor = true;
            this.btn_zmien.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_dodaj
            // 
            this.btn_dodaj.Location = new System.Drawing.Point(14, 108);
            this.btn_dodaj.Margin = new System.Windows.Forms.Padding(2);
            this.btn_dodaj.Name = "btn_dodaj";
            this.btn_dodaj.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_dodaj.Size = new System.Drawing.Size(203, 28);
            this.btn_dodaj.TabIndex = 59;
            this.btn_dodaj.Text = "DODAJ";
            this.btn_dodaj.UseVisualStyleBackColor = true;
            this.btn_dodaj.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_anuluj
            // 
            this.btn_anuluj.Location = new System.Drawing.Point(11, 197);
            this.btn_anuluj.Margin = new System.Windows.Forms.Padding(2);
            this.btn_anuluj.Name = "btn_anuluj";
            this.btn_anuluj.Size = new System.Drawing.Size(206, 28);
            this.btn_anuluj.TabIndex = 58;
            this.btn_anuluj.Text = "ANULUJ";
            this.btn_anuluj.UseVisualStyleBackColor = true;
            this.btn_anuluj.Click += new System.EventHandler(this.button1_Click);
            // 
            // lb_uzytkownicy
            // 
            this.lb_uzytkownicy.ContextMenuStrip = this.contextMenuStrip1;
            this.lb_uzytkownicy.FormattingEnabled = true;
            this.lb_uzytkownicy.Location = new System.Drawing.Point(232, 9);
            this.lb_uzytkownicy.Name = "lb_uzytkownicy";
            this.lb_uzytkownicy.Size = new System.Drawing.Size(161, 264);
            this.lb_uzytkownicy.TabIndex = 61;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zmieńToolStripMenuItem,
            this.usuńToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(109, 48);
            // 
            // zmieńToolStripMenuItem
            // 
            this.zmieńToolStripMenuItem.Name = "zmieńToolStripMenuItem";
            this.zmieńToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.zmieńToolStripMenuItem.Text = "Zmień";
            this.zmieńToolStripMenuItem.Click += new System.EventHandler(this.zmieńToolStripMenuItem_Click);
            // 
            // usuńToolStripMenuItem
            // 
            this.usuńToolStripMenuItem.Name = "usuńToolStripMenuItem";
            this.usuńToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.usuńToolStripMenuItem.Text = "Usuń";
            this.usuńToolStripMenuItem.Click += new System.EventHandler(this.usuńToolStripMenuItem_Click);
            // 
            // btn_usun
            // 
            this.btn_usun.Location = new System.Drawing.Point(11, 243);
            this.btn_usun.Margin = new System.Windows.Forms.Padding(2);
            this.btn_usun.Name = "btn_usun";
            this.btn_usun.Size = new System.Drawing.Size(206, 28);
            this.btn_usun.TabIndex = 62;
            this.btn_usun.Text = "USUŃ";
            this.btn_usun.UseVisualStyleBackColor = true;
            this.btn_usun.Click += new System.EventHandler(this.btn_usun_Click);
            // 
            // FormularzUzytkownik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 280);
            this.Controls.Add(this.btn_usun);
            this.Controls.Add(this.lb_uzytkownicy);
            this.Controls.Add(this.btn_zmien);
            this.Controls.Add(this.btn_dodaj);
            this.Controls.Add(this.btn_anuluj);
            this.Controls.Add(this.txt_nazwisko);
            this.Controls.Add(this.txt_imie);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormularzUzytkownik";
            this.Text = "FormularzUzytkownik";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_imie;
        private System.Windows.Forms.TextBox txt_nazwisko;
        private System.Windows.Forms.Button btn_zmien;
        private System.Windows.Forms.Button btn_dodaj;
        private System.Windows.Forms.Button btn_anuluj;
        private System.Windows.Forms.ListBox lb_uzytkownicy;
        private System.Windows.Forms.Button btn_usun;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem zmieńToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuńToolStripMenuItem;
    }
}