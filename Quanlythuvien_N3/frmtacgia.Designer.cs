namespace Quanlythuvien_N3
{
    partial class frmtacgia
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmtacgia));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbxemtacgia = new System.Windows.Forms.ToolStripButton();
            this.tsbsuatacgia = new System.Windows.Forms.ToolStripButton();
            this.tsbxoatacgia = new System.Windows.Forms.ToolStripButton();
            this.tsbthemtacgia = new System.Windows.Forms.ToolStripButton();
            this.txttimkiem = new System.Windows.Forms.ToolStripTextBox();
            this.tsbtimkiem = new System.Windows.Forms.ToolStripButton();
            this.dgvtacgia = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtacgia)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbxemtacgia,
            this.tsbsuatacgia,
            this.tsbxoatacgia,
            this.tsbthemtacgia,
            this.txttimkiem,
            this.tsbtimkiem});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(937, 31);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbxemtacgia
            // 
            this.tsbxemtacgia.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbxemtacgia.Image = ((System.Drawing.Image)(resources.GetObject("tsbxemtacgia.Image")));
            this.tsbxemtacgia.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbxemtacgia.Name = "tsbxemtacgia";
            this.tsbxemtacgia.Size = new System.Drawing.Size(29, 28);
            this.tsbxemtacgia.Text = "Xem Tác Giả";
            this.tsbxemtacgia.ToolTipText = "Xem Danh Sách Tác Giả";
            this.tsbxemtacgia.Click += new System.EventHandler(this.tsbxemtacgia_Click);
            // 
            // tsbsuatacgia
            // 
            this.tsbsuatacgia.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbsuatacgia.Image = ((System.Drawing.Image)(resources.GetObject("tsbsuatacgia.Image")));
            this.tsbsuatacgia.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbsuatacgia.Name = "tsbsuatacgia";
            this.tsbsuatacgia.Size = new System.Drawing.Size(29, 28);
            this.tsbsuatacgia.Text = "Sửa  Tác Giả";
            this.tsbsuatacgia.Click += new System.EventHandler(this.tsbsuatacgia_Click);
            // 
            // tsbxoatacgia
            // 
            this.tsbxoatacgia.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbxoatacgia.Image = ((System.Drawing.Image)(resources.GetObject("tsbxoatacgia.Image")));
            this.tsbxoatacgia.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbxoatacgia.Name = "tsbxoatacgia";
            this.tsbxoatacgia.Size = new System.Drawing.Size(29, 28);
            this.tsbxoatacgia.Text = "Xóa Tác Giả";
            this.tsbxoatacgia.Click += new System.EventHandler(this.tsbxoatacgia_Click);
            // 
            // tsbthemtacgia
            // 
            this.tsbthemtacgia.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbthemtacgia.Image = ((System.Drawing.Image)(resources.GetObject("tsbthemtacgia.Image")));
            this.tsbthemtacgia.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbthemtacgia.Name = "tsbthemtacgia";
            this.tsbthemtacgia.Size = new System.Drawing.Size(29, 28);
            this.tsbthemtacgia.Text = "toolStripButton4";
            this.tsbthemtacgia.ToolTipText = "Thêm Tác Giả";
            this.tsbthemtacgia.Click += new System.EventHandler(this.tsbthemtacgia_Click);
            // 
            // txttimkiem
            // 
            this.txttimkiem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txttimkiem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.Size = new System.Drawing.Size(100, 31);
            this.txttimkiem.ToolTipText = "Nhập Thông Tin Tác Giả";
            this.txttimkiem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txttimkiem_KeyDown);
            // 
            // tsbtimkiem
            // 
            this.tsbtimkiem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtimkiem.Image = ((System.Drawing.Image)(resources.GetObject("tsbtimkiem.Image")));
            this.tsbtimkiem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtimkiem.Name = "tsbtimkiem";
            this.tsbtimkiem.Size = new System.Drawing.Size(29, 28);
            this.tsbtimkiem.Text = "Tìm Tác Giả";
            this.tsbtimkiem.ToolTipText = "Tìm Tác Giả";
            this.tsbtimkiem.Click += new System.EventHandler(this.tsbtimkiem_Click);
            // 
            // dgvtacgia
            // 
            this.dgvtacgia.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dgvtacgia.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvtacgia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvtacgia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvtacgia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvtacgia.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvtacgia.Location = new System.Drawing.Point(13, 44);
            this.dgvtacgia.Name = "dgvtacgia";
            this.dgvtacgia.RowHeadersWidth = 51;
            this.dgvtacgia.RowTemplate.Height = 24;
            this.dgvtacgia.Size = new System.Drawing.Size(912, 479);
            this.dgvtacgia.TabIndex = 2;
            this.dgvtacgia.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvtacgia_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaTacGia";
            this.Column1.HeaderText = "Mã tác giả";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 98;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TenTacGia";
            this.Column2.HeaderText = "Tên tác giả";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 103;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "QuocTich";
            this.Column3.HeaderText = "Quốc tịch";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 91;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "NamSinh";
            this.Column4.HeaderText = "Năm sinh";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 92;
            // 
            // frmtacgia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 535);
            this.Controls.Add(this.dgvtacgia);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmtacgia";
            this.Text = "frmtacgia";
            this.Load += new System.EventHandler(this.frmtacgia_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtacgia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbxemtacgia;
        private System.Windows.Forms.ToolStripButton tsbsuatacgia;
        private System.Windows.Forms.ToolStripButton tsbxoatacgia;
        private System.Windows.Forms.ToolStripButton tsbthemtacgia;
        private System.Windows.Forms.ToolStripTextBox txttimkiem;
        private System.Windows.Forms.ToolStripButton tsbtimkiem;
        private System.Windows.Forms.DataGridView dgvtacgia;
        private System.Windows.Forms.ToolTip toolTip1;
        private System .Windows .Forms .DataGridViewTextBoxColumn Column1;
        private System .Windows .Forms .DataGridViewTextBoxColumn Column2;
        private System .Windows .Forms .DataGridViewTextBoxColumn Column3;
        private System .Windows .Forms .DataGridViewTextBoxColumn Column4;
    }
}

