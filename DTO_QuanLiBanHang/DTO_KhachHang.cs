using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLiBanHang
{
    public class DTO_KhachHang
    {
        private string dienThoai;
        private string tenKhachHang;
        private string diaChi;
        private int gioiTinh;

        public string DienThoai
        {
            get
            {
                return dienThoai;
            }
            set
            {
                dienThoai = value;
            }          
        }
        public string TenKhachHang
        {
            get
            {
                return tenKhachHang;
            }
            set
            {
                tenKhachHang = value;
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
        public int GioiTinh
        {
            get
            {
                return gioiTinh;
            }
            set
            {
                gioiTinh = value;
            }
        }
        public DTO_KhachHang(string dienThoai, string tenKhachHang, string diaChi, int gioiTinh)
        {
            this.dienThoai = dienThoai;
            this.tenKhachHang = tenKhachHang;
            this.diaChi = diaChi;
            this.gioiTinh = gioiTinh;
        }
        public DTO_KhachHang(string dienThoai, string tenKhachHang, int gioiTinh)
        {
            this.dienThoai = dienThoai;
            this.tenKhachHang = tenKhachHang;          
            this.gioiTinh = gioiTinh;
        }
    }
}
