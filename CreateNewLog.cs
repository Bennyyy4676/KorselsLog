using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Tur_og_Retur___Kørsels_Logbog
{
    public partial class CreateNewLog : Form
    {
        public CreateNewLog()
        {
            InitializeComponent();
        }

        private void GemLog_Button_Click(object sender, EventArgs e)
        {
            string selectFromQuery = "SELECT * FROM post_nr_by WHERE by_navn = @WhereFrom";
            string selectToQuery = "SELECT * FROM post_nr_by WHERE by_navn = @WhereTo";

            using (SqlConnection sqlConn = new SqlConnection(@"Data Source=WIN-ACDDOS57HEI\MSSQLSERVER01;Initial Catalog=Kørselslog;Integrated Security=True"))
            {
                sqlConn.Open();

                SqlCommand cmdFrom = new SqlCommand(selectFromQuery, sqlConn);
                cmdFrom.Parameters.AddWithValue("@WhereFrom", From_TextBox.Text);

                SqlCommand cmdTo = new SqlCommand(selectToQuery, sqlConn);
                cmdTo.Parameters.AddWithValue("@WhereTo", To_TextBox.Text);

                SqlDataAdapter sdaFrom = new SqlDataAdapter(cmdFrom);
                SqlDataAdapter sdaTo = new SqlDataAdapter(cmdTo);

                DataTable by_navnFromDataTable = new DataTable();
                DataTable by_navnToDataTable = new DataTable();

                sdaFrom.Fill(by_navnFromDataTable);
                sdaTo.Fill(by_navnToDataTable);

                if (by_navnFromDataTable.Rows.Count > 0 && by_navnToDataTable.Rows.Count > 0)
                {
                    SqlCommand selectCommand = new SqlCommand("SELECT TOP 1 LogID FROM Logs ORDER BY LogID DESC", sqlConn);
                    object result = selectCommand.ExecuteScalar();
                    int logID = Convert.ToInt32(result) + 1;

                    string insertQuery = "INSERT INTO Logs(userID, LogID, WhereFrom, WhereTo) " + "Values('" + Variables.UserID.ToString() + "', '" + logID.ToString() + "', '" + From_TextBox.Text + "', '" + To_TextBox.Text + "')";
                    SqlCommand insertCommand = new SqlCommand(insertQuery, sqlConn);
                    insertCommand.ExecuteNonQuery();
                    MessageBox.Show("Kørselslog oprettet", "Kørselslog", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                    if (Variables.AdminID > 0)
                    {
                        Forms.AdminPage();
                        Hide();
                    }
                    else
                    {
                        Forms.HomePage();
                        Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Ugyldig by", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    From_TextBox.Clear();
                    To_TextBox.Clear();

                    From_TextBox.Focus();
                }
            }
        }

        private void BackArrow_PictureBox_Click(object sender, EventArgs e)
        {
            Hide();
            Forms.HomePage();
        }
    }
}
