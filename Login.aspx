<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
   
    <link href="css/login.css" rel="stylesheet" type="text/css" />
    <link href="css/bootstrap.min.css" rel="stylesheet" type="text/css" />
    <link href="font-awesome-4.7.0/css/font-awesome.min.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    

     <section class="hero-area">
        <div class="overlay"></div>
        <div class="container">
          <div class="row">
            <div class="col-md-12 ">
                <div class="contact-h-cont">
                  <h3 class="text-center"><img src="img/logo-s.png" class="img-fluid" alt=""></h3><br>
                  <form>
                   <div class="form-group">
                       
                     
                       <asp:Label ID="lblMsg" runat="server" Text="" Font-Bold="true" ForeColor="Red" ></asp:Label>
                    </div>  

                    <div class="form-group">
                      <label for="username">Username</label>
             
                      <asp:TextBox ID="txtUserName" runat="server" class="form-control" placeholder="Enter Username" required ></asp:TextBox>
                    </div>  
                    <div class="form-group">
                      <label for="exampleInputEmail1">Password</label>
                     
                      <asp:TextBox ID="txtpwd" runat="server" TextMode="Password" class="form-control"  placeholder="Enter Password" required ></asp:TextBox>
                    </div>   
                  
                    <asp:Button ID="BtnLogin" CssClass="btn btn-blue" runat="server" Text="Login" 
                       onclick="BtnLogin_Click"></asp:Button>
                  </form>
                </div>
            </div>
          </div>  
        </div>
      </section>



    </form>
</body>
</html>
