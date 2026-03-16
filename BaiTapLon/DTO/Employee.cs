using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_QuanLyKhoHang_Nhom20.DTO
{
    internal class Employee : User
    {
        public int Employee_id {  get; set; }
        public int Role_id { get; set; }
        public string Username { get; set; }
        public string Password_hash { get; set; }
        public bool Is_deleted { get; set; }
    }
}
