using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapLon.DAO
{
    internal class ProductDAO
    {
        public DataTable LayDanhSachSanPham()
        {
            string query = "SELECT * FROM products WHERE is_deleted = 0";
            return DataProvider.Instance.ExecuteQuery(query);
        }
    }
}
