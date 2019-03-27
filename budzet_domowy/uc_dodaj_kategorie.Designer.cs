namespace budzet_domowy
{
    partial class uc_dodaj_kategorię
    {
        /// <summary> 
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_anuluj = new System.Windows.Forms.Button();
            this.txt_tekst = new System.Windows.Forms.TextBox();
            this.btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_anuluj
            // 
            this.btn_anuluj.Location = new System.Drawing.Point(101, 4);
            this.btn_anuluj.Name = "btn_anuluj";
            this.btn_anuluj.Size = new System.Drawing.Size(20, 20);
            this.btn_anuluj.TabIndex = 7;
            this.btn_anuluj.Text = "X";
            this.btn_anuluj.UseVisualStyleBackColor = true;
            this.btn_anuluj.Click += new System.EventHandler(this.btn_anuluj_Click);
            // 
            // txt_tekst
            // 
            this.txt_tekst.Location = new System.Drawing.Point(7, 36);
            this.txt_tekst.Name = "txt_tekst";
            this.txt_tekst.Size = new System.Drawing.Size(114, 20);
            this.txt_tekst.TabIndex = 6;
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(7, 62);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(114, 23);
            this.btn.TabIndex = 5;
            this.btn.UseVisualStyleBackColor = false;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nazwa kategorii";
            // 
            // uc_dodaj_kategorię
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_anuluj);
            this.Controls.Add(this.txt_tekst);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.label1);
            this.Name = "uc_dodaj_kategorię";
            this.Size = new System.Drawing.Size(130, 101);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_anuluj;
        private System.Windows.Forms.TextBox txt_tekst;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.Label label1;
    }
}
