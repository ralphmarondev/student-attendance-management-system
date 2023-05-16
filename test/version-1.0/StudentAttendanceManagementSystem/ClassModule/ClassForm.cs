using StudentAttendanceManagementSystem.DashBoardModule;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace StudentAttendanceManagementSystem.ClassModule
{
    public partial class ClassForm : Form
    {
        public ClassForm()
        {
            InitializeComponent();
        }

        private void btn_add_class_Click(object sender, EventArgs e)
        {
            AddClassForm add_class_form = new AddClassForm();

            add_class_form.Show();
        }

        private void btn_update_class_Click(object sender, EventArgs e)
        {
            UpdateClassForm update_class_form = new UpdateClassForm();

            update_class_form.Show();
        }

        private void btn_delete_class_Click(object sender, EventArgs e)
        {
            DeleteClassForm delete_class_form = new DeleteClassForm();

            delete_class_form.Show();
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            try
            {
                string MyConnection2 = "Data Source=LAPTOP-T2HJFRJU\\SQLEXPRESS;Initial Catalog=StudentAttendanceManagementSystemDB;Integrated Security=True";
                //Display query
                string Query = "select * from classes_table;";
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

        private void btn_back_Click(object sender, EventArgs e)
        {
            DashBoardForm dash_board_form = new DashBoardForm();

            dash_board_form.Show();
            this.Hide();
        }

        private void ClassForm_Load(object sender, EventArgs e)
        {
            btn_refresh_Click(sender, e);
        }

        private void btn_search_class_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=LAPTOP-T2HJFRJU\\SQLEXPRESS;Initial Catalog=StudentAttendanceManagementSystemDB;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("Select * from classes_table where class_code = @class_code", conn);
            conn.Open();
            cmd.Parameters.AddWithValue("class_code", tb_class_code_search.Text);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgv_classes_lists.DataSource = dt;
        }
    }
}
