﻿using StudentAttendanceManagementSystem.DashBoardModule;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace StudentAttendanceManagementSystem
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// This verifies if the username and password is on the database,
        /// if it is there, it will open DashboardForm, otherwise,
        /// it will show a message-box saying 'login failed'
        /// </summary>
        private void btn_login_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=LAPTOP-T2HJFRJU\\SQLEXPRESS;Initial Catalog=StudentAttendanceManagementSystemDB;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select * From dbo.Users where username=@username AND password=@password", conn);
            cmd.Parameters.AddWithValue("username", tb_username.Text.Trim());
            cmd.Parameters.AddWithValue("password", tb_password.Text.Trim());

            try
            {
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    DashBoardForm dash_board_form = new DashBoardForm();

                    dash_board_form.Show();

                    tb_username.Clear();
                    tb_password.Clear();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Username and Password doesn't match!", "Login Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    tb_username.Clear();
                    tb_password.Clear();
                }
            }
            catch
            {
                MessageBox.Show("Username and Password doesn't match!", "Login Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                tb_username.Clear();
                tb_password.Clear();
            }



        }

        private void link_lbl_forgot_password_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Default Credentials:\nUsername: root\nPassword: toor\n", "HINT", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
