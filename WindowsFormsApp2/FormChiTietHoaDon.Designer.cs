namespace WindowsFormsApp2
{
    partial class FormChiTietHoaDon
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
            this.danhSachLoaiSanPham = new System.Windows.Forms.FlowLayoutPanel();
            this.danhSachSanPham = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.danhSachChiTiet = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tongTien = new System.Windows.Forms.Label();
            this.ngayTao = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nguoiTao = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ghiChu = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.danhSachChiTiet)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // danhSachLoaiSanPham
            // 
            this.danhSachLoaiSanPham.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.danhSachLoaiSanPham.Location = new System.Drawing.Point(12, 13);
            this.danhSachLoaiSanPham.Name = "danhSachLoaiSanPham";
            this.danhSachLoaiSanPham.Size = new System.Drawing.Size(164, 672);
            this.danhSachLoaiSanPham.TabIndex = 0;
            // 
            // danhSachSanPham
            // 
            this.danhSachSanPham.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.danhSachSanPham.Location = new System.Drawing.Point(182, 13);
            this.danhSachSanPham.Name = "danhSachSanPham";
            this.danhSachSanPham.Size = new System.Drawing.Size(578, 590);
            this.danhSachSanPham.TabIndex = 0;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel3.Controls.Add(this.button1);
            this.flowLayoutPanel3.Controls.Add(this.button2);
            this.flowLayoutPanel3.Controls.Add(this.button3);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(766, 609);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(412, 76);
            this.flowLayoutPanel3.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 63);
            this.button1.TabIndex = 0;
            this.button1.Text = "Đóng";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(132, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(123, 63);
            this.button2.TabIndex = 0;
            this.button2.Text = "Hủy";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(261, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(123, 63);
            this.button3.TabIndex = 0;
            this.button3.Text = "Thanh toán";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel4.Controls.Add(this.danhSachChiTiet);
            this.flowLayoutPanel4.Location = new System.Drawing.Point(767, 232);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(411, 371);
            this.flowLayoutPanel4.TabIndex = 2;
            // 
            // danhSachChiTiet
            // 
            this.danhSachChiTiet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.danhSachChiTiet.Location = new System.Drawing.Point(3, 3);
            this.danhSachChiTiet.Name = "danhSachChiTiet";
            this.danhSachChiTiet.RowHeadersWidth = 51;
            this.danhSachChiTiet.RowTemplate.Height = 24;
            this.danhSachChiTiet.Size = new System.Drawing.Size(401, 368);
            this.danhSachChiTiet.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.tongTien);
            this.panel1.Controls.Add(this.ngayTao);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.nguoiTao);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(767, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(411, 213);
            this.panel1.TabIndex = 3;
            // 
            // tongTien
            // 
            this.tongTien.AutoSize = true;
            this.tongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tongTien.Location = new System.Drawing.Point(135, 154);
            this.tongTien.Name = "tongTien";
            this.tongTien.Size = new System.Drawing.Size(94, 25);
            this.tongTien.TabIndex = 1;
            this.tongTien.Text = "Tổng tiền";
            // 
            // ngayTao
            // 
            this.ngayTao.AutoSize = true;
            this.ngayTao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ngayTao.Location = new System.Drawing.Point(135, 108);
            this.ngayTao.Name = "ngayTao";
            this.ngayTao.Size = new System.Drawing.Size(90, 25);
            this.ngayTao.TabIndex = 1;
            this.ngayTao.Text = "Ngày tạo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "Tổng tiền";
            // 
            // nguoiTao
            // 
            this.nguoiTao.AutoSize = true;
            this.nguoiTao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nguoiTao.Location = new System.Drawing.Point(135, 62);
            this.nguoiTao.Name = "nguoiTao";
            this.nguoiTao.Size = new System.Drawing.Size(95, 25);
            this.nguoiTao.TabIndex = 1;
            this.nguoiTao.Text = "Người tạo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Ngày tạo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Người tạo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(72, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thông Tin Hóa Đơn";
            // 
            // ghiChu
            // 
            this.ghiChu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ghiChu.Location = new System.Drawing.Point(182, 609);
            this.ghiChu.Multiline = true;
            this.ghiChu.Name = "ghiChu";
            this.ghiChu.Size = new System.Drawing.Size(578, 75);
            this.ghiChu.TabIndex = 4;
            // 
            // FormChiTietHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1190, 697);
            this.Controls.Add(this.ghiChu);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel4);
            this.Controls.Add(this.flowLayoutPanel3);
            this.Controls.Add(this.danhSachSanPham);
            this.Controls.Add(this.danhSachLoaiSanPham);
            this.Name = "FormChiTietHoaDon";
            this.Text = "FormChiTietHoaDon";
            this.Load += new System.EventHandler(this.FormChiTietHoaDon_Load);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.danhSachChiTiet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel danhSachLoaiSanPham;
        private System.Windows.Forms.FlowLayoutPanel danhSachSanPham;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView danhSachChiTiet;
        private System.Windows.Forms.TextBox ghiChu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label tongTien;
        private System.Windows.Forms.Label ngayTao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label nguoiTao;
    }
}