using Org.BouncyCastle.Bcpg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Project.V0.SQLConn
{
    public class DB
    {
        //1 Address of SQL server and DB
        string ConnectionString = "Data Source=MENENABANSPC\\SQLEXPRESS;Initial Catalog=Project_v0;Integrated Security=True";
        //2 Establish connection 
        SqlConnection conn = null;

        public DB()
        {
            conn = new SqlConnection(ConnectionString);
        }
        //experoment
        public SqlConnection Conn
        {
            get { return conn; }
        }
        //experoment
        public SqlDataReader Execute(string Query)
        {
            
            try
            {              
                //3 Open Conn
                conn.Open();
                //4 Prepare SQL Query
                SqlCommand cmd = new SqlCommand(Query, conn);
                //5 Execute query
                return cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
               
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                //6 Close conn
                conn.Close();
            }
            return null;
        }

    }
}
