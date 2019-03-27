namespace budzet_domowy
{
    partial class FormualrzGlowny
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

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.userListView1 = new budzet_domowy.Views.UserListView();
            this.categoryListView2 = new budzet_domowy.Views.CategoryListView();
            this.operationListView = new budzet_domowy.Views.OperationListView();
            this.categoryListView = new budzet_domowy.Views.CategoryListView();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(76, 66);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(216, 97);
            this.button1.TabIndex = 0;
            this.button1.Text = "User";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(76, 206);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(216, 93);
            this.button2.TabIndex = 1;
            this.button2.Text = "Category";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(76, 345);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(216, 93);
            this.button3.TabIndex = 2;
            this.button3.Text = "Operation";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // userListView1
            // 
            this.userListView1.Location = new System.Drawing.Point(394, 28);
            this.userListView1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.userListView1.Name = "userListView1";
            this.userListView1.Size = new System.Drawing.Size(942, 508);
            this.userListView1.TabIndex = 4;
            // 
            // categoryListView2
            // 
            this.categoryListView2.Location = new System.Drawing.Point(662, 218);
            this.categoryListView2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.categoryListView2.Name = "categoryListView2";
            this.categoryListView2.Size = new System.Drawing.Size(24, 8);
            this.categoryListView2.TabIndex = 6;
            // 
            // operationListView
            // 
            this.operationListView.Location = new System.Drawing.Point(556, 20);
            this.operationListView.Margin = new System.Windows.Forms.Padding(9, 6, 9, 6);
            this.operationListView.Name = "operationListView";
            this.operationListView.Size = new System.Drawing.Size(1778, 786);
            this.operationListView.TabIndex = 5;
            // 
            // categoryListView
            // 
            this.categoryListView.Location = new System.Drawing.Point(556, 46);
            this.categoryListView.Margin = new System.Windows.Forms.Padding(9, 6, 9, 6);
            this.categoryListView.Name = "categoryListView";
            this.categoryListView.Size = new System.Drawing.Size(1477, 722);
            this.categoryListView.TabIndex = 7;
            // 
            // FormualrzGlowny
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1355, 580);
            this.Controls.Add(this.categoryListView);
            this.Controls.Add(this.categoryListView2);
            this.Controls.Add(this.operationListView);
            this.Controls.Add(this.userListView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "FormualrzGlowny";
            this.Text = "Category";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private Views.UserListView userListView1;
        private Views.CategoryListView categoryListView2;
        private Views.OperationListView operationListView;
        private Views.CategoryListView categoryListView;
    }
}

