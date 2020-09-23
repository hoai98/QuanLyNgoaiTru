<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="quanli.aspx.cs" Inherits="quanli.quanli" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" type="text/css" href="Content/bootstrap.min.css" />
    <style type="text/css">
       
       .dropdown{
           margin-top:35px;
           height:20px;
       }
        .main{
			width: 100%;
			height: 435px;
		}
		.left{
			width: 50%;
			margin-left: 5%;
			float: left;
		}
		.right{
			padding-left: 5%;
			float: left;
			width: 30%;
		}
		.control{
			width: 100%;
		}
		.control button{
			width: 80px;
		}
		.header{
			height: 100px;
		}
		.marginbot{
			margin-bottom:10px;
		}
        .margintop{
            margin-top:10px;
        }
       
       
    </style>
</head>
<body>
    <form id="form1" runat="server" >
        <div class="header"> 
            <h1 style="margin-left:27%;font-size:50px;">Quản Lí Thông Tin Sinh Viên Ở Trọ</h1>
        </div>
       <div class="main">
	<div class="left">
		<div class="row">
			<div class="col-md-6">
				<div class="form-group">
			    	  <asp:Label ID="Label1" runat="server" Text="Mã SV:"></asp:Label>
			    	  <asp:TextBox ID="txtmasv" runat="server"  class="form-control"></asp:TextBox>

			  		</div>
				</div>
			<div class="col-md-6">
				<div class="form-group">
    					<asp:Label ID="Label2" runat="server" Text="Họ Tên :"></asp:Label>
                   
                        <asp:TextBox ID="txthoten" class="form-control" runat="server" ></asp:TextBox>
  					</div>	
			</div>

		</div>
		<div class="row">
			<div class="col-md-6">
				<div class="form-group">
			    	 <asp:Label ID="Label3" runat="server" Text="Ngày Tháng Năm Sinh:"></asp:Label>
                    <asp:DropDownList ID="drngaysinh" runat="server"></asp:DropDownList>
                    <asp:DropDownList ID="drthangsinh" runat="server"></asp:DropDownList>
                    <asp:DropDownList ID="drnamsinh" runat="server"></asp:DropDownList>
			  		</div>
				</div>
			<div class="col-md-6">
				<div class="form-group">
    			 <asp:Label ID="Label4" runat="server" Text="Giới tính:"></asp:Label>
                   
                        <asp:DropDownList class="dropdown" ID="DropDownList3" runat="server"   >
                            <asp:ListItem Value="True">Nam</asp:ListItem>
                            <asp:ListItem Value="False">Nữ</asp:ListItem>
                        </asp:DropDownList>
  					</div>	
			</div>

		</div>
		<div class="row">
			<div class="col-md-6">
				<div class="form-group">
			    	 <asp:Label ID="Label5" runat="server" Text="Quê Quán:"></asp:Label>
                   
                        <asp:TextBox ID="txtquequan"  class="form-control" runat="server"></asp:TextBox>
			  		</div>
				</div>
			<div class="col-md-6">
				<div class="form-group">
    				<asp:Label ID="Label6" runat="server" Text="Khoa:"></asp:Label>
                  
                        <asp:DropDownList class="dropdown" ID="drkhoa" runat="server">
                        </asp:DropDownList>
  					</div>	
			</div>

		</div>
		<div class="row">
			<div class="col-md-6">
				<div class="form-group">
			    	   <asp:Label ID="Label7" runat="server" Text="Lớp:"></asp:Label>
                    
                        <asp:TextBox ID="txtlop"  class="form-control" runat="server" ></asp:TextBox>
			  		</div>
				</div>
			<div class="col-md-6">
				<div class="form-group">
    				<asp:Label ID="Label8" runat="server" Text="Tên chủ trọ:"></asp:Label>
                  
                        <asp:TextBox ID="txttenchutro" runat="server"  class="form-control "></asp:TextBox>
  					</div>	
			</div>

		</div>

		<div class="row">
			<div class="col-md-6">
				<div class="form-group">
			    	<asp:Label ID="Label9" runat="server" Text="Số điện thoại:"></asp:Label>
                    
                        <asp:TextBox ID="txtsdt" class="form-control" runat="server"></asp:TextBox>
                  
			  		</div>
				</div>
			<div class="col-md-6">
				<div class="form-group">
    				 <asp:Label ID="Label10" runat="server" Text="Địa chỉ:"></asp:Label>
                   
                        <asp:TextBox ID="txtdiachi" class="form-control" runat="server"></asp:TextBox>
                    
  					</div>	
			</div>

		</div>

		<div class="row">
			<div class="col-md-6">
				<div class="form-group">
			    	 <asp:Label ID="Label11" runat="server" Text="Ngày đến:"></asp:Label>
                   
                    <asp:DropDownList ID="drngayden" runat="server"></asp:DropDownList>
                    <asp:DropDownList ID="drthangden" runat="server"></asp:DropDownList>
                    <asp:DropDownList ID="drnamden" runat="server"></asp:DropDownList>
			  		</div>
				</div>
			<div class="col-md-6">
				<div class="form-group">
    				 <asp:Label ID="Label12" runat="server" Text="Ngày đi:"></asp:Label>
                    <asp:DropDownList ID="drngaydi" runat="server"></asp:DropDownList>
                    <asp:DropDownList ID="drthangdi" runat="server"></asp:DropDownList>
                    <asp:DropDownList ID="drnamdi" runat="server"></asp:DropDownList>
                        
  					</div>	
			</div>

		</div>

	</div>

	<div class="right">
		
		<div class="row">
			<div class="col">
				<div class="form-group">
			    	 <asp:Label ID="Label13" runat="server" Text="Tìm kiếm MSV:"></asp:Label>
			    	 <asp:TextBox ID="txttim" runat="server"   class="form-control"></asp:TextBox>
			    	<asp:Button ID="find" runat="server" class="margintop btn btn-primary" Text="Tìm" Width="96px" OnClick="find_Click"  />
			  		</div>
                  <asp:Label ID="lbthongbao" runat="server" class=" alert-success "></asp:Label>
			</div>	

		</div>	

	</div>
</div>
<div class="control marginbot" >
		<div class="row">
			<div class="col-md-2">
			</div>	
			<div class="col-md-4">
			            <asp:Button ID="txtsave" runat="server" Text="Thêm" class="btn btn-primary" Width="75px" OnClick="txtsave_Click" />
                   
                        <asp:Button ID="Button1" runat="server" class="btn btn-danger"  Text="Xóa" Width="96px" OnClick="delete_Click" OnClientClick="return confirm(&quot;Bạn Có Muốn Xóa Tài Khoản Này Không?&quot;);" />
                    
                    
                        <asp:Button ID="Button2" runat="server" class="btn btn-primary" Text="Sửa" Width="94px" OnClick="update_Click" />
                   
                        <asp:Button ID="Button3" runat="server" class="btn btn-primary" Text="Đăng Xuất" Width="96px " />
			</div>
		</div>
	</div>
            
           
           
            
        
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" Height="116px" Width="100%" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" OnRowDeleting="GridView1_RowDeleting">
            <Columns>
                <asp:BoundField HeaderText="Mã SV" DataField="MaSV" />
                <asp:BoundField HeaderText="Tên SV" DataField="HoTen" />
                <asp:CheckBoxField HeaderText="Giới Tính" DataField="GioiTinh" />
                <asp:BoundField HeaderText="Ngày Sinh" DataField="NgaySinh" DataFormatString="{0:dd/MM/yyyy}" />
                <asp:BoundField HeaderText="Khoa" DataField="TenKhoa" />
                <asp:BoundField HeaderText="Lớp" DataField="Lop" />
                <asp:BoundField HeaderText="Tên Chủ Trọ" DataField="TenChuTro" />
                <asp:BoundField HeaderText="SĐT" DataField="SDT" />
                <asp:BoundField HeaderText="Địa Chỉ" DataField="DiaChi" />
                <asp:BoundField HeaderText="Ngày Đến " DataField="NgayDen" DataFormatString="{0:dd/MM/yyyy}" />
                <asp:BoundField HeaderText="Ngày Đi" DataField="NgayDi" DataFormatString="{0:dd/MM/yyyy}" />
                <asp:CommandField ShowDeleteButton="True" />
            </Columns>
            <FooterStyle BackColor="White" ForeColor="#000066" />
            <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
            <RowStyle ForeColor="#000066" />
            <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#007DBB" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#00547E" />
        </asp:GridView>
        </form>
   
</body>
</html>
