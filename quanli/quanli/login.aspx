<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="quanli.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="Content/bootstrap.min.css" type="text/css" rel="stylesheet" />
    <title>Login</title>
    <style>
        .form-login{
            width:400px;
            height:400px;
            margin:0 auto;
            margin-top:150px;
            padding:70px;
        }

    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div class="container" >
        
            
        
        <div class="row">
              
            <div class="form-login">

                   <h1>Đăng Nhập</h1>
                        <div class="form-inline">
                            <asp:TextBox ID="txtusername" runat="server" type="text" placeholder="Tên Đăng Nhập" class="form-control"></asp:TextBox>
                   
                        </div>
                        <div class="form-inline" style="margin-top:5px">
                            
                            <asp:TextBox ID="txtpassword" runat="server" type="password" placeholder="Nhập Mật Khẩu" class="form-control" style="margin-bottom:5px;"></asp:TextBox>
                   
                        </div>
                            <asp:Label ID="lbthongbao" runat="server" Text="" style="display:block;color:red" ></asp:Label>
                            <asp:Button ID="btnlogin" runat="server" Text="Login" CssClass=" btn btn-success" OnClick="btnlogin_Click" />
                    </div> 
                </div>
           
      </div>   
    </form>
</body>
</html>
