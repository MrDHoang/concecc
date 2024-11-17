using System;
using System .Collections .Generic;
using System .ComponentModel;
using System .Data;
using System .Drawing;
using System .Linq;
using System .Text;
using System .Threading .Tasks;
using System .Windows .Forms;

namespace Quanlythuvien_N3
{
    public partial class frmsuatailieu : Form
    {
        public frmsuatailieu()
        {
            InitializeComponent();
        }
        public string matailieu = "";
        private void frmsuatailieu_Load(object sender , EventArgs e)
        {
            Xulydulieu xl = new Xulydulieu();
            DataTable data = xl .LayDuLieu($"select * from tailieu where matailieu='{matailieu}';");
            txtmatailieu .Text = data .Rows[0][0] .ToString();
            txttentailieu .Text = data .Rows[0][1] .ToString();
            txtloaitailieu .Text = data .Rows[0][2] .ToString();
            txtnhaxuatbantailieu .Text = data .Rows[0][3] .ToString();
            txtnamsanxuat .Text = data .Rows[0][4] .ToString();
            txtsoluong .Text = data .Rows[0][5] .ToString();
            txttrangthaitailieu .Text = data .Rows[0][6] .ToString();
        }

        private void pbluutailieu_Click(object sender , EventArgs e)
        {
            string sql = $"update tailieu set MaTaiLieu='{txtmatailieu .Text}', TenTaiLieu=N'{txttentailieu .Text}', LoaiTaiLieu=N'{txtloaitailieu .Text}', NhaXuatBan='{txtnhaxuatbantailieu .Text}', NamXuatBan='{txtnamsanxuat.Text}', SoLuong='{txtsoluong.Text}', TrangThai='{txttrangthaitailieu .Text}' where matailieu = '{matailieu}'";
            Xulydulieu xl = new Xulydulieu();
            int kq = xl .ThucHienLenh(sql);
            if (kq == -1)
            {
                MessageBox .Show("Không thể sửa vui nòng thử nại!");
            }
            else
            {
                MessageBox .Show("Đã sửa tài liệu");
            }
        }
    }
}
