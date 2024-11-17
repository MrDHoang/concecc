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
    public partial class frmsuatacgiacs : Form
        {
        public frmsuatacgiacs()
            {
            InitializeComponent();
            }
        public string matacgia = "";
        private void frmsuatacgiacs_Load(object sender , EventArgs e)
        {
            Xulydulieu xl = new Xulydulieu();
            DataTable data = xl .LayDuLieu($"select * from tacgia where matacgia='{matacgia}';");
            txtmatacgia.Text = data .Rows[0][0] .ToString();
            txttentacgia.Text = data .Rows[0][1] .ToString();
            txtquoctichtacgia.Text = data .Rows[0][2] .ToString();
            txtnamsinhtacgia.Text = data.Rows[0][3].ToString();
        }

        private void pictureBox2_Click(object sender , EventArgs e)
        {
            string sql = $"update tacgia set MaTacGia='{txtmatacgia .Text}', TenTacGia=N'{txttentacgia.Text}', QuocTich=N'{txtquoctichtacgia.Text}', NamSinh='{txtnamsinhtacgia.Text}' where matacgia = '{matacgia}'";
            Xulydulieu xl = new Xulydulieu();
            int kq = xl .ThucHienLenh(sql);
            if (kq == -1)
            {
                MessageBox .Show("Không thể sửa vui nòng thử nại!");
            }
            else
            {
                MessageBox .Show("Đã sửa tác giả");
            }
        }

        private void pictureBox1_Click(object sender , EventArgs e)
        {
            this .Close();
        }
    }
}
