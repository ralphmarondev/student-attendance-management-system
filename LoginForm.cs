using System;
using System.Windows.Forms;

namespace StudentAttendanceManagementSystem
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = tb_username.Text;
            string password = tb_password.Text;

            if (username == "root" && password == "toor")
            {
                DashBoardForm dash_board_form = new DashBoardForm();

                dash_board_form.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Credentials!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            tb_username.Clear();
            tb_password.Clear();
        }

        private void link_lbl_forgot_password_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Username: root\nPassword: toor\n", "DEFAULT CREDENTIALS", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
