using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace quanli
{
    public class SinhVienDAO
    {
        public string Connectionstring = ConfigurationManager.ConnectionStrings["DB"].ConnectionString;
        public bool CheckUser(string masv)
        {
            SqlConnection cn = new SqlConnection(Connectionstring);
            cn.Open();
            string sql = "SELECT COUNT(*) FROM SinhVien WHERE MaSV=@masv ";

            SqlCommand cmd = new SqlCommand(sql,cn);
            cmd.Parameters.AddWithValue("@masv",masv);
           int result=(int)cmd.ExecuteScalar();
            return result>=1;

        }
        public bool Insert(Sinhvien sv)
        {
            SqlConnection cn = new SqlConnection(Connectionstring);
            cn.Open();
            string sql = "INSERT INTO SinhVien(MaSV,HoTen,NgaySinh,GioiTinh,QueQuan,Lop,TenChuTro,SDT,DiaChi,NgayDen,NgayDi,MaKhoa)VALUES(@masv,@hoten,@ngaysinh,@gioitinh,@quequan,@lop,@tenchutro,@sdt,@diachi,@ngayden,@ngaydi,@MaKhoa)";

            SqlCommand cmd = new SqlCommand(sql,cn);
            cmd.Parameters.AddWithValue("@masv",sv.MaSV);
            cmd.Parameters.AddWithValue("@hoten",sv.HoTen);
            cmd.Parameters.AddWithValue("@ngaysinh", sv.NgaySinh);
            cmd.Parameters.AddWithValue("@gioitinh", sv.GioiTinh);
            cmd.Parameters.AddWithValue("@quequan", sv.QueQuan);
            cmd.Parameters.AddWithValue("@lop",sv.Lop);
            cmd.Parameters.AddWithValue("@tenchutro", sv.TenChuTro);
            cmd.Parameters.AddWithValue("@sdt", sv.SDT);
            cmd.Parameters.AddWithValue("@diachi", sv.DiaChi);
            cmd.Parameters.AddWithValue("@ngayden", sv.NgayDen);
            cmd.Parameters.AddWithValue("@ngaydi", sv.NgayDi);
            cmd.Parameters.AddWithValue("@makhoa", sv.MaKhoa);
            int result = (int)cmd.ExecuteNonQuery();
            return (result>=1);
        }
        public DataTable Getdata(string sql)
        {
            SqlConnection cn = new SqlConnection(Connectionstring);
            SqlDataAdapter da = new SqlDataAdapter(sql,cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
            
        }
        public bool Delete(string username)
        {
            SqlConnection cn = new SqlConnection(Connectionstring);
            string sql = "DELETE FROM SinhVien WHERE MaSV=@username";
            cn.Open();
            SqlCommand cmd = new SqlCommand(sql,cn);
            cmd.Parameters.AddWithValue("@username",username);
            int kq = (int)cmd.ExecuteNonQuery();
            return (kq>=1);
        }
        public bool Update(string username,Sinhvien sv)
        {
            SqlConnection cn = new SqlConnection(Connectionstring);
            string sql = "UPDATE SinhVien SET HoTen=@hoten,NgaySinh=@ngaysinh,GioiTinh=@gioitinh,QueQuan=@quequan,Lop=@lop,TenChuTro=@tenchutro,SDT=@sdt,DiaChi=@diachi,NgayDen=@ngayden,NgayDi=@ngaydi,MaKhoa=@makhoa WHERE MaSV=@username";
            SqlCommand cmd = new SqlCommand(sql, cn);
            cn.Open();
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@hoten",sv.HoTen);
            cmd.Parameters.AddWithValue("@ngaysinh",sv.NgaySinh);
            cmd.Parameters.AddWithValue("@gioitinh",sv.GioiTinh);
            cmd.Parameters.AddWithValue("@quequan",sv.QueQuan);
            cmd.Parameters.AddWithValue("@lop",sv.Lop);
            cmd.Parameters.AddWithValue("@tenchutro",sv.TenChuTro);
            cmd.Parameters.AddWithValue("@sdt",sv.SDT);
            cmd.Parameters.AddWithValue("@diachi",sv.DiaChi);
            cmd.Parameters.AddWithValue("@ngayden",sv.NgayDen);
            cmd.Parameters.AddWithValue("@ngaydi",sv.NgayDi);
            cmd.Parameters.AddWithValue("@makhoa",sv.MaKhoa);

            int kq = (int)cmd.ExecuteNonQuery();
            return (kq >= 1);
        }




    }
}