namespace Tur_og_Retur___Kørsels_Logbog
{
    partial class Login
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
            this.Login_Label = new System.Windows.Forms.Label();
            this.Brugernavn_Label = new System.Windows.Forms.Label();
            this.Password_Label = new System.Windows.Forms.Label();
            this.Login_Button = new System.Windows.Forms.Button();
            this.Username_TextBox = new System.Windows.Forms.TextBox();
            this.Password_TextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Login_Label
            // 
            this.Login_Label.AutoSize = true;
            this.Login_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_Label.Location = new System.Drawing.Point(165, 44);
            this.Login_Label.Name = "Login_Label";
            this.Login_Label.Size = new System.Drawing.Size(70, 20);
            this.Login_Label.TabIndex = 22;
            this.Login_Label.Text = "Log Ind";
            // 
            // Brugernavn_Label
            // 
            this.Brugernavn_Label.AutoSize = true;
            this.Brugernavn_Label.Location = new System.Drawing.Point(35, 109);
            this.Brugernavn_Label.Name = "Brugernavn_Label";
            this.Brugernavn_Label.Size = new System.Drawing.Size(65, 13);
            this.Brugernavn_Label.TabIndex = 23;
            this.Brugernavn_Label.Text = "Brugernavn:";
            this.Brugernavn_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Password_Label
            // 
            this.Password_Label.AutoSize = true;
            this.Password_Label.Location = new System.Drawing.Point(44, 148);
            this.Password_Label.Name = "Password_Label";
            this.Password_Label.Size = new System.Drawing.Size(56, 13);
            this.Password_Label.TabIndex = 24;
            this.Password_Label.Text = "Password:";
            this.Password_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Login_Button
            // 
            this.Login_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Login_Button.ForeColor = System.Drawing.Color.Black;
            this.Login_Button.Location = new System.Drawing.Point(158, 188);
            this.Login_Button.Name = "Login_Button";
            this.Login_Button.Size = new System.Drawing.Size(84, 26);
            this.Login_Button.TabIndex = 3;
            this.Login_Button.Text = "Login";
            this.Login_Button.UseVisualStyleBackColor = true;
            this.Login_Button.Click += new System.EventHandler(this.Login_Button_Click);
            // 
            // Username_TextBox
            // 
            this.Username_TextBox.Location = new System.Drawing.Point(111, 106);
            this.Username_TextBox.Name = "Username_TextBox";
            this.Username_TextBox.Size = new System.Drawing.Size(179, 20);
            this.Username_TextBox.TabIndex = 1;
            // 
            // Password_TextBox
            // 
            this.Password_TextBox.Location = new System.Drawing.Point(111, 145);
            this.Password_TextBox.Name = "Password_TextBox";
            this.Password_TextBox.Size = new System.Drawing.Size(179, 20);
            this.Password_TextBox.TabIndex = 2;
            this.Password_TextBox.UseSystemPasswordChar = true;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 275);
            this.Controls.Add(this.Login_Button);
            this.Controls.Add(this.Login_Label);
            this.Controls.Add(this.Brugernavn_Label);
            this.Controls.Add(this.Password_Label);
            this.Controls.Add(this.Username_TextBox);
            this.Controls.Add(this.Password_TextBox);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Login_Label;
        private System.Windows.Forms.Label Brugernavn_Label;
        private System.Windows.Forms.Label Password_Label;

        private System.Windows.Forms.Button Login_Button;
        private System.Windows.Forms.TextBox Username_TextBox;
        private System.Windows.Forms.TextBox Password_TextBox;
    }
}
