using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_QuanLyKhoHang_Nhom20.DTO
{
    internal class Customer : User
    {
        public int Customer_id { get; set; }
        public string Address { get; set; }
    }
}
