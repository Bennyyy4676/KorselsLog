namespace Tur_og_Retur___Kørsels_Logbog
{
    partial class HomePage
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
            this.Kørselslog_Label = new System.Windows.Forms.Label();
            this.OpretNyLog_Button = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ProfileAvatar_PictureBox = new System.Windows.Forms.PictureBox();
            this.DineLogs_Label = new System.Windows.Forms.Label();
            this.YourLogs_ListView = new System.Windows.Forms.ListView();
            this.Hello_Label = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProfileAvatar_PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // Kørselslog_Label
            // 
            this.Kørselslog_Label.AutoSize = true;
            this.Kørselslog_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Kørselslog_Label.ForeColor = System.Drawing.Color.Black;
            this.Kørselslog_Label.Location = new System.Drawing.Point(62, 39);
            this.Kørselslog_Label.Name = "Kørselslog_Label";
            this.Kørselslog_Label.Size = new System.Drawing.Size(89, 18);
            this.Kørselslog_Label.TabIndex = 3;
            this.Kørselslog_Label.Text = "Kørselslog";
            this.Kørselslog_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OpretNyLog_Button
            // 
            this.OpretNyLog_Button.ForeColor = System.Drawing.Color.Black;
            this.OpretNyLog_Button.Location = new System.Drawing.Point(17, 29);
            this.OpretNyLog_Button.Name = "OpretNyLog_Button";
            this.OpretNyLog_Button.Size = new System.Drawing.Size(84, 26);
            this.OpretNyLog_Button.TabIndex = 0;
            this.OpretNyLog_Button.Text = "Opret Ny Log";
            this.OpretNyLog_Button.UseVisualStyleBackColor = true;
            this.OpretNyLog_Button.Click += new System.EventHandler(this.OpretNyLog_Button_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.OpretNyLog_Button);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(12, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(198, 241);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "l";
            // 
            // ProfileAvatar_PictureBox
            // 
            this.ProfileAvatar_PictureBox.Image = global::Tur_og_Retur___Kørsels_Logbog.Properties.Resources.Avatar_Profile_Picture;
            this.ProfileAvatar_PictureBox.Location = new System.Drawing.Point(522, 9);
            this.ProfileAvatar_PictureBox.Name = "ProfileAvatar_PictureBox";
            this.ProfileAvatar_PictureBox.Size = new System.Drawing.Size(25, 25);
            this.ProfileAvatar_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ProfileAvatar_PictureBox.TabIndex = 1;
            this.ProfileAvatar_PictureBox.TabStop = false;
            this.ProfileAvatar_PictureBox.Click += new System.EventHandler(this.ProfileAvatar_PictureBox_Click);
            // 
            // DineLogs_Label
            // 
            this.DineLogs_Label.AutoSize = true;
            this.DineLogs_Label.BackColor = System.Drawing.Color.Transparent;
            this.DineLogs_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DineLogs_Label.ForeColor = System.Drawing.Color.Black;
            this.DineLogs_Label.Location = new System.Drawing.Point(339, 39);
            this.DineLogs_Label.Name = "DineLogs_Label";
            this.DineLogs_Label.Size = new System.Drawing.Size(84, 18);
            this.DineLogs_Label.TabIndex = 2;
            this.DineLogs_Label.Text = "Dine Logs";
            this.DineLogs_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // YourLogs_ListView
            // 
            this.YourLogs_ListView.BackColor = System.Drawing.SystemColors.Control;
            this.YourLogs_ListView.GridLines = true;
            this.YourLogs_ListView.HideSelection = false;
            this.YourLogs_ListView.Location = new System.Drawing.Point(216, 62);
            this.YourLogs_ListView.Name = "YourLogs_ListView";
            this.YourLogs_ListView.Size = new System.Drawing.Size(331, 235);
            this.YourLogs_ListView.TabIndex = 3;
            this.YourLogs_ListView.UseCompatibleStateImageBehavior = false;
            this.YourLogs_ListView.View = System.Windows.Forms.View.Details;
            // 
            // Hello_Label
            // 
            this.Hello_Label.AutoSize = true;
            this.Hello_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.Hello_Label.ForeColor = System.Drawing.Color.Black;
            this.Hello_Label.Location = new System.Drawing.Point(12, 12);
            this.Hello_Label.Name = "Hello_Label";
            this.Hello_Label.Size = new System.Drawing.Size(42, 18);
            this.Hello_Label.TabIndex = 6;
            this.Hello_Label.Text = "Hello";
            this.Hello_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 307);
            this.Controls.Add(this.Kørselslog_Label);
            this.Controls.Add(this.DineLogs_Label);
            this.Controls.Add(this.YourLogs_ListView);
            this.Controls.Add(this.Hello_Label);
            this.Controls.Add(this.ProfileAvatar_PictureBox);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Name = "HomePage";
            this.Text = "Home";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ProfileAvatar_PictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Kørselslog_Label;
        private System.Windows.Forms.Button OpretNyLog_Button;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox ProfileAvatar_PictureBox;
        private System.Windows.Forms.Label DineLogs_Label;
        private System.Windows.Forms.ListView YourLogs_ListView;
        private System.Windows.Forms.Label Hello_Label;
    }
}

