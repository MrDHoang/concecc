using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quanlythuvien_N3
{
    public partial class frmtacgia : Form
    {
        public frmtacgia()
        {
            InitializeComponent();
        }

        private void dgvtacgia_CellContentClick(object sender , DataGridViewCellEventArgs e)
        {
            Xulydulieu XL = new Xulydulieu();
            DataTable kq = XL .LayDuLieu("Select * from TACGIA");
            dgvtacgia .DataSource = kq;
        }

        private void tsbxemtacgia_Click(object sender , EventArgs e)
        {
            Xulydulieu XL = new Xulydulieu();
            DataTable kq = XL .LayDuLieu("Select * from TACGIA");
            dgvtacgia .DataSource = kq;
        }

        private void tsbtimkiem_Click(object sender , EventArgs e)
        {
            string key = txttimkiem .Text;
            string sql = $"select * from Tacgia where matacgia like '%{key}%' or tentacgia like N'%{key}%' or quoctich like N'%{key}%'";
            Xulydulieu xl = new Xulydulieu();
            DataTable data = xl .LayDuLieu(sql);
            if (data .Rows .Count == 0)
            {
                MessageBox .Show("không có dữ liệu  liên quan!");
            }
            else
                dgvtacgia .DataSource = data;
        }

        private void tsbsuatacgia_Click(object sender , EventArgs e)
        {
            frmsuatacgiacs f = new frmsuatacgiacs();
            f.matacgia = dgvtacgia .SelectedRows[0] .Cells[0] .Value .ToString();
            f.ShowDialog();
        }
        private void tsbxoatacgia_Click(object sender , EventArgs e)
        {
            DialogResult rs = MessageBox .Show("Bạn có chắc muốn xóa tác giả không?" , "Cảnh báo xóa tác giả" , MessageBoxButtons .YesNo , MessageBoxIcon .Warning);
            if (rs == DialogResult .Yes)
            {
                Xulydulieu xl = new Xulydulieu();
                string matacgia = dgvtacgia .SelectedRows[0] .Cells[0] .Value .ToString();
                DataTable data = xl .LayDuLieu($"select 1  from danhsach_tacgia where matacgia='{matacgia}'");
                if (data .Rows .Count > 0)
                {
                    MessageBox .Show("Tác giả này có dư liệu liên quan không được xóa!");
                }
                else
                {
                    string sql = $"delete from tacgia where matacgia='{matacgia}'";
                    int kq = xl .ThucHienLenh(sql);
                    if (kq == -1)
                    {
                        MessageBox .Show("Không thể xóa vui nòng thử lại!");
                    }
                    else
                    {
                        MessageBox .Show("Đã xóa tác giả");
                    }
                }
            }
        }
        private void tsbthemtacgia_Click(object sender , EventArgs e)
        {
            frmthemtacgia f = new frmthemtacgia();
            f .ShowDialog();
        }

        private void txttimkiem_KeyDown(object sender , KeyEventArgs e)
        {
            if (e .KeyCode == Keys .Enter)
            {
                tsbtimkiem.PerformClick();
            }
        }

        private void frmtacgia_Load(object sender , EventArgs e)
        {
            tsbxemtacgia.PerformClick();
        }

        private void toolStrip1_ItemClicked(object sender , ToolStripItemClickedEventArgs e)
        {

        }
    }
}
