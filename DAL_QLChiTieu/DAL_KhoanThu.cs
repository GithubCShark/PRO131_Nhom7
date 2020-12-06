using DTO_QLChiTieu;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_QLChiTieu
{
    public class DAL_KhoanThu : DBConnect
    {
        public bool InsertKhoanThu(DTO_KhoanThu kt)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "InsertDataIntoKhoanThu";
                cmd.Parameters.AddWithValue("tenkhoanthu", kt.TenKT);
                cmd.Parameters.AddWithValue("ngaythu", kt.NgayThu);
                cmd.Parameters.AddWithValue("sotien", kt.SoTien);
                cmd.Parameters.AddWithValue("mota", kt.MoTa);
                cmd.Parameters.AddWithValue("email", kt.Email);

                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            finally
            {
                _conn.Close();
            }
            return false;
        }

        public bool UpdateKhoanThu(DTO_KhoanThu kt)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "UpdateDataIntoKhoanThu";
                cmd.Parameters.AddWithValue("maKT", kt.MaKT);
                cmd.Parameters.AddWithValue("tenkhoanthu", kt.TenKT);
                cmd.Parameters.AddWithValue("ngaythu", kt.NgayThu);
                cmd.Parameters.AddWithValue("sotien", kt.SoTien);
                cmd.Parameters.AddWithValue("mota", kt.MoTa);

                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            finally
            {
                _conn.Close();
            }
            return false;
        }

        public bool DeleteKhoanThu(string maKT)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "DeleteDataFromKhoanThu";
                cmd.Parameters.AddWithValue("maKT", maKT);

                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            finally
            {
                _conn.Close();
            }
            return false;
        }

        public DataTable getKhoanThu()
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "DanhSachKhoanThu";
                DataTable dtKhoanThu = new DataTable();
                dtKhoanThu.Load(cmd.ExecuteReader());
                return dtKhoanThu;
            }
            finally
            {
                _conn.Close();
            }
        }

        public DataTable getKhoanThuNgay(DateTime ngay)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "DahSachKhoanThuNgay";
                cmd.Parameters.AddWithValue("ngay", ngay);
                DataTable dtKTNgay = new DataTable();
                dtKTNgay.Load(cmd.ExecuteReader());
                return dtKTNgay;
            }
            finally
            {
                _conn.Close();
            }
        }

        public DataTable getKhoanThuThang(DateTime thang)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "DahSachKhoanThuThang";
                cmd.Parameters.AddWithValue("ngay", thang);
                DataTable dtKTThang = new DataTable();
                dtKTThang.Load(cmd.ExecuteReader());
                return dtKTThang;
            }
            finally
            {
                _conn.Close();
            }
        }
    }
}
