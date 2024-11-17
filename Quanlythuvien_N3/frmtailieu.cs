using System;
using System .Collections .Generic;
using System .ComponentModel;
using System .Data;
using System .Drawing;
using System .Linq;
using System .Text;
using System .Threading .Tasks;
using System .Windows .Forms;
using static System .Windows .Forms .VisualStyles .VisualStyleElement;

namespace Quanlythuvien_N3
{
    public partial class frmtailieu : Form
    {
        public frmtailieu()
        {
            InitializeComponent();
        }

        private void tsbxemtailieu_Click(object sender , EventArgs e)
        {
            Xulydulieu XL = new Xulydulieu();
            DataTable kq = XL .LayDuLieu("Select * from TAILIEU");
            dgvtailieu .DataSource = kq;
        }

        private void tsbxoatailieu_Click(object sender , EventArgs e)
        {
            DialogResult rs = MessageBox .Show("Bạn có chắc muốn xóa tài liệu không?" , "Cảnh báo xóa tài liệu" , MessageBoxButtons .YesNo , MessageBoxIcon .Warning);
            if (rs == DialogResult .Yes)
            {
                Xulydulieu xl = new Xulydulieu();
                string matailieu = dgvtailieu .SelectedRows[0] .Cells[0] .Value .ToString();
                DataTable data = xl .LayDuLieu($"select 1 from danhsach_tacgia where matailieu='{matailieu}'");
                if (data .Rows .Count > 0)
                {
                    MessageBox .Show("Tài liệu này có dư liệu liên quan không được xóa!");
                }
                else
                {
                    string sql = $"delete from tailieu where matailieu='{matailieu}'";
                    int kq = xl .ThucHienLenh(sql);
                    if (kq == -1)
                    {
                        MessageBox .Show("Không thể xóa vui nòng thử lại!");
                    }
                    else
                    {
                        MessageBox .Show("Đã xóa tài liệu");
                    }
                }
            }
        }

        private void tsbsuatailieu_Click(object sender , EventArgs e)
        {
            frmsuatailieu f = new frmsuatailieu();
            f .matailieu = dgvtailieu .SelectedRows[0] .Cells[0] .Value .ToString();
            f .ShowDialog();
        }

        private void txttimkiem_Click(object sender , EventArgs e)
        {
        }

        private void tsbtimkiem_Click(object sender , EventArgs e)
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
                dgvtailieu .DataSource = data;
        }

        private void frmtailieu_Load(object sender , EventArgs e)
        {
            tsbxemtailieu .PerformClick();
        }

        private void txttimkiem_KeyDown(object sender , KeyEventArgs e)
        {
            if (e .KeyCode == Keys .Enter)
            {
                tsbtimkiem .PerformClick();
            }
        }
        private void tsbthemtailieu_Click(object sender , EventArgs e)
        {
            frmthemtailieu f = new frmthemtailieu();
            f .ShowDialog();
        }
    }
}
