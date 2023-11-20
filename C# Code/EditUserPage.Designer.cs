namespace Tur_og_Retur___Kørsels_Logbog
{
    partial class EditUserPage
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
            this.Username_Label = new System.Windows.Forms.Label();
            this.Username_TextBox = new System.Windows.Forms.TextBox();
            this.Save_Button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.UserID_TextBox = new System.Windows.Forms.TextBox();
            this.Logs_ListBox = new System.Windows.Forms.ListBox();
            this.EditKørselslog_Button = new System.Windows.Forms.Button();
            this.Add_Button = new System.Windows.Forms.Button();
            this.BackArrow_PictureBox = new System.Windows.Forms.PictureBox();
            this.DeleteUser_Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.BackArrow_PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // Username_Label
            // 
            this.Username_Label.AutoSize = true;
            this.Username_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.Username_Label.Location = new System.Drawing.Point(207, 20);
            this.Username_Label.Name = "Username_Label";
            this.Username_Label.Size = new System.Drawing.Size(66, 24);
            this.Username_Label.TabIndex = 3;
            this.Username_Label.Text = "label1";
            // 
            // Username_TextBox
            // 
            this.Username_TextBox.Location = new System.Drawing.Point(89, 77);
            this.Username_TextBox.Name = "Username_TextBox";
            this.Username_TextBox.Size = new System.Drawing.Size(198, 20);
            this.Username_TextBox.TabIndex = 0;
            // 
            // Save_Button
            // 
            this.Save_Button.Location = new System.Drawing.Point(349, 75);
            this.Save_Button.Name = "Save_Button";
            this.Save_Button.Size = new System.Drawing.Size(105, 23);
            this.Save_Button.TabIndex = 2;
            this.Save_Button.Text = "Gem Ændringer";
            this.Save_Button.UseVisualStyleBackColor = true;
            this.Save_Button.Click += new System.EventHandler(this.Save_Button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Brugernavn:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "BrugerID:";
            // 
            // UserID_TextBox
            // 
            this.UserID_TextBox.Location = new System.Drawing.Point(89, 118);
            this.UserID_TextBox.Name = "UserID_TextBox";
            this.UserID_TextBox.Size = new System.Drawing.Size(198, 20);
            this.UserID_TextBox.TabIndex = 1;
            // 
            // Logs_ListBox
            // 
            this.Logs_ListBox.FormattingEnabled = true;
            this.Logs_ListBox.Location = new System.Drawing.Point(25, 164);
            this.Logs_ListBox.Name = "Logs_ListBox";
            this.Logs_ListBox.Size = new System.Drawing.Size(293, 303);
            this.Logs_ListBox.TabIndex = 14;
            this.Logs_ListBox.SelectedIndexChanged += new System.EventHandler(this.Logs_ListBox_SelectedIndexChanged);
            // 
            // EditKørselslog_Button
            // 
            this.EditKørselslog_Button.Location = new System.Drawing.Point(349, 352);
            this.EditKørselslog_Button.Name = "EditKørselslog_Button";
            this.EditKørselslog_Button.Size = new System.Drawing.Size(105, 23);
            this.EditKørselslog_Button.TabIndex = 15;
            this.EditKørselslog_Button.Text = "Rediger Kørselslog";
            this.EditKørselslog_Button.UseVisualStyleBackColor = true;
            this.EditKørselslog_Button.Click += new System.EventHandler(this.EditKørselslog_Button_Click);
            // 
            // Add_Button
            // 
            this.Add_Button.Location = new System.Drawing.Point(349, 270);
            this.Add_Button.Name = "Add_Button";
            this.Add_Button.Size = new System.Drawing.Size(105, 23);
            this.Add_Button.TabIndex = 16;
            this.Add_Button.Text = "Tilføj Kørselslog";
            this.Add_Button.UseVisualStyleBackColor = true;
            this.Add_Button.Click += new System.EventHandler(this.Add_Button_Click);
            // 
            // BackArrow_PictureBox
            // 
            this.BackArrow_PictureBox.Image = global::Tur_og_Retur___Kørsels_Logbog.Properties.Resources.Back_Arrow;
            this.BackArrow_PictureBox.Location = new System.Drawing.Point(12, 12);
            this.BackArrow_PictureBox.Name = "BackArrow_PictureBox";
            this.BackArrow_PictureBox.Size = new System.Drawing.Size(20, 20);
            this.BackArrow_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BackArrow_PictureBox.TabIndex = 13;
            this.BackArrow_PictureBox.TabStop = false;
            this.BackArrow_PictureBox.Click += new System.EventHandler(this.BackArrow_PictureBox_Click);
            // 
            // DeleteUser_Button
            // 
            this.DeleteUser_Button.Location = new System.Drawing.Point(349, 116);
            this.DeleteUser_Button.Name = "DeleteUser_Button";
            this.DeleteUser_Button.Size = new System.Drawing.Size(105, 23);
            this.DeleteUser_Button.TabIndex = 17;
            this.DeleteUser_Button.Text = "Slet Bruger";
            this.DeleteUser_Button.UseVisualStyleBackColor = true;
            this.DeleteUser_Button.Click += new System.EventHandler(this.DeleteUser_Button_Click);
            // 
            // EditUserPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 479);
            this.Controls.Add(this.DeleteUser_Button);
            this.Controls.Add(this.Add_Button);
            this.Controls.Add(this.EditKørselslog_Button);
            this.Controls.Add(this.Logs_ListBox);
            this.Controls.Add(this.BackArrow_PictureBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.UserID_TextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Save_Button);
            this.Controls.Add(this.Username_TextBox);
            this.Controls.Add(this.Username_Label);
            this.Name = "EditUserPage";
            this.Text = "EditUserPage";
            ((System.ComponentModel.ISupportInitialize)(this.BackArrow_PictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Username_Label;
        private System.Windows.Forms.TextBox Username_TextBox;
        private System.Windows.Forms.Button Save_Button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox UserID_TextBox;
        private System.Windows.Forms.PictureBox BackArrow_PictureBox;
        private System.Windows.Forms.ListBox Logs_ListBox;
        private System.Windows.Forms.Button EditKørselslog_Button;
        private System.Windows.Forms.Button Add_Button;
        private System.Windows.Forms.Button DeleteUser_Button;
    }
}