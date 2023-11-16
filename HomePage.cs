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
using static Tur_og_Retur___Kørsels_Logbog.Login;

namespace Tur_og_Retur___Kørsels_Logbog
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
            PopulateYourLogsListView();

            Hello_Label.Text = "Hello " + Variables.HelloLabel;
        }

        private void OpretNyLog_Button_Click(object sender, EventArgs e)
        {
            Hide();
            Forms.NewLogPage();
        }

        private void ProfileAvatar_PictureBox_Click(object sender, EventArgs e)
        {
            ContextMenu profileAvatarMenu = new ContextMenu();
            profileAvatarMenu.MenuItems.Add("Log Ud", new EventHandler(LogOut_Handler));
            ProfileAvatar_PictureBox.ContextMenu = profileAvatarMenu;
        }

        private void LogOut_Handler(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Sikker på du vil logge ud?", "Log Ud", MessageBoxButtons.YesNo);

            if (DialogResult == DialogResult.Yes)
            {
                Hide();
                Forms.LoginPage();
            }
        }

        private void PopulateYourLogsListView()
        {
            YourLogs_ListView.View = View.Details;
            YourLogs_ListView.Columns.Add("Fra", 163);
            YourLogs_ListView.Columns.Add("Til", 164);
            YourLogs_ListView.Font = new Font("Arial", 10);

            using (SqlConnection sqlConn = new SqlConnection(@"Data Source=WIN-ACDDOS57HEI\MSSQLSERVER01;Initial Catalog=Kørselslog;Integrated Security=True"))
            {
                sqlConn.Open();

                SqlCommand command = new SqlCommand("SELECT * FROM Logs WHERE UserID = @userID", sqlConn);
                command.Parameters.AddWithValue("@userID", Variables.UserID);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    ListViewItem item = new ListViewItem(reader["WhereFrom"].ToString());
                    item.SubItems.Add(reader["WhereTo"].ToString());
                    YourLogs_ListView.Items.Add(item);
                }
                reader.Close();
            }
        }
    }
}
