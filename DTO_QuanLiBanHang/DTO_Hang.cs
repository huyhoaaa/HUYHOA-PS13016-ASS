using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLiBanHang
{
    public class DTO_Hang
    {
        private string tenHang;
        private int soLuong;
        private float donGiaNhap;
        private float dongGiaBan;
        private string ghiChu;

        public string TenHang
        {
            get
            {
                return tenHang;
            }
            set
            {
                tenHang = value;
            }
        }
        public int SoLuong
        {
            get
            {
                return soLuong;
            }
            set
            {
                soLuong = value;
            }
        }
        public float DonGiaNhap
        {
            get
            {
                return donGiaNhap;
            }
            set
            {
                DonGiaNhap = value;
            }
        }
        public float DonGiaBan
        {
            get
            {
                return dongGiaBan;
            }
            set
            {
                DonGiaNhap = value;
            }
        }
        public string GhiChu
        {
            get
            {
                return ghiChu;
            }
            set
            {
                ghiChu = value;
            }
        }
        public DTO_Hang(string tenHang, int soLuong, float dongGiaNhap, float donGiaBan)
        {
            this.tenHang = tenHang;
            this.soLuong = soLuong;
            this.donGiaNhap = dongGiaNhap;
            this.DonGiaBan = DonGiaBan;
        }
    }
}
