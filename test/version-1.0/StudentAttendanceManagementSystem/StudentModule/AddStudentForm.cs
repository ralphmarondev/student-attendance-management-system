using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace StudentAttendanceManagementSystem.DashBoardModule
{
    public partial class AddStudentForm : Form
    {
        public AddStudentForm()
        {
            InitializeComponent();
        }

        private void AddStudentForm_Load(object sender, EventArgs e)
        {

        }

        private void btn_finish_Click(object sender, EventArgs e)
        {
            try
            {
                //This is my connection string i have assigned the database file address path
                string MyConnection2 = "Data Source=LAPTOP-T2HJFRJU\\SQLEXPRESS;Initial Catalog=StudentAttendanceManagementSystemDB;Integrated Security=True";
                //This is my insert query in which i am taking input from the user through windows forms
                string Query = "insert into students_table(id_number, name, address, contact_number, name_of_guardian, college, department, semester, school_year) values" + "('" +
                    tb_id_number.Text + "','" +
                    tb_name.Text + "','" +
                    tb_address.Text + "','" +
                    tb_contact_number.Text + "','" +
                    tb_name_of_guardian.Text + "','" +
                    cb_college.Text + "','" +
                    cb_department.Text + "','" +
                    cb_semester.Text + "','" +
                    cb_school_year.Text + "');";
                //This is  MySqlConnection here i have created the object and pass my connection string.
                SqlConnection MyConn2 = new SqlConnection(MyConnection2);
                //This is command class which will handle the query and connection object.
                SqlCommand MyCommand2 = new SqlCommand(Query, MyConn2);
                SqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.
                MessageBox.Show("Saved Successfully!");
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
    }
}
