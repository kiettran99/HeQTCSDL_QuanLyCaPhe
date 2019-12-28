using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyCaPhe.DBLayer;
using System.Data.SqlClient;
using System.Data;
namespace QuanLyCaPhe.BSLayer
{
    class ThucAn
    {
        DBMain dbMain = null;
        public ThucAn()
        {
            dbMain = new DBMain();
        }

        public DataSet LayThucAn()
        {
            return dbMain.ExecuteQueryDataSet("select *from ThucAn", CommandType.Text);
        }

        public DataSet LayThucAnTheoLoai(string tenLoaiThucAn)
        {
            return dbMain.ExecuteQueryDataSet($"select * from ThucAn join LoaiThucAn on ThucAn.IDLoaiThucAn = LoaiThucAn.IDLoaiThucAn where TenLoaiThucAn = N'{tenLoaiThucAn}'", CommandType.Text);
        }


        public bool ThemThucAn(string MaThucAn, string DanhMuc, float Gia, string TenMon, ref string error)
        {
            string sqlString;
            try
            {
                sqlString = $"Insert into ThucAn values(N'{MaThucAn.Trim()}',  N'{TenMon.ToString()}', N'{DanhMuc.Trim()}', '{Gia}')";
                error = "Thêm thành công";
            }
            catch (SqlException)
            {
                error = "Thêm không được";
                return false;
            }
           
            return dbMain.MyExecuteNonQuery(sqlString, CommandType.Text, ref error);
        }
        public bool SuaThucAn(string MaThucAn, string DanhMuc, string Gia, string TenMon, ref string error)
        {
            string sqlString;
            try
            {
                sqlString = "Update ThucAn Set TenThucAn = N'" + TenMon +"',IDLoaiThucAn=N'" + int.Parse(DanhMuc) +
                "',Gia='" + float.Parse(Gia) + "'where IDThucAn = '" + int.Parse(MaThucAn) + "'";
                error = "Sửa thành công";
            }
            catch (SqlException)
            {
                error = "Sửa không được";
                return false;
            }
           
            return dbMain.MyExecuteNonQuery(sqlString, CommandType.Text, ref error);
        }
        public bool XoaThucAn(string MaThucAn, ref string error)
        {
            string sqlString = $"delete from ThucAn where IDThucAn = '{MaThucAn}'";
            return dbMain.MyExecuteNonQuery(sqlString, CommandType.Text, ref error);
        }

        public int TimIDThucAn(string tenThucAn, ref string error)
        {
            string strSQL = $"select IDThucAn from ThucAn where TenThucAn = N'{tenThucAn}'";
            return (int)dbMain.FirstRowQuery(strSQL, CommandType.Text, ref error);
        }

        public DataSet TimKimF(string TenThucAn)
        {
            return dbMain.ExecuteQueryDataSet($"select *from ThucAn where TenThucAn like N'%{TenThucAn}%'", CommandType.Text);
        }
    }
}
