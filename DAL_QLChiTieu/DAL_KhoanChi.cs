﻿using DTO_QLChiTieu;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_QLChiTieu
{
    public class DAL_KhoanChi : DBConnect
    {
        public bool InsertKhoanChi(DTO_KhoanChi kc)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "InsertDataIntoKhoanChi";
                cmd.Parameters.AddWithValue("tenkhoanchi", kc.TenKC);
                cmd.Parameters.AddWithValue("ngaychi", kc.NgayChi);
                cmd.Parameters.AddWithValue("sotien", kc.SoTien);
                cmd.Parameters.AddWithValue("mota", kc.MoTa);
                cmd.Parameters.AddWithValue("email", kc.Email);

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

        public bool UpdateKhoanChi(DTO_KhoanChi kc)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "UpdateDataIntoKhoanThu";
                cmd.Parameters.AddWithValue("maKC", kc.MaKC);
                cmd.Parameters.AddWithValue("tenkhoanchi", kc.TenKC);
                cmd.Parameters.AddWithValue("ngayhi", kc.NgayChi);
                cmd.Parameters.AddWithValue("sotien", kc.SoTien);
                cmd.Parameters.AddWithValue("mota", kc.MoTa);

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

        public bool DeleteKhoanChi(string maKC)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "DeleteDataFromKhoanChi";
                cmd.Parameters.AddWithValue("maKC", maKC);

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

        public DataTable getKhoanChi()
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "DanhSachKhoanChi";
                DataTable dtKhoanChi = new DataTable();
                dtKhoanChi.Load(cmd.ExecuteReader());
                return dtKhoanChi;
            }
            finally
            {
                _conn.Close();
            }
        }
    }
}