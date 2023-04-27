using System.Windows.Forms;

namespace StudentAttendanceManagementSystem
{
    public partial class DashBoardForm : Form
    {
        public DashBoardForm()
        {
            InitializeComponent();
        }

        private void DashBoardForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoginForm login_form = new LoginForm();

            login_form.Show();
        }
    }
}
