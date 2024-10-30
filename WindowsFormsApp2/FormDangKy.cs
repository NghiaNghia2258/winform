using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class FormDangKy : Form
    {
        public FormDangKy()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(mk.Text == mk2.Text)
            {
                try
                {
                    string caulenhSQL = $@"
                    INSERT INTO NguoiDungDangNhap (TenDangNhap, MatKhau)
                    VALUES (N'{tk.Text}', N'{mk.Text}');";
                    DataProvider.Instance.ExecuteNonQuery(caulenhSQL);
                    MessageBox.Show("Đăng ký thành công");
                    Hide();
                    FormDangNhap form = new FormDangNhap();
                    form.ShowDialog();
                    Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Tài khoản đã tồn tại");
                }
            }
            else
            {
                MessageBox.Show("Mật khẩu không khớp");
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Hide();
            FormDangNhap form = new FormDangNhap();
            form.ShowDialog();
            Close();
        }
    }
}
