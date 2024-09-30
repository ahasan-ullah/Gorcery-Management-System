using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gorcery_Management_System
{
    public partial class SignIn : Form
    {
        private int id;
        private int pass;
        private int storedPass;
        public SignIn()
        {
            InitializeComponent();
        }

        private void signUpLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new SignUp().Show();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            try
            {
                id = Convert.ToInt32(txtID.Text);
                pass = Convert.ToInt32(txtPassword.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Id must be a number");
                return;
            }
            if (txtID.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Enter ID or Password");
            }
            else
            {
                string query = "select * from UserInfoTable where ID = '" + id + "';";
                try
                {
                    storedPass = Convert.ToInt32(Access.GetData(query).Rows[0]["Password"].ToString());
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error User Id");
                }
                string type = Access.GetData(query).Rows[0]["Type"].ToString();
                if (pass == storedPass)
                {
                    if (type == "Customer")
                    {
                        this.Hide();
                        new CustomerDashBoard(id).Show();
                    }
                    else if (type == "Salesman")
                    {
                        this.Hide();
                        new SalesmanDashboard(id).Show();
                    }
                    else if (type == "Admin")
                    {
                        //
                    }
                    else
                    {
                        MessageBox.Show("User Type Error");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid username or password");
                }
            }
        }
    }
}
