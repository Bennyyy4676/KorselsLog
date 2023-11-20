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
    public partial class EditLogsPage : Form
    {
        public EditLogsPage()
        {
            InitializeComponent();

            UserID_TextBox.Text = Variables.UserID.ToString();
            LogID_TextBox.Text = Variables.LogSelectedItemLogId;
            From_TextBox.Text = Variables.LogSelectedItemFrom;
            To_TextBox.Text = Variables.LogSelectedItemTo;
        }

        private void GemLog_Button_Click(object sender, EventArgs e)
        {
            string updateQuery = "UPDATE Logs SET LogID = @newLogId, UserID = @newUserId, WhereFrom = @newWhereFrom, WhereTo = @newWhereTo WHERE LogId = @logId";

            using (SqlConnection sqlConn = new SqlConnection(@"Data Source=WIN-ACDDOS57HEI\MSSQLSERVER01;Initial Catalog=Kørselslog;Integrated Security=True"))
            {
                sqlConn.Open();

                SqlCommand command = new SqlCommand(updateQuery, sqlConn);
                command.Parameters.AddWithValue("@newLogId", Convert.ToInt32(LogID_TextBox.Text));
                command.Parameters.AddWithValue("@newUserId", Convert.ToInt32(UserID_TextBox.Text));
                command.Parameters.AddWithValue("@newWhereFrom", From_TextBox.Text);
                command.Parameters.AddWithValue("@newWhereTo", To_TextBox.Text);
                command.Parameters.AddWithValue("@logId", Variables.LogSelectedItemLogId);

                if (!Global.GetLogIdList().Contains(Convert.ToInt32(LogID_TextBox.Text)) || LogID_TextBox.Text == Variables.LogSelectedItemLogId)
                {
                    if (!Global.GetUserIdList().Contains(Convert.ToInt32(UserID_TextBox.Text)))
                    {
                        MessageBox.Show("Bruger-ID eksisterer ikke");

                        UserID_TextBox.Text = Variables.UserID.ToString();
                        UserID_TextBox.Focus();
                        return;
                    }

                    command.ExecuteNonQuery();
                    MessageBox.Show("Ændringerne er blevet fuldført");

                    Forms.EditUserPage();
                    Hide();
                }
                else
                {
                    MessageBox.Show("Log ID eksisterer allerede");

                    LogID_TextBox.Text = Variables.LogSelectedItemLogId;
                    LogID_TextBox.Focus();
                }
            }
        }

        private void BackArrow_PictureBox_Click(object sender, EventArgs e)
        {
            Forms.EditUserPage();
            Hide();
        }
    }
}
