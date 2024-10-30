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
    public partial class FormQuanLy : Form
    {
        public FormQuanLy()
        {
            InitializeComponent();
            Main();
            try
            {
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        void Main()
        {
           
            HienThiDanhSachHoa();
            HienThiDanhSachLoaiHoa();
            HienThiDanhSachHoaDon();
            HienThiDanhSachTaiKhoan();
        }
        void HienThiDanhSachHoa()
        {
            string caulenhSQL = $@"
                        select * from Hoa where DaXoa = 0;
                        ";
            DataTable dt = DataProvider.Instance.ExecuteQuery(caulenhSQL);
            dsHoa.DataSource = dt;
        }
        void HienThiDanhSachLoaiHoa()
        {
            string caulenhSQL = $@"
                        select * from LoaiHoa where DaXoa = 0;
                        ";
            DataTable dt = DataProvider.Instance.ExecuteQuery(caulenhSQL);
            tenLoaiHoa.Items.Clear();
            foreach (DataRow dr in dt.Rows)
            {
                tenLoaiHoa.Items.Add(dr["TenLoaiHoa"].ToString());
            }
            dsLoaiHoa.DataSource = dt;
        }
        void HienThiDanhSachHoaDon()
        {
            string caulenhSQL = $@"
                        select * from HoaDon where DaXoa = 0 and TrangThai = N'Đã Thanh Toán';
                        ";
            DataTable dt = DataProvider.Instance.ExecuteQuery(caulenhSQL);
            dataGridView1.DataSource = dt;
        }
        void HienThiDanhSachTaiKhoan()
        {
            string caulenhSQL = $@"
                        select * from NguoiDungDangNhap;
                        ";
            DataTable dt = DataProvider.Instance.ExecuteQuery(caulenhSQL);
            dsTaiKhoan.DataSource = dt;
        }
        private void button12_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDanhSachHoaDon form = new FormDanhSachHoaDon();
            form.ShowDialog();
            this.Close();
        }

        private void dsLoaiHoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            tenLoai.Text = dsLoaiHoa.Rows[index].Cells["TenLoaiHoa"].Value.ToString();
            motaLoaiHoa.Text = dsLoaiHoa.Rows[index].Cells["MoTa"].Value.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult dia = MessageBox.Show($"Bạn có muốn xóa loại hoa {tenLoai.Text} không", "Xóa ?", MessageBoxButtons.OKCancel);
            if (dia == DialogResult.OK)
            {
                string caulenhSQL = $@"
                        Update LoaiHoa set DaXoa = 1 where TenLoaiHoa = N'{tenLoai.Text}';
                        ";
                DataProvider.Instance.ExecuteNonQuery(caulenhSQL);
                HienThiDanhSachLoaiHoa();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string caulenhSQL = $@"
                    INSERT INTO LoaiHoa (TenLoaiHoa, MoTa)
                    VALUES (N'{tenLoai.Text}', N'{motaLoaiHoa.Text}');
                        ";
            DataProvider.Instance.ExecuteNonQuery(caulenhSQL);
            HienThiDanhSachLoaiHoa();
        }

        private void dsHoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = e.RowIndex;
                tenHoa.Text = dsHoa.Rows[index].Cells["Ten"].Value.ToString();
                tenLoaiHoa.Text = dsHoa.Rows[index].Cells["TenLoaiHoa"].Value.ToString();
                giaHoa.Text = dsHoa.Rows[index].Cells["Gia"].Value.ToString();
                tonKho.Text = dsHoa.Rows[index].Cells["SoLuongTon"].Value.ToString();
                ngayTao.Text = dsHoa.Rows[index].Cells["NgayTao"].Value.ToString();
                motaHoa.Text = dsHoa.Rows[index].Cells["MoTa"].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            string caulenhSQL = $@"
                    INSERT INTO Hoa (Ten, MoTa, Gia, SoLuongTon, TenLoaiHoa)
                    VALUES (N'{tenHoa.Text}', N'{motaHoa.Text}', {giaHoa.Text}, {tonKho.Text}, N'{tenLoaiHoa.Text}');
                        ";
            DataProvider.Instance.ExecuteNonQuery(caulenhSQL);
            HienThiDanhSachHoa();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string caulenhSQL = $@"
                Update Hoa set MoTa = N'{motaHoa.Text}', Gia = {giaHoa.Text}, SoLuongTon = {tonKho.Text}, TenLoaiHoa = N'{tenLoaiHoa.Text}'
                Where Ten = N'{tenHoa.Text}'
                        ";
            DataProvider.Instance.ExecuteNonQuery(caulenhSQL);
            HienThiDanhSachHoa();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dia = MessageBox.Show($"Bạn có muốn xóa hoa {tenHoa.Text} không", "Xóa ?", MessageBoxButtons.OKCancel);
            if (dia == DialogResult.OK)
            {
                string caulenhSQL = $@"
                        Update Hoa set DaXoa = 1 where Ten = N'{tenHoa.Text}';
                        ";
                DataProvider.Instance.ExecuteNonQuery(caulenhSQL);
                HienThiDanhSachHoa();
            }
        }

        private void dsHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = e.RowIndex;
                maHD.Text = dataGridView1.Rows[index].Cells["MaHoaDon"].Value.ToString();
                ngayTaoHD.Text = dataGridView1.Rows[index].Cells["NgayLap"].Value.ToString();
                nguoiTaoHD.Text = dataGridView1.Rows[index].Cells["NguoiTaoId"].Value.ToString();
                tongTienHD.Text = dataGridView1.Rows[index].Cells["TongTien"].Value.ToString();
                ghiChuHD.Text = dataGridView1.Rows[index].Cells["GhiChu"].Value.ToString();
                string caulenhSQL = $@"
                        select * from ChiTietHoaDon where HoaDonId = {dataGridView1.Rows[index].Cells["HoaDonId"].Value};
                        ";
                DataTable dt = DataProvider.Instance.ExecuteQuery(caulenhSQL);
                chitiethoadon.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dsTaiKhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            taikhoan.Text = dsTaiKhoan.Rows[index].Cells["TenDangNhap"].Value.ToString();
            matkhau.Text = dsTaiKhoan.Rows[index].Cells["MatKhau"].Value.ToString();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string caulenhSQL = $@"
                Update NguoiDungDangNhap set MatKhau = N'{matkhau.Text}' where TenDangNhap = N'{taikhoan.Text}'
                    ";
            DataProvider.Instance.ExecuteNonQuery(caulenhSQL);
            HienThiDanhSachTaiKhoan();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if(taikhoan.Text.ToLower() == "admin")
            {
                MessageBox.Show("Không được xóa tài khoản admin");
            }
            DialogResult dia = MessageBox.Show($"Bạn có muốn xóa tài khoản {taikhoan.Text} không", "Xóa ?", MessageBoxButtons.OKCancel);
            if (dia == DialogResult.OK)
            {
                string caulenhSQL = $@"
                delete NguoiDungDangNhap where TenDangNhap = N'{taikhoan.Text}'
                    ";
                DataProvider.Instance.ExecuteNonQuery(caulenhSQL);
                HienThiDanhSachTaiKhoan();
            }
        }

        private void giaHoa_TextChanged(object sender, EventArgs e)
        {
        }

        private void giaHoa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
