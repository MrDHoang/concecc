namespace Quanlythuvien_N3
    {
    partial class frmthemtacgia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmthemtacgia));
            this.txtquoctichtacgia = new System.Windows.Forms.TextBox();
            this.txttentacgia = new System.Windows.Forms.TextBox();
            this.txtmatacgia = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.txtnamsinhtacgia = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtquoctichtacgia
            // 
            this.txtquoctichtacgia.Location = new System.Drawing.Point(148, 153);
            this.txtquoctichtacgia.Name = "txtquoctichtacgia";
            this.txtquoctichtacgia.Size = new System.Drawing.Size(160, 22);
            this.txtquoctichtacgia.TabIndex = 17;
            this.toolTip1.SetToolTip(this.txtquoctichtacgia, "Nhập quốc tịch tác giả");
            // 
            // txttentacgia
            // 
            this.txttentacgia.Location = new System.Drawing.Point(148, 99);
            this.txttentacgia.Name = "txttentacgia";
            this.txttentacgia.Size = new System.Drawing.Size(204, 22);
            this.txttentacgia.TabIndex = 16;
            this.toolTip1.SetToolTip(this.txttentacgia, "Nhập tên tác giả");
            // 
            // txtmatacgia
            // 
            this.txtmatacgia.Location = new System.Drawing.Point(148, 48);
            this.txtmatacgia.Name = "txtmatacgia";
            this.txtmatacgia.Size = new System.Drawing.Size(204, 22);
            this.txtmatacgia.TabIndex = 15;
            this.toolTip1.SetToolTip(this.txtmatacgia, "Nhập mã tác giả");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "Năm sinh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Quốc tịch";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Mã tác giả";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Tên tác giả";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(683, 338);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(71, 65);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox2, "Lưu");
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(594, 338);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(65, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox1, "Hủy");
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // txtnamsinhtacgia
            // 
            this.txtnamsinhtacgia.Location = new System.Drawing.Point(148, 208);
            this.txtnamsinhtacgia.Name = "txtnamsinhtacgia";
            this.txtnamsinhtacgia.Size = new System.Drawing.Size(160, 22);
            this.txtnamsinhtacgia.TabIndex = 20;
            this.toolTip1.SetToolTip(this.txtnamsinhtacgia, "Nhập năm sinh tác giả");
            // 
            // frmthemtacgia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtquoctichtacgia);
            this.Controls.Add(this.txttentacgia);
            this.Controls.Add(this.txtmatacgia);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtnamsinhtacgia);
            this.Name = "frmthemtacgia";
            this.Text = "frmthemtacgia";
            this.Load += new System.EventHandler(this.frmthemtacgia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

            }

        #endregion
        private System .Windows .Forms .TextBox txtquoctichtacgia;
        private System .Windows .Forms .ToolTip toolTip1;
        private System .Windows .Forms .TextBox txttentacgia;
        private System .Windows .Forms .TextBox txtmatacgia;
        private System .Windows .Forms .Label label4;
        private System .Windows .Forms .Label label3;
        private System .Windows .Forms .Label label2;
        private System .Windows .Forms .Label label1;
        private System .ComponentModel .BackgroundWorker backgroundWorker1;
        private System .Windows .Forms .PictureBox pictureBox2;
        private System .Windows .Forms .PictureBox pictureBox1;
        private System .Windows .Forms .TextBox txtnamsinhtacgia;
    }
    }