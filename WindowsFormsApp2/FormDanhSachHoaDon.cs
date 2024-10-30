using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class FormDanhSachHoaDon : Form
    {
        public FormDanhSachHoaDon()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                string maHoaDon = LocalStore.TaoChuoiNgauNhien(6);
                string caulenhSQL = $@"
                    INSERT INTO HoaDon (MaHoaDon, NguoiTaoId, TongTien)
                    VALUES (N'{maHoaDon}', N'{LocalStore.TaiKhoanDangNhap}', 0);                    
                 ";
                DataProvider.Instance.ExecuteNonQuery(caulenhSQL);
                Hide();
                FormChiTietHoaDon form = new FormChiTietHoaDon(maHoaDon);
                form.ShowDialog();
                Close();
            }
            catch
            {
                MessageBox.Show("Lỗi");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string maHoaDon = LocalStore.TaoChuoiNgauNhien(6);
                string caulenhSQL = $@"
                    INSERT INTO HoaDon (MaHoaDon, NguoiTaoId, TongTien,TrangThai)
                    VALUES (N'{maHoaDon}', N'{LocalStore.TaiKhoanDangNhap}', 0,N'Đặt hàng');                    
                 ";
                DataProvider.Instance.ExecuteNonQuery(caulenhSQL);
                Hide();
                FormChiTietHoaDon form = new FormChiTietHoaDon(maHoaDon);
                form.ShowDialog();
                Close();
            }
            catch
            {
                MessageBox.Show("Lỗi");
            }
        }

        private void danhsachhoadon_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormDanhSachHoaDon_Load(object sender, EventArgs e)
        {
            string caulenhSQL = $@"
                    select * from HoaDon where DaXoa = 0 and TrangThai != N'Đã Thanh Toán'               
                 ";
            DataTable dt = DataProvider.Instance.ExecuteQuery(caulenhSQL);
            foreach (DataRow dr in dt.Rows)
            {
                Button btn = new Button();
                btn.Text = dr["MaHoaDon"].ToString();
                btn.Width = 100;
                btn.Height = 62;
                if (dr["TrangThai"].ToString().ToLower() == "chưa thanh toán") { btn.BackColor = Color.Green; }
                else if(dr["TrangThai"].ToString().ToLower() == "đặt hàng") { btn.BackColor = Color.Orange; }
                btn.Click += (object sender2, EventArgs e2) =>
                {
                    this.Hide();
                    FormChiTietHoaDon form = new FormChiTietHoaDon(dr["MaHoaDon"].ToString());
                    form.ShowDialog();
                    this.Close();

                };
                danhsachhoadon.Controls.Add(btn);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(LocalStore.QuyenCuaNguoiDung == "admin")
            {
                this.Hide();
                FormQuanLy form = new FormQuanLy();
                form.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Bạn không có quyền truy cập trang này");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDangNhap form = new FormDangNhap();
            LocalStore.TaiKhoanDangNhap = "";
            LocalStore.QuyenCuaNguoiDung = "";
            form.ShowDialog();
            this.Close();
        }
    }
}
