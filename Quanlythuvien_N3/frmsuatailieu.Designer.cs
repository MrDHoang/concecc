namespace Quanlythuvien_N3
{
    partial class frmsuatailieu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System .ComponentModel .IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components .Dispose();
            }
            base .Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmsuatailieu));
            this.txtloaitailieu = new System.Windows.Forms.TextBox();
            this.txttentailieu = new System.Windows.Forms.TextBox();
            this.txtmatailieu = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pbluutailieu = new System.Windows.Forms.PictureBox();
            this.pbhuyluu = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.txtnhaxuatbantailieu = new System.Windows.Forms.TextBox();
            this.txttrangthaitailieu = new System.Windows.Forms.TextBox();
            this.txtnamsanxuat = new System.Windows.Forms.TextBox();
            this.txtsoluong = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbluutailieu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbhuyluu)).BeginInit();
            this.SuspendLayout();
            // 
            // txtloaitailieu
            // 
            this.txtloaitailieu.Location = new System.Drawing.Point(148, 153);
            this.txtloaitailieu.Name = "txtloaitailieu";
            this.txtloaitailieu.Size = new System.Drawing.Size(204, 22);
            this.txtloaitailieu.TabIndex = 17;
            this.toolTip1.SetToolTip(this.txtloaitailieu, "Nhập Loại Tài Liệu");
            // 
            // txttentailieu
            // 
            this.txttentailieu.Location = new System.Drawing.Point(148, 99);
            this.txttentailieu.Name = "txttentailieu";
            this.txttentailieu.Size = new System.Drawing.Size(204, 22);
            this.txttentailieu.TabIndex = 16;
            this.toolTip1.SetToolTip(this.txttentailieu, "Nhập Tên Tài Liệu");
            // 
            // txtmatailieu
            // 
            this.txtmatailieu.Location = new System.Drawing.Point(148, 48);
            this.txtmatailieu.Name = "txtmatailieu";
            this.txtmatailieu.Size = new System.Drawing.Size(204, 22);
            this.txtmatailieu.TabIndex = 15;
            this.toolTip1.SetToolTip(this.txtmatailieu, "Nhập Mã Tài Liệu");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(434, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "Nhà xuất bản";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Loại tài liệu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Mã tài liệu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Tên tài liệu";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbluutailieu
            // 
            this.pbluutailieu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pbluutailieu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbluutailieu.Image = ((System.Drawing.Image)(resources.GetObject("pbluutailieu.Image")));
            this.pbluutailieu.Location = new System.Drawing.Point(683, 338);
            this.pbluutailieu.Name = "pbluutailieu";
            this.pbluutailieu.Size = new System.Drawing.Size(71, 65);
            this.pbluutailieu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbluutailieu.TabIndex = 19;
            this.pbluutailieu.TabStop = false;
            this.toolTip1.SetToolTip(this.pbluutailieu, "Lưu");
            this.pbluutailieu.Click += new System.EventHandler(this.pbluutailieu_Click);
            // 
            // pbhuyluu
            // 
            this.pbhuyluu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pbhuyluu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbhuyluu.Image = ((System.Drawing.Image)(resources.GetObject("pbhuyluu.Image")));
            this.pbhuyluu.Location = new System.Drawing.Point(594, 338);
            this.pbhuyluu.Name = "pbhuyluu";
            this.pbhuyluu.Size = new System.Drawing.Size(65, 63);
            this.pbhuyluu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbhuyluu.TabIndex = 18;
            this.pbhuyluu.TabStop = false;
            this.toolTip1.SetToolTip(this.pbhuyluu, "Hủy");
            // 
            // txtnhaxuatbantailieu
            // 
            this.txtnhaxuatbantailieu.Location = new System.Drawing.Point(547, 51);
            this.txtnhaxuatbantailieu.Name = "txtnhaxuatbantailieu";
            this.txtnhaxuatbantailieu.Size = new System.Drawing.Size(160, 22);
            this.txtnhaxuatbantailieu.TabIndex = 20;
            this.toolTip1.SetToolTip(this.txtnhaxuatbantailieu, "Nhập Nhà Xuất Bản");
            // 
            // txttrangthaitailieu
            // 
            this.txttrangthaitailieu.Location = new System.Drawing.Point(148, 215);
            this.txttrangthaitailieu.Name = "txttrangthaitailieu";
            this.txttrangthaitailieu.Size = new System.Drawing.Size(100, 22);
            this.txttrangthaitailieu.TabIndex = 24;
            this.toolTip1.SetToolTip(this.txttrangthaitailieu, "Nhập Trạng Thái Tài Liệu");
            // 
            // txtnamsanxuat
            // 
            this.txtnamsanxuat.Location = new System.Drawing.Point(547, 105);
            this.txtnamsanxuat.Name = "txtnamsanxuat";
            this.txtnamsanxuat.Size = new System.Drawing.Size(160, 22);
            this.txtnamsanxuat.TabIndex = 25;
            this.toolTip1.SetToolTip(this.txtnamsanxuat, "Nhập Năm Sản Xuất ");
            // 
            // txtsoluong
            // 
            this.txtsoluong.Location = new System.Drawing.Point(547, 153);
            this.txtsoluong.Name = "txtsoluong";
            this.txtsoluong.Size = new System.Drawing.Size(100, 22);
            this.txtsoluong.TabIndex = 26;
            this.toolTip1.SetToolTip(this.txtsoluong, "Nhập Số Lượng");
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(434, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 16);
            this.label5.TabIndex = 21;
            this.label5.Text = "Năm sản xuất";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(434, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 16);
            this.label6.TabIndex = 22;
            this.label6.Text = "Số lượng";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(51, 215);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 16);
            this.label7.TabIndex = 23;
            this.label7.Text = "Trạng thái";
            // 
            // frmsuatailieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtsoluong);
            this.Controls.Add(this.txtnamsanxuat);
            this.Controls.Add(this.txttrangthaitailieu);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtloaitailieu);
            this.Controls.Add(this.txttentailieu);
            this.Controls.Add(this.txtmatailieu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbluutailieu);
            this.Controls.Add(this.pbhuyluu);
            this.Controls.Add(this.txtnhaxuatbantailieu);
            this.Name = "frmsuatailieu";
            this.Text = "frmsuatailieu";
            this.Load += new System.EventHandler(this.frmsuatailieu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbluutailieu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbhuyluu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System .Windows .Forms .TextBox txtloaitailieu;
        private System .Windows .Forms .ToolTip toolTip1;
        private System .Windows .Forms .TextBox txttentailieu;
        private System .Windows .Forms .TextBox txtmatailieu;
        private System .Windows .Forms .Label label4;
        private System .Windows .Forms .Label label3;
        private System .Windows .Forms .Label label2;
        private System .Windows .Forms .Label label1;
        private System .ComponentModel .BackgroundWorker backgroundWorker1;
        private System .Windows .Forms .PictureBox pbluutailieu;
        private System .Windows .Forms .PictureBox pbhuyluu;
        private System .Windows .Forms .TextBox txtnhaxuatbantailieu;
        private System .Windows .Forms .Label label5;
        private System .Windows .Forms .Label label6;
        private System .Windows .Forms .Label label7;
        private System .Windows .Forms .TextBox txttrangthaitailieu;
        private System .Windows .Forms .TextBox txtnamsanxuat;
        private System .Windows .Forms .TextBox txtsoluong;
    }
}