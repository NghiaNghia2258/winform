using System.Text;
using System;

namespace WindowsFormsApp2
{
    public static class LocalStore
    {
        public static string TaiKhoanDangNhap = "";
        public static string QuyenCuaNguoiDung = "";

        public static string TaoChuoiNgauNhien(int dodai = 6)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            StringBuilder result = new StringBuilder(dodai);
            Random random = new Random();

            for (int i = 0; i < dodai; i++)
            {
                result.Append(chars[random.Next(chars.Length)]);
            }

            return result.ToString();
        }
    }
}
