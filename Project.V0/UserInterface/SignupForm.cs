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
            LoadData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            btnAddFuntion();
        }
        //example of loading data using button
        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadData();
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
                    MessageBox.Show("Succesfully created an account");
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Age must be a valid number.",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtAge.Clear();
                }                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void LoadData()
        {
            SignupClass s = new SignupClass();
            List<SignupClass> list = s.getAllUserInfo();
            dgUserinfo.DataSource = list;
        }
        
    }
}
