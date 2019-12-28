using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyCaPhe.DBLayer;
using System.Data;

namespace QuanLyCaPhe.BSLayer
{
    class ChiTietHoaDon
    {
        DBMain db = null;

        public ChiTietHoaDon()
        {
            db = new DBMain();
        }

        /// <summary>
        /// Lấy hóa đơn từ 1 bàn
        /// </summary>
        /// <param name="idBan"></param>
        public DataSet LayChiTietHoaDon(int idBan)
        {
            string strSQL = $"Select TenThucAn, SoLuong, Gia from ChiTietHoaDon join HoaDon on ChiTietHoaDon.IDHoaDon = HoaDon.IDHoaDon join ThucAn on ThucAn.IDThucAn = ChiTietHoaDon.IDThucAn join BanAn on BanAn.IDBanAn = HoaDon.IDBanAn where BanAn.IDBanAn = {idBan} and HoaDon.TinhTrang = 0";
            return db.ExecuteQueryDataSet(strSQL, CommandType.Text);
        }

        public void ThemChiTietHD(int idHoaDon, int idThucAn, int count, ref string error)
        {
            string strSQL = $"Insert into ChiTietHoaDon(IDHoaDon, IDThucAn, SoLuong) values({idHoaDon}, {idThucAn}, {count})";
            if(db.MyExecuteNonQuery(strSQL, CommandType.Text, ref error) == false)
            {
                int soluong=0;
                db.LayMa($"select Soluong from ChiTietHoaDon where IDHoaDon ='" + idHoaDon + "'AND IDTHUCAN ='" + idThucAn + "'", CommandType.Text, ref soluong);
                soluong += count;
                strSQL = "Update ChiTietHoaDon Set SoLuong =N'" + soluong+ "'where IDHoaDon =N'" + idHoaDon + "'AND IDThucAn =N'" + idThucAn + "'";
                db.MyExecuteNonQuery(strSQL, CommandType.Text, ref error);
            }
        }

        public void ThemChiTietHDTonTai(int idHoaDon, int idThucAn, int count, ref string error)
        {
            string strSQL = $"Insert into ChiTietHoaDon(IDHoaDon, IDThucAn, SoLuong) values({idHoaDon}, {idThucAn}, {count})";
            db.MyExecuteNonQuery(strSQL, CommandType.Text, ref error);
        }

        public void XoaChiTietHoaDon(int idBan, int idThucAn, ref string error)
        {
            string strSQL = $"delete from ChiTietHoaDon where IDThucAn = {idThucAn} and IDHoaDon = (select IDHoaDon from HoaDon where IDBanAn = {idBan} and TinhTrang = 0)";
            db.MyExecuteNonQuery(strSQL, CommandType.Text, ref error);
        }
    }
}
