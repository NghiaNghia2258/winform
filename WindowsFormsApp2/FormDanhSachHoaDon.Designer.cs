﻿namespace WindowsFormsApp2
{
    partial class FormDanhSachHoaDon
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
            this.danhsachhoadon = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // danhsachhoadon
            // 
            this.danhsachhoadon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.danhsachhoadon.Location = new System.Drawing.Point(12, 62);
            this.danhsachhoadon.Name = "danhsachhoadon";
            this.danhsachhoadon.Size = new System.Drawing.Size(821, 619);
            this.danhsachhoadon.TabIndex = 0;
            this.danhsachhoadon.Paint += new System.Windows.Forms.PaintEventHandler(this.danhsachhoadon_Paint);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button1.Location = new System.Drawing.Point(852, 62);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(217, 58);
            this.button1.TabIndex = 1;
            this.button1.Text = "Tạo mới";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button2.Location = new System.Drawing.Point(852, 126);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(217, 58);
            this.button2.TabIndex = 1;
            this.button2.Text = "Đặt hàng";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Yellow;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button3.Location = new System.Drawing.Point(852, 190);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(217, 58);
            this.button3.TabIndex = 1;
            this.button3.Text = "Quản lý";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Gray;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button4.Location = new System.Drawing.Point(852, 623);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(217, 58);
            this.button4.TabIndex = 1;
            this.button4.Text = "Đăng xuất";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // FormDanhSachHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 693);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.danhsachhoadon);
            this.Name = "FormDanhSachHoaDon";
            this.Text = "FormDanhSachHoaDon";
            this.Load += new System.EventHandler(this.FormDanhSachHoaDon_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel danhsachhoadon;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}