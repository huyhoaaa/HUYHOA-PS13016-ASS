using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DTO_QuanLiBanHang;

namespace DAL_QuanLiBanHang
{
    public class DAL_NhanVien: DBConnect
    {
        public bool NhanVienDangNhap(DTO_NhanVien nv) // có  thể sài string emal em, string matkhau để tránh lãng phí tài nguyên
        {
            /*code này là parameter 
            try
            {
                //ket noi
                
                conn.Open();

                string query = "select * from NhanVien where Email = @email,, MatKhau = @matkhau";
                SqlParameter emailPara = new SqlParameter();
                emailPara.Value = nv.Email;

                SqlParameter matKhauPara = new SqlParameter();
                matKhauPara.Value = nv.MatKhau;

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add(emailPara);
                cmd.Parameters.Add(matKhauPara);
                //query và kiểm tra
                if (Convert.ToInt32(cmd.ExecuteScalar()) > 0)
                {
                    return true;
                }           
            }
            catch (Exception ex)
            {   }
            finally
            {
                //dong ket noi
                conn.Close();
            }
            return false;
                */

            //using procedure
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "DangNhap";
                cmd.Parameters.AddWithValue("email", nv.Email);
                cmd.Parameters.AddWithValue("matkhau", nv.MatKhau);
                //query và kiểm tra
                if (Convert.ToInt32(cmd.ExecuteScalar()) > 0)
                {
                    return true;
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                conn.Close();
            }
            return false;
        }

        public bool NhanVienQuenMatKhau(string email)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "QuenMatKhau";
                cmd.Parameters.AddWithValue("email",email);
                //query và kiểm tra
                if (Convert.ToInt32(cmd.ExecuteScalar()) > 0)
                {
                    return true;
                }
            }
            catch (Exception)
            { }
            finally
            {
                conn.Close();
            }
            return false;
        }
        //tao moi mat khau khi quen mat khau
        //cap nhat thong tin nhan vien, cap nhat mat khau
        public bool TaoMatKhau(string email, string matKhauMoi)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "TaoMatKhauMoi";
                cmd.Parameters.AddWithValue("email",email);
                cmd.Parameters.AddWithValue("matkhau", matKhauMoi);
                if (Convert.ToInt32(cmd.ExecuteNonQuery()) > 0)
                {
                    return true;
                }
            }
            catch (Exception)
            { }
            finally
            {
                conn.Close();
            }
            return false;
        }
    } 
}
