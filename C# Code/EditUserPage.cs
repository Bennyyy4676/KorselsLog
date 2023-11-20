using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tur_og_Retur___Kørsels_Logbog
{
    public partial class EditUserPage : Form
    {
        public EditUserPage()
        {
            InitializeComponent();
            PopulateListbox();

            Username_Label.Text = Variables.Username;
            Username_TextBox.Text = Variables.Username;
            UserID_TextBox.Text = Variables.UserID.ToString();
        }

        private void Add_Button_Click(object sender, EventArgs e)
        {
            Forms.NewLogPage();
            Hide();
        }

        private void EditKørselslog_Button_Click(object sender, EventArgs e)
        {
            if (Variables.LogSelectedItemLogId != null)
            {
                Forms.EditLogsPage();
                Hide();
            }
        }

        private void DeleteUser_Button_Click(object sender, EventArgs e)
        {
            string deleteQuery = "DELETE FROM Users WHERE UserID = @userId";

            using (SqlConnection sqlConn = new SqlConnection(@"Data Source=WIN-ACDDOS57HEI\MSSQLSERVER01;Initial Catalog=Kørselslog;Integrated Security=True"))
            {
                sqlConn.Open();

                SqlCommand command = new SqlCommand(deleteQuery, sqlConn);
                command.Parameters.AddWithValue("@userID", Variables.UserID);

                DialogResult dialogResult = MessageBox.Show("Er du sikker på du vil slette denne bruger?", "Slet Bruger", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    command.ExecuteNonQuery();

                    Forms.AdminPage();
                    Hide();
                }
            }
        }

        private void Save_Button_Click(object sender, EventArgs e)
        {
            string updateQuery = "UPDATE Users SET Username = @newUsername, UserID = @newUserID WHERE UserID = @userID";

            using (SqlConnection sqlConn = new SqlConnection(@"Data Source=WIN-ACDDOS57HEI\MSSQLSERVER01;Initial Catalog=Kørselslog;Integrated Security=True"))
            {
                sqlConn.Open();

                SqlCommand command = new SqlCommand(updateQuery, sqlConn);
                command.Parameters.AddWithValue("@newUsername", Username_TextBox.Text);
                command.Parameters.AddWithValue("@newUserID", UserID_TextBox.Text);
                command.Parameters.AddWithValue("@userID", Variables.UserID);

                if (Global.GetUsernameList().Contains(Username_TextBox.Text))
                {
                    if (Username_TextBox.Text == Variables.Username)
                    {
                        goto label1;
                    }
                    else
                    {
                        MessageBox.Show("Brugernavn eksisterer allerede");
                        Username_TextBox.Focus();

                        return;
                    }
                }

                label1:
                if (Global.GetUserIdList().Contains(Convert.ToInt32(UserID_TextBox.Text)))
                {
                    if (Convert.ToInt32(UserID_TextBox.Text) == Variables.UserID)
                    {
                        command.ExecuteNonQuery();

                        MessageBox.Show("Ændringerne er blevet fuldført");
                        Forms.AdminPage();
                        Hide();
                    }
                    else
                    {
                        MessageBox.Show("Bruger-ID eksisterer allerede");
                        UserID_TextBox.Focus();
                    }
                }
                else
                {
                    command.ExecuteNonQuery();

                    MessageBox.Show("Ændringerne er blevet fuldført");
                    Forms.AdminPage();
                    Hide();
                }
            }
        }

        private void Logs_ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Logs_ListBox.SelectedItems.Count > 0)
            {
                string selectedLog = Logs_ListBox.SelectedItem.ToString();

                Variables.LogSelectedItemFrom = Global.ExtractFrom(selectedLog);
                Variables.LogSelectedItemTo = Global.ExtractTo(selectedLog);
                Variables.LogSelectedItemLogId = Global.ExtractLogID(selectedLog).ToString();
            }
        }

        private void BackArrow_PictureBox_Click(object sender, EventArgs e)
        {
            Forms.AdminPage();
            Hide();
        }

        private void PopulateListbox()
        {
            string query = "SELECT * FROM Logs WHERE UserID = @userId";

            using (SqlConnection sqlConn = new SqlConnection(@"Data Source=WIN-ACDDOS57HEI\MSSQLSERVER01;Initial Catalog=Kørselslog;Integrated Security=True"))
            {
                sqlConn.Open();
                SqlCommand command = new SqlCommand(query, sqlConn);
                command.Parameters.AddWithValue("@UserID", Variables.UserID);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int logId = reader.GetInt32(0);
                    int userId = reader.GetInt32(1);
                    string whereFrom = reader.GetString(2);
                    string whereTo = reader.GetString(3);

                    Logs_ListBox.Items.Add($"Log ID: {logId}    BrugerID: {userId}    Fra: {whereFrom}    Til: {whereTo}");
                }
            }
        }
    }
}
