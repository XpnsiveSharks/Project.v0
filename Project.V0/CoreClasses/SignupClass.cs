using Project.V0.SQLConn;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.V0.CoreClasses
{
    public class SignupClass
    {
        public string fname {  get; set; }
        public string lname {  get; set; }
        public int age { get; set; }
        public string sex { get; set; }
        public void AddUserInfo(string fname, string lname, int age, string sex)
        {
            DB db = new DB();
            string query = "INSERT INTO USERINFOS(FIRST_NAME, LAST_NAME, AGE, SEX) VALUES ('" + fname + "','" + lname + "','" + age + "','" + sex + "')";
            db.Execute(query);
        }
    }
    
}
