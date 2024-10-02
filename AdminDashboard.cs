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
    public partial class AdminDashboard : Form
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Personal\Projects\C#\Gorcery_Management_System\Gorcery_Management_Database.mdf;Integrated Security=True;Connect Timeout=30";
        int id;
        Image ADefaultImage;
        Image PDefaultImage;
        private string strFilePath = "";
        Image temp;
        public AdminDashboard(int id)
        {
            this.id = id;
            InitializeComponent();
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            profilePanel.Hide();
            userPanel.Hide();
            ADefaultImage = adminImageBox.Image;
            PDefaultImage = productImageBox.Image;
            this.ChangeDashBoardTitle(id);
            LoadProducts();
        }

        public void ChangeDashBoardTitle(int id)
        {
            string query = "select Name from UserInfoTable where ID = '" + id + "';";
            string name = Access.GetData(query).Rows[0]["Name"].ToString();
            adminUsernameLabel.Text = name + "'s" + " Dashboard";
        }



        private void LoadProfileInfo()
        {
            string query = "select * from UserInfoTable where id = '" + id + "'";
            var result = Access.GetData(query);

            txtProfileID.Text = Convert.ToString(id);
            txtProfileName.Text = result.Rows[0]["Name"].ToString();
            txtProfilePassword.Text = result.Rows[0]["Password"].ToString();
            txtProfileEmail.Text = result.Rows[0]["Email"].ToString();

            string queryImage = "select Image from UserInfoTable where id = '" + id + "'";
            byte[] profileImage = Access.GetImage(queryImage);

            if (profileImage != null)
            {
                MemoryStream ms = new MemoryStream(profileImage);
                profilePicture.Image = Image.FromStream(ms);
            }
            else
            {
                profilePicture.Image = null;
            }
        }







        private void LoadAdminInfo()
        {
            string query = "select * from UserInfoTable";
            var result = Access.GetData(query);
            if (result == null)
            {
                MessageBox.Show("Something went wrong");
            }

            dgvAdmin.AutoGenerateColumns = false;
            dgvAdmin.DataSource = result;
            dgvAdmin.ClearSelection();
            dgvAdmin.Refresh();
            adminImageBox.Image = ADefaultImage;
            txtAdminID.Text = "";
        }

        private void LoadAdminImage(int adminID)
        {
            string query = "select Image from UserInfoTable where ID = '"+adminID+"';";
            byte [] adminImage = Access.GetImage(query);

            if(adminImage != null)
            {
                MemoryStream ms = new MemoryStream(adminImage);
                adminImageBox.Image = Image.FromStream(ms);
            }
            else
            {
                adminImageBox.Image = ADefaultImage;
            }
        }

        private void dgvAdmin_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int adminID = Convert.ToInt32(dgvAdmin.Rows[e.RowIndex].Cells[0].Value.ToString());
                txtAdminID.Text = Convert.ToString(adminID);
                this.LoadAdminImage(adminID);
            }
        }

        private void btnAdminDelete_Click(object sender, EventArgs e)
        {
            string adminID = txtAdminID.Text;
            if (adminID == "")
            {
                MessageBox.Show("Please select user to delete");
                return;
            }
            var click = MessageBox.Show("Do you want to delete?", "Confirmation", MessageBoxButtons.YesNo);
            if (click == DialogResult.No)
            {
                return;
            }
            string query = "delete from UserInfoTable where ID = '"+ Convert.ToInt32(txtAdminID.Text) + "';";
            var result = Access.ExecuteQuery(query);

            if (result == false)
            {
                MessageBox.Show("Error");
                return;
            }
            MessageBox.Show("User Deleted Successfully");
            LoadAdminInfo();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadAdminInfo();
        }



        private void btnProductsRefresh_Click(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void btnProductDelete_Click(object sender, EventArgs e)
        {
            string productID = txtProductID.Text;
            if (productID == "")
            {
                MessageBox.Show("Please select product to delete");
                return;
            }
            var click = MessageBox.Show("Do you want to delete?", "Confirmation", MessageBoxButtons.YesNo);
            if (click == DialogResult.No)
            {
                return;
            }
            string query = "delete from ProductInfoTable where ID = '" + Convert.ToInt32(txtProductID.Text) + "';";
            var result = Access.ExecuteQuery(query);

            if (result == false)
            {
                MessageBox.Show("Error");
                return;
            }
            MessageBox.Show("Product Deleted Successfully");
            LoadProducts();
        }


        private void LoadProductImage(int productID)
        {
            string query = "select P_Image from ProductInfoTable where P_ID = '" + productID + "';";
            byte[] productImage = Access.GetImage(query);

            if (productImage != null)
            {
                MemoryStream ms = new MemoryStream(productImage);
                productImageBox.Image = Image.FromStream(ms);
            }
            else
            {
                productImageBox.Image = PDefaultImage;
            }
        }


        private void LoadProducts()
        {
            string query = "select * from ProductInfoTable";
            DataTable input = Access.GetData(query);

            if (input == null)
            {
                MessageBox.Show("Something went wrong");
                return;
            }
            dgvProducts.AutoGenerateColumns = false;
            dgvProducts.DataSource = input;
            dgvProducts.Refresh();
            productImageBox.Image = ADefaultImage;
            dgvProducts.ClearSelection();
        }

        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int productID = Convert.ToInt32(dgvProducts.Rows[e.RowIndex].Cells[0].Value.ToString());
                txtProductID.Text = Convert.ToString(productID);
                this.LoadProductImage(productID);
            }
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            profilePanel.Hide();
            LoadAdminInfo();
            userPanel.Show();
            productsPanel.Hide();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            LoadProfileInfo();
            profilePanel.Show();
            userPanel.Hide();
            productsPanel.Hide();
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            profilePanel.Hide();
            userPanel.Hide();
            LoadProducts();
            productsPanel.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Dispose();
            new SignIn().Show();
        }

        private void btnProfileUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog userImage = new OpenFileDialog();
            //userImage.Filter = "Image(.jpg, .png)|*.png;*.jpg";
            if (userImage.ShowDialog() == DialogResult.OK)
            {
                strFilePath = userImage.FileName;
                profilePicture.Image = new Bitmap(strFilePath);
            }
        }

        private void btnProfileUpdate_Click(object sender, EventArgs e)
        {
            string name = txtProfileName.Text;
            string pass = txtProfilePassword.Text;
            string email = txtProfileEmail.Text;

            if (name == "" || email == "" || pass == "")
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

                string query = "update UserInfoTable set Name = @Name, Email = @Email, Password = @Password, " +
                   "Image = @Image where ID = '" + id + "'";

                SqlConnection conn = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Password", pass);
                cmd.Parameters.AddWithValue("@Image", imageByteArray);

                conn.Open();
                cmd.ExecuteNonQuery();

                this.ChangeDashBoardTitle(id);
                MessageBox.Show("Profile Successfully Updated");
                LoadProfileInfo();
            }
        }
    }
}
