namespace Tur_og_Retur___Kørsels_Logbog
{
    partial class CreateNewUser
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
            this.Password_TextBox = new System.Windows.Forms.TextBox();
            this.Username_TextBox = new System.Windows.Forms.TextBox();
            this.NyBruger_Label = new System.Windows.Forms.Label();
            this.Username_Label = new System.Windows.Forms.Label();
            this.Password_Label = new System.Windows.Forms.Label();
            this.SaveUser_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Password_TextBox
            // 
            this.Password_TextBox.Location = new System.Drawing.Point(112, 122);
            this.Password_TextBox.Name = "Password_TextBox";
            this.Password_TextBox.Size = new System.Drawing.Size(179, 20);
            this.Password_TextBox.TabIndex = 14;
            // 
            // Username_TextBox
            // 
            this.Username_TextBox.Location = new System.Drawing.Point(112, 81);
            this.Username_TextBox.Name = "Username_TextBox";
            this.Username_TextBox.Size = new System.Drawing.Size(179, 20);
            this.Username_TextBox.TabIndex = 13;
            // 
            // NyBruger_Label
            // 
            this.NyBruger_Label.AutoSize = true;
            this.NyBruger_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NyBruger_Label.Location = new System.Drawing.Point(145, 36);
            this.NyBruger_Label.Name = "NyBruger_Label";
            this.NyBruger_Label.Size = new System.Drawing.Size(113, 20);
            this.NyBruger_Label.TabIndex = 15;
            this.NyBruger_Label.Text = "Opret Bruger";
            // 
            // Username_Label
            // 
            this.Username_Label.AutoSize = true;
            this.Username_Label.Location = new System.Drawing.Point(41, 84);
            this.Username_Label.Name = "Username_Label";
            this.Username_Label.Size = new System.Drawing.Size(65, 13);
            this.Username_Label.TabIndex = 16;
            this.Username_Label.Text = "Brugernavn:";
            this.Username_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Password_Label
            // 
            this.Password_Label.AutoSize = true;
            this.Password_Label.Location = new System.Drawing.Point(51, 125);
            this.Password_Label.Name = "Password_Label";
            this.Password_Label.Size = new System.Drawing.Size(56, 13);
            this.Password_Label.TabIndex = 17;
            this.Password_Label.Text = "Password:";
            this.Password_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SaveUser_Button
            // 
            this.SaveUser_Button.ForeColor = System.Drawing.Color.Black;
            this.SaveUser_Button.Location = new System.Drawing.Point(159, 168);
            this.SaveUser_Button.Name = "SaveUser_Button";
            this.SaveUser_Button.Size = new System.Drawing.Size(84, 26);
            this.SaveUser_Button.TabIndex = 18;
            this.SaveUser_Button.Text = "Gem Bruger";
            this.SaveUser_Button.UseVisualStyleBackColor = true;
            this.SaveUser_Button.Click += new System.EventHandler(this.SaveUser_Button_Click);
            // 
            // CreateNewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 218);
            this.Controls.Add(this.Password_TextBox);
            this.Controls.Add(this.Username_TextBox);
            this.Controls.Add(this.NyBruger_Label);
            this.Controls.Add(this.Username_Label);
            this.Controls.Add(this.Password_Label);
            this.Controls.Add(this.SaveUser_Button);
            this.Name = "CreateNewUser";
            this.Text = "CreateNewUser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Password_TextBox;
        private System.Windows.Forms.TextBox Username_TextBox;
        private System.Windows.Forms.Label NyBruger_Label;
        private System.Windows.Forms.Label Username_Label;
        private System.Windows.Forms.Label Password_Label;
        private System.Windows.Forms.Button SaveUser_Button;
    }
}