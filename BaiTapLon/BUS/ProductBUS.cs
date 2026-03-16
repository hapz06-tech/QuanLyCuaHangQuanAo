using BaiTapLon.DAO;
using BTL_QuanLyKhoHang_Nhom20;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapLon.BUS
{
    internal class ProductBUS
    {
        private static ProductBUS instance = new ProductBUS();
        public static ProductBUS Instance {  get { return instance; } }
        public List<Product> GetAllProducts()
        {
            return ProductDAO.Instance.GetAllProducts();
        }
    }
}
