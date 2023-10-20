using Project.V0.CoreClasses;
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
    public partial class SignupForm : Form
    {
        public SignupForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            btnAddFuntion();
        }
        /// <summary>
        /// Methods
        /// </summary>
        private void btnAddFuntion()
        {
            try
            {
                string age = txtAge.Text;
                int ageInt;

                if (int.TryParse(age, out ageInt))
                {
                    SignupClass sc = new SignupClass();
                    string Fname = txtFname.Text;
                    string Lname = txtLname.Text;
                    string sex;

                    if (rdbtnMale.Checked)
                    {
                        sex = "Male";
                    }
                    else
                    {
                        sex = "Female";
                    }

                    sc.AddUserInfo(Fname, Lname, ageInt, sex);
                }
                else
                {
                    // The age input is not a valid integer
                    MessageBox.Show("Age must be a valid number.");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
