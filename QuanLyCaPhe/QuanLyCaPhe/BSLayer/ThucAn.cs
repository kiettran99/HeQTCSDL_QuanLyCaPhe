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
            //return dbMain.ExecuteQueryDataSet("select *from ThucAn", CommandType.Text);
            
            return dbMain.ExecuteQueryDataSet("uspGetLayThucAn_ByTen", CommandType.StoredProcedure);
        }

        public DataSet LayThucAnTheoLoai(string tenLoaiThucAn)
        {

            //return dbMain.ExecuteQueryDataSet($"select * from ThucAn join LoaiThucAn on ThucAn.IDLoaiThucAn = LoaiThucAn.IDLoaiThucAn where TenLoaiThucAn = N'{tenLoaiThucAn}'", CommandType.Text);
            return dbMain.ExecuteQueryDataSet("uspGetLayThucAn_ByTenLoaiThucAn", CommandType.StoredProcedure);
        }


        public bool ThemThucAn(ref string error,
           int  IDHoaDon ,
          int IDThucAn  ,
         string TenThucAn,
	    int	IDLoaiThucAn,
        float Gia  ,
		string    TenLoaiThucAn ,
		int    SoLuong )
        {
            //string sqlString;
            //try
            //{
            //    sqlString = $"Insert into ThucAn values(N'{MaThucAn.Trim()}',  N'{TenMon.ToString()}', N'{DanhMuc.Trim()}', '{Gia}')";
            //    error = "Thêm thành công";
            //}
            //catch (SqlException)
            //{
            //    error = "Thêm không được";
            //    return false;
            //}

            //return dbMain.MyExecuteNonQuery(sqlString, CommandType.Text, ref error);
            return dbMain.MyExecuteNonQuery("uspInsertThucAn", CommandType.StoredProcedure, ref error,
                  new SqlParameter("@IDHoaDon", IDHoaDon),
                  new SqlParameter("@IDThucAn", IDThucAn),
                  new SqlParameter("@TenThucAn", TenThucAn),
                  new SqlParameter("@IDLoaiThucAn", IDLoaiThucAn),
                  new SqlParameter("@Gia", Gia),
                  new SqlParameter("@TenLoaiThucAn", TenLoaiThucAn),
                  new SqlParameter("@SoLuong", SoLuong));



    }
        public bool SuaThucAn(ref string error,
           int  IDHoaDon ,
          int IDThucAn  ,
         string TenThucAn,
	    int	IDLoaiThucAn,
        float Gia  ,
		string    TenLoaiThucAn ,
		int    SoLuong )
        {
            //string sqlString;
            //try
            //{
            //    sqlString = "Update ThucAn Set TenThucAn = N'" + TenMon +"',IDLoaiThucAn=N'" + int.Parse(DanhMuc) +
            //    "',Gia='" + float.Parse(Gia) + "'where IDThucAn = '" + int.Parse(MaThucAn) + "'";
            //    error = "Sửa thành công";
            //}
            //catch (SqlException)
            //{
            //    error = "Sửa không được";
            //    return false;
            //}

            //return dbMain.MyExecuteNonQuery(sqlString, CommandType.Text, ref error);
            return dbMain.MyExecuteNonQuery("uspUpdateThucAn", CommandType.StoredProcedure, ref error,
                    new SqlParameter("@IDHoaDon", IDHoaDon),
                    new SqlParameter("@IDThucAn", IDThucAn),
                    new SqlParameter("@TenThucAn", TenThucAn),
                    new SqlParameter("@IDLoaiThucAn", IDLoaiThucAn),
                    new SqlParameter("@Gia", Gia),
                    new SqlParameter("@TenLoaiThucAn", TenLoaiThucAn),
                    new SqlParameter("@SoLuong", SoLuong));
        }
        public bool XoaThucAn(string MaThucAn, ref string error)
        {
            //string sqlString = $"delete from ThucAn where IDThucAn = '{MaThucAn}'";
            //return dbMain.MyExecuteNonQuery(sqlString, CommandType.Text, ref error);

            return dbMain.MyExecuteNonQuery("uspDeleteThucAn", CommandType.StoredProcedure, ref error, new SqlParameter("IDThucAn", MaThucAn));
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
