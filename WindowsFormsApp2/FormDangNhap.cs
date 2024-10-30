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
    public partial class FormDangNhap : Form
    {
        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try {
                string caulenhSQL = $@"
                    SELECT * 
                    FROM NguoiDungDangNhap
                    WHERE TenDangNhap = N'{tk.Text}' 
                      AND MatKhau = N'{mk.Text}';";
                DataTable dt = DataProvider.Instance.ExecuteQuery(caulenhSQL);
                if(dt.Rows.Count > 0)
                {
                   if(tk.Text.ToLower() == "admin")
                    {
                        LocalStore.QuyenCuaNguoiDung = "admin";
                    }
                    LocalStore.TaiKhoanDangNhap = tk.Text;
                    Hide();
                    FormDanhSachHoaDon form = new FormDanhSachHoaDon();
                    form.ShowDialog();
                    Close();
                }
                else
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu không đúng !!!");
                }

            } catch(Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Hide();
            FormDangKy form = new FormDangKy();
            form.ShowDialog();
            Close();
        }
    }
}
