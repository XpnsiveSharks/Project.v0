using Project.V0.SQLConn;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace Project.V0.CoreClasses
{
    public class SignupClass
    {
        DB db = new DB();
        public int Id { get; set; }
        public string FIRST_NAME {  get; set; }
        public string LAST_NAME {  get; set; }
        public int AGE { get; set; }
        public string SEX { get; set; }
        public void AddUserInfo(string fname, string lname, int age, string sex)
        {   
            string query = "INSERT INTO USERINFOS(FIRST_NAME, LAST_NAME, AGE, SEX) VALUES ('" + fname + "','" + lname + "','" + age + "','" + sex + "')";
            db.Execute(query);
        }
        public List<SignupClass> getAllUserInfo()
        {
            List<SignupClass> list = new List<SignupClass>();
            SqlConnection con = new SqlConnection (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Prince\Desktop\CSshark\Project.V0\Project.V0\Database_101.mdf;Integrated Security=True;Connect Timeout=30");
            string sql = "SELECT * FROM USERINFOS";

            con.Open ();
            using (SqlCommand cmd = new SqlCommand(sql, con)) 
            {
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    SignupClass s = new SignupClass();
                    s.Id = (int)dr["Id"];
                    s.FIRST_NAME = dr["FIRST_NAME"].ToString();
                    s.LAST_NAME = dr["LAST_NAME"].ToString();
                    s.AGE = (int)dr["AGE"];
                    s.SEX = dr["SEX"].ToString();

                    list.Add(s);
                }
            }

            return list;
        }
    }
    
}
