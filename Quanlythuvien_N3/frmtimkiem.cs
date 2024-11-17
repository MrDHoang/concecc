using System;
using System .Collections .Generic;
using System .ComponentModel;
using System .Data;
using System .Data .SqlClient;
using System .Drawing;
using System .Linq;
using System .Text;
using System .Threading .Tasks;
using System .Windows .Forms;

namespace Quanlythuvien_N3
{
    public partial class frmtimkiem : Form
    {
        private string connectionString = @"Data Source=HOANG\SQLEXPRESS;Initial Catalog=YOUR_DATABASE_NAME;Integrated Security=True";
        public frmtimkiem()
        {
            InitializeComponent();
        }
        private void pbtimkiem_Click(object sender , EventArgs e)
        {
            string key = txttimkiem .Text;
            string sql = $"select * from Tailieu where matailieu = '%{key}%' or tentailieu like N'%{key}%' or loaitailieu like N'%{key}%' or nhaxuatban like N'%{key}%' or namxuatban like N'%{key}%' or soluong like N'%{key}%' or trangthai like N'%{key}%'";
            Xulydulieu xl = new Xulydulieu();
            DataTable data = xl .LayDuLieu(sql);
            if (data .Rows .Count == 0)
            {
                MessageBox .Show("không có dữ liệu  liên quan!");
            }
            else
                dgvtimkiem .DataSource = data;
        }

        private void txttimkiem_KeyDown(object sender , KeyEventArgs e)
        {
            if (e .KeyCode == Keys .Enter)
            {
                pbtimkiem_Click(sender , e);
            }
        }
        private void btdangnhapquantrivien_Click(object sender , EventArgs e)
        {
            frmdangnhapquantrivien f = new frmdangnhapquantrivien();
            f .Show();
        }

        private void btdangnhaphoivien_Click(object sender , EventArgs e)
        {
            frmdangnhaphoivien f = new frmdangnhaphoivien();
            f .Show();
        }

        private void btdangnhap_Click(object sender , EventArgs e)
        {
            string username = txttaikhoan .Text;
            string password = txtmatkhau .Text;

            string role = kiemtra(username , password);

            if (!string .IsNullOrEmpty(role))
            {
                if (role == "Thủ Thư")
                {
                    // Mở form Thủ Thư
                    frmthuthu f = new frmthuthu();
                    f .Show();
                }
                else if (role == "Hội Viên")
                {
                    // Mở form Hội Viên
                    frmhoivien f = new frmhoivien();
                    f .Show();
                }
            }
            else
            {
                MessageBox .Show("Tên đăng nhập hoặc mật khẩu không đúng!" , "Lỗi");
            }
        }

    }
}
