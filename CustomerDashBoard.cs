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
    public partial class CustomerDashBoard : Form
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Personal\Projects\C#\Gorcery_Management_System\Gorcery_Management_Database.mdf;Integrated Security=True;Connect Timeout=30";
        int id;
        Image PDefaultImage;
        private string PstrFilePath = "";
        private string strFilePath = "";
        Image temp;
        Image Ptemp;

        public CustomerDashBoard(int id)
        {
            this.id = id;
            InitializeComponent();
        }

        private void CustomerDashBoard_Load(object sender, EventArgs e)
        {
            //LoadProductData()
            profilePanel.Hide();
            this.ChangeDashBoardTitle(id);
        }


        public void ChangeDashBoardTitle(int id)
        {
            string query = "select Name from UserInfoTable where ID = '" + id + "';";
            string name = Access.GetData(query).Rows[0]["Name"].ToString();
            customerUsernameLabel.Text = name + "'s" + " Dashboard";
        }

        private void LoadProfileInfo()
        {
            string query = "select * from UserInfoTable where ID = '" + id + "';";
            var result = Access.GetData(query);

            txtProfileID.Text = Convert.ToString(id);
            txtProfileName.Text = result.Rows[0]["Name"].ToString();
            txtProfilePassword.Text = result.Rows[0]["Password"].ToString();
            txtProfileEmail.Text = result.Rows[0]["Email"].ToString();
            rtxtProfileAddress.Text = result.Rows[0]["Address"].ToString();


            string queryImage = "select Image from UserInfoTable where ID = '" + id + "' ";
            byte[] imageBytes = Access.GetImage(queryImage);

            if (imageBytes != null)
            {
                MemoryStream ms = new MemoryStream(imageBytes);
                profilePicture.Image = Image.FromStream(ms);
            }
            else
            {
                profilePicture.Image = null;
            }
        }

        private void btnProfileUpdate_Click(object sender, EventArgs e)
        {
            string name = txtProfileName.Text;
            string pass = txtProfilePassword.Text;
            string email = txtProfileEmail.Text;
            string address = rtxtProfileAddress.Text;

            if (name == "" || email == "" || pass == "" || address == "")
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
                   "Address = @Address, Image = @Image where ID = '" + id + "'";

                SqlConnection conn = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Password", pass);
                cmd.Parameters.AddWithValue("@Address", address);
                cmd.Parameters.AddWithValue("@Image", imageByteArray);

                conn.Open();
                cmd.ExecuteNonQuery();

                this.ChangeDashBoardTitle(id);
                MessageBox.Show("Profile Successfully Updated");
                LoadProfileInfo();
            }
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

        private void btnProfile_Click(object sender, EventArgs e)
        {
            LoadProfileInfo();
            productsPanel.Hide();
            profilePanel.Show();
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            //LoadProductData();
            productsPanel.Show();
            profilePanel.Hide();
        }
    }
}
