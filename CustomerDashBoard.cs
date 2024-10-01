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
using Microsoft.VisualBasic;

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
            historyPanel.Hide();
            profilePanel.Hide();
            panel1.Hide();
            LoadProducts();
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



        private void LoadPurchaseHistory()
        {
            string query = "select O_ID, O_Date, O_Price, O_Type from CustomerOrderTable where C_ID = '"+id+"';";
            DataTable input = Access.GetData(query);

            if (input == null)
            {
                MessageBox.Show("Something went wrong");
                return;
            }
            dgvHistory.AutoGenerateColumns = false;
            dgvHistory.DataSource = input;
            dgvHistory.Refresh();
            dgvHistory.ClearSelection();
        }

        private void LoadReviews()
        {
            string query = "select R_Date, R_Comment, P_ID from SalesmenReviewTable where C_ID = '" + id + "';";
            DataTable input = Access.GetData(query);

            if (input == null)
            {
                MessageBox.Show("Something went wrong");
                return;
            }
            dgvReview.AutoGenerateColumns = false;
            dgvReview.DataSource = input;
            dgvReview.Refresh();
            dgvReview.ClearSelection();
        }





        public class Product
        {
            public int ProductId { get; set; }
            public string ProductName { get; set; }
            public string Price { get; set; }
            public string Type { get; set; }
            public byte[] ImageData { get; set; }
        }

        private void LoadProducts()
        {
            Product[] products = GetProducts();
            foreach (var product in products)
            {
                if (product != null) 
                {
                    CreateProductCard(product);
                }
            }
        }

        private Product[] GetProducts()
        {
            string query = "select * from ProductInfoTable";
            DataTable input = Access.GetData(query);
            if (input == null || input.Rows.Count == 0)
            {
                return new Product[0];
            }

            Product[] products = new Product[input.Rows.Count];
            for (int i=0;i<input.Rows.Count;i++)
            {
                products[i] = new Product
                {
                    ProductId = Convert.ToInt32(input.Rows[i]["P_ID"]),
                    ProductName = input.Rows[i]["P_Name"].ToString(),
                    Price = input.Rows[i]["P_Price"].ToString(),
                    Type = input.Rows[i]["P_Type"].ToString(),
                    ImageData = input.Rows[i]["P_Image"] as byte[]
                };
            }

            return products;
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            Button ifCLicked = sender as Button; 
            if (ifCLicked != null && ifCLicked.Tag is Product product)
            {
                var click = MessageBox.Show("Do you want to purchase this product?", "Confirmation", MessageBoxButtons.YesNo);
                if (click == DialogResult.No)
                {
                    return;
                }
                //MessageBox.Show(product.ProductName + "\n" + product.Price);
                string currentTime = DateTime.Now.ToString("MM-dd-yyyy HH:mm:ss");
                string query = "insert into CustomerOrderTable (O_Date,O_Price,O_Type,C_ID,P_ID)" +
                    " values ('" + currentTime + "','" + product.Price + "','" + product.Type + "','" + id + "','" + product.ProductId + "')";
                var result = Access.ExecuteQuery(query);
                if (result == true)
                {
                    MessageBox.Show("Product Purchased Successfully!");
                    var reviewBox = MessageBox.Show("Do you want togive feedback?", "Confirmation", MessageBoxButtons.YesNo);
                    if (reviewBox == DialogResult.No)
                    {
                        return;
                    }
                    string review = Interaction.InputBox("Give Your Valueable Feedback \n So that we can improve our service", "FeedBack");
                    string query2 = "insert into SalesmenReviewTable (R_Comment,R_Date,C_ID,P_ID)" +
                    " values ('" + review + "','" + currentTime + "','" + id + "','" + product.ProductId + "')";
                    var result2 = Access.ExecuteQuery(query2);
                    if (result2 == true)
                    {
                        MessageBox.Show("Thanks for your valueable feedback! \n Happy Shopping");
                    }
                }
            }
        }

        private void CreateProductCard(Product product)
        {
            Panel card = new Panel
            {
                Width = 200,
                Height = 260,
                BorderStyle = BorderStyle.FixedSingle,
                Margin = new Padding(10)
            };

            Label nameLabel = new Label
            {
                Text = product.ProductName,
                Font = new Font("Arial", 10, FontStyle.Regular),
                Top = 205,
                Left = 20,
                AutoSize = true 
            };
            Label priceLabel = new Label 
            {
                Top = 205,
                Left = 100,
                Font = new Font("Arial", 10, FontStyle.Regular),
                Text ="Price: " + product.Price, 
                AutoSize = true
            };
            PictureBox pictureBox = new PictureBox
            {
                Top = 15,
                Left=15,
                SizeMode = PictureBoxSizeMode.StretchImage,
                Width = 170,
                Height = 180
            };
            if (product.ImageData != null)
            {
                MemoryStream ms = new MemoryStream(product.ImageData);
                pictureBox.Image = Image.FromStream(ms);
            }
            Button btnBuy = new Button 
            {
                Font = new Font("Arial", 12, FontStyle.Bold),
                Text = "Buy", 
                Height=30,
                BackColor = Color.FromArgb(255, 255, 128, 0),
                ForeColor = Color.White,
                Dock = DockStyle.Bottom,
            };

            btnBuy.Tag = product;
            btnBuy.Click += new System.EventHandler(this.btnBuy_Click);

            card.Controls.Add(pictureBox);
            card.Controls.Add(nameLabel);
            card.Controls.Add(priceLabel);
            card.Controls.Add(btnBuy);

            productsPanel.Controls.Add(card);
            productsPanel.AutoScroll = true;
        }




        private void btnProfile_Click(object sender, EventArgs e)
        {
            LoadProfileInfo();
            productsPanel.Hide();
            profilePanel.Show();
            historyPanel.Hide();
            panel1.Hide();
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            //LoadProductData();
            productsPanel.Show();
            profilePanel.Hide();
            historyPanel.Hide();
            panel1.Hide();
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            productsPanel.Hide();
            profilePanel.Hide();
            LoadPurchaseHistory();
            historyPanel.Show();
            panel1.Hide();
        }

        private void btnReview_Click(object sender, EventArgs e)
        {
            productsPanel.Hide();
            profilePanel.Hide();
            historyPanel.Hide();
            LoadReviews();
            panel1.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Dispose();
            new SignIn().Show();
        }

        
    }
}
