using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Tur_og_Retur___Kørsels_Logbog
{
    public partial class AdminPage : Form
    {
        public AdminPage()
        {
            InitializeComponent();
            Users_Listbox();
        }

        private void AddUser_Button_Click(object sender, EventArgs e)
        {
            Forms.NewUserPage();
        }

        private void Users_Button_Click(object sender, EventArgs e)
        {
            Users_Listbox();
        }

        private void Logs_Button_Click(object sender, EventArgs e)
        {
            ListBox.Items.Clear();

            EditProfile_Button.Visible = false;

            string query = "SELECT LogID, UserID, WhereFrom, WhereTo FROM Logs";

            using (SqlConnection sqlConn = new SqlConnection(@"Data Source=WIN-ACDDOS57HEI\MSSQLSERVER01;Initial Catalog=Kørselslog;Integrated Security=True"))
            {
                sqlConn.Open();

                SqlCommand command = new SqlCommand(query, sqlConn);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int logID = reader.GetInt32(0);
                    int userID = reader.GetInt32(1);
                    string whereFrom = reader.GetString(2);
                    string whereTo = reader.GetString(3);
                    ListBox.Items.Add($"LogNR: {logID},  BrugerID: {userID},  Fra: {whereFrom},  Til: {whereTo}");
                }
                reader.Close();
            }
        }

        private void EditProfile_Button_Click(object sender, EventArgs e)
        {
            if (Variables.UserID != -1)
            {
                Forms.EditUserPage();
                Hide();
            }
        }

        private void ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListBox.SelectedItem != null)
            {
                if (Variables.UpdateUserID == true)
                {
                    Variables.UserID = Global.GetUserIdByUsername(ListBox.SelectedItem.ToString());
                    Variables.UsernameHeader = (ListBox.SelectedItem.ToString());

                    if (Variables.UserID != -1)
                    {
                        Logs_ListboxByUserId();
                    }
                }
            }
        }

        private void Users_Listbox()
        {
            ListBox.Items.Clear();

            Variables.UpdateUserID = true;
            EditProfile_Button.Visible = false;

            string selectQuery = "SELECT Username FROM Users";

            using (SqlConnection sqlConn = new SqlConnection(@"Data Source=WIN-ACDDOS57HEI\MSSQLSERVER01;Initial Catalog=Kørselslog;Integrated Security=True"))
            {
                sqlConn.Open();

                SqlCommand command = new SqlCommand(selectQuery, sqlConn);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string users = reader.GetString(0);
                    ListBox.Items.Add($"{users}");
                }
                reader.Close();
            }
        }

        private void Logs_ListboxByUserId()
        {
            EditProfile_Button.Visible = true;

            string selectQuery = "SELECT WhereFrom, WhereTo FROM Logs WHERE UserID = @userID";
            
            using (SqlConnection sqlConn = new SqlConnection(@"Data Source=WIN-ACDDOS57HEI\MSSQLSERVER01;Initial Catalog=Kørselslog;Integrated Security=True"))
            {
                sqlConn.Open();

                SqlCommand command = new SqlCommand(selectQuery, sqlConn);
                command.Parameters.AddWithValue("@userID", Variables.UserID);
                SqlDataReader reader = command.ExecuteReader();
                
                ListBox.Items.Clear();
                ListBox.Items.Add(Variables.UsernameHeader + ":");
                ListBox.Items.Add("Opgaver:");

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        string whereFrom = reader.GetString(0);
                        string whereTo = reader.GetString(1);
                        ListBox.Items.Add($"Fra: {whereFrom}           Til: {whereTo}");
                    }
                    reader.Close();
                }
                else
                {
                    ListBox.Items.Add("Ingen opgaver fundet.");
                }
            }      
        }
    }
}
