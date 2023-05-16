using StudentAttendanceManagementSystem.ClassModule;
using StudentAttendanceManagementSystem.StudentModule;
using System;
using System.Windows.Forms;

namespace StudentAttendanceManagementSystem.DashBoardModule
{
    public partial class DashBoardForm : Form
    {
        public DashBoardForm()
        {
            InitializeComponent();
        }

        private void btn_class_form_Click(object sender, EventArgs e)
        {
            ClassForm class_form = new ClassForm();

            class_form.Show();
            this.Hide();
        }

        private void btn_student_form_Click(object sender, EventArgs e)
        {
            StudentForm student_form = new StudentForm();

            student_form.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainForm main_form = new MainForm();

            main_form.Show();
            Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
