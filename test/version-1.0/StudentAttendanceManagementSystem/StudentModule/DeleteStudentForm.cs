using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace StudentAttendanceManagementSystem.StudentModule
{
    public partial class DeleteStudentForm : Form
    {
        public DeleteStudentForm()
        {
            InitializeComponent();
        }

        private void btn_finish_Click(object sender, EventArgs e)
        {
            try
            {
                string MyConnection2 = "Data Source=LAPTOP-T2HJFRJU\\SQLEXPRESS;Initial Catalog=StudentAttendanceManagementSystemDB;Integrated Security=True";
                string Query = "delete from students_table where id_number ='" + this.tb_id_number.Text + "';";
                SqlConnection MyConn2 = new SqlConnection(MyConnection2);
                SqlCommand MyCommand2 = new SqlCommand(Query, MyConn2);
                SqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();
                MessageBox.Show("Data Deleted");
                while (MyReader2.Read())
                {
                }
                MyConn2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Hide();
        }

        private void DeleteStudentForm_Load(object sender, EventArgs e)
        {

        }
    }
}
