using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Database database = new Database();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            textBox_passwordd.PasswordChar = '*';
            textBox_passwordd.MaxLength = 50;
            textBox_loginn.MaxLength = 50;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_log_Click(object sender, EventArgs e)
        {
            var loginUser = textBox_loginn.Text;
            var password = textBox_passwordd.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable(); // Два объекта класса для работы с БД

            string querystring = $"select id, login, password from register where login = '{loginUser}' and  password = '{password}'";
            SqlCommand command = new SqlCommand(querystring, database.GetConnection()); // Создали переменную для запроса в SSMS и объект команды запроса

            adapter.SelectCommand = command;
            adapter.Fill(table); // Заносим данные в таблицу

            if(table.Rows.Count == 1) // Проверка равности строки 1(были данные)
            {
                MessageBox.Show("Вы успешно вошли!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DataGrid drg = new DataGrid();
                drg.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Такого аккаунта не существует!", "Аккаунта нет!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
