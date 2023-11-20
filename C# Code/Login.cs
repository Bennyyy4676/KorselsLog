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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Tur_og_Retur___Kørsels_Logbog
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Button_Click(object sender, EventArgs e)
        {
            string userQuery = "SELECT * FROM Users WHERE Username = @username COLLATE Latin1_General_BIN AND UserPassword = @password COLLATE Latin1_General_BIN";
            string adminQuery = "SELECT * FROM Admins WHERE AdminUsername = @username COLLATE Latin1_General_BIN AND AdminPassword = @password COLLATE Latin1_General_BIN";

            using (SqlConnection sqlConn = new SqlConnection(@"Data Source=WIN-ACDDOS57HEI\MSSQLSERVER01;Initial Catalog=Kørselslog;Integrated Security=True"))
            {
                DataTable userDataTable = new DataTable();
                DataTable adminDataTable = new DataTable();

                SqlDataAdapter userAdapter = new SqlDataAdapter(userQuery, sqlConn);
                userAdapter.SelectCommand.Parameters.AddWithValue("@username", Username_TextBox.Text);
                userAdapter.SelectCommand.Parameters.AddWithValue("@password", Password_TextBox.Text);
                userAdapter.Fill(userDataTable);

                SqlDataAdapter adminAdapter = new SqlDataAdapter(adminQuery, sqlConn);
                adminAdapter.SelectCommand.Parameters.AddWithValue("@username", Username_TextBox.Text);
                adminAdapter.SelectCommand.Parameters.AddWithValue("@password", Password_TextBox.Text);
                adminAdapter.Fill(adminDataTable);
                

                if (userDataTable.Rows.Count > 0)
                {
                    Variables.UserID = Convert.ToInt32(userDataTable.Rows[0]["UserID"]);
                    Variables.HelloLabel = Username_TextBox.Text;

                    Hide();
                    Forms.HomePage();
                }
                else if (adminDataTable.Rows.Count > 0)
                {
                    Variables.AdminID = Convert.ToInt32(adminDataTable.Rows[0]["AdminID"]);

                    Hide();
                    Forms.AdminPage();
                }
                else
                {
                    MessageBox.Show("Ugyldigt Login", "Fejl", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Username_TextBox.Clear();
                    Password_TextBox.Clear();

                    Username_TextBox.Focus();
                }
            }
        }
    }
}
