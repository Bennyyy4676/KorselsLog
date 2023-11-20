namespace Tur_og_Retur___Kørsels_Logbog
{
    partial class CreateNewLog
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
            this.From_TextBox = new System.Windows.Forms.TextBox();
            this.To_TextBox = new System.Windows.Forms.TextBox();
            this.NyLog_Label = new System.Windows.Forms.Label();
            this.Fra_Label = new System.Windows.Forms.Label();
            this.Til_Label = new System.Windows.Forms.Label();
            this.GemLog_Button = new System.Windows.Forms.Button();
            this.BackArrow_PictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.BackArrow_PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // From_TextBox
            // 
            this.From_TextBox.Location = new System.Drawing.Point(110, 108);
            this.From_TextBox.Name = "From_TextBox";
            this.From_TextBox.Size = new System.Drawing.Size(179, 20);
            this.From_TextBox.TabIndex = 1;
            // 
            // To_TextBox
            // 
            this.To_TextBox.Location = new System.Drawing.Point(110, 147);
            this.To_TextBox.Name = "To_TextBox";
            this.To_TextBox.Size = new System.Drawing.Size(179, 20);
            this.To_TextBox.TabIndex = 3;
            // 
            // NyLog_Label
            // 
            this.NyLog_Label.AutoSize = true;
            this.NyLog_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NyLog_Label.Location = new System.Drawing.Point(167, 44);
            this.NyLog_Label.Name = "NyLog_Label";
            this.NyLog_Label.Size = new System.Drawing.Size(64, 20);
            this.NyLog_Label.TabIndex = 7;
            this.NyLog_Label.Text = "Ny Log";
            // 
            // Fra_Label
            // 
            this.Fra_Label.AutoSize = true;
            this.Fra_Label.Location = new System.Drawing.Point(74, 111);
            this.Fra_Label.Name = "Fra_Label";
            this.Fra_Label.Size = new System.Drawing.Size(25, 13);
            this.Fra_Label.TabIndex = 8;
            this.Fra_Label.Text = "Fra:";
            this.Fra_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Til_Label
            // 
            this.Til_Label.AutoSize = true;
            this.Til_Label.Location = new System.Drawing.Point(74, 150);
            this.Til_Label.Name = "Til_Label";
            this.Til_Label.Size = new System.Drawing.Size(21, 13);
            this.Til_Label.TabIndex = 9;
            this.Til_Label.Text = "Til:";
            this.Til_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GemLog_Button
            // 
            this.GemLog_Button.ForeColor = System.Drawing.Color.Black;
            this.GemLog_Button.Location = new System.Drawing.Point(157, 193);
            this.GemLog_Button.Name = "GemLog_Button";
            this.GemLog_Button.Size = new System.Drawing.Size(84, 26);
            this.GemLog_Button.TabIndex = 10;
            this.GemLog_Button.Text = "Gem Log";
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
            this.BackArrow_PictureBox.TabIndex = 12;
            this.BackArrow_PictureBox.TabStop = false;
            this.BackArrow_PictureBox.Click += new System.EventHandler(this.BackArrow_PictureBox_Click);
            // 
            // CreateNewLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 275);
            this.Controls.Add(this.To_TextBox);
            this.Controls.Add(this.From_TextBox);
            this.Controls.Add(this.NyLog_Label);
            this.Controls.Add(this.Fra_Label);
            this.Controls.Add(this.Til_Label);
            this.Controls.Add(this.GemLog_Button);
            this.Controls.Add(this.BackArrow_PictureBox);
            this.Name = "CreateNewLog";
            this.Text = "Opret Log";
            ((System.ComponentModel.ISupportInitialize)(this.BackArrow_PictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox From_TextBox;
        private System.Windows.Forms.TextBox To_TextBox;
        private System.Windows.Forms.Label NyLog_Label;
        private System.Windows.Forms.Label Fra_Label;
        private System.Windows.Forms.Label Til_Label;
        private System.Windows.Forms.Button GemLog_Button;
        private System.Windows.Forms.PictureBox BackArrow_PictureBox;
    }
}
