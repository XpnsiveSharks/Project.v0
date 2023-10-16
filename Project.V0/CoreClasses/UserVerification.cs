using Project.V0.SQLConn;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.V0.CoreClasses
{
    public class UserVerification
    { 
        public bool VerifyLogin(string username, string password)
        {
            DB dB = new DB();
            string Query = "SELECT COUNT(*) FROM dbo.USERS_v0 WHERE Username = @username AND Password = @password";

            SqlCommand cmd = new SqlCommand(Query, dB.conn);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);

            int count = (int)cmd.ExecuteScalar();
            if (count > 0)
            {
                MessageBox.Show("User Exist");
                return true;
            }
            else
            {
                MessageBox.Show("User dont exist");
                return false;
            }
        }
    }
}
