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
    public partial class frmthemtailieu : Form
    {
        public frmthemtailieu()
        {
            InitializeComponent();
        }

        private void pbhuyluu_Click(object sender , EventArgs e)
        {
            this .Close();
        }

        private void pbluutailieu_Click(object sender , EventArgs e)
        {
            string sql = $"insert into tacgia (matailieu,tentailieu,loaitailieu,nhaxuatban,namxuatban,soluong,trangthai) values (N'{txtmatailieu .Text}', N'{txttentailieu .Text}', N'{txtloaitailieu .Text}', N'{txtnhaxuatbantailieu .Text}', N'{txtnamsanxuat.Text}', N'{txtsoluong.Text}', N'{txttrangthaitailieu.Text}') ";
            Xulydulieu xl = new Xulydulieu();
            int kq = xl .ThucHienLenh(sql);
            if (kq == -1)
                MessageBox .Show("Không thể lưu! Vui lòng thử lại.");
            else
                MessageBox .Show("Thêm Tác giả thành công.");
        }
    }
}
