using BaiTapLon.BUS;
using BaiTapLon.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapLon
{
    public partial class Form1 : Form
    {
        private BindingSource bindingSource = new BindingSource();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bindingSource.DataSource = ProductBUS.Instance.GetAllProducts();
            dataGridView1.DataSource = bindingSource;
        }
    }
}
