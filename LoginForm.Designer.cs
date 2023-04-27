namespace StudentAttendanceManagementSystem
{
    partial class LoginForm
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
            this.gb_login = new System.Windows.Forms.GroupBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.lbl_username = new System.Windows.Forms.Label();
            this.tb_username = new System.Windows.Forms.TextBox();
            this.lbl_password = new System.Windows.Forms.Label();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.link_lbl_forgot_password = new System.Windows.Forms.LinkLabel();
            this.gb_login.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_login
            // 
            this.gb_login.BackColor = System.Drawing.SystemColors.Control;
            this.gb_login.Controls.Add(this.link_lbl_forgot_password);
            this.gb_login.Controls.Add(this.lbl_password);
            this.gb_login.Controls.Add(this.tb_password);
            this.gb_login.Controls.Add(this.lbl_username);
            this.gb_login.Controls.Add(this.tb_username);
            this.gb_login.Controls.Add(this.btn_login);
            this.gb_login.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_login.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.gb_login.Location = new System.Drawing.Point(365, 107);
            this.gb_login.Name = "gb_login";
            this.gb_login.Size = new System.Drawing.Size(431, 379);
            this.gb_login.TabIndex = 0;
            this.gb_login.TabStop = false;
            this.gb_login.Text = "LOGIN";
            // 
            // btn_login
            // 
            this.btn_login.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.Location = new System.Drawing.Point(30, 265);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(374, 47);
            this.btn_login.TabIndex = 0;
            this.btn_login.Text = "LOGIN";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_username.Location = new System.Drawing.Point(26, 57);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(89, 17);
            this.lbl_username.TabIndex = 1;
            this.lbl_username.Text = "Username:";
            // 
            // tb_username
            // 
            this.tb_username.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_username.Location = new System.Drawing.Point(30, 82);
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(374, 30);
            this.tb_username.TabIndex = 2;
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_password.Location = new System.Drawing.Point(26, 149);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(89, 17);
            this.lbl_password.TabIndex = 3;
            this.lbl_password.Text = "Password:";
            // 
            // tb_password
            // 
            this.tb_password.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_password.Location = new System.Drawing.Point(30, 174);
            this.tb_password.Name = "tb_password";
            this.tb_password.Size = new System.Drawing.Size(374, 30);
            this.tb_password.TabIndex = 4;
            // 
            // link_lbl_forgot_password
            // 
            this.link_lbl_forgot_password.AutoSize = true;
            this.link_lbl_forgot_password.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.link_lbl_forgot_password.Location = new System.Drawing.Point(137, 332);
            this.link_lbl_forgot_password.Name = "link_lbl_forgot_password";
            this.link_lbl_forgot_password.Size = new System.Drawing.Size(169, 20);
            this.link_lbl_forgot_password.TabIndex = 5;
            this.link_lbl_forgot_password.TabStop = true;
            this.link_lbl_forgot_password.Text = "Forgot Password?";
            this.link_lbl_forgot_password.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_lbl_forgot_password_LinkClicked);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1094, 591);
            this.Controls.Add(this.gb_login);
            this.Font = new System.Drawing.Font("Courier New", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOGIN";
            this.gb_login.ResumeLayout(false);
            this.gb_login.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_login;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.TextBox tb_username;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.LinkLabel link_lbl_forgot_password;
    }
}

