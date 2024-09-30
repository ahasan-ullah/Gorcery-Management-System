
namespace Gorcery_Management_System
{
    partial class SignIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignIn));
            this.loginPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.signUpLink = new System.Windows.Forms.LinkLabel();
            this.btnSignIn = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.Logo = new System.Windows.Forms.Label();
            this.loginPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginPanel
            // 
            this.loginPanel.BackColor = System.Drawing.SystemColors.Control;
            this.loginPanel.Controls.Add(this.label1);
            this.loginPanel.Controls.Add(this.label3);
            this.loginPanel.Controls.Add(this.signUpLink);
            this.loginPanel.Controls.Add(this.btnSignIn);
            this.loginPanel.Controls.Add(this.txtPassword);
            this.loginPanel.Controls.Add(this.txtID);
            this.loginPanel.Controls.Add(this.passwordLabel);
            this.loginPanel.Controls.Add(this.idLabel);
            this.loginPanel.Location = new System.Drawing.Point(1, 190);
            this.loginPanel.Name = "loginPanel";
            this.loginPanel.Size = new System.Drawing.Size(579, 562);
            this.loginPanel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mimmo", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(147, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 38);
            this.label1.TabIndex = 21;
            this.label1.Text = "Happy Shopping";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(150, 414);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 21);
            this.label3.TabIndex = 20;
            this.label3.Text = "Don\'t have any account?";
            // 
            // signUpLink
            // 
            this.signUpLink.AutoSize = true;
            this.signUpLink.Font = new System.Drawing.Font("Calibri Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signUpLink.Location = new System.Drawing.Point(356, 414);
            this.signUpLink.Name = "signUpLink";
            this.signUpLink.Size = new System.Drawing.Size(63, 21);
            this.signUpLink.TabIndex = 19;
            this.signUpLink.TabStop = true;
            this.signUpLink.Text = "Sign Up";
            this.signUpLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.signUpLink_LinkClicked);
            // 
            // btnSignIn
            // 
            this.btnSignIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSignIn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSignIn.FlatAppearance.BorderSize = 0;
            this.btnSignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignIn.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignIn.ForeColor = System.Drawing.Color.White;
            this.btnSignIn.Location = new System.Drawing.Point(136, 443);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(295, 67);
            this.btnSignIn.TabIndex = 18;
            this.btnSignIn.Text = "Sign In";
            this.btnSignIn.UseVisualStyleBackColor = false;
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(219, 230);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(289, 30);
            this.txtPassword.TabIndex = 14;
            // 
            // txtID
            // 
            this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtID.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(219, 161);
            this.txtID.Multiline = true;
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(289, 30);
            this.txtID.TabIndex = 13;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.Location = new System.Drawing.Point(59, 231);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(105, 29);
            this.passwordLabel.TabIndex = 12;
            this.passwordLabel.Text = "Password";
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idLabel.Location = new System.Drawing.Point(59, 162);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(34, 29);
            this.idLabel.TabIndex = 11;
            this.idLabel.Text = "ID";
            // 
            // Logo
            // 
            this.Logo.AutoSize = true;
            this.Logo.Font = new System.Drawing.Font("Mimmo", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Logo.Location = new System.Drawing.Point(187, 55);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(178, 47);
            this.Logo.TabIndex = 2;
            this.Logo.Text = "ShopiFy";
            // 
            // SignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(582, 753);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.loginPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SignIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SignIn";
            this.loginPanel.ResumeLayout(false);
            this.loginPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel loginPanel;
        private System.Windows.Forms.Label Logo;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel signUpLink;
        private System.Windows.Forms.Button btnSignIn;
        private System.Windows.Forms.Label label1;
    }
}