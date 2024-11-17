namespace Quanlythuvien_N3
{
    partial class frmtailieu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmtailieu));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbxemtailieu = new System.Windows.Forms.ToolStripButton();
            this.tsbsuatailieu = new System.Windows.Forms.ToolStripButton();
            this.tsbxoatailieu = new System.Windows.Forms.ToolStripButton();
            this.tsbthemtailieu = new System.Windows.Forms.ToolStripButton();
            this.txttimkiem = new System.Windows.Forms.ToolStripTextBox();
            this.tsbtimkiem = new System.Windows.Forms.ToolStripButton();
            this.dgvtailieu = new System.Windows.Forms.DataGridView();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtailieu)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbxemtailieu,
            this.tsbsuatailieu,
            this.tsbxoatailieu,
            this.tsbthemtailieu,
            this.txttimkiem,
            this.tsbtimkiem});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 27);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbxemtailieu
            // 
            this.tsbxemtailieu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbxemtailieu.Image = ((System.Drawing.Image)(resources.GetObject("tsbxemtailieu.Image")));
            this.tsbxemtailieu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbxemtailieu.Name = "tsbxemtailieu";
            this.tsbxemtailieu.Size = new System.Drawing.Size(29, 24);
            this.tsbxemtailieu.Text = "Xem Tài Liệu";
            this.tsbxemtailieu.ToolTipText = "Xem Danh Sách Tác Giả";
            this.tsbxemtailieu.Click += new System.EventHandler(this.tsbxemtailieu_Click);
            // 
            // tsbsuatailieu
            // 
            this.tsbsuatailieu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbsuatailieu.Image = ((System.Drawing.Image)(resources.GetObject("tsbsuatailieu.Image")));
            this.tsbsuatailieu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbsuatailieu.Name = "tsbsuatailieu";
            this.tsbsuatailieu.Size = new System.Drawing.Size(29, 24);
            this.tsbsuatailieu.Text = "Sửa Tài Liệu";
            this.tsbsuatailieu.Click += new System.EventHandler(this.tsbsuatailieu_Click);
            // 
            // tsbxoatailieu
            // 
            this.tsbxoatailieu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbxoatailieu.Image = ((System.Drawing.Image)(resources.GetObject("tsbxoatailieu.Image")));
            this.tsbxoatailieu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbxoatailieu.Name = "tsbxoatailieu";
            this.tsbxoatailieu.Size = new System.Drawing.Size(29, 24);
            this.tsbxoatailieu.Text = "Xóa Tài Liệu";
            this.tsbxoatailieu.Click += new System.EventHandler(this.tsbxoatailieu_Click);
            // 
            // tsbthemtailieu
            // 
            this.tsbthemtailieu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbthemtailieu.Image = ((System.Drawing.Image)(resources.GetObject("tsbthemtailieu.Image")));
            this.tsbthemtailieu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbthemtailieu.Name = "tsbthemtailieu";
            this.tsbthemtailieu.Size = new System.Drawing.Size(29, 24);
            this.tsbthemtailieu.Text = "Thêm Tài Liệu";
            this.tsbthemtailieu.ToolTipText = "Thêm Tác Giả";
            this.tsbthemtailieu.Click += new System.EventHandler(this.tsbthemtailieu_Click);
            // 
            // txttimkiem
            // 
            this.txttimkiem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txttimkiem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.Size = new System.Drawing.Size(100, 27);
            this.txttimkiem.ToolTipText = "Nhập Thông Tin Tài Liệu";
            this.txttimkiem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txttimkiem_KeyDown);
            this.txttimkiem.Click += new System.EventHandler(this.txttimkiem_Click);
            // 
            // tsbtimkiem
            // 
            this.tsbtimkiem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtimkiem.Image = ((System.Drawing.Image)(resources.GetObject("tsbtimkiem.Image")));
            this.tsbtimkiem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtimkiem.Name = "tsbtimkiem";
            this.tsbtimkiem.Size = new System.Drawing.Size(29, 24);
            this.tsbtimkiem.Text = "Tìm Kiếm Tài Liệu";
            this.tsbtimkiem.ToolTipText = "Tìm Tác Giả";
            this.tsbtimkiem.Click += new System.EventHandler(this.tsbtimkiem_Click);
            // 
            // dgvtailieu
            // 
            this.dgvtailieu.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dgvtailieu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvtailieu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvtailieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvtailieu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dgvtailieu.Location = new System.Drawing.Point(12, 42);
            this.dgvtailieu.Name = "dgvtailieu";
            this.dgvtailieu.RowHeadersWidth = 51;
            this.dgvtailieu.RowTemplate.Height = 24;
            this.dgvtailieu.Size = new System.Drawing.Size(776, 396);
            this.dgvtailieu.TabIndex = 4;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaTaiLieu";
            this.Column1.HeaderText = "Mã Tài Liệu";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 106;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TenTaiLieu";
            this.Column2.HeaderText = "Tên Tài Liệu";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 111;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "LoaiTaiLieu";
            this.Column3.HeaderText = "Loại Tài Liệu";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 113;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "NhaXuatBan";
            this.Column4.HeaderText = "Nhà Xuất Bản";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 117;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "NamXuatBan";
            this.Column5.HeaderText = "Năm Sản Xuất";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 121;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "SoLuong";
            this.Column6.HeaderText = "Số Lượng ";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 96;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "TrangThai";
            this.Column7.HeaderText = "Trạng Thái";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.Width = 102;
            // 
            // frmtailieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dgvtailieu);
            this.Name = "frmtailieu";
            this.Text = "frmtailieu";
            this.Load += new System.EventHandler(this.frmtailieu_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtailieu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System .Windows .Forms .ToolStrip toolStrip1;
        private System .Windows .Forms .ToolStripButton tsbxemtailieu;
        private System .Windows .Forms .ToolStripButton tsbsuatailieu;
        private System .Windows .Forms .ToolStripButton tsbxoatailieu;
        private System .Windows .Forms .ToolStripButton tsbthemtailieu;
        private System .Windows .Forms .ToolStripTextBox txttimkiem;
        private System .Windows .Forms .ToolStripButton tsbtimkiem;
        private System .Windows .Forms .DataGridView dgvtailieu;
        private System .Windows .Forms .ToolTip toolTip1;
        private System .Windows .Forms .DataGridViewTextBoxColumn Column1;
        private System .Windows .Forms .DataGridViewTextBoxColumn Column2;
        private System .Windows .Forms .DataGridViewTextBoxColumn Column3;
        private System .Windows .Forms .DataGridViewTextBoxColumn Column4;
        private System .Windows .Forms .DataGridViewTextBoxColumn Column5;
        private System .Windows .Forms .DataGridViewTextBoxColumn Column6;
        private System .Windows .Forms .DataGridViewTextBoxColumn Column7;
    }
}