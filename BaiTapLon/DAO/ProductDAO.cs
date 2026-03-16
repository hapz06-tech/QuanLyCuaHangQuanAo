using BTL_QuanLyKhoHang_Nhom20;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapLon.DAO
{
    internal class ProductDAO
    {
        private static ProductDAO instance = new ProductDAO();

        public static ProductDAO Instance { get { return instance; } }
        public List<Product> GetAllProducts()
        {
            List<Product> list = new List<Product>();
            string query = @"SELECT p.product_id, p.product_name, c.category_name, 
                            p.size, p.selling_price, p.stock_quantity, p.is_selected
                     FROM products p
                     INNER JOIN categories c ON p.category_id = c.category_id
                     WHERE p.is_deleted = 0";

            using (SQLiteConnection conn = DataProvider.GetConnection())
            {
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    conn.Open();
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read()) // Đọc từng dòng trong database
                        {
                            Product p = new Product
                            {
                                Product_id = Convert.ToInt32(reader["product_id"]),
                                Product_name = reader["product_name"].ToString(),
                                Category_name = reader["category_name"].ToString(),
                                Product_size = reader["size"].ToString(),
                                Product_sellingPrice = Convert.ToSingle(reader["selling_price"]),
                                Product_stockQuantity = Convert.ToInt32(reader["stock_quantity"]),
                                Is_selected = Convert.ToBoolean(reader["is_selected"])
                            };

                            list.Add(p);
                        }
                    }
                }
            }
            return list;
        }
    }
}
