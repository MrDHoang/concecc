namespace Quanlythuvien_N3
{
    partial class frmthuthu
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btquanlytacgia = new System.Windows.Forms.Button();
            this.btquanlytailieu = new System.Windows.Forms.Button();
            this.btquanlynhaxuatban = new System.Windows.Forms.Button();
            this.btquanlymuontra = new System.Windows.Forms.Button();
            this.btquanlyboithuong = new System.Windows.Forms.Button();
            this.btquanlyhoivien = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(223, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(298, 30);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "CHỨC NĂNG THỦ THƯ";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btquanlytacgia
            // 
            this.btquanlytacgia.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btquanlytacgia.Location = new System.Drawing.Point(111, 76);
            this.btquanlytacgia.Name = "btquanlytacgia";
            this.btquanlytacgia.Size = new System.Drawing.Size(165, 65);
            this.btquanlytacgia.TabIndex = 1;
            this.btquanlytacgia.Text = "Quản Lý Tác Giả";
            this.btquanlytacgia.UseVisualStyleBackColor = true;
            this.btquanlytacgia.Click += new System.EventHandler(this.btquanlytacgia_Click);
            // 
            // btquanlytailieu
            // 
            this.btquanlytailieu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btquanlytailieu.Location = new System.Drawing.Point(111, 169);
            this.btquanlytailieu.Name = "btquanlytailieu";
            this.btquanlytailieu.Size = new System.Drawing.Size(165, 65);
            this.btquanlytailieu.TabIndex = 2;
            this.btquanlytailieu.Text = "Quản Lý Tài Liệu";
            this.btquanlytailieu.UseVisualStyleBackColor = true;
            this.btquanlytailieu.Click += new System.EventHandler(this.btquanlytailieu_Click);
            // 
            // btquanlynhaxuatban
            // 
            this.btquanlynhaxuatban.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btquanlynhaxuatban.Location = new System.Drawing.Point(418, 169);
            this.btquanlynhaxuatban.Name = "btquanlynhaxuatban";
            this.btquanlynhaxuatban.Size = new System.Drawing.Size(165, 65);
            this.btquanlynhaxuatban.TabIndex = 3;
            this.btquanlynhaxuatban.Text = "Quản Lý Nhà Xuất Bản";
            this.btquanlynhaxuatban.UseVisualStyleBackColor = true;
            // 
            // btquanlymuontra
            // 
            this.btquanlymuontra.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btquanlymuontra.Location = new System.Drawing.Point(111, 260);
            this.btquanlymuontra.Name = "btquanlymuontra";
            this.btquanlymuontra.Size = new System.Drawing.Size(165, 65);
            this.btquanlymuontra.TabIndex = 4;
            this.btquanlymuontra.Text = "Quản Lý Mượn Trả";
            this.btquanlymuontra.UseVisualStyleBackColor = true;
            // 
            // btquanlyboithuong
            // 
            this.btquanlyboithuong.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btquanlyboithuong.Location = new System.Drawing.Point(418, 260);
            this.btquanlyboithuong.Name = "btquanlyboithuong";
            this.btquanlyboithuong.Size = new System.Drawing.Size(165, 65);
            this.btquanlyboithuong.TabIndex = 5;
            this.btquanlyboithuong.Text = "Quản Lý Bồi Thường";
            this.btquanlyboithuong.UseVisualStyleBackColor = true;
            // 
            // btquanlyhoivien
            // 
            this.btquanlyhoivien.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btquanlyhoivien.Location = new System.Drawing.Point(418, 76);
            this.btquanlyhoivien.Name = "btquanlyhoivien";
            this.btquanlyhoivien.Size = new System.Drawing.Size(165, 65);
            this.btquanlyhoivien.TabIndex = 7;
            this.btquanlyhoivien.Text = "Quản Lý Hội Viên";
            this.btquanlyhoivien.UseVisualStyleBackColor = true;
            // 
            // frmthuthu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btquanlyhoivien);
            this.Controls.Add(this.btquanlyboithuong);
            this.Controls.Add(this.btquanlymuontra);
            this.Controls.Add(this.btquanlynhaxuatban);
            this.Controls.Add(this.btquanlytailieu);
            this.Controls.Add(this.btquanlytacgia);
            this.Controls.Add(this.textBox1);
            this.Name = "frmthuthu";
            this.Text = "frmquantrivien";
            this.Load += new System.EventHandler(this.frmquantrivien_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System .Windows .Forms .TextBox textBox1;
        private System .Windows .Forms .Button btquanlytacgia;
        private System .Windows .Forms .Button btquanlytailieu;
        private System .Windows .Forms .Button btquanlynhaxuatban;
        private System .Windows .Forms .Button btquanlymuontra;
        private System .Windows .Forms .Button btquanlyboithuong;
        private System .Windows .Forms .Button btquanlyhoivien;
    }
}