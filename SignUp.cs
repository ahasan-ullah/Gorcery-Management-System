using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gorcery_Management_System
{
    public partial class SignUp : Form
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Personal\Projects\C#\Gorcery_Management_System\Gorcery_Management_Database.mdf;Integrated Security=True;Connect Timeout=30";
        private string name;
        private string email;
        private string pass;
        private string type;
        private string address;
        private string shopname;
        private string strFilePath = "";
        Byte[] ImageByteArray;
        Image temp;
        public SignUp()
        {
            InitializeComponent();

            customerPanel.Hide();
            adminPanel.Hide();
            salesmanPanel.Hide();
        }


        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog userImage = new OpenFileDialog();
            //userImage.Filter = "Image(.jpg, .png)|*.png;*.jpg";
            if (userImage.ShowDialog() == DialogResult.OK)
            {
                strFilePath = userImage.FileName;
                userImageBox.Image = new Bitmap(strFilePath);
            }
        }

        private void rbtnCustomer_CheckedChanged(object sender, EventArgs e)
        {
            customerPanel.Show();
            adminPanel.Hide();
            salesmanPanel.Hide();
        }

        private void rbtnSalesman_CheckedChanged(object sender, EventArgs e)
        {
            customerPanel.Hide();
            adminPanel.Hide();
            salesmanPanel.Show();
        }

        private void rbtnAdmin_CheckedChanged(object sender, EventArgs e)
        {
            customerPanel.Hide();
            adminPanel.Show();
            salesmanPanel.Hide();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            name = txtName.Text;
            email = txtEmail.Text;
            pass = txtPassword.Text;
            address = "";
            shopname = "";

            if (rbtnCustomer.Checked)
            {
                type = rbtnCustomer.Text;
                address = rtxtCustomerAddrress.Text;
            }
            else if (rbtnSalesman.Checked)
            {
                type = rbtnSalesman.Text;
                address = rtxtSalesmanAddress.Text;
                shopname = txtShopname.Text;
            }
            else if (rbtnAdmin.Checked)
            {
                if (Convert.ToInt32(txtSecurity.Text) == 0000)
                {
                    type = rbtnAdmin.Text;
                }
                else
                {
                    MessageBox.Show("Invalid Security Key");
                }
            }
            else
            {
                MessageBox.Show("Please select user type");
                return;
            }


            if (name=="" || email=="" || pass=="" || type=="")
            {
                MessageBox.Show("Please fill all required fields.");
            }
            else
            {
                byte[] imageByteArray;
                try
                {
                    temp = new Bitmap(strFilePath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Select Image");
                    return;
                }
                MemoryStream stream = new MemoryStream();
                temp.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
                imageByteArray = stream.ToArray();

                string query = "insert into UserInfoTable (Name, Email, Password, Type, Address, Shopname, Image) values (@Name, @Email, @Password, @Type, @Address, @Shopname, @Image)";

                SqlConnection conn = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Password", pass);
                cmd.Parameters.AddWithValue("@Type", type);
                cmd.Parameters.AddWithValue("@Address", address);
                cmd.Parameters.AddWithValue("@Shopname", shopname);
                cmd.Parameters.AddWithValue("@Image", imageByteArray);

                conn.Open();
                int result = cmd.ExecuteNonQuery();
                if (result == 1)
                {
                    string query2 = "select ID from UserInfoTable where Email = '"+email+"';";
                    int id = Convert.ToInt32(Access.GetData(query2).Rows[0]["ID"].ToString());

                    txtName.Text = "";
                    txtEmail.Text = "";
                    txtPassword.Text = "";
                    rtxtCustomerAddrress.Text = "";
                    rtxtSalesmanAddress.Text = "";
                    txtSecurity.Text = "";
                    txtShopname.Text = "";
                    strFilePath = "";

                    MessageBox.Show("Success! Your ID is: " + id);
                }
                else
                {
                    MessageBox.Show("Error inserting user data.");
                }
             }
        }


        private void signInLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new SignIn().Show();
        }
    }
}
