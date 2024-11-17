namespace Quanlythuvien_N3
    {
    partial class frmsuatacgiacs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmsuatacgiacs));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtmatacgia = new System.Windows.Forms.TextBox();
            this.txttentacgia = new System.Windows.Forms.TextBox();
            this.txtquoctichtacgia = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.txtnamsinhtacgia = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên tác giả";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã tác giả";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Quốc tịch";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Năm sinh";
            // 
            // txtmatacgia
            // 
            this.txtmatacgia.Location = new System.Drawing.Point(150, 65);
            this.txtmatacgia.Name = "txtmatacgia";
            this.txtmatacgia.Size = new System.Drawing.Size(204, 22);
            this.txtmatacgia.TabIndex = 4;
            this.toolTip1.SetToolTip(this.txtmatacgia, "Nhập mã tác giả");
            // 
            // txttentacgia
            // 
            this.txttentacgia.Location = new System.Drawing.Point(150, 116);
            this.txttentacgia.Name = "txttentacgia";
            this.txttentacgia.Size = new System.Drawing.Size(204, 22);
            this.txttentacgia.TabIndex = 5;
            this.toolTip1.SetToolTip(this.txttentacgia, "Nhập tên tác giả");
            // 
            // txtquoctichtacgia
            // 
            this.txtquoctichtacgia.Location = new System.Drawing.Point(150, 170);
            this.txtquoctichtacgia.Name = "txtquoctichtacgia";
            this.txtquoctichtacgia.Size = new System.Drawing.Size(160, 22);
            this.txtquoctichtacgia.TabIndex = 6;
            this.toolTip1.SetToolTip(this.txtquoctichtacgia, "Nhập quốc tịch tác giả");
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(596, 355);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(65, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox1, "Hủy");
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(685, 355);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(71, 65);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox2, "Lưu");
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // txtnamsinhtacgia
            // 
            this.txtnamsinhtacgia.Location = new System.Drawing.Point(150, 225);
            this.txtnamsinhtacgia.Name = "txtnamsinhtacgia";
            this.txtnamsinhtacgia.Size = new System.Drawing.Size(160, 22);
            this.txtnamsinhtacgia.TabIndex = 10;
            this.toolTip1.SetToolTip(this.txtnamsinhtacgia, "Nhập năm sinh tác giả");
            // 
            // frmsuatacgiacs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtnamsinhtacgia);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtquoctichtacgia);
            this.Controls.Add(this.txttentacgia);
            this.Controls.Add(this.txtmatacgia);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmsuatacgiacs";
            this.Text = "frmsuatacgiacs";
            this.Load += new System.EventHandler(this.frmsuatacgiacs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

            }

        #endregion
        private System .Windows .Forms .Label label1;
        private System .Windows .Forms .Label label2;
        private System .Windows .Forms .Label label3;
        private System .Windows .Forms .Label label4;
        private System .Windows .Forms .TextBox txtmatacgia;
        private System .Windows .Forms .TextBox txttentacgia;
        private System .Windows .Forms .TextBox txtquoctichtacgia;
        private System .ComponentModel .BackgroundWorker backgroundWorker1;
        private System .Windows .Forms .PictureBox pictureBox1;
        private System .Windows .Forms .PictureBox pictureBox2;
        private System .Windows .Forms .ToolTip toolTip1;
        private System .Windows .Forms .TextBox txtnamsinhtacgia;
    }
    }