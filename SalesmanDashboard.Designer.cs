
namespace Gorcery_Management_System
{
    partial class SalesmanDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesmanDashboard));
            this.sidePanel = new System.Windows.Forms.Panel();
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnProduct = new System.Windows.Forms.Button();
            this.salesmanUsernameLabel = new System.Windows.Forms.Label();
            this.sellerLabel = new System.Windows.Forms.Label();
            this.upperPanel = new System.Windows.Forms.Panel();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.P_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.P_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.P_Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.P_Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.P_Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.P_Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameLabel = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.descLabel = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.rtxtProductDesc = new System.Windows.Forms.RichTextBox();
            this.priceLabel = new System.Windows.Forms.Label();
            this.txtProductPrice = new System.Windows.Forms.TextBox();
            this.typeLabel = new System.Windows.Forms.Label();
            this.txtProductType = new System.Windows.Forms.TextBox();
            this.txtStock = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.productImageBox = new System.Windows.Forms.PictureBox();
            this.btnProductUpload = new System.Windows.Forms.Button();
            this.productsPanel = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.txtProductStock = new System.Windows.Forms.TextBox();
            this.profilePicture = new System.Windows.Forms.PictureBox();
            this.btnProfileUpload = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtProfileID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rtxtProfileAddress = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtProfileName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtProfilePassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtProfileEmail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtProfileShop = new System.Windows.Forms.TextBox();
            this.btnProfileUpdate = new System.Windows.Forms.Button();
            this.profilePanel = new System.Windows.Forms.Panel();
            this.sidePanel.SuspendLayout();
            this.upperPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productImageBox)).BeginInit();
            this.productsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilePicture)).BeginInit();
            this.profilePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidePanel
            // 
            this.sidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.sidePanel.Controls.Add(this.btnProfile);
            this.sidePanel.Controls.Add(this.btnProduct);
            this.sidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidePanel.Location = new System.Drawing.Point(0, 52);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(188, 701);
            this.sidePanel.TabIndex = 1;
            // 
            // btnProfile
            // 
            this.btnProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.btnProfile.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfile.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnProfile.Location = new System.Drawing.Point(30, 168);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(131, 50);
            this.btnProfile.TabIndex = 2;
            this.btnProfile.Text = "Profile";
            this.btnProfile.UseVisualStyleBackColor = false;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // btnProduct
            // 
            this.btnProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.btnProduct.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProduct.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnProduct.Location = new System.Drawing.Point(30, 35);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(131, 50);
            this.btnProduct.TabIndex = 1;
            this.btnProduct.Text = "Products";
            this.btnProduct.UseVisualStyleBackColor = false;
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // salesmanUsernameLabel
            // 
            this.salesmanUsernameLabel.AutoSize = true;
            this.salesmanUsernameLabel.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salesmanUsernameLabel.Location = new System.Drawing.Point(25, 9);
            this.salesmanUsernameLabel.Name = "salesmanUsernameLabel";
            this.salesmanUsernameLabel.Size = new System.Drawing.Size(225, 29);
            this.salesmanUsernameLabel.TabIndex = 2;
            this.salesmanUsernameLabel.Text = "SalesMan DashBoard";
            // 
            // sellerLabel
            // 
            this.sellerLabel.AutoSize = true;
            this.sellerLabel.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sellerLabel.Location = new System.Drawing.Point(991, 10);
            this.sellerLabel.Name = "sellerLabel";
            this.sellerLabel.Size = new System.Drawing.Size(69, 29);
            this.sellerLabel.TabIndex = 3;
            this.sellerLabel.Text = "Seller";
            // 
            // upperPanel
            // 
            this.upperPanel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.upperPanel.Controls.Add(this.sellerLabel);
            this.upperPanel.Controls.Add(this.salesmanUsernameLabel);
            this.upperPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.upperPanel.Location = new System.Drawing.Point(0, 0);
            this.upperPanel.Name = "upperPanel";
            this.upperPanel.Size = new System.Drawing.Size(1182, 52);
            this.upperPanel.TabIndex = 0;
            // 
            // dgvProducts
            // 
            this.dgvProducts.AllowUserToAddRows = false;
            this.dgvProducts.AllowUserToDeleteRows = false;
            this.dgvProducts.AllowUserToResizeColumns = false;
            this.dgvProducts.AllowUserToResizeRows = false;
            this.dgvProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProducts.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvProducts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProducts.ColumnHeadersHeight = 29;
            this.dgvProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.P_ID,
            this.P_Name,
            this.P_Description,
            this.P_Price,
            this.P_Type,
            this.P_Stock});
            this.dgvProducts.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvProducts.Location = new System.Drawing.Point(20, 162);
            this.dgvProducts.MultiSelect = false;
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.ReadOnly = true;
            this.dgvProducts.RowHeadersVisible = false;
            this.dgvProducts.RowHeadersWidth = 51;
            this.dgvProducts.RowTemplate.Height = 60;
            this.dgvProducts.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProducts.Size = new System.Drawing.Size(609, 501);
            this.dgvProducts.TabIndex = 0;
            this.dgvProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProducts_CellClick);
            // 
            // P_ID
            // 
            this.P_ID.DataPropertyName = "P_ID";
            this.P_ID.HeaderText = "ID";
            this.P_ID.MinimumWidth = 6;
            this.P_ID.Name = "P_ID";
            this.P_ID.ReadOnly = true;
            // 
            // P_Name
            // 
            this.P_Name.DataPropertyName = "P_Name";
            this.P_Name.HeaderText = "Name";
            this.P_Name.MinimumWidth = 6;
            this.P_Name.Name = "P_Name";
            this.P_Name.ReadOnly = true;
            // 
            // P_Description
            // 
            this.P_Description.DataPropertyName = "P_Description";
            this.P_Description.HeaderText = "Description";
            this.P_Description.MinimumWidth = 6;
            this.P_Description.Name = "P_Description";
            this.P_Description.ReadOnly = true;
            // 
            // P_Price
            // 
            this.P_Price.DataPropertyName = "P_Price";
            this.P_Price.HeaderText = "Price";
            this.P_Price.MinimumWidth = 6;
            this.P_Price.Name = "P_Price";
            this.P_Price.ReadOnly = true;
            // 
            // P_Type
            // 
            this.P_Type.DataPropertyName = "P_Type";
            this.P_Type.HeaderText = "Type";
            this.P_Type.MinimumWidth = 6;
            this.P_Type.Name = "P_Type";
            this.P_Type.ReadOnly = true;
            // 
            // P_Stock
            // 
            this.P_Stock.DataPropertyName = "P_Stock";
            this.P_Stock.HeaderText = "Stock";
            this.P_Stock.MinimumWidth = 6;
            this.P_Stock.Name = "P_Stock";
            this.P_Stock.ReadOnly = true;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(642, 199);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(72, 29);
            this.nameLabel.TabIndex = 7;
            this.nameLabel.Text = "Name";
            // 
            // txtProductName
            // 
            this.txtProductName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtProductName.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductName.Location = new System.Drawing.Point(647, 231);
            this.txtProductName.Multiline = true;
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(289, 30);
            this.txtProductName.TabIndex = 8;
            // 
            // descLabel
            // 
            this.descLabel.AutoSize = true;
            this.descLabel.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descLabel.Location = new System.Drawing.Point(642, 277);
            this.descLabel.Name = "descLabel";
            this.descLabel.Size = new System.Drawing.Size(125, 29);
            this.descLabel.TabIndex = 9;
            this.descLabel.Text = "Description";
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idLabel.Location = new System.Drawing.Point(15, 103);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(34, 29);
            this.idLabel.TabIndex = 11;
            this.idLabel.Text = "ID";
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtID.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(104, 103);
            this.txtID.Multiline = true;
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(96, 30);
            this.txtID.TabIndex = 12;
            // 
            // rtxtProductDesc
            // 
            this.rtxtProductDesc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxtProductDesc.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtProductDesc.Location = new System.Drawing.Point(647, 309);
            this.rtxtProductDesc.Name = "rtxtProductDesc";
            this.rtxtProductDesc.Size = new System.Drawing.Size(289, 96);
            this.rtxtProductDesc.TabIndex = 13;
            this.rtxtProductDesc.Text = "";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceLabel.Location = new System.Drawing.Point(642, 422);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(61, 29);
            this.priceLabel.TabIndex = 14;
            this.priceLabel.Text = "Price";
            // 
            // txtProductPrice
            // 
            this.txtProductPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtProductPrice.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductPrice.Location = new System.Drawing.Point(647, 454);
            this.txtProductPrice.Multiline = true;
            this.txtProductPrice.Name = "txtProductPrice";
            this.txtProductPrice.Size = new System.Drawing.Size(289, 30);
            this.txtProductPrice.TabIndex = 15;
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeLabel.Location = new System.Drawing.Point(642, 498);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(60, 29);
            this.typeLabel.TabIndex = 16;
            this.typeLabel.Text = "Type";
            // 
            // txtProductType
            // 
            this.txtProductType.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtProductType.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductType.Location = new System.Drawing.Point(647, 530);
            this.txtProductType.Multiline = true;
            this.txtProductType.Name = "txtProductType";
            this.txtProductType.Size = new System.Drawing.Size(289, 30);
            this.txtProductType.TabIndex = 17;
            // 
            // txtStock
            // 
            this.txtStock.AutoSize = true;
            this.txtStock.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStock.Location = new System.Drawing.Point(642, 574);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(66, 29);
            this.txtStock.TabIndex = 18;
            this.txtStock.Text = "Stock";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(20, 20);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(96, 39);
            this.btnAdd.TabIndex = 20;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(155, 20);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(96, 39);
            this.btnDelete.TabIndex = 21;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(292, 20);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(96, 39);
            this.btnUpdate.TabIndex = 22;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // productImageBox
            // 
            this.productImageBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("productImageBox.BackgroundImage")));
            this.productImageBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.productImageBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.productImageBox.Image = ((System.Drawing.Image)(resources.GetObject("productImageBox.Image")));
            this.productImageBox.Location = new System.Drawing.Point(647, 13);
            this.productImageBox.Name = "productImageBox";
            this.productImageBox.Size = new System.Drawing.Size(157, 160);
            this.productImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.productImageBox.TabIndex = 23;
            this.productImageBox.TabStop = false;
            // 
            // btnProductUpload
            // 
            this.btnProductUpload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnProductUpload.FlatAppearance.BorderSize = 0;
            this.btnProductUpload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductUpload.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductUpload.ForeColor = System.Drawing.Color.White;
            this.btnProductUpload.Location = new System.Drawing.Point(840, 86);
            this.btnProductUpload.Name = "btnProductUpload";
            this.btnProductUpload.Size = new System.Drawing.Size(96, 39);
            this.btnProductUpload.TabIndex = 24;
            this.btnProductUpload.Text = "Upload";
            this.btnProductUpload.UseVisualStyleBackColor = false;
            this.btnProductUpload.Click += new System.EventHandler(this.btnProductUpload_Click);
            // 
            // productsPanel
            // 
            this.productsPanel.Controls.Add(this.btnRefresh);
            this.productsPanel.Controls.Add(this.txtProductStock);
            this.productsPanel.Controls.Add(this.btnProductUpload);
            this.productsPanel.Controls.Add(this.productImageBox);
            this.productsPanel.Controls.Add(this.btnUpdate);
            this.productsPanel.Controls.Add(this.btnDelete);
            this.productsPanel.Controls.Add(this.btnAdd);
            this.productsPanel.Controls.Add(this.txtStock);
            this.productsPanel.Controls.Add(this.txtProductType);
            this.productsPanel.Controls.Add(this.typeLabel);
            this.productsPanel.Controls.Add(this.txtProductPrice);
            this.productsPanel.Controls.Add(this.priceLabel);
            this.productsPanel.Controls.Add(this.rtxtProductDesc);
            this.productsPanel.Controls.Add(this.txtID);
            this.productsPanel.Controls.Add(this.idLabel);
            this.productsPanel.Controls.Add(this.descLabel);
            this.productsPanel.Controls.Add(this.txtProductName);
            this.productsPanel.Controls.Add(this.nameLabel);
            this.productsPanel.Controls.Add(this.dgvProducts);
            this.productsPanel.Location = new System.Drawing.Point(194, 58);
            this.productsPanel.Name = "productsPanel";
            this.productsPanel.Size = new System.Drawing.Size(951, 683);
            this.productsPanel.TabIndex = 0;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(429, 19);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(96, 39);
            this.btnRefresh.TabIndex = 26;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // txtProductStock
            // 
            this.txtProductStock.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtProductStock.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductStock.Location = new System.Drawing.Point(647, 615);
            this.txtProductStock.Multiline = true;
            this.txtProductStock.Name = "txtProductStock";
            this.txtProductStock.Size = new System.Drawing.Size(289, 30);
            this.txtProductStock.TabIndex = 25;
            // 
            // profilePicture
            // 
            this.profilePicture.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("profilePicture.BackgroundImage")));
            this.profilePicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.profilePicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.profilePicture.Location = new System.Drawing.Point(612, 25);
            this.profilePicture.Name = "profilePicture";
            this.profilePicture.Size = new System.Drawing.Size(157, 160);
            this.profilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.profilePicture.TabIndex = 25;
            this.profilePicture.TabStop = false;
            // 
            // btnProfileUpload
            // 
            this.btnProfileUpload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnProfileUpload.FlatAppearance.BorderSize = 0;
            this.btnProfileUpload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfileUpload.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfileUpload.ForeColor = System.Drawing.Color.White;
            this.btnProfileUpload.Location = new System.Drawing.Point(647, 191);
            this.btnProfileUpload.Name = "btnProfileUpload";
            this.btnProfileUpload.Size = new System.Drawing.Size(96, 39);
            this.btnProfileUpload.TabIndex = 26;
            this.btnProfileUpload.Text = "Upload";
            this.btnProfileUpload.UseVisualStyleBackColor = false;
            this.btnProfileUpload.Click += new System.EventHandler(this.btnProfileUpload_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 29);
            this.label2.TabIndex = 27;
            this.label2.Text = "ID";
            // 
            // txtProfileID
            // 
            this.txtProfileID.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtProfileID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtProfileID.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProfileID.Location = new System.Drawing.Point(109, 24);
            this.txtProfileID.Multiline = true;
            this.txtProfileID.Name = "txtProfileID";
            this.txtProfileID.ReadOnly = true;
            this.txtProfileID.Size = new System.Drawing.Size(107, 30);
            this.txtProfileID.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(80, 406);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 29);
            this.label1.TabIndex = 29;
            this.label1.Text = "Address";
            // 
            // rtxtProfileAddress
            // 
            this.rtxtProfileAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxtProfileAddress.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtProfileAddress.Location = new System.Drawing.Point(260, 369);
            this.rtxtProfileAddress.Name = "rtxtProfileAddress";
            this.rtxtProfileAddress.Size = new System.Drawing.Size(289, 96);
            this.rtxtProfileAddress.TabIndex = 30;
            this.rtxtProfileAddress.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(80, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 29);
            this.label3.TabIndex = 31;
            this.label3.Text = "Name";
            // 
            // txtProfileName
            // 
            this.txtProfileName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtProfileName.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProfileName.Location = new System.Drawing.Point(260, 202);
            this.txtProfileName.Multiline = true;
            this.txtProfileName.Name = "txtProfileName";
            this.txtProfileName.Size = new System.Drawing.Size(289, 30);
            this.txtProfileName.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(80, 257);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 29);
            this.label4.TabIndex = 33;
            this.label4.Text = "Password";
            // 
            // txtProfilePassword
            // 
            this.txtProfilePassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtProfilePassword.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProfilePassword.Location = new System.Drawing.Point(260, 257);
            this.txtProfilePassword.Multiline = true;
            this.txtProfilePassword.Name = "txtProfilePassword";
            this.txtProfilePassword.Size = new System.Drawing.Size(289, 30);
            this.txtProfilePassword.TabIndex = 34;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(80, 310);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 29);
            this.label5.TabIndex = 35;
            this.label5.Text = "Email";
            // 
            // txtProfileEmail
            // 
            this.txtProfileEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtProfileEmail.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProfileEmail.Location = new System.Drawing.Point(260, 310);
            this.txtProfileEmail.Multiline = true;
            this.txtProfileEmail.Name = "txtProfileEmail";
            this.txtProfileEmail.Size = new System.Drawing.Size(289, 30);
            this.txtProfileEmail.TabIndex = 36;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(80, 488);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 29);
            this.label6.TabIndex = 37;
            this.label6.Text = "Shop";
            // 
            // txtProfileShop
            // 
            this.txtProfileShop.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtProfileShop.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProfileShop.Location = new System.Drawing.Point(260, 488);
            this.txtProfileShop.Multiline = true;
            this.txtProfileShop.Name = "txtProfileShop";
            this.txtProfileShop.Size = new System.Drawing.Size(289, 30);
            this.txtProfileShop.TabIndex = 38;
            // 
            // btnProfileUpdate
            // 
            this.btnProfileUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnProfileUpdate.FlatAppearance.BorderSize = 0;
            this.btnProfileUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfileUpdate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfileUpdate.ForeColor = System.Drawing.Color.White;
            this.btnProfileUpdate.Location = new System.Drawing.Point(356, 560);
            this.btnProfileUpdate.Name = "btnProfileUpdate";
            this.btnProfileUpdate.Size = new System.Drawing.Size(96, 39);
            this.btnProfileUpdate.TabIndex = 39;
            this.btnProfileUpdate.Text = "Update";
            this.btnProfileUpdate.UseVisualStyleBackColor = false;
            this.btnProfileUpdate.Click += new System.EventHandler(this.btnProfileUpdate_Click);
            // 
            // profilePanel
            // 
            this.profilePanel.Controls.Add(this.btnProfileUpdate);
            this.profilePanel.Controls.Add(this.txtProfileShop);
            this.profilePanel.Controls.Add(this.label6);
            this.profilePanel.Controls.Add(this.txtProfileEmail);
            this.profilePanel.Controls.Add(this.label5);
            this.profilePanel.Controls.Add(this.txtProfilePassword);
            this.profilePanel.Controls.Add(this.label4);
            this.profilePanel.Controls.Add(this.txtProfileName);
            this.profilePanel.Controls.Add(this.label3);
            this.profilePanel.Controls.Add(this.rtxtProfileAddress);
            this.profilePanel.Controls.Add(this.label1);
            this.profilePanel.Controls.Add(this.txtProfileID);
            this.profilePanel.Controls.Add(this.label2);
            this.profilePanel.Controls.Add(this.btnProfileUpload);
            this.profilePanel.Controls.Add(this.profilePicture);
            this.profilePanel.Location = new System.Drawing.Point(255, 62);
            this.profilePanel.Name = "profilePanel";
            this.profilePanel.Size = new System.Drawing.Size(915, 644);
            this.profilePanel.TabIndex = 25;
            // 
            // SalesmanDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Controls.Add(this.sidePanel);
            this.Controls.Add(this.upperPanel);
            this.Controls.Add(this.productsPanel);
            this.Controls.Add(this.profilePanel);
            this.MaximizeBox = false;
            this.Name = "SalesmanDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Salesman Dashboard";
            this.Load += new System.EventHandler(this.SalesmanDashboard_Load);
            this.sidePanel.ResumeLayout(false);
            this.upperPanel.ResumeLayout(false);
            this.upperPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productImageBox)).EndInit();
            this.productsPanel.ResumeLayout(false);
            this.productsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilePicture)).EndInit();
            this.profilePanel.ResumeLayout(false);
            this.profilePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel sidePanel;
        private System.Windows.Forms.Button btnProduct;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Panel profilePanel;
        private System.Windows.Forms.Panel productsPanel;
        private System.Windows.Forms.Button btnProductUpload;
        private System.Windows.Forms.PictureBox productImageBox;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label txtStock;
        private System.Windows.Forms.TextBox txtProductType;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.TextBox txtProductPrice;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.RichTextBox rtxtProductDesc;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label descLabel;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.Button btnProfileUpdate;
        private System.Windows.Forms.TextBox txtProfileShop;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtProfileEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtProfilePassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtProfileName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox rtxtProfileAddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtProfileID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnProfileUpload;
        private System.Windows.Forms.PictureBox profilePicture;
        private System.Windows.Forms.Label salesmanUsernameLabel;
        private System.Windows.Forms.Label sellerLabel;
        private System.Windows.Forms.Panel upperPanel;
        private System.Windows.Forms.TextBox txtProductStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn P_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn P_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn P_Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn P_Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn P_Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn P_Stock;
        private System.Windows.Forms.Button btnRefresh;
    }
}