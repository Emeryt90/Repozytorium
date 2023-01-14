
namespace ToDoList.Kontrolki
{
    partial class RegisterControl
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
            this.groupBoxUserData = new System.Windows.Forms.GroupBox();
            this.tbPowtorzHaslo = new System.Windows.Forms.TextBox();
            this.lblPasswordValidation = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblLoginValidation = new System.Windows.Forms.Label();
            this.lblHaslo = new System.Windows.Forms.Label();
            this.lblRepeatPasswordValidation = new System.Windows.Forms.Label();
            this.lblPowtorzHaslo = new System.Windows.Forms.Label();
            this.lblNameValidation = new System.Windows.Forms.Label();
            this.lblImie = new System.Windows.Forms.Label();
            this.tbImie = new System.Windows.Forms.TextBox();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.tbHaslo = new System.Windows.Forms.TextBox();
            this.btnZarejestruj = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnCofnij = new System.Windows.Forms.Button();
            this.groupBoxUserData.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxUserData
            // 
            this.groupBoxUserData.Controls.Add(this.tbPowtorzHaslo);
            this.groupBoxUserData.Controls.Add(this.lblPasswordValidation);
            this.groupBoxUserData.Controls.Add(this.lblLogin);
            this.groupBoxUserData.Controls.Add(this.lblLoginValidation);
            this.groupBoxUserData.Controls.Add(this.lblHaslo);
            this.groupBoxUserData.Controls.Add(this.lblRepeatPasswordValidation);
            this.groupBoxUserData.Controls.Add(this.lblPowtorzHaslo);
            this.groupBoxUserData.Controls.Add(this.lblNameValidation);
            this.groupBoxUserData.Controls.Add(this.lblImie);
            this.groupBoxUserData.Controls.Add(this.tbImie);
            this.groupBoxUserData.Controls.Add(this.tbLogin);
            this.groupBoxUserData.Controls.Add(this.tbHaslo);
            this.groupBoxUserData.Font = new System.Drawing.Font("Monotype Corsiva", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxUserData.Location = new System.Drawing.Point(26, 114);
            this.groupBoxUserData.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxUserData.Name = "groupBoxUserData";
            this.groupBoxUserData.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxUserData.Size = new System.Drawing.Size(460, 430);
            this.groupBoxUserData.TabIndex = 14;
            this.groupBoxUserData.TabStop = false;
            this.groupBoxUserData.Text = "Dane nowego użytkownika";
            // 
            // tbPowtorzHaslo
            // 
            this.tbPowtorzHaslo.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPowtorzHaslo.Location = new System.Drawing.Point(224, 336);
            this.tbPowtorzHaslo.Margin = new System.Windows.Forms.Padding(4);
            this.tbPowtorzHaslo.Name = "tbPowtorzHaslo";
            this.tbPowtorzHaslo.PasswordChar = '*';
            this.tbPowtorzHaslo.Size = new System.Drawing.Size(220, 41);
            this.tbPowtorzHaslo.TabIndex = 7;
            // 
            // lblPasswordValidation
            // 
            this.lblPasswordValidation.AutoEllipsis = true;
            this.lblPasswordValidation.AutoSize = true;
            this.lblPasswordValidation.Font = new System.Drawing.Font("Monotype Corsiva", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasswordValidation.ForeColor = System.Drawing.Color.Red;
            this.lblPasswordValidation.Location = new System.Drawing.Point(218, 280);
            this.lblPasswordValidation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPasswordValidation.Name = "lblPasswordValidation";
            this.lblPasswordValidation.Size = new System.Drawing.Size(197, 29);
            this.lblPasswordValidation.TabIndex = 9;
            this.lblPasswordValidation.Text = "Labelka na walidacje";
            this.lblPasswordValidation.Visible = false;
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.Location = new System.Drawing.Point(100, 124);
            this.lblLogin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(87, 37);
            this.lblLogin.TabIndex = 3;
            this.lblLogin.Text = "Login:";
            // 
            // lblLoginValidation
            // 
            this.lblLoginValidation.AutoEllipsis = true;
            this.lblLoginValidation.AutoSize = true;
            this.lblLoginValidation.Font = new System.Drawing.Font("Monotype Corsiva", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginValidation.ForeColor = System.Drawing.Color.Red;
            this.lblLoginValidation.Location = new System.Drawing.Point(218, 175);
            this.lblLoginValidation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLoginValidation.Name = "lblLoginValidation";
            this.lblLoginValidation.Size = new System.Drawing.Size(197, 29);
            this.lblLoginValidation.TabIndex = 9;
            this.lblLoginValidation.Text = "Labelka na walidacje";
            this.lblLoginValidation.Visible = false;
            // 
            // lblHaslo
            // 
            this.lblHaslo.AutoSize = true;
            this.lblHaslo.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHaslo.Location = new System.Drawing.Point(100, 231);
            this.lblHaslo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHaslo.Name = "lblHaslo";
            this.lblHaslo.Size = new System.Drawing.Size(89, 37);
            this.lblHaslo.TabIndex = 4;
            this.lblHaslo.Text = "Hasło:";
            // 
            // lblRepeatPasswordValidation
            // 
            this.lblRepeatPasswordValidation.AutoEllipsis = true;
            this.lblRepeatPasswordValidation.AutoSize = true;
            this.lblRepeatPasswordValidation.Font = new System.Drawing.Font("Monotype Corsiva", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRepeatPasswordValidation.ForeColor = System.Drawing.Color.Red;
            this.lblRepeatPasswordValidation.Location = new System.Drawing.Point(218, 385);
            this.lblRepeatPasswordValidation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRepeatPasswordValidation.Name = "lblRepeatPasswordValidation";
            this.lblRepeatPasswordValidation.Size = new System.Drawing.Size(197, 29);
            this.lblRepeatPasswordValidation.TabIndex = 9;
            this.lblRepeatPasswordValidation.Text = "Labelka na walidacje";
            this.lblRepeatPasswordValidation.Visible = false;
            // 
            // lblPowtorzHaslo
            // 
            this.lblPowtorzHaslo.AutoSize = true;
            this.lblPowtorzHaslo.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPowtorzHaslo.Location = new System.Drawing.Point(8, 339);
            this.lblPowtorzHaslo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPowtorzHaslo.Name = "lblPowtorzHaslo";
            this.lblPowtorzHaslo.Size = new System.Drawing.Size(181, 37);
            this.lblPowtorzHaslo.TabIndex = 4;
            this.lblPowtorzHaslo.Text = "Powtórz hasło:";
            // 
            // lblNameValidation
            // 
            this.lblNameValidation.AutoEllipsis = true;
            this.lblNameValidation.AutoSize = true;
            this.lblNameValidation.Font = new System.Drawing.Font("Monotype Corsiva", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameValidation.ForeColor = System.Drawing.Color.Red;
            this.lblNameValidation.Location = new System.Drawing.Point(218, 76);
            this.lblNameValidation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNameValidation.Name = "lblNameValidation";
            this.lblNameValidation.Size = new System.Drawing.Size(197, 29);
            this.lblNameValidation.TabIndex = 8;
            this.lblNameValidation.Text = "Labelka na walidacje";
            this.lblNameValidation.Visible = false;
            // 
            // lblImie
            // 
            this.lblImie.AutoSize = true;
            this.lblImie.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImie.Location = new System.Drawing.Point(115, 27);
            this.lblImie.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblImie.Name = "lblImie";
            this.lblImie.Size = new System.Drawing.Size(72, 37);
            this.lblImie.TabIndex = 4;
            this.lblImie.Text = "Imię:";
            // 
            // tbImie
            // 
            this.tbImie.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbImie.Location = new System.Drawing.Point(223, 24);
            this.tbImie.Margin = new System.Windows.Forms.Padding(4);
            this.tbImie.Name = "tbImie";
            this.tbImie.Size = new System.Drawing.Size(220, 41);
            this.tbImie.TabIndex = 7;
            // 
            // tbLogin
            // 
            this.tbLogin.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLogin.Location = new System.Drawing.Point(224, 125);
            this.tbLogin.Margin = new System.Windows.Forms.Padding(4);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(220, 41);
            this.tbLogin.TabIndex = 6;
            // 
            // tbHaslo
            // 
            this.tbHaslo.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbHaslo.Location = new System.Drawing.Point(224, 231);
            this.tbHaslo.Margin = new System.Windows.Forms.Padding(4);
            this.tbHaslo.Name = "tbHaslo";
            this.tbHaslo.PasswordChar = '*';
            this.tbHaslo.Size = new System.Drawing.Size(220, 41);
            this.tbHaslo.TabIndex = 7;
            // 
            // btnZarejestruj
            // 
            this.btnZarejestruj.BackColor = System.Drawing.Color.LightGreen;
            this.btnZarejestruj.FlatAppearance.BorderSize = 0;
            this.btnZarejestruj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZarejestruj.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZarejestruj.Location = new System.Drawing.Point(77, 552);
            this.btnZarejestruj.Margin = new System.Windows.Forms.Padding(4);
            this.btnZarejestruj.Name = "btnZarejestruj";
            this.btnZarejestruj.Size = new System.Drawing.Size(353, 76);
            this.btnZarejestruj.TabIndex = 13;
            this.btnZarejestruj.Text = "Zarejestruj";
            this.btnZarejestruj.UseVisualStyleBackColor = false;
            this.btnZarejestruj.Click += new System.EventHandler(this.btnZarejestruj_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Monotype Corsiva", 40F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(166, 16);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(303, 82);
            this.lblTitle.TabIndex = 12;
            this.lblTitle.Text = "Rejestracja";
            // 
            // btnCofnij
            // 
            this.btnCofnij.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnCofnij.FlatAppearance.BorderSize = 0;
            this.btnCofnij.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCofnij.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCofnij.Location = new System.Drawing.Point(26, 16);
            this.btnCofnij.Margin = new System.Windows.Forms.Padding(4);
            this.btnCofnij.Name = "btnCofnij";
            this.btnCofnij.Size = new System.Drawing.Size(95, 82);
            this.btnCofnij.TabIndex = 11;
            this.btnCofnij.Text = "🢨";
            this.btnCofnij.UseVisualStyleBackColor = false;
            this.btnCofnij.Click += new System.EventHandler(this.btnCofnij_Click);
            // 
            // RegisterControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.Controls.Add(this.groupBoxUserData);
            this.Controls.Add(this.btnZarejestruj);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnCofnij);
            this.Name = "RegisterControl";
            this.Size = new System.Drawing.Size(500, 640);
            this.groupBoxUserData.ResumeLayout(false);
            this.groupBoxUserData.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxUserData;
        private System.Windows.Forms.TextBox tbPowtorzHaslo;
        private System.Windows.Forms.Label lblPasswordValidation;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblLoginValidation;
        private System.Windows.Forms.Label lblHaslo;
        private System.Windows.Forms.Label lblRepeatPasswordValidation;
        private System.Windows.Forms.Label lblPowtorzHaslo;
        private System.Windows.Forms.Label lblNameValidation;
        private System.Windows.Forms.Label lblImie;
        private System.Windows.Forms.TextBox tbImie;
        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.TextBox tbHaslo;
        private System.Windows.Forms.Button btnZarejestruj;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnCofnij;
    }
}
