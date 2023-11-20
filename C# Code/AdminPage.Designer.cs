namespace Tur_og_Retur___Kørsels_Logbog
{
    partial class AdminPage
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
            this.ListBox = new System.Windows.Forms.ListBox();
            this.Users_Button = new System.Windows.Forms.Button();
            this.Logs_Button = new System.Windows.Forms.Button();
            this.EditProfile_Button = new System.Windows.Forms.Button();
            this.AddUser_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ListBox
            // 
            this.ListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.75F);
            this.ListBox.FormattingEnabled = true;
            this.ListBox.ItemHeight = 17;
            this.ListBox.Location = new System.Drawing.Point(266, 11);
            this.ListBox.Margin = new System.Windows.Forms.Padding(5);
            this.ListBox.Name = "ListBox";
            this.ListBox.Size = new System.Drawing.Size(373, 327);
            this.ListBox.TabIndex = 0;
            this.ListBox.SelectedIndexChanged += new System.EventHandler(this.ListBox_SelectedIndexChanged);
            // 
            // Users_Button
            // 
            this.Users_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.Users_Button.Location = new System.Drawing.Point(57, 75);
            this.Users_Button.Name = "Users_Button";
            this.Users_Button.Size = new System.Drawing.Size(146, 28);
            this.Users_Button.TabIndex = 1;
            this.Users_Button.Text = "Brugere";
            this.Users_Button.UseVisualStyleBackColor = true;
            this.Users_Button.Click += new System.EventHandler(this.Users_Button_Click);
            // 
            // Logs_Button
            // 
            this.Logs_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.Logs_Button.Location = new System.Drawing.Point(57, 160);
            this.Logs_Button.Name = "Logs_Button";
            this.Logs_Button.Size = new System.Drawing.Size(146, 28);
            this.Logs_Button.TabIndex = 2;
            this.Logs_Button.Text = "Alle Logs";
            this.Logs_Button.UseVisualStyleBackColor = true;
            this.Logs_Button.Click += new System.EventHandler(this.Logs_Button_Click);
            // 
            // EditProfile_Button
            // 
            this.EditProfile_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.EditProfile_Button.Location = new System.Drawing.Point(57, 248);
            this.EditProfile_Button.Name = "EditProfile_Button";
            this.EditProfile_Button.Size = new System.Drawing.Size(146, 28);
            this.EditProfile_Button.TabIndex = 5;
            this.EditProfile_Button.Text = "Rediger Bruger";
            this.EditProfile_Button.UseVisualStyleBackColor = true;
            this.EditProfile_Button.Visible = false;
            this.EditProfile_Button.Click += new System.EventHandler(this.EditProfile_Button_Click);
            // 
            // AddUser_Button
            // 
            this.AddUser_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.AddUser_Button.Location = new System.Drawing.Point(57, 248);
            this.AddUser_Button.Name = "AddUser_Button";
            this.AddUser_Button.Size = new System.Drawing.Size(146, 28);
            this.AddUser_Button.TabIndex = 6;
            this.AddUser_Button.Text = "Opret Bruger";
            this.AddUser_Button.UseVisualStyleBackColor = true;
            this.AddUser_Button.Click += new System.EventHandler(this.AddUser_Button_Click);
            // 
            // AdminPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 349);
            this.Controls.Add(this.Logs_Button);
            this.Controls.Add(this.Users_Button);
            this.Controls.Add(this.ListBox);
            this.Controls.Add(this.EditProfile_Button);
            this.Controls.Add(this.AddUser_Button);
            this.Name = "AdminPage";
            this.Text = "AdminPage";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox ListBox;
        private System.Windows.Forms.Button Users_Button;
        private System.Windows.Forms.Button Logs_Button;
        private System.Windows.Forms.Button EditProfile_Button;
        private System.Windows.Forms.Button AddUser_Button;
    }
}