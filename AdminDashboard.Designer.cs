
namespace Gorcery_Management_System
{
    partial class AdminDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDashboard));
            this.profilePanel = new System.Windows.Forms.Panel();
            this.btnProfileUpdate = new System.Windows.Forms.Button();
            this.txtProfileEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtProfilePassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtProfileName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtProfileID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnProfileUpload = new System.Windows.Forms.Button();
            this.profilePicture = new System.Windows.Forms.PictureBox();
            this.sidePanel = new System.Windows.Forms.Panel();
            this.btnReviews = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnUser = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnProduct = new System.Windows.Forms.Button();
            this.upperPanel = new System.Windows.Forms.Panel();
            this.adminLabel = new System.Windows.Forms.Label();
            this.adminUsernameLabel = new System.Windows.Forms.Label();
            this.userPanel = new System.Windows.Forms.Panel();
            this.txtAdminID = new System.Windows.Forms.TextBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.adminImageBox = new System.Windows.Forms.PictureBox();
            this.btnUserDelete = new System.Windows.Forms.Button();
            this.dgvAdmin = new System.Windows.Forms.DataGridView();
            this.P_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.P_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.U_Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.U_Pass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Shopname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productsPanel = new System.Windows.Forms.Panel();
            this.btnProductsRefresh = new System.Windows.Forms.Button();
            this.productImageBox = new System.Windows.Forms.PictureBox();
            this.btnProductDelete = new System.Windows.Forms.Button();
            this.txtProductID = new System.Windows.Forms.TextBox();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.P_Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.P_Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.P_Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.P_Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reviewPanel = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvReview = new System.Windows.Forms.DataGridView();
            this.R_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.R_Comment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.profilePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilePicture)).BeginInit();
            this.sidePanel.SuspendLayout();
            this.upperPanel.SuspendLayout();
            this.userPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adminImageBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdmin)).BeginInit();
            this.productsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productImageBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.reviewPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReview)).BeginInit();
            this.SuspendLayout();
            // 
            // profilePanel
            // 
            this.profilePanel.Controls.Add(this.btnProfileUpdate);
            this.profilePanel.Controls.Add(this.txtProfileEmail);
            this.profilePanel.Controls.Add(this.label5);
            this.profilePanel.Controls.Add(this.txtProfilePassword);
            this.profilePanel.Controls.Add(this.label4);
            this.profilePanel.Controls.Add(this.txtProfileName);
            this.profilePanel.Controls.Add(this.label3);
            this.profilePanel.Controls.Add(this.txtProfileID);
            this.profilePanel.Controls.Add(this.label2);
            this.profilePanel.Controls.Add(this.btnProfileUpload);
            this.profilePanel.Controls.Add(this.profilePicture);
            this.profilePanel.Location = new System.Drawing.Point(255, 62);
            this.profilePanel.Name = "profilePanel";
            this.profilePanel.Size = new System.Drawing.Size(915, 662);
            this.profilePanel.TabIndex = 43;
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
            // txtProfileEmail
            // 
            this.txtProfileEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtProfileEmail.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProfileEmail.Location = new System.Drawing.Point(275, 379);
            this.txtProfileEmail.Multiline = true;
            this.txtProfileEmail.Name = "txtProfileEmail";
            this.txtProfileEmail.Size = new System.Drawing.Size(289, 30);
            this.txtProfileEmail.TabIndex = 36;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(95, 379);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 29);
            this.label5.TabIndex = 35;
            this.label5.Text = "Email";
            // 
            // txtProfilePassword
            // 
            this.txtProfilePassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtProfilePassword.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProfilePassword.Location = new System.Drawing.Point(275, 326);
            this.txtProfilePassword.Multiline = true;
            this.txtProfilePassword.Name = "txtProfilePassword";
            this.txtProfilePassword.Size = new System.Drawing.Size(289, 30);
            this.txtProfilePassword.TabIndex = 34;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(95, 326);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 29);
            this.label4.TabIndex = 33;
            this.label4.Text = "Password";
            // 
            // txtProfileName
            // 
            this.txtProfileName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtProfileName.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProfileName.Location = new System.Drawing.Point(275, 271);
            this.txtProfileName.Multiline = true;
            this.txtProfileName.Name = "txtProfileName";
            this.txtProfileName.Size = new System.Drawing.Size(289, 30);
            this.txtProfileName.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(95, 271);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 29);
            this.label3.TabIndex = 31;
            this.label3.Text = "Name";
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
            // sidePanel
            // 
            this.sidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.sidePanel.Controls.Add(this.btnReviews);
            this.sidePanel.Controls.Add(this.btnLogout);
            this.sidePanel.Controls.Add(this.btnUser);
            this.sidePanel.Controls.Add(this.btnProfile);
            this.sidePanel.Controls.Add(this.btnProduct);
            this.sidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidePanel.Location = new System.Drawing.Point(0, 52);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(188, 701);
            this.sidePanel.TabIndex = 42;
            // 
            // btnReviews
            // 
            this.btnReviews.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.btnReviews.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReviews.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnReviews.Location = new System.Drawing.Point(30, 247);
            this.btnReviews.Name = "btnReviews";
            this.btnReviews.Size = new System.Drawing.Size(131, 50);
            this.btnReviews.TabIndex = 7;
            this.btnReviews.Text = "Reviews";
            this.btnReviews.UseVisualStyleBackColor = false;
            this.btnReviews.Click += new System.EventHandler(this.btnReviews_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.btnLogout.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLogout.Location = new System.Drawing.Point(30, 604);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(131, 50);
            this.btnLogout.TabIndex = 6;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnUser
            // 
            this.btnUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.btnUser.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUser.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnUser.Location = new System.Drawing.Point(30, 145);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(131, 50);
            this.btnUser.TabIndex = 5;
            this.btnUser.Text = "User";
            this.btnUser.UseVisualStyleBackColor = false;
            this.btnUser.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // btnProfile
            // 
            this.btnProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.btnProfile.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfile.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnProfile.Location = new System.Drawing.Point(30, 349);
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
            // upperPanel
            // 
            this.upperPanel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.upperPanel.Controls.Add(this.adminLabel);
            this.upperPanel.Controls.Add(this.adminUsernameLabel);
            this.upperPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.upperPanel.Location = new System.Drawing.Point(0, 0);
            this.upperPanel.Name = "upperPanel";
            this.upperPanel.Size = new System.Drawing.Size(1182, 52);
            this.upperPanel.TabIndex = 41;
            // 
            // adminLabel
            // 
            this.adminLabel.AutoSize = true;
            this.adminLabel.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminLabel.Location = new System.Drawing.Point(991, 10);
            this.adminLabel.Name = "adminLabel";
            this.adminLabel.Size = new System.Drawing.Size(80, 29);
            this.adminLabel.TabIndex = 3;
            this.adminLabel.Text = "Admin";
            // 
            // adminUsernameLabel
            // 
            this.adminUsernameLabel.AutoSize = true;
            this.adminUsernameLabel.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminUsernameLabel.Location = new System.Drawing.Point(25, 10);
            this.adminUsernameLabel.Name = "adminUsernameLabel";
            this.adminUsernameLabel.Size = new System.Drawing.Size(195, 29);
            this.adminUsernameLabel.TabIndex = 2;
            this.adminUsernameLabel.Text = "Admin DashBoard";
            // 
            // userPanel
            // 
            this.userPanel.Controls.Add(this.txtAdminID);
            this.userPanel.Controls.Add(this.btnRefresh);
            this.userPanel.Controls.Add(this.adminImageBox);
            this.userPanel.Controls.Add(this.btnUserDelete);
            this.userPanel.Controls.Add(this.dgvAdmin);
            this.userPanel.Location = new System.Drawing.Point(213, 65);
            this.userPanel.Name = "userPanel";
            this.userPanel.Size = new System.Drawing.Size(954, 633);
            this.userPanel.TabIndex = 40;
            // 
            // txtAdminID
            // 
            this.txtAdminID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAdminID.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdminID.Location = new System.Drawing.Point(803, 288);
            this.txtAdminID.Multiline = true;
            this.txtAdminID.Name = "txtAdminID";
            this.txtAdminID.Size = new System.Drawing.Size(80, 30);
            this.txtAdminID.TabIndex = 33;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(161, 21);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(96, 39);
            this.btnRefresh.TabIndex = 26;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // adminImageBox
            // 
            this.adminImageBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("adminImageBox.BackgroundImage")));
            this.adminImageBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.adminImageBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.adminImageBox.Image = ((System.Drawing.Image)(resources.GetObject("adminImageBox.Image")));
            this.adminImageBox.Location = new System.Drawing.Point(764, 95);
            this.adminImageBox.Name = "adminImageBox";
            this.adminImageBox.Size = new System.Drawing.Size(157, 160);
            this.adminImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.adminImageBox.TabIndex = 23;
            this.adminImageBox.TabStop = false;
            // 
            // btnUserDelete
            // 
            this.btnUserDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnUserDelete.FlatAppearance.BorderSize = 0;
            this.btnUserDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserDelete.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserDelete.ForeColor = System.Drawing.Color.White;
            this.btnUserDelete.Location = new System.Drawing.Point(20, 20);
            this.btnUserDelete.Name = "btnUserDelete";
            this.btnUserDelete.Size = new System.Drawing.Size(96, 39);
            this.btnUserDelete.TabIndex = 21;
            this.btnUserDelete.Text = "Delete";
            this.btnUserDelete.UseVisualStyleBackColor = false;
            this.btnUserDelete.Click += new System.EventHandler(this.btnAdminDelete_Click);
            // 
            // dgvAdmin
            // 
            this.dgvAdmin.AllowUserToAddRows = false;
            this.dgvAdmin.AllowUserToDeleteRows = false;
            this.dgvAdmin.AllowUserToResizeColumns = false;
            this.dgvAdmin.AllowUserToResizeRows = false;
            this.dgvAdmin.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAdmin.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvAdmin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAdmin.ColumnHeadersHeight = 29;
            this.dgvAdmin.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.P_ID,
            this.P_Name,
            this.U_Email,
            this.U_Pass,
            this.Type,
            this.Address,
            this.Shopname});
            this.dgvAdmin.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvAdmin.Location = new System.Drawing.Point(20, 95);
            this.dgvAdmin.MultiSelect = false;
            this.dgvAdmin.Name = "dgvAdmin";
            this.dgvAdmin.ReadOnly = true;
            this.dgvAdmin.RowHeadersVisible = false;
            this.dgvAdmin.RowHeadersWidth = 51;
            this.dgvAdmin.RowTemplate.Height = 60;
            this.dgvAdmin.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvAdmin.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAdmin.Size = new System.Drawing.Size(719, 501);
            this.dgvAdmin.TabIndex = 0;
            this.dgvAdmin.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAdmin_CellClick);
            // 
            // P_ID
            // 
            this.P_ID.DataPropertyName = "ID";
            this.P_ID.HeaderText = "ID";
            this.P_ID.MinimumWidth = 6;
            this.P_ID.Name = "P_ID";
            this.P_ID.ReadOnly = true;
            // 
            // P_Name
            // 
            this.P_Name.DataPropertyName = "Name";
            this.P_Name.HeaderText = "Name";
            this.P_Name.MinimumWidth = 6;
            this.P_Name.Name = "P_Name";
            this.P_Name.ReadOnly = true;
            // 
            // U_Email
            // 
            this.U_Email.DataPropertyName = "Email";
            this.U_Email.HeaderText = "Email";
            this.U_Email.MinimumWidth = 6;
            this.U_Email.Name = "U_Email";
            this.U_Email.ReadOnly = true;
            // 
            // U_Pass
            // 
            this.U_Pass.DataPropertyName = "Password";
            this.U_Pass.HeaderText = "Password";
            this.U_Pass.MinimumWidth = 6;
            this.U_Pass.Name = "U_Pass";
            this.U_Pass.ReadOnly = true;
            // 
            // Type
            // 
            this.Type.DataPropertyName = "Type";
            this.Type.HeaderText = "Type";
            this.Type.MinimumWidth = 6;
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            // 
            // Address
            // 
            this.Address.DataPropertyName = "Address";
            this.Address.HeaderText = "Address";
            this.Address.MinimumWidth = 6;
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            // 
            // Shopname
            // 
            this.Shopname.DataPropertyName = "Shopname";
            this.Shopname.HeaderText = "Shopname";
            this.Shopname.MinimumWidth = 6;
            this.Shopname.Name = "Shopname";
            this.Shopname.ReadOnly = true;
            // 
            // productsPanel
            // 
            this.productsPanel.Controls.Add(this.btnProductsRefresh);
            this.productsPanel.Controls.Add(this.productImageBox);
            this.productsPanel.Controls.Add(this.btnProductDelete);
            this.productsPanel.Controls.Add(this.txtProductID);
            this.productsPanel.Controls.Add(this.dgvProducts);
            this.productsPanel.Location = new System.Drawing.Point(194, 62);
            this.productsPanel.Name = "productsPanel";
            this.productsPanel.Size = new System.Drawing.Size(970, 644);
            this.productsPanel.TabIndex = 44;
            // 
            // btnProductsRefresh
            // 
            this.btnProductsRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnProductsRefresh.FlatAppearance.BorderSize = 0;
            this.btnProductsRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductsRefresh.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductsRefresh.ForeColor = System.Drawing.Color.White;
            this.btnProductsRefresh.Location = new System.Drawing.Point(164, 42);
            this.btnProductsRefresh.Name = "btnProductsRefresh";
            this.btnProductsRefresh.Size = new System.Drawing.Size(96, 39);
            this.btnProductsRefresh.TabIndex = 31;
            this.btnProductsRefresh.Text = "Refresh";
            this.btnProductsRefresh.UseVisualStyleBackColor = false;
            this.btnProductsRefresh.Click += new System.EventHandler(this.btnProductsRefresh_Click);
            // 
            // productImageBox
            // 
            this.productImageBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("productImageBox.BackgroundImage")));
            this.productImageBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.productImageBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.productImageBox.Image = ((System.Drawing.Image)(resources.GetObject("productImageBox.Image")));
            this.productImageBox.Location = new System.Drawing.Point(765, 25);
            this.productImageBox.Name = "productImageBox";
            this.productImageBox.Size = new System.Drawing.Size(137, 133);
            this.productImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.productImageBox.TabIndex = 30;
            this.productImageBox.TabStop = false;
            // 
            // btnProductDelete
            // 
            this.btnProductDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnProductDelete.FlatAppearance.BorderSize = 0;
            this.btnProductDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductDelete.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductDelete.ForeColor = System.Drawing.Color.White;
            this.btnProductDelete.Location = new System.Drawing.Point(31, 42);
            this.btnProductDelete.Name = "btnProductDelete";
            this.btnProductDelete.Size = new System.Drawing.Size(96, 39);
            this.btnProductDelete.TabIndex = 29;
            this.btnProductDelete.Text = "Delete";
            this.btnProductDelete.UseVisualStyleBackColor = false;
            this.btnProductDelete.Click += new System.EventHandler(this.btnProductDelete_Click);
            // 
            // txtProductID
            // 
            this.txtProductID.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtProductID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtProductID.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductID.Location = new System.Drawing.Point(31, 127);
            this.txtProductID.Multiline = true;
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.ReadOnly = true;
            this.txtProductID.Size = new System.Drawing.Size(96, 30);
            this.txtProductID.TabIndex = 28;
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
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.P_Description,
            this.P_Price,
            this.P_Type,
            this.P_Stock});
            this.dgvProducts.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvProducts.Location = new System.Drawing.Point(31, 183);
            this.dgvProducts.MultiSelect = false;
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.ReadOnly = true;
            this.dgvProducts.RowHeadersVisible = false;
            this.dgvProducts.RowHeadersWidth = 51;
            this.dgvProducts.RowTemplate.Height = 60;
            this.dgvProducts.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProducts.Size = new System.Drawing.Size(910, 453);
            this.dgvProducts.TabIndex = 27;
            this.dgvProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProducts_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "P_ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "P_Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
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
            // reviewPanel
            // 
            this.reviewPanel.Controls.Add(this.label7);
            this.reviewPanel.Controls.Add(this.dgvReview);
            this.reviewPanel.Location = new System.Drawing.Point(272, 54);
            this.reviewPanel.Name = "reviewPanel";
            this.reviewPanel.Size = new System.Drawing.Size(839, 687);
            this.reviewPanel.TabIndex = 45;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(295, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(189, 29);
            this.label7.TabIndex = 12;
            this.label7.Text = "Customer Review";
            // 
            // dgvReview
            // 
            this.dgvReview.AllowUserToAddRows = false;
            this.dgvReview.AllowUserToDeleteRows = false;
            this.dgvReview.AllowUserToResizeColumns = false;
            this.dgvReview.AllowUserToResizeRows = false;
            this.dgvReview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReview.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvReview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvReview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.R_Date,
            this.R_Comment,
            this.dataGridViewTextBoxColumn3,
            this.C_ID});
            this.dgvReview.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvReview.Location = new System.Drawing.Point(17, 186);
            this.dgvReview.MultiSelect = false;
            this.dgvReview.Name = "dgvReview";
            this.dgvReview.ReadOnly = true;
            this.dgvReview.RowHeadersVisible = false;
            this.dgvReview.RowHeadersWidth = 51;
            this.dgvReview.RowTemplate.Height = 30;
            this.dgvReview.RowTemplate.ReadOnly = true;
            this.dgvReview.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvReview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReview.Size = new System.Drawing.Size(804, 408);
            this.dgvReview.TabIndex = 11;
            // 
            // R_Date
            // 
            this.R_Date.DataPropertyName = "R_Date";
            this.R_Date.HeaderText = "Review Date";
            this.R_Date.MinimumWidth = 6;
            this.R_Date.Name = "R_Date";
            this.R_Date.ReadOnly = true;
            // 
            // R_Comment
            // 
            this.R_Comment.DataPropertyName = "R_Comment";
            this.R_Comment.HeaderText = "Review";
            this.R_Comment.MinimumWidth = 6;
            this.R_Comment.Name = "R_Comment";
            this.R_Comment.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "P_ID";
            this.dataGridViewTextBoxColumn3.HeaderText = "Product ID";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // C_ID
            // 
            this.C_ID.DataPropertyName = "C_ID";
            this.C_ID.HeaderText = "Customer_ID";
            this.C_ID.MinimumWidth = 6;
            this.C_ID.Name = "C_ID";
            this.C_ID.ReadOnly = true;
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Controls.Add(this.reviewPanel);
            this.Controls.Add(this.sidePanel);
            this.Controls.Add(this.upperPanel);
            this.Controls.Add(this.profilePanel);
            this.Controls.Add(this.productsPanel);
            this.Controls.Add(this.userPanel);
            this.Name = "AdminDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminDashboard";
            this.Load += new System.EventHandler(this.AdminDashboard_Load);
            this.profilePanel.ResumeLayout(false);
            this.profilePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilePicture)).EndInit();
            this.sidePanel.ResumeLayout(false);
            this.upperPanel.ResumeLayout(false);
            this.upperPanel.PerformLayout();
            this.userPanel.ResumeLayout(false);
            this.userPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adminImageBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdmin)).EndInit();
            this.productsPanel.ResumeLayout(false);
            this.productsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productImageBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.reviewPanel.ResumeLayout(false);
            this.reviewPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel profilePanel;
        private System.Windows.Forms.Button btnProfileUpdate;
        private System.Windows.Forms.TextBox txtProfileEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtProfilePassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtProfileName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtProfileID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnProfileUpload;
        private System.Windows.Forms.PictureBox profilePicture;
        private System.Windows.Forms.Panel sidePanel;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Button btnProduct;
        private System.Windows.Forms.Panel upperPanel;
        private System.Windows.Forms.Label adminLabel;
        private System.Windows.Forms.Label adminUsernameLabel;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnUser;
        private System.Windows.Forms.Panel userPanel;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.PictureBox adminImageBox;
        private System.Windows.Forms.Button btnUserDelete;
        private System.Windows.Forms.DataGridView dgvAdmin;
        private System.Windows.Forms.TextBox txtAdminID;
        private System.Windows.Forms.DataGridViewTextBoxColumn P_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn P_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn U_Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn U_Pass;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Shopname;
        private System.Windows.Forms.Panel productsPanel;
        private System.Windows.Forms.Button btnProductsRefresh;
        private System.Windows.Forms.PictureBox productImageBox;
        private System.Windows.Forms.Button btnProductDelete;
        private System.Windows.Forms.TextBox txtProductID;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn P_Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn P_Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn P_Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn P_Stock;
        private System.Windows.Forms.Button btnReviews;
        private System.Windows.Forms.Panel reviewPanel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvReview;
        private System.Windows.Forms.DataGridViewTextBoxColumn R_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn R_Comment;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_ID;
    }
}