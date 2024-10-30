using System;
using System.Data;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class FormChiTietHoaDon : Form
    {
        public string _hoaDonId = string.Empty;
        public double tong = 0;
        public DataRow hoadon {  get; set; }
        public FormChiTietHoaDon()
        {
            InitializeComponent();
        }
        public FormChiTietHoaDon(string hoaDonId)
        {
            _hoaDonId = hoaDonId;
            InitializeComponent();
        }
        void HienThiChiTietHoaDon()
        {
            string caulenhSQL = $@"
                        select * from ChiTietHoaDon where HoaDonId = {hoadon["HoaDonId"].ToString()};
                        ";
            DataTable dt = DataProvider.Instance.ExecuteQuery(caulenhSQL);
            foreach (DataRow dr in dt.Rows)
            {
                tong += double.Parse(dr["ThanhTien"].ToString());
            }
            tongTien.Text = tong.ToString();
            danhSachChiTiet.DataSource = dt;
        }
        void HienThiHoa(string loaiHoa = "")
        {
            danhSachSanPham.Controls.Clear();
            string caulenhSQL = $@"
                        select * from Hoa where TenLoaiHoa like N'{loaiHoa}' and DaXoa = 0
                        ";
            if(loaiHoa == "")
            {
                caulenhSQL = $@"
                        select * from Hoa
                        ";
            }
            DataTable dt = DataProvider.Instance.ExecuteQuery(caulenhSQL);
            foreach (DataRow dr in dt.Rows)
            {
                Button btn = new Button();
                btn.Text = dr["Ten"].ToString();
                btn.Width = 90;
                btn.Height = 52;
                btn.Click += (object sender2, EventArgs e2) =>
                {
                    string caulenhSQLKiemTraSanPhamTonTai = $@"
                        SELECT *
                        FROM ChiTietHoaDon 
                        WHERE HoaDonId = {hoadon["HoaDonId"].ToString()} AND TenHoa = N'{btn.Text}'
                        ";
                    DataTable dt1 = DataProvider.Instance.ExecuteQuery(caulenhSQLKiemTraSanPhamTonTai);
                    if(dt1.Rows.Count > 0)
                    {
                        string caulenhSQLTangSoLuong = $@"
                        UPDATE ChiTietHoaDon
                        SET SoLuong = SoLuong + 1
                        WHERE HoaDonId = {hoadon["HoaDonId"].ToString()}  AND TenHoa = N'{btn.Text}';
";
                        DataProvider.Instance.ExecuteNonQuery(caulenhSQLTangSoLuong);
                    }
                    else
                    {
                        string caulenhSQLThemChiTietHoaDonMoi = $@"
                        INSERT INTO ChiTietHoaDon (HoaDonId, TenHoa, SoLuong, DonGia)
                        VALUES ({hoadon["HoaDonId"].ToString()},N'{dr["Ten"].ToString()}' , 1, {dr["Gia"].ToString()});
";
                        DataProvider.Instance.ExecuteNonQuery(caulenhSQLThemChiTietHoaDonMoi);
                    }
                    HienThiChiTietHoaDon();
                };
                danhSachSanPham.Controls.Add(btn);

            }
        }
        void HienThiLoaiHoa()
        {
            string caulenhSQL = $@"
                        select TenLoaiHoa from LoaiHoa where DaXoa = 0
                        ";
            DataTable dt = DataProvider.Instance.ExecuteQuery(caulenhSQL);
            foreach (DataRow dr in dt.Rows)
            {
                Button btn = new Button();
                btn.Text = dr[0].ToString();
                btn.Width = 90;
                btn.Height = 58;
                btn.Click += (object sender2, EventArgs e2) =>
                {
                    HienThiHoa(btn.Text);
                };
                danhSachLoaiSanPham.Controls.Add(btn);
            }
        }
        private void FormChiTietHoaDon_Load(object sender, EventArgs e)
        {
            string caulenhSQL = $@"
                        select * from HoaDon
                        WHERE MaHoaDon = '{_hoaDonId}';                   
                        ";
            DataTable dt = DataProvider.Instance.ExecuteQuery(caulenhSQL);
            hoadon = dt.Rows[0];
            nguoiTao.Text = hoadon["NguoiTaoId"].ToString();
            ngayTao.Text = hoadon["NgayLap"].ToString();
            tongTien.Text = hoadon["TongTien"].ToString();
            ghiChu.Text = hoadon["GhiChu"].ToString();
            HienThiLoaiHoa();
            HienThiHoa();
            HienThiChiTietHoaDon();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string caulenhSQL = $@"
                        UPDATE HoaDon
                        SET GhiChu = N'{ghiChu.Text}', TongTien = {tong}
                        WHERE MaHoaDon = '{_hoaDonId}';                   
                        ";
            DataProvider.Instance.ExecuteNonQuery(caulenhSQL);
            Hide();
            FormDanhSachHoaDon form = new FormDanhSachHoaDon();
            form.ShowDialog();
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dia = MessageBox.Show("Bạn có muốn hủy hóa đơn này không", "Xóa ?", MessageBoxButtons.OKCancel);
                if (dia == DialogResult.OK)
                {
                    string caulenhSQL = $@"
                        UPDATE HoaDon
                        SET DaXoa = 1
                        WHERE MaHoaDon = '{_hoaDonId}';                   
                        ";
                    DataProvider.Instance.ExecuteNonQuery(caulenhSQL);
                    Hide();
                    FormDanhSachHoaDon form = new FormDanhSachHoaDon();
                    form.ShowDialog();
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dia = MessageBox.Show("Bạn có muốn thanh toán hóa đơn này không", "Thanh toán ?", MessageBoxButtons.OKCancel);
                if (dia == DialogResult.OK)
                {
                    string caulenhSQL = $@"
                        UPDATE HoaDon
                        SET TrangThai = N'Đã Thanh Toán',
                        GhiChu = N'{ghiChu.Text}',TongTien = {tong}
                        WHERE MaHoaDon = '{_hoaDonId}';                   
                        ";
                    DataProvider.Instance.ExecuteNonQuery(caulenhSQL);
                    Hide();
                    FormDanhSachHoaDon form = new FormDanhSachHoaDon();
                    form.ShowDialog();
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
