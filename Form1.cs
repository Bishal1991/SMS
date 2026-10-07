using Accessibility;
using System.Data;
using System.Data.OleDb;

namespace StudentManagementSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //dataGridView1.AutoGenerateColumns = true;
            //dataGridView1.AllowUserToAddRows = false;
        }
        int rowSelectedIndex = 0;
        String dbconnection = $@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SMS.accdb";


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt16(txtID.Text);
            string name = NameTxt.Text;
            int rolln = Convert.ToInt16(RollNumTxt.Text);
            string sec = SectionTxt.Text;
            int age = Convert.ToInt16(AgeTxt.Text);
            string addr = AddressTxt.Text;
            string phNo = PhNumTxt.Text;
            OleDbConnection conn = new OleDbConnection(dbconnection);
            string query = "INSERT INTO StudentManagementSystem ([ID], [Name], [RollNumber], [Section], [Age], [Address], [PhoneNumber]) VALUES (?, ?, ?, ?, ?, ?, ?)";

            OleDbCommand oleDbCommand = new OleDbCommand(query, conn);
            oleDbCommand.Parameters.AddWithValue("@Id", id);
            oleDbCommand.Parameters.AddWithValue("@Name", name);
            oleDbCommand.Parameters.AddWithValue("@RollNumber", rolln);
            oleDbCommand.Parameters.AddWithValue("@Section", sec);
            oleDbCommand.Parameters.AddWithValue("@Age", age);
            oleDbCommand.Parameters.AddWithValue("@Address", addr);
            oleDbCommand.Parameters.AddWithValue("@PhoneNumber", phNo);

            conn.Open();
            oleDbCommand.ExecuteNonQuery();
            conn.Close();



        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ViewBtn_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            OleDbConnection conn = new OleDbConnection(dbconnection);
            string dbcmd = "SELECT * From StudentManagementSystem";

            OleDbCommand oleDbCommand = new OleDbCommand(dbcmd, conn);
            OleDbDataAdapter adapter = new OleDbDataAdapter(oleDbCommand);

            adapter.Fill(dt);

            dataGridView1.DataSource = dt;
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection(dbconnection);
            string query = "UPDATE StudentManagementSystem SET [Name]=?, [RollNumber]=?, [Section]=?, [Age]=?, [Address]=?, [PhoneNumber]=? WHERE [ID]=?";
            OleDbCommand oleDbCommand = new OleDbCommand(query, conn);
            var selectedRow = dataGridView1.Rows[rowSelectedIndex];
            oleDbCommand.Parameters.AddWithValue("@id", selectedRow.Cells["ID"].Value);
            oleDbCommand.Parameters.AddWithValue("@name", selectedRow.Cells["Name"].Value);
            oleDbCommand.Parameters.AddWithValue("@rollnumber", selectedRow.Cells["RollNumber"].Value);
            oleDbCommand.Parameters.AddWithValue("@section", selectedRow.Cells["Section"].Value);
            oleDbCommand.Parameters.AddWithValue("@age", selectedRow.Cells["Age"].Value);
            oleDbCommand.Parameters.AddWithValue("@address", selectedRow.Cells["Address"].Value);
            oleDbCommand.Parameters.AddWithValue("@phoneNumber", selectedRow.Cells["PhoneNumber"].Value);

            conn.Open();
            oleDbCommand.ExecuteNonQuery();
            conn.Close();
        }

        private void dltBtn_Click(object sender, EventArgs e)
        {
            OleDbConnection oleDbConnection = new OleDbConnection(dbconnection);
            string query = "DELETE FROM StudentManagementSystem WHERE ID = ?";
            OleDbCommand oleDbCommand = new OleDbCommand(query, oleDbConnection);

            var selectedRow = dataGridView1.Rows[rowSelectedIndex];

            oleDbCommand.Parameters.AddWithValue("@id", selectedRow.Cells["ID"].Value.ToString());
           

            oleDbConnection.Open();
            oleDbCommand.ExecuteNonQuery();
            oleDbConnection.Close();
        }
    }
}
