
namespace ToDoList.Kontrolki
{
    partial class TasksControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("");
            this.lblTodoTitle = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblKreski = new System.Windows.Forms.Label();
            this.lblZalogowanyWartosc = new System.Windows.Forms.Label();
            this.lblZalogowny = new System.Windows.Forms.Label();
            this.btnWyloguj = new System.Windows.Forms.Button();
            this.lvZadania = new System.Windows.Forms.ListView();
            this.columnId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lblTodoTitle
            // 
            this.lblTodoTitle.AutoSize = true;
            this.lblTodoTitle.Font = new System.Drawing.Font("Monotype Corsiva", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTodoTitle.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.lblTodoTitle.Location = new System.Drawing.Point(3, 3);
            this.lblTodoTitle.Name = "lblTodoTitle";
            this.lblTodoTitle.Size = new System.Drawing.Size(149, 60);
            this.lblTodoTitle.TabIndex = 20;
            this.lblTodoTitle.Text = "TODO";
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Turquoise;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft JhengHei UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(422, 305);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(68, 220);
            this.btnEdit.TabIndex = 19;
            this.btnEdit.Text = "🖉";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Tomato;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft JhengHei UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(422, 531);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(68, 106);
            this.btnDelete.TabIndex = 18;
            this.btnDelete.Text = "🗑";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.LightGreen;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Maiandra GD", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(422, 89);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(68, 210);
            this.btnAdd.TabIndex = 17;
            this.btnAdd.Text = "➕";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblKreski
            // 
            this.lblKreski.AutoSize = true;
            this.lblKreski.Font = new System.Drawing.Font("Monotype Corsiva", 6F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKreski.Location = new System.Drawing.Point(1, 70);
            this.lblKreski.Name = "lblKreski";
            this.lblKreski.Size = new System.Drawing.Size(595, 13);
            this.lblKreski.TabIndex = 15;
            this.lblKreski.Text = "_________________________________________________________________________________" +
    "_________________";
            // 
            // lblZalogowanyWartosc
            // 
            this.lblZalogowanyWartosc.AutoSize = true;
            this.lblZalogowanyWartosc.Font = new System.Drawing.Font("Monotype Corsiva", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZalogowanyWartosc.Location = new System.Drawing.Point(304, 42);
            this.lblZalogowanyWartosc.Name = "lblZalogowanyWartosc";
            this.lblZalogowanyWartosc.Size = new System.Drawing.Size(100, 36);
            this.lblZalogowanyWartosc.TabIndex = 14;
            this.lblZalogowanyWartosc.Text = "Anonim";
            // 
            // lblZalogowny
            // 
            this.lblZalogowny.AutoSize = true;
            this.lblZalogowny.Font = new System.Drawing.Font("Monotype Corsiva", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZalogowny.Location = new System.Drawing.Point(147, 13);
            this.lblZalogowny.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblZalogowny.Name = "lblZalogowny";
            this.lblZalogowny.Size = new System.Drawing.Size(172, 29);
            this.lblZalogowny.TabIndex = 13;
            this.lblZalogowny.Text = "Zalogowany jako:";
            // 
            // btnWyloguj
            // 
            this.btnWyloguj.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnWyloguj.FlatAppearance.BorderSize = 0;
            this.btnWyloguj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWyloguj.Font = new System.Drawing.Font("Monotype Corsiva", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWyloguj.Location = new System.Drawing.Point(422, 13);
            this.btnWyloguj.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnWyloguj.Name = "btnWyloguj";
            this.btnWyloguj.Size = new System.Drawing.Size(68, 56);
            this.btnWyloguj.TabIndex = 12;
            this.btnWyloguj.Text = "🏃";
            this.btnWyloguj.UseVisualStyleBackColor = false;
            this.btnWyloguj.Click += new System.EventHandler(this.btnWyloguj_Click);
            // 
            // lvZadania
            // 
            this.lvZadania.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lvZadania.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnId,
            this.columnTitle,
            this.columnDone});
            this.lvZadania.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvZadania.FullRowSelect = true;
            this.lvZadania.GridLines = true;
            this.lvZadania.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvZadania.HideSelection = false;
            this.lvZadania.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem4});
            this.lvZadania.Location = new System.Drawing.Point(13, 90);
            this.lvZadania.MultiSelect = false;
            this.lvZadania.Name = "lvZadania";
            this.lvZadania.ShowGroups = false;
            this.lvZadania.Size = new System.Drawing.Size(403, 548);
            this.lvZadania.TabIndex = 21;
            this.lvZadania.UseCompatibleStateImageBehavior = false;
            this.lvZadania.View = System.Windows.Forms.View.Details;
            // 
            // columnId
            // 
            this.columnId.Text = "Id";
            this.columnId.Width = 42;
            // 
            // columnTitle
            // 
            this.columnTitle.Text = "Tytuł";
            this.columnTitle.Width = 230;
            // 
            // columnDone
            // 
            this.columnDone.Text = "Czy zrobione?";
            this.columnDone.Width = 125;
            // 
            // TasksControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.Controls.Add(this.lvZadania);
            this.Controls.Add(this.lblTodoTitle);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblKreski);
            this.Controls.Add(this.lblZalogowanyWartosc);
            this.Controls.Add(this.lblZalogowny);
            this.Controls.Add(this.btnWyloguj);
            this.Name = "TasksControl";
            this.Size = new System.Drawing.Size(500, 640);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTodoTitle;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblKreski;
        private System.Windows.Forms.Label lblZalogowanyWartosc;
        private System.Windows.Forms.Label lblZalogowny;
        private System.Windows.Forms.Button btnWyloguj;
        private System.Windows.Forms.ListView lvZadania;
        private System.Windows.Forms.ColumnHeader columnId;
        private System.Windows.Forms.ColumnHeader columnTitle;
        private System.Windows.Forms.ColumnHeader columnDone;
    }
}
