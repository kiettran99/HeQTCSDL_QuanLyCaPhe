using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyCaPhe.DBLayer;

namespace QuanLyCaPhe.BSLayer
{
    public class ThongKeHoaDon
    {
        DBMain db = new DBMain();
        string err = "";

        public DataSet LayThongKeHoaDon()
        {
            return db.ExecuteQueryDataSet("select *from NhanVien_HoaDon_KhachHang", CommandType.Text);
        }

        public void ThemThongKeHoaDon(int IDHoaDon, string TenNV, string TenKH, DateTime NgayBan, float ThanhTien)
        {
            db.MyExecuteNonQuery($"insert into NhanVien_HoaDon_KhachHang({IDHoaDon}, N'{TenNV}', N'{TenKH}', {NgayBan.ToString("YYYY-MM-DD")}, {ThanhTien})", CommandType.Text, ref err);
        }

    }
}
