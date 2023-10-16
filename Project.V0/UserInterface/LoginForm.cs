using Project.V0.SQLConn;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.V0.UserInterface
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string user = txtUser.Text;
            string pass = txtPass.Text;
            string Query = "INSERT INTO dbo.USERS_v0(USERNAME, PASSWORD) VALUES ('" + user + "','" + pass + "')";
            DB dB = new DB();
            dB.Execute(Query);
        }
    }
}
