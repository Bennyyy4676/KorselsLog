using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tur_og_Retur___Kørsels_Logbog
{
    public partial class CreateNewUser : Form
    {
        public CreateNewUser()
        {
            InitializeComponent();
        }

        private void SaveUser_Button_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlConn = new SqlConnection(@"Data Source=WIN-ACDDOS57HEI\MSSQLSERVER01;Initial Catalog=Kørselslog;Integrated Security=True"))
            {
                sqlConn.Open();

                if (Admin_CheckBox.Checked == true)
                {
                    SqlCommand adminCmd = new SqlCommand("SELECT TOP 1 AdminID FROM Admins ORDER BY AdminID DESC", sqlConn);
                    object adminResult = adminCmd.ExecuteScalar();
                    int adminId = Convert.ToInt32(adminResult) + 1;

                    string insertAdminQuery = "INSERT INTO Admins(AdminID, AdminUsername, AdminPassword) " + "VALUES ('" + adminId + "', '" + Username_TextBox.Text + "', '" + Password_TextBox.Text + "')";
                    SqlCommand adminCommand = new SqlCommand(insertAdminQuery, sqlConn);

                    if (!Global.GetUsernameList().Contains(Username_TextBox.Text))
                    {
                        MessageBox.Show("Bruger Oprettet");
                        adminCommand.ExecuteNonQuery();

                        Hide();
                    }
                    else
                    {
                        MessageBox.Show("Brugernavn eksisterer allerede");
                        Username_TextBox.Clear();
                    }
                }

                if (Admin_CheckBox.Checked == false)
                {
                    SqlCommand cmd = new SqlCommand("SELECT TOP 1 UserID FROM Users ORDER BY UserID DESC", sqlConn);
                    object result = cmd.ExecuteScalar();
                    int userId = Convert.ToInt32(result) + 1;

                    string insertQuery = "INSERT INTO Users(userID, Username, UserPassword) " + "VALUES ('" + userId + "', '" + Username_TextBox.Text + "', '" + Password_TextBox.Text + "')";
                    SqlCommand command = new SqlCommand(insertQuery, sqlConn);

                    if (!Global.GetUsernameList().Contains(Username_TextBox.Text))
                    {
                        MessageBox.Show("Bruger Oprettet");
                        command.ExecuteNonQuery();

                        Hide();
                    }
                    else
                    {
                        MessageBox.Show("Brugernavn eksisterer allerede");
                        Username_TextBox.Clear();
                    }
                }
            }
        }
    }
}
