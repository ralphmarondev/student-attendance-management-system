using StudentAttendanceManagementSystem.DashBoardModule;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace StudentAttendanceManagementSystem.StudentModule
{
    public partial class StudentForm : Form
    {
        public StudentForm()
        {
            InitializeComponent();
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            try
            {
                string MyConnection2 = "Data Source=LAPTOP-T2HJFRJU\\SQLEXPRESS;Initial Catalog=StudentAttendanceManagementSystemDB;Integrated Security=True";
                //Display query
                string Query = "select * from students_table;";
                SqlConnection MyConn2 = new SqlConnection(MyConnection2);
                SqlCommand MyCommand2 = new SqlCommand(Query, MyConn2);
                //  MyConn2.Open();
                //For offline connection we weill use  MySqlDataAdapter class.
                SqlDataAdapter MyAdapter = new SqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand2;
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);
                dgv_classes_lists.DataSource = dTable; // here i have assign dTable object to the dataGridView1 object to display data.
                                                       // MyConn2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_add_class_Click(object sender, EventArgs e)
        {
            AddStudentForm add_student_form = new AddStudentForm();

            add_student_form.Show();
        }

        private void btn_update_student_Click(object sender, EventArgs e)
        {
            UpdateStudentForm update_student_form = new UpdateStudentForm();

            update_student_form.Show();
        }

        private void btn_delete_student_Click(object sender, EventArgs e)
        {
            DeleteStudentForm delete_student_form = new DeleteStudentForm();

            delete_student_form.Show();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            DashBoardForm dash_board_form = new DashBoardForm();

            dash_board_form.Show();
            this.Hide();
        }

        private void dgv_classes_lists_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_search_student_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=LAPTOP-T2HJFRJU\\SQLEXPRESS;Initial Catalog=StudentAttendanceManagementSystemDB;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("Select * from students_table where id_number = @id_number", conn);
            conn.Open();
            cmd.Parameters.AddWithValue("id_number", tb_student_id_search.Text);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgv_classes_lists.DataSource = dt;
        }
    }
}
