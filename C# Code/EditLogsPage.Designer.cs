namespace Tur_og_Retur___Kørsels_Logbog
{
    partial class EditLogsPage
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
            this.To_TextBox = new System.Windows.Forms.TextBox();
            this.From_TextBox = new System.Windows.Forms.TextBox();
            this.EditLog_Label = new System.Windows.Forms.Label();
            this.Fra_Label = new System.Windows.Forms.Label();
            this.Til_Label = new System.Windows.Forms.Label();
            this.GemLog_Button = new System.Windows.Forms.Button();
            this.BackArrow_PictureBox = new System.Windows.Forms.PictureBox();
            this.LogID_TextBox = new System.Windows.Forms.TextBox();
            this.UserID_TextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BackArrow_PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // To_TextBox
            // 
            this.To_TextBox.Location = new System.Drawing.Point(68, 139);
            this.To_TextBox.Name = "To_TextBox";
            this.To_TextBox.Size = new System.Drawing.Size(179, 20);
            this.To_TextBox.TabIndex = 14;
            // 
            // From_TextBox
            // 
            this.From_TextBox.Location = new System.Drawing.Point(68, 100);
            this.From_TextBox.Name = "From_TextBox";
            this.From_TextBox.Size = new System.Drawing.Size(179, 20);
            this.From_TextBox.TabIndex = 13;
            // 
            // EditLog_Label
            // 
            this.EditLog_Label.AutoSize = true;
            this.EditLog_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditLog_Label.Location = new System.Drawing.Point(202, 46);
            this.EditLog_Label.Name = "EditLog_Label";
            this.EditLog_Label.Size = new System.Drawing.Size(107, 20);
            this.EditLog_Label.TabIndex = 15;
            this.EditLog_Label.Text = "Rediger Log";
            // 
            // Fra_Label
            // 
            this.Fra_Label.AutoSize = true;
            this.Fra_Label.Location = new System.Drawing.Point(37, 103);
            this.Fra_Label.Name = "Fra_Label";
            this.Fra_Label.Size = new System.Drawing.Size(25, 13);
            this.Fra_Label.TabIndex = 16;
            this.Fra_Label.Text = "Fra:";
            this.Fra_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Til_Label
            // 
            this.Til_Label.AutoSize = true;
            this.Til_Label.Location = new System.Drawing.Point(41, 146);
            this.Til_Label.Name = "Til_Label";
            this.Til_Label.Size = new System.Drawing.Size(21, 13);
            this.Til_Label.TabIndex = 17;
            this.Til_Label.Text = "Til:";
            this.Til_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GemLog_Button
            // 
            this.GemLog_Button.ForeColor = System.Drawing.Color.Black;
            this.GemLog_Button.Location = new System.Drawing.Point(207, 192);
            this.GemLog_Button.Name = "GemLog_Button";
            this.GemLog_Button.Size = new System.Drawing.Size(96, 26);
            this.GemLog_Button.TabIndex = 18;
            this.GemLog_Button.Text = "Gem Ændringer";
            this.GemLog_Button.UseVisualStyleBackColor = true;
            this.GemLog_Button.Click += new System.EventHandler(this.GemLog_Button_Click);
            // 
            // BackArrow_PictureBox
            // 
            this.BackArrow_PictureBox.Image = global::Tur_og_Retur___Kørsels_Logbog.Properties.Resources.Back_Arrow;
            this.BackArrow_PictureBox.Location = new System.Drawing.Point(12, 12);
            this.BackArrow_PictureBox.Name = "BackArrow_PictureBox";
            this.BackArrow_PictureBox.Size = new System.Drawing.Size(20, 20);
            this.BackArrow_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BackArrow_PictureBox.TabIndex = 19;
            this.BackArrow_PictureBox.TabStop = false;
            this.BackArrow_PictureBox.Click += new System.EventHandler(this.BackArrow_PictureBox_Click);
            // 
            // LogID_TextBox
            // 
            this.LogID_TextBox.Location = new System.Drawing.Point(324, 139);
            this.LogID_TextBox.Name = "LogID_TextBox";
            this.LogID_TextBox.Size = new System.Drawing.Size(179, 20);
            this.LogID_TextBox.TabIndex = 21;
            // 
            // UserID_TextBox
            // 
            this.UserID_TextBox.Location = new System.Drawing.Point(324, 100);
            this.UserID_TextBox.Name = "UserID_TextBox";
            this.UserID_TextBox.Size = new System.Drawing.Size(179, 20);
            this.UserID_TextBox.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(263, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Bruger ID:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(276, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Log ID:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EditLogsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 259);
            this.Controls.Add(this.LogID_TextBox);
            this.Controls.Add(this.UserID_TextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.To_TextBox);
            this.Controls.Add(this.From_TextBox);
            this.Controls.Add(this.EditLog_Label);
            this.Controls.Add(this.Fra_Label);
            this.Controls.Add(this.Til_Label);
            this.Controls.Add(this.GemLog_Button);
            this.Controls.Add(this.BackArrow_PictureBox);
            this.Name = "EditLogsPage";
            this.Text = "EditLogsPage";
            ((System.ComponentModel.ISupportInitialize)(this.BackArrow_PictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox To_TextBox;
        private System.Windows.Forms.TextBox From_TextBox;
        private System.Windows.Forms.Label EditLog_Label;
        private System.Windows.Forms.Label Fra_Label;
        private System.Windows.Forms.Label Til_Label;
        private System.Windows.Forms.Button GemLog_Button;
        private System.Windows.Forms.PictureBox BackArrow_PictureBox;
        private System.Windows.Forms.TextBox LogID_TextBox;
        private System.Windows.Forms.TextBox UserID_TextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}