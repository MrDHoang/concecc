namespace Quanlythuvien_N3
{
    partial class frmtimkiem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmtimkiem));
            this.txttimkiem = new System.Windows.Forms.TextBox();
            this.dgvtimkiem = new System.Windows.Forms.DataGridView();
            this.pbtimkiem = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btdangnhapquantrivien = new System.Windows.Forms.Button();
            this.btdangnhaphoivien = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txttaikhoan = new System.Windows.Forms.TextBox();
            this.txtmatkhau = new System.Windows.Forms.TextBox();
            this.rbthuthu = new System.Windows.Forms.RadioButton();
            this.rbhoivien = new System.Windows.Forms.RadioButton();
            this.btdangnhap = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtimkiem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbtimkiem)).BeginInit();
            this.SuspendLayout();
            // 
            // txttimkiem
            // 
            this.txttimkiem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txttimkiem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txttimkiem.Location = new System.Drawing.Point(15, 72);
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.Size = new System.Drawing.Size(446, 22);
            this.txttimkiem.TabIndex = 0;
            this.txttimkiem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txttimkiem_KeyDown);
            // 
            // dgvtimkiem
            // 
            this.dgvtimkiem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvtimkiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvtimkiem.Location = new System.Drawing.Point(15, 102);
            this.dgvtimkiem.Name = "dgvtimkiem";
            this.dgvtimkiem.RowHeadersWidth = 51;
            this.dgvtimkiem.RowTemplate.Height = 24;
            this.dgvtimkiem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvtimkiem.Size = new System.Drawing.Size(478, 336);
            this.dgvtimkiem.TabIndex = 1;
            // 
            // pbtimkiem
            // 
            this.pbtimkiem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbtimkiem.BackColor = System.Drawing.SystemColors.Control;
            this.pbtimkiem.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbtimkiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbtimkiem.Image = ((System.Drawing.Image)(resources.GetObject("pbtimkiem.Image")));
            this.pbtimkiem.Location = new System.Drawing.Point(467, 72);
            this.pbtimkiem.Name = "pbtimkiem";
            this.pbtimkiem.Size = new System.Drawing.Size(26, 22);
            this.pbtimkiem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbtimkiem.TabIndex = 2;
            this.pbtimkiem.TabStop = false;
            this.pbtimkiem.Click += new System.EventHandler(this.pbtimkiem_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "TÌM KIẾM TÀI LIỆU";
            // 
            // btdangnhapquantrivien
            // 
            this.btdangnhapquantrivien.Location = new System.Drawing.Point(515, 352);
            this.btdangnhapquantrivien.Name = "btdangnhapquantrivien";
            this.btdangnhapquantrivien.Size = new System.Drawing.Size(125, 23);
            this.btdangnhapquantrivien.TabIndex = 4;
            this.btdangnhapquantrivien.Text = "QUẢN TRỊ VIÊN";
            this.btdangnhapquantrivien.UseVisualStyleBackColor = true;
            this.btdangnhapquantrivien.Click += new System.EventHandler(this.btdangnhapquantrivien_Click);
            // 
            // btdangnhaphoivien
            // 
            this.btdangnhaphoivien.Location = new System.Drawing.Point(529, 396);
            this.btdangnhaphoivien.Name = "btdangnhaphoivien";
            this.btdangnhaphoivien.Size = new System.Drawing.Size(111, 23);
            this.btdangnhaphoivien.TabIndex = 5;
            this.btdangnhaphoivien.Text = "HỘI VIÊN";
            this.btdangnhaphoivien.UseVisualStyleBackColor = true;
            this.btdangnhaphoivien.Click += new System.EventHandler(this.btdangnhaphoivien_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(526, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "ĐĂNG NHẬP";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(528, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tài khoản:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(528, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Mật khẩu:";
            // 
            // txttaikhoan
            // 
            this.txttaikhoan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txttaikhoan.Location = new System.Drawing.Point(532, 114);
            this.txttaikhoan.Multiline = true;
            this.txttaikhoan.Name = "txttaikhoan";
            this.txttaikhoan.Size = new System.Drawing.Size(256, 22);
            this.txttaikhoan.TabIndex = 9;
            // 
            // txtmatkhau
            // 
            this.txtmatkhau.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtmatkhau.Location = new System.Drawing.Point(532, 194);
            this.txtmatkhau.Multiline = true;
            this.txtmatkhau.Name = "txtmatkhau";
            this.txtmatkhau.Size = new System.Drawing.Size(256, 22);
            this.txtmatkhau.TabIndex = 10;
            // 
            // rbthuthu
            // 
            this.rbthuthu.AutoSize = true;
            this.rbthuthu.Location = new System.Drawing.Point(532, 262);
            this.rbthuthu.Name = "rbthuthu";
            this.rbthuthu.Size = new System.Drawing.Size(77, 20);
            this.rbthuthu.TabIndex = 11;
            this.rbthuthu.TabStop = true;
            this.rbthuthu.Text = "Thủ Thư";
            this.rbthuthu.UseVisualStyleBackColor = true;
            // 
            // rbhoivien
            // 
            this.rbhoivien.AutoSize = true;
            this.rbhoivien.Location = new System.Drawing.Point(685, 262);
            this.rbhoivien.Name = "rbhoivien";
            this.rbhoivien.Size = new System.Drawing.Size(77, 20);
            this.rbhoivien.TabIndex = 12;
            this.rbhoivien.TabStop = true;
            this.rbhoivien.Text = "Hội viên";
            this.rbhoivien.UseVisualStyleBackColor = true;
            // 
            // btdangnhap
            // 
            this.btdangnhap.Location = new System.Drawing.Point(700, 377);
            this.btdangnhap.Name = "btdangnhap";
            this.btdangnhap.Size = new System.Drawing.Size(88, 42);
            this.btdangnhap.TabIndex = 13;
            this.btdangnhap.Text = "Đăng Nhập";
            this.btdangnhap.UseVisualStyleBackColor = true;
            this.btdangnhap.Click += new System.EventHandler(this.btdangnhap_Click);
            // 
            // frmtimkiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btdangnhap);
            this.Controls.Add(this.rbhoivien);
            this.Controls.Add(this.rbthuthu);
            this.Controls.Add(this.txtmatkhau);
            this.Controls.Add(this.txttaikhoan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btdangnhaphoivien);
            this.Controls.Add(this.btdangnhapquantrivien);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbtimkiem);
            this.Controls.Add(this.dgvtimkiem);
            this.Controls.Add(this.txttimkiem);
            this.Name = "frmtimkiem";
            this.Text = "frmtimkiem";
            ((System.ComponentModel.ISupportInitialize)(this.dgvtimkiem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbtimkiem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System .Windows .Forms .TextBox txttimkiem;
        private System .Windows .Forms .DataGridView dgvtimkiem;
        private System .Windows .Forms .PictureBox pbtimkiem;
        private System .Windows .Forms .Label label1;
        private System .Windows .Forms .Button btdangnhapquantrivien;
        private System .Windows .Forms .Button btdangnhaphoivien;
        private System .Windows .Forms .Label label2;
        private System .Windows .Forms .Label label3;
        private System .Windows .Forms .Label label4;
        private System .Windows .Forms .TextBox txttaikhoan;
        private System .Windows .Forms .TextBox txtmatkhau;
        private System .Windows .Forms .RadioButton rbthuthu;
        private System .Windows .Forms .RadioButton rbhoivien;
        private System .Windows .Forms .Button btdangnhap;
    }
}