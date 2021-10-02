using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace DTO_QuanLiBanHang
{
    public class DTO_NhanVien
    {
        private string tenNhanVien;
        private string diaChi;
        private int vaiTro;
        private string email;
        private string matKhau;
        private int tinhTrang;

        public string TenNhanVien
        {
            get
            {
                return tenNhanVien;
            }
            set
            {
                tenNhanVien = value;
            }
        }
        public string DiaChi
        {
            get
            {
                return diaChi;
            }
            set
            {
                diaChi = value;
            }
        }
        public int VaiTro
        {
            get
            {
                return vaiTro;
            }
            set
            {
                vaiTro = value;
            }
        }
        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                email = value;
            }
        }
        public string MatKhau
        {
            get
            {
                return matKhau;
            }
            set
            {
                matKhau = value;
            }
        }
        public int TinhTrang
        {
            get
            {
                return tinhTrang;
            }
            set
            {
                tinhTrang = value;
            }
        }
        public DTO_NhanVien(string email, string tenNhanVien, string diaChi, int vaiTro, int tinhTrang, string matKhau)
        {
            this.tenNhanVien = tenNhanVien;
            this.diaChi = diaChi;
            this.vaiTro = vaiTro;
            this.email = email;
            this.tinhTrang = tinhTrang;
            this.matKhau = matKhau;
        }
        public DTO_NhanVien(string email, string tenNhanVien, string diaChi, int vaiTro, int tinhTrang)
        {
            this.tenNhanVien = tenNhanVien;
            this.diaChi = diaChi;
            this.vaiTro = vaiTro;
            this.email = email;
            this.tinhTrang = tinhTrang;
        }
        public DTO_NhanVien()
        {

        }
    }
}
