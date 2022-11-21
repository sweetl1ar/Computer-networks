using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; // Библиотека БД

namespace WindowsFormsApp1
{
    internal class Database
    {
        SqlConnection sqlconnection = new SqlConnection(@"Data Source=PC-9; Initial Catalog = DNS; Integrated Security=True"); // Подключение
        public void openConnection()
        {
            if(sqlconnection.State == System.Data.ConnectionState.Closed) sqlconnection.Open();
        }
        public void closeConnection()
        {
            if (sqlconnection.State == System.Data.ConnectionState.Open) sqlconnection.Close();
        }
        public SqlConnection GetConnection()
        {
            return sqlconnection;
        }
    }
}
