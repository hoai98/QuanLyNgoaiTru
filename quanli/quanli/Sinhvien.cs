using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace quanli
{
    public class Sinhvien
    {
        private string masv;
        private string hoten;
        private DateTime ngaysinh;
        private bool gioitinh;
        private string quequan;
        private string tenchutro;
        private string sdt;
        private string diachi;
        private DateTime ngayden;
        private DateTime ngaydi;
        private string lop;
        private string makhoa;

        public string MaSV
        {
            get { return masv; }
            set { masv = value; }
        }
        public string HoTen
        {
            get { return hoten; }
            set { hoten = value; }
        }
        public DateTime NgaySinh
        {
            get { return ngaysinh; }
            set { ngaysinh = value; }
        }
        public bool GioiTinh
        {
            get { return gioitinh; }
            set { gioitinh = value; }
        }
        public string QueQuan
        {
            get { return quequan; }
            set { quequan = value; }
        }
      
        
        public string TenChuTro
        {
            get { return tenchutro; }
            set { tenchutro = value; }
        }
        public string SDT
        {
            get { return sdt; }
            set { sdt = value; }
        }
        public string DiaChi
        {
            get { return diachi; }
            set { diachi = value; }
        }
        public DateTime NgayDen
        {
            get { return ngayden; }
            set { ngayden = value; }

        }
        public DateTime NgayDi
        {
            get { return ngaydi; }
            set{ ngaydi = value; }
        }
        public string Lop
        {
            get { return lop; }
            set { lop = value; }
        }
        public string MaKhoa
        {
            get { return makhoa; }
            set { makhoa = value; }
        }
        public Sinhvien(string masv,string hoten, DateTime ngaysinh,bool gioitinh,string quequan,string tenchutro,string sdt,string diachi,DateTime ngayden,DateTime ngaydi,string lop,string makhoa)
        {
            
            this.masv = masv;
            this.hoten = hoten;
            this.ngaysinh = ngaysinh;
            this.gioitinh = gioitinh;
            this.quequan = quequan;
            this.tenchutro = tenchutro;
            this.sdt = sdt;
            this.diachi = diachi;
            this.ngayden = ngayden;
            this.ngaydi = ngaydi;
            this.lop = lop;
            this.makhoa = makhoa;
        }

          


    }
}