using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace quanli
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnlogin_Click(object sender, EventArgs e)
        {
            
                string username = txtusername.Text.Trim();
                string password = txtpassword.Text.Trim();
                string con = ConfigurationManager.ConnectionStrings["DB"].ConnectionString;
                SqlConnection cn = new SqlConnection(con);
                cn.Open();
                string sql = "SELECT * FROM Login WHERE UserName='" + username + "' AND PassWord='" + password + "'";
                SqlCommand cmd = new SqlCommand(sql, cn);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read() == true)
                {
                Response.Redirect("quanli.aspx");
                Session["admin"]="admin";
                }
                else
                {
                    lbthongbao.Text = "Sai Thông Tin Đăng Nhập";
                }
            
        }
    }
}