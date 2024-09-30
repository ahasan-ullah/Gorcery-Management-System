
namespace Gorcery_Management_System
{
    partial class CustomerDashBoard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerDashBoard));
            this.sidePanel = new System.Windows.Forms.Panel();
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnProduct = new System.Windows.Forms.Button();
            this.upperPanel = new System.Windows.Forms.Panel();
            this.sellerLabel = new System.Windows.Forms.Label();
            this.customerUsernameLabel = new System.Windows.Forms.Label();
            this.profilePanel = new System.Windows.Forms.Panel();
            this.btnProfileUpdate = new System.Windows.Forms.Button();
            this.txtProfileEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtProfilePassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtProfileName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rtxtProfileAddress = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtProfileID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnProfileUpload = new System.Windows.Forms.Button();
            this.profilePicture = new System.Windows.Forms.PictureBox();
            this.productsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.sidePanel.SuspendLayout();
            this.upperPanel.SuspendLayout();
            this.profilePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilePicture)).BeginInit();
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
            this.sidePanel.TabIndex = 28;
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
            // upperPanel
            // 
            this.upperPanel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.upperPanel.Controls.Add(this.sellerLabel);
            this.upperPanel.Controls.Add(this.customerUsernameLabel);
            this.upperPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.upperPanel.Location = new System.Drawing.Point(0, 0);
            this.upperPanel.Name = "upperPanel";
            this.upperPanel.Size = new System.Drawing.Size(1182, 52);
            this.upperPanel.TabIndex = 26;
            // 
            // sellerLabel
            // 
            this.sellerLabel.AutoSize = true;
            this.sellerLabel.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sellerLabel.Location = new System.Drawing.Point(991, 10);
            this.sellerLabel.Name = "sellerLabel";
            this.sellerLabel.Size = new System.Drawing.Size(71, 29);
            this.sellerLabel.TabIndex = 3;
            this.sellerLabel.Text = "Buyer";
            // 
            // customerUsernameLabel
            // 
            this.customerUsernameLabel.AutoSize = true;
            this.customerUsernameLabel.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerUsernameLabel.Location = new System.Drawing.Point(25, 10);
            this.customerUsernameLabel.Name = "customerUsernameLabel";
            this.customerUsernameLabel.Size = new System.Drawing.Size(226, 29);
            this.customerUsernameLabel.TabIndex = 2;
            this.customerUsernameLabel.Text = "Customer DashBoard";
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
            this.profilePanel.Controls.Add(this.rtxtProfileAddress);
            this.profilePanel.Controls.Add(this.label1);
            this.profilePanel.Controls.Add(this.txtProfileID);
            this.profilePanel.Controls.Add(this.label2);
            this.profilePanel.Controls.Add(this.btnProfileUpload);
            this.profilePanel.Controls.Add(this.profilePicture);
            this.profilePanel.Location = new System.Drawing.Point(255, 62);
            this.profilePanel.Name = "profilePanel";
            this.profilePanel.Size = new System.Drawing.Size(915, 644);
            this.profilePanel.TabIndex = 29;
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
            this.txtProfileEmail.Location = new System.Drawing.Point(260, 310);
            this.txtProfileEmail.Multiline = true;
            this.txtProfileEmail.Name = "txtProfileEmail";
            this.txtProfileEmail.Size = new System.Drawing.Size(289, 30);
            this.txtProfileEmail.TabIndex = 36;
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
            // productsPanel
            // 
            this.productsPanel.Location = new System.Drawing.Point(203, 58);
            this.productsPanel.Name = "productsPanel";
            this.productsPanel.Size = new System.Drawing.Size(964, 683);
            this.productsPanel.TabIndex = 40;
            // 
            // CustomerDashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Controls.Add(this.profilePanel);
            this.Controls.Add(this.sidePanel);
            this.Controls.Add(this.upperPanel);
            this.Controls.Add(this.productsPanel);
            this.Name = "CustomerDashBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomerDashBoard";
            this.Load += new System.EventHandler(this.CustomerDashBoard_Load);
            this.sidePanel.ResumeLayout(false);
            this.upperPanel.ResumeLayout(false);
            this.upperPanel.PerformLayout();
            this.profilePanel.ResumeLayout(false);
            this.profilePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilePicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sidePanel;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Button btnProduct;
        private System.Windows.Forms.Panel upperPanel;
        private System.Windows.Forms.Label sellerLabel;
        private System.Windows.Forms.Label customerUsernameLabel;
        private System.Windows.Forms.Panel profilePanel;
        private System.Windows.Forms.Button btnProfileUpdate;
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
        private System.Windows.Forms.FlowLayoutPanel productsPanel;
    }
}