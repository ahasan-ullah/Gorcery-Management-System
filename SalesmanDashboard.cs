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
    public partial class SalesmanDashboard : Form
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Personal\Projects\C#\Gorcery_Management_System\Gorcery_Management_Database.mdf;Integrated Security=True;Connect Timeout=30";
        int id;
        Image PDefaultImage;
        private string PstrFilePath = "";
        private string strFilePath = "";
        Image temp;
        Image Ptemp;

        public SalesmanDashboard(int id)
        {
            this.id = id;
            InitializeComponent();
            PDefaultImage = productImageBox.Image;
        }

        public void ChangeDashBoardTitle(int id)
        {
            string query = "select Name from UserInfoTable where ID = '" + id + "';";
            string name = Access.GetData(query).Rows[0]["Name"].ToString();
            salesmanUsernameLabel.Text = name + "'s" + " Dashboard";
        }

        private void SalesmanDashboard_Load(object sender, EventArgs e)
        {
            LoadProductData();
            profilePanel.Hide();
            this.ChangeDashBoardTitle(id);
        }


        private void ProductInfoClear()
        {
            txtID.Text = "";
            txtProductName.Text = "";
            rtxtProductDesc.Text = "";
            txtProductPrice.Text = "";
            txtProductType.Text = "";
            txtProductStock.Text = "";
            PstrFilePath = "";
            productImageBox.Image = PDefaultImage;
        }

        private void LoadProductData()
        {
            string query = "select P_ID, P_Name, P_Description, P_Price, P_Type, P_Stock from ProductInfoTable where ID = '"+id+"';";
            DataTable input = Access.GetData(query);

            if (input == null)
            {
                MessageBox.Show("Something went wrong");
                return;
            }
            dgvProducts.AutoGenerateColumns = false;
            dgvProducts.DataSource = input;
            dgvProducts.Refresh();
            ProductInfoClear();
            dgvProducts.ClearSelection();
        }

        private void btnProductUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog userImage = new OpenFileDialog();
            //userImage.Filter = "Image(.jpg, .png)|*.png;*.jpg";
            if (userImage.ShowDialog() == DialogResult.OK)
            {
                PstrFilePath = userImage.FileName;
                productImageBox.Image = new Bitmap(PstrFilePath);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string pName = txtProductName.Text;
            string PDesc = rtxtProductDesc.Text;
            string pPrice = txtProductPrice.Text;
            string pType = txtProductType.Text;
            string pStock = txtProductStock.Text;


            if (pName == "" || PDesc == "" || pPrice == "" || pType == "" || pStock=="")
            {
                MessageBox.Show("Please fill all required fields.");
            }
            else
            {
                byte[] PimageByteArray;
                try
                {
                    Ptemp = new Bitmap(PstrFilePath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Select Image");
                    return;
                }
                MemoryStream stream = new MemoryStream();
                Ptemp.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
                PimageByteArray = stream.ToArray();

                string query = "insert into ProductInfoTable (P_Name, P_Description, P_Price, P_Type, ID, P_Stock, P_Image) values (@PName, @PDescription, @PPrice, @PType, @ID, @PStock, @PImage)";

                SqlConnection conn = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@PName", pName);
                cmd.Parameters.AddWithValue("PDescription", PDesc);
                cmd.Parameters.AddWithValue("@PPrice", pPrice);
                cmd.Parameters.AddWithValue("@PType", pType);
                cmd.Parameters.AddWithValue("@ID", id);
                cmd.Parameters.AddWithValue("@PStock", pStock);
                cmd.Parameters.AddWithValue("@PImage", PimageByteArray);

                conn.Open();
                int result = cmd.ExecuteNonQuery();
                if (result == 1)
                {
                    MessageBox.Show("Product Added Successfully");
                    ProductInfoClear();
                    dgvProducts.ClearSelection();
                }
                else
                {
                    MessageBox.Show("Error inserting user data.");
                }
            }
            LoadProductData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string productId = txtID.Text;
            if (productId == "")
            {
                MessageBox.Show("Please select row first");
                return;
            }
            var click = MessageBox.Show("Do you want to delete?", "Confirmation", MessageBoxButtons.YesNo);
            if (click == DialogResult.No)
            {
                return;
            }

            string query = "delete from ProductInfoTable where P_ID = '" + Convert.ToInt32(productId) + "';";
            var result = Access.ExecuteQuery(query);

            if (result == false)
            {
                MessageBox.Show("Error");
                return;
            }
            
            MessageBox.Show("Product Deleted Successfully");
            LoadProductData();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string pID = txtID.Text;
            string pName = txtProductName.Text;
            string PDesc = rtxtProductDesc.Text;
            string pPrice = txtProductPrice.Text;
            string pType = txtProductType.Text;
            string pStock = txtProductStock.Text;


            if (pName == "" || PDesc == "" || pPrice == "" || pType == "" || pStock == "")
            {
                MessageBox.Show("Please fill all required fields.");
            }
            else
            {
                byte[] PimageByteArray;
                try
                {
                    Ptemp = new Bitmap(PstrFilePath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Select Image");
                    return;
                }
                MemoryStream stream = new MemoryStream();
                Ptemp.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
                PimageByteArray = stream.ToArray();

                string query = "update ProductInfoTable set P_Name = @PName, P_Description = @PDescription, P_Price = @PPrice, P_Type = @PType, P_Stock = @PStock, P_Image = @PImage where P_ID = '" + pID+"';";

                SqlConnection conn = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@PName", pName);
                cmd.Parameters.AddWithValue("PDescription", PDesc);
                cmd.Parameters.AddWithValue("@PPrice", pPrice);
                cmd.Parameters.AddWithValue("@PType", pType);
                cmd.Parameters.AddWithValue("@PStock", pStock);
                cmd.Parameters.AddWithValue("@PImage", PimageByteArray);

                conn.Open();
                int result = cmd.ExecuteNonQuery();
                if (result == 1)
                {
                    MessageBox.Show("Product Updated Successfully");
                    ProductInfoClear();
                    dgvProducts.ClearSelection();
                }
                else
                {
                    MessageBox.Show("Error inserting user data.");
                }
            }
            LoadProductData();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadProductData();
        }

        private void LoadCellData(int productID)
        {
            string query = "select * from ProductInfoTable where P_ID = '" + productID + "';";
            var result = Access.GetData(query);
            if (result == null)
            {
                MessageBox.Show("Error");
                return;
            }
            txtID.Text = result.Rows[0]["P_ID"].ToString();
            txtProductName.Text = result.Rows[0]["P_Name"].ToString();
            rtxtProductDesc.Text = result.Rows[0]["P_Description"].ToString();
            txtProductType.Text = result.Rows[0]["P_Type"].ToString();
            txtProductPrice.Text = result.Rows[0]["P_Price"].ToString();
            txtProductStock.Text = result.Rows[0]["P_Stock"].ToString();

            string queryImage = "select P_Image from ProductInfoTable where P_ID = '" + productID + "' ";
            byte[] imageBytes = Access.GetImage(queryImage);

            if (imageBytes != null)
            {
                MemoryStream ms = new MemoryStream(imageBytes);
                productImageBox.Image = Image.FromStream(ms);
            }
            else
            {
                productImageBox.Image = PDefaultImage;
            }
        }

        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int productId = Convert.ToInt32(dgvProducts.Rows[e.RowIndex].Cells[0].Value.ToString());
                this.LoadCellData(productId);
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

        private void LoadProfileInfo()
        {
            string query= "select * from UserInfoTable where ID = '" + id + "';";
            var result = Access.GetData(query);

            txtProfileID.Text = Convert.ToString(id);
            txtProfileName.Text = result.Rows[0]["Name"].ToString();
            txtProfilePassword.Text = result.Rows[0]["Password"].ToString();
            txtProfileEmail.Text = result.Rows[0]["Email"].ToString();
            rtxtProfileAddress.Text = result.Rows[0]["Address"].ToString();
            txtProfileShop.Text = result.Rows[0]["Shopname"].ToString();

            
            string queryImage = "select Image from UserInfoTable where ID = '"+id+"' ";
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
            string shop = txtProfileShop.Text;

            if (name == "" || email == "" || pass == "" || address == "" || shop == "")
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
                   "Address = @Address, Shopname = @Shopname, Image = @Image where ID = '"+id+"'";

                SqlConnection conn = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Password", pass);
                cmd.Parameters.AddWithValue("@Address", address);
                cmd.Parameters.AddWithValue("@Shopname", shop);
                cmd.Parameters.AddWithValue("@Image", imageByteArray);

                conn.Open();
                cmd.ExecuteNonQuery();

                this.ChangeDashBoardTitle(id);
                MessageBox.Show("Profile Successfully Updated");
                LoadProfileInfo();
            }
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            LoadProductData();
            productsPanel.Show();
            profilePanel.Hide();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            LoadProfileInfo();
            productsPanel.Hide();
            profilePanel.Show();
        }
    }
}
