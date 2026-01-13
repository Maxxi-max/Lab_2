using System.Data;
using System.Data.OleDb;
namespace Lab6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        string connectionstring = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=C:\Users\pc\source\repos\Lab_2\Lab_2\Lab6\FilterTolerance.accdb;";
        private void load_database(object sender, EventArgs e)
        {
            OleDbConnection connect = new OleDbConnection(connectionstring);
            string query = "SELECT * From Посадки";
            OleDbDataAdapter adapter = new OleDbDataAdapter(query, connectionstring);
            DataTable dt = new DataTable();
            connect.Open();
            adapter.Fill(dt);
            connect.Close();
            dataGridView1.DataSource = dt;

        }

        private void btn_insert_dt(object sender, EventArgs e)
        {
            string otv = textBox1.Text;
            string type = textBox2.Text;
            OleDbConnection connect = new OleDbConnection(connectionstring);
            string query = @$"INSERT INTO [Посадки] ([Отверстия], [Тип посадки]) VALUES ('{otv}', '{type}')";
            OleDbCommand cmd = new OleDbCommand(query, connect);
            connect.Open();
            try 
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Добавление невозможно");
            }
            connect.Close();
        }

        private void btn_delete_dt(object sender, EventArgs e)
        {
            string name = textBox6.Text;
            OleDbConnection connect = new OleDbConnection(connectionstring);
            string query = @$"DELETE FROM [Посадки] WHERE [Отверстия] = '{name}'";
            OleDbCommand cmd = new OleDbCommand(query, connect);
            connect.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Удаление невозможно");
            }
            connect.Close();
        }


        private void btn_update_dt(object sender, EventArgs e)
        {
            string otv = textBox4.Text;
            string type = textBox3.Text;
            int i = dataGridView1.CurrentCell.RowIndex;
            string id = dataGridView1[0, i].Value.ToString();
            OleDbConnection connect = new OleDbConnection(connectionstring);
            string query = @$"UPDATE [Посадки] SET [Отверстия] =  '{otv}', [Тип посадки] = '{type}' WHERE [ID] = {id}";
            OleDbCommand cmd = new OleDbCommand(query, connect);
            connect.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Обновление невозможно");
            }
            connect.Close();
            
        }
        

    }
}
