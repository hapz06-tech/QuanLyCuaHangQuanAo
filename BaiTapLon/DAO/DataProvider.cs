using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace BaiTapLon.DAO
{
    public class DataProvider
    {
        private static DataProvider _instance;
        public static DataProvider Instance
        {
            get
            {
                if (_instance == null) _instance = new DataProvider();
                return _instance;
            }
            private set { _instance = value; }
        }
        private DataProvider() { }
        private string connectionString = "Data Source=QuanLyCuaHangQuanAo.db;Version=3;";

        public DataTable ExecuteQuery(string query, Dictionary<string, object> parameters = null)
        {
            DataTable data = new DataTable();
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    // Gắn tham số vào câu lệnh (nếu có) để chống SQL Injection
                    if (parameters != null)
                    {
                        foreach (var item in parameters)
                        {
                            command.Parameters.AddWithValue(item.Key, item.Value);
                        }
                    }

                    using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(command))
                    {
                        adapter.Fill(data);
                    }
                }
            }
            return data;
        }
    }
}
