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
    public partial class frmthuthu : Form
    {
        public frmthuthu()
        {
            InitializeComponent();
        }

        private void frmquantrivien_Load(object sender , EventArgs e)
        {
        }

        private void btquanlytacgia_Click(object sender , EventArgs e)
        {
            frmtacgia f = new frmtacgia();
            f .ShowDialog();
        }

        private void btquanlytailieu_Click(object sender , EventArgs e)
        {
            frmtailieu f = new frmtailieu();
            f .ShowDialog();
        }
    }
}
