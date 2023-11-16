using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tur_og_Retur___Kørsels_Logbog
{
    public class Variables
    {
        public static string LogSelectedItemLogId { get; set; }

        public static string LogSelectedItemFrom { get; set; }

        public static string LogSelectedItemTo { get; set; }

        public static string HelloLabel { get; set; }

        public static string UsernameHeader { get; set; }

        public static int AdminID { get; set; }

        public static int UserID { get; set; }

        public static bool UpdateUserID { get; set; }
    }

    public class Global
    {
        public static int GetUserIdByUsername(string username)
        {
            string query = "SELECT UserID FROM Users WHERE Username = @Username";
            int userId = -1;

            using (SqlConnection sqlConn = new SqlConnection(@"Data Source=WIN-ACDDOS57HEI\MSSQLSERVER01;Initial Catalog=Kørselslog;Integrated Security=True"))
            {
                sqlConn.Open();

                SqlCommand command = new SqlCommand(query, sqlConn);
                command.Parameters.AddWithValue("@Username", username);

                object result = command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out userId))
                {
                    Variables.UpdateUserID = false;
                    return userId;
                }
                else
                {
                    return -1;
                }
            }
        }

        public static int ExtractLogID(string selectedItem)
        {
            int logID = 0;
            string pattern = @"Log ID: (\d+)";

            Match match = Regex.Match(selectedItem, pattern);

            if (match.Success)
            {
                string logIDString = match.Groups[1].Value;
                if (int.TryParse(logIDString, out logID))
                {
                    return logID;
                }
            }

            return logID;
        }

        public static string ExtractFrom(string selectedItem)
        {
            string fromCity = "";
            string pattern = @"Fra: (\w+)";

            Match match = Regex.Match(selectedItem, pattern);

            if (match.Success)
            {
                fromCity = match.Groups[1].Value;
            }

            return fromCity;
        }

        public static string ExtractTo(string selectedItem)
        {
            string toCity = "";
            string pattern = @"Til: (\w+)";

            Match match = Regex.Match(selectedItem, pattern);

            if (match.Success)
            {
                toCity = match.Groups[1].Value;
            }

            return toCity;
        }

        public static List<int> GetLogIdList()
        {
            List<int> logIdList = new List<int>();
            string selectQuery = "SELECT LogID FROM Logs";

            using (SqlConnection sqlConn = new SqlConnection(@"Data Source=WIN-ACDDOS57HEI\MSSQLSERVER01;Initial Catalog=Kørselslog;Integrated Security=True"))
            {
                sqlConn.Open();

                SqlCommand command = new SqlCommand(selectQuery, sqlConn);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int userId = reader.GetInt32(0);
                    logIdList.Add(userId);
                }

                return logIdList;
            }
        }

        public static List<int> GetUserIdList()
        {
            List<int> userIdList = new List<int>();
            string selectQuery = "SELECT UserID FROM Users";

            using (SqlConnection sqlConn = new SqlConnection(@"Data Source=WIN-ACDDOS57HEI\MSSQLSERVER01;Initial Catalog=Kørselslog;Integrated Security=True"))
            {
                sqlConn.Open();

                SqlCommand command = new SqlCommand(selectQuery, sqlConn);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int userId = reader.GetInt32(0);
                    userIdList.Add(userId);
                }

                return userIdList;
            }
        }

        public static List<string> GetUsernameList()
        {
            List<string> usernameList = new List<string>();
            string selectQuery = "SELECT Username FROM Users";

            using (SqlConnection sqlConn = new SqlConnection(@"Data Source=WIN-ACDDOS57HEI\MSSQLSERVER01;Initial Catalog=Kørselslog;Integrated Security=True"))
            {
                sqlConn.Open();

                SqlCommand command = new SqlCommand(selectQuery, sqlConn);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string username = reader.GetString(0);
                    usernameList.Add(username);
                }

                return usernameList;
            }
        }
    }

    public class Forms
    {
        public static void HomePage()
        {
            HomePage homePage = new HomePage {
                StartPosition = FormStartPosition.Manual,
                Location = new Point(100, 100)
            };
            
            homePage.Show();
        }

        public static void NewUserPage()
        {
            CreateNewUser createNewUser = new CreateNewUser
            {
                StartPosition = FormStartPosition.Manual,
                Location = new Point(125, 125)
            };

            createNewUser.Show();
        }

        public static void NewLogPage()
        {
            CreateNewLog createNewLog = new CreateNewLog {
                StartPosition = FormStartPosition.Manual,
                Location = new Point(100, 100)
            };

            createNewLog.Show();
        }

        public static void LoginPage()
        {
            Login login = new Login {
                StartPosition = FormStartPosition.Manual,
                Location = new Point(100, 100)
            };

            login.Show();
        }

        public static void AdminPage()
        {
            AdminPage adminPage = new AdminPage
            {
                StartPosition = FormStartPosition.Manual,
                Location = new Point(100, 100)
            };

            adminPage.Show();
        }

        public static void EditUserPage()
        {
            EditUserPage editUserPage = new EditUserPage
            {
                StartPosition = FormStartPosition.Manual,
                Location = new Point(100, 100)
            };

            editUserPage.Show();
        }

        public static void EditLogsPage()
        {
            EditLogsPage editLogsPage = new EditLogsPage
            {
                StartPosition = FormStartPosition.Manual,
                Location = new Point(100, 100)
            };

            editLogsPage.Show();
        }
    }
}
