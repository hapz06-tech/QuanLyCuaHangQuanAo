using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_QuanLyKhoHang_Nhom20.DTO
{
    public abstract class User
    {
        public string Full_name { get; set; }
        public string Gender { get; set; }
        public string Phone_number { get; set; }
    }
}
