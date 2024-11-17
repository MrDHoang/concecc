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
    public partial class frmthemtacgia : Form
        {
        public frmthemtacgia()
            {
            InitializeComponent();
            }

        private void pictureBox2_Click(object sender , EventArgs e)
        {
            string sql = $"insert into tacgia (matacgia,tentacgia,quoctich,namsinh) values (N'{txtmatacgia .Text}', N'{txttentacgia .Text}', N'{txtquoctichtacgia .Text}', N'{txtnamsinhtacgia .Text}') ";
            Xulydulieu xl = new Xulydulieu();
            int kq = xl .ThucHienLenh(sql);
            if (kq == -1)
                MessageBox .Show("Không thể lưu! Vui lòng thử lại.");
            else
                MessageBox .Show("Thêm Tác giả thành công.");
        }

        private void pictureBox1_Click(object sender , EventArgs e)
        {
            this .Close();
        }

        private void frmthemtacgia_Load(object sender , EventArgs e)
        {

        }
    }
}
