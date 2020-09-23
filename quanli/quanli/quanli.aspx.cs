using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace quanli
{
    public partial class quanli : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

             LoadGridview();
            //sinh ra ngay thang nam
            for (int i=1;i<=31;i++)
            {
                drngaysinh.Items.Add(i.ToString());
                drngayden.Items.Add(i.ToString());
                drngaydi.Items.Add(i.ToString());
            }
            for (int i=1;i<=12;i++)
            {
                drthangsinh.Items.Add(i.ToString());
                drthangden.Items.Add(i.ToString());
                drthangdi.Items.Add(i.ToString());
            }
            for (int i = 1997; i <= 2000; i++)
            {
                drnamsinh.Items.Add(i.ToString());
                
            }
            for (int i=2014;i<=DateTime.Now.Year;i++)
            {
                
                drnamden.Items.Add(i.ToString());
                drnamdi.Items.Add(i.ToString());
            }
            
           

            

        }
        public void LoadGridview()
        {
            SinhVienDAO sv = new SinhVienDAO();
            drkhoa.DataSource = sv.Getdata("SELECT MaKhoa,TenKhoa FROM Khoa");
            drkhoa.DataTextField = "TenKhoa";
            drkhoa.DataValueField = "MaKhoa";
            drkhoa.DataBind();
            GridView1.DataSource = sv.Getdata("SELECT  MaSV,HoTen,NgaySinh,GioiTinh,TenKhoa,Lop,TenChuTro,SDT,DiaChi,NgayDen,NgayDi,TenKhoa FROM SinhVien,Khoa");
            GridView1.DataBind();
        }
        public Sinhvien GetSinhvien()
        {
            int ngaysinh = int.Parse(drngaysinh.SelectedValue);
            int thangsinh = int.Parse(drthangsinh.SelectedValue);
            int namsinh = int.Parse(drnamsinh.SelectedValue);
            int ngayden = int.Parse(drngayden.SelectedValue);
            int thangden = int.Parse(drthangden.SelectedValue);
            int namden = int.Parse(drnamden.SelectedValue);
            int ngaydi = int.Parse(drngaydi.SelectedValue);
            int thangdi = int.Parse(drthangdi.SelectedValue);
            int namdi = int.Parse(drnamdi.SelectedValue);

            string masv = txtmasv.Text;
            string hoten = txthoten.Text;
            DateTime ngaythangnamsinh = new DateTime(namsinh,thangsinh,ngaysinh);
            bool gioitinh = bool.Parse(DropDownList3.SelectedValue);
            string quequan = txtquequan.Text;
            string lop = txtlop.Text;
            string tenchutro = txttenchutro.Text;
            string sdt = txtsdt.Text;
            string diachi = txtdiachi.Text;
            DateTime ngaydentro = new DateTime(namden,thangden,ngayden);
            DateTime ngayditro = new DateTime(namdi,thangdi,ngaydi);
            string makhoa = drkhoa.SelectedValue.ToString();
            Sinhvien sv = new Sinhvien(masv,hoten,ngaythangnamsinh,gioitinh,quequan,tenchutro,sdt,diachi,ngaydentro,ngayditro,lop,makhoa);

            return sv;
        }
        protected void txtsave_Click(object sender, EventArgs e)
        {
            //string masv = txtmasv.Text;
            //string hoten = txthoten.Text;
            //string ngaysinh = txtngaysinh.Text;
            //bool gioitinh = bool.Parse(DropDownList3.SelectedValue);
            //string quequan = txtquequan.Text;
            //string lop = txtmalop.Text;
            //string tenchutro = txttenchutro.Text;
            //string sdt = txtsdt.Text;
            //string diachi = txtdiachi.Text;
            //string ngayden = txtngayden.Text;
            //string ngaydi = txtngaydi.Text;
            //Sinhvien sv = new Sinhvien(masv, hoten, ngaysinh, gioitinh, quequan, tenchutro, sdt, diachi, ngayden, ngaydi, lop);
            SinhVienDAO svdao = new SinhVienDAO();
            if (svdao.CheckUser(txtmasv.Text))
            {
                lbthongbao.Text = "Tai Khoan Ton Tai";
            }
            else
            {
                svdao.Insert(GetSinhvien());
                lbthongbao.Text = "Luu Thanh Cong";
                LoadGridview();
            }
        }

        protected void delete_Click(object sender, EventArgs e)
        {
            string username = txtmasv.Text;
            SinhVienDAO svdao = new SinhVienDAO();
            if (svdao.Delete(username))
            {
                lbthongbao.Text = "Xóa Thành Công";
                LoadGridview();
            }
            else
            {
                lbthongbao.Text = "Có Lỗi Xảy Ra";
            }


        }

        protected void update_Click(object sender, EventArgs e)
        {
            SinhVienDAO svdao = new SinhVienDAO();
            if (svdao.Update(txtmasv.Text, GetSinhvien()))
            {
                lbthongbao.Text = "Cập Nhật Thành Công";
                LoadGridview();
            }
            else
            {
                lbthongbao.Text = "Có Lỗi Xảy Ra";
            }

        }

        protected void find_Click(object sender, EventArgs e)
        {
            SinhVienDAO svdao = new SinhVienDAO();
            if (!svdao.CheckUser(txttim.Text.Trim()))
            {
                lbthongbao.Text = "Không tìm thấy";
            }
            else
            {
                 GridView1.DataSource= svdao.Getdata("SELECT  MaSV,HoTen,NgaySinh,GioiTinh,TenKhoa,Lop,TenChuTro,SDT,DiaChi,NgayDen,NgayDi,TenKhoa FROM SinhVien,Khoa WHERE MaSV='"+txttim.Text+"' ");
                 GridView1.DataBind();
                lbthongbao.Text = "";
            }
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            string masv = GridView1.Rows[e.RowIndex].Cells[0].Text;
            SinhVienDAO svdao = new SinhVienDAO();
            if (svdao.Delete(masv))
            {
                lbthongbao.Text = "Xóa Thành Công";
                LoadGridview();
            }
            else
            {
                lbthongbao.Text = "Có Lỗi Xảy Ra";
            }
            LoadGridview();

        }
    }
}