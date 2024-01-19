<%@ Page Title="" Language="C#" MasterPageFile="~/MainMaster.master" AutoEventWireup="true" CodeFile="Registration.aspx.cs" Inherits="Registration" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">

 <link rel="stylesheet" href="css/team.css"> 
    <script type="text/javascript">

        function isNumber(evt) {
            evt = (evt) ? evt : window.event;
            var charCode = (evt.which) ? evt.which : evt.keyCode;
            if (charCode > 31 && (charCode < 48 || charCode > 57)) {
                return false;
            }
            return true;
        }


    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

 		 <div class="overlay-contact-h"></div>
    <section id="contact-h" class="bg-parallax contact-h-bg">
      <div class="container">
        <div class="row">
          <div class="col-md-12">
            <div class="contact-h-cont">
              <h3 class="cl-white">Continue The Conversation</h3><br>
              <div class="row">
                <div class="form-group cl-white col-lg-6">
                  <label for="name">First Name</label>
                  <asp:TextBox ID="txtfname" runat="server" CssClass="form-control" MaxLength="100" placeholder="Enter First Name"></asp:TextBox>
                </div>  
                <div class="form-group cl-white col-lg-6">
                  <label for="exampleInputEmail1">Last Name</label>
                  <asp:TextBox ID="txtlname" runat="server" CssClass="form-control" MaxLength="50" placeholder="Enter Last Name"></asp:TextBox>
                </div>  
                <div class="form-group cl-white col-lg-6">
                  <label for="subject">Gender</label>
                  <asp:DropDownList ID="ddlgender" runat="server" CssClass="form-control">
                      <asp:ListItem>-- Select Gender --</asp:ListItem>
                      <asp:ListItem Value="M">Male</asp:ListItem>
                      <asp:ListItem Value="F">Female</asp:ListItem>
                    </asp:DropDownList>
                  
                </div>  
                <div class="form-group cl-white col-lg-6">
                  <label for="subject">DOB</label>
                  <asp:TextBox ID="txtdob" runat="server" CssClass="form-control" placeholder="DOB" 
                        ReadOnly="True"></asp:TextBox> 
                </div>
                
                
                <div class="form-group cl-white col-lg-6">
                  <label for="name">Email Id</label>
                  <asp:TextBox ID="txtmail" runat="server" CssClass="form-control" 
                        placeholder="EnterEmai Id" MaxLength="150" ></asp:TextBox>
                            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" 
                        runat="server" ErrorMessage="Enter Valid Email" ControlToValidate="txtmail" 
                        ForeColor="#990000" SetFocusOnError="True" ValidationGroup="s" 
                        ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">*</asp:RegularExpressionValidator>
                </div>  
                <div class="form-group cl-white col-lg-6">
                  <label for="exampleInputEmail1">Mobile Number</label>
                  <asp:TextBox ID="txtmno" runat="server" CssClass="form-control" onkeypress="return isNumber(event)" onpaste="return false;"    
                        placeholder="Enter Mobile No" MaxLength="10"></asp:TextBox>
                </div>  

                 <div class="form-group cl-white col-lg-6">
                  <label for="subject">Branch</label>
                  <asp:DropDownList ID="ddlbranch" runat="server" CssClass="form-control">
                      <asp:ListItem>-- Select Branch --</asp:ListItem>
                    </asp:DropDownList>
                  
                </div>  

                 <div class="form-group cl-white col-lg-6">
                  <label for="subject">Position Applied for</label>
                  <asp:DropDownList ID="ddlposition" runat="server" CssClass="form-control">
                      <asp:ListItem>-- Select  --</asp:ListItem>
                    </asp:DropDownList>
                  
                </div>  
                 <div class="form-group cl-white col-lg-6">
                <label for="name">Highest Qualification</label>
                  <asp:TextBox ID="txthqli" runat="server" CssClass="form-control" MaxLength="100" placeholder="Enter Highest Qualification"></asp:TextBox>
                </div>  

                <div class="form-group cl-white col-lg-6">
                  <label for="exampleInputEmail1">Address</label>
                  <asp:TextBox ID="txtadd" runat="server" CssClass="form-control" MaxLength="200" placeholder="Enter Address"></asp:TextBox>
                </div> 
                
                 <div class="form-group cl-white col-lg-6">
                  <label for="fileupload">Upload Resume</label>
                 <asp:FileUpload ID="FileUpload1" runat="server" ToolTip="Select Only PDF File"  ></asp:FileUpload>
                     <asp:Label ID="Label1" runat="server" ForeColor="Red" Text="[.PDF] Only"></asp:Label>
                    
                     </div> 
                
                
                
                
                
                
                 <asp:Label ID="lblMsg" runat="server" Font-Bold="True" 
                      ForeColor="White"></asp:Label>
                <asp:ValidationSummary ID="ValidationSummary1" runat="server" ValidationGroup="s" 
                      ShowMessageBox="True" ShowSummary="False"></asp:ValidationSummary>
                   <asp:LinkButton ID="lnkbtnsubmit" CssClass="btn btn-general btn-white"  ValidationGroup="s"
                      runat="server"  >Submit <i class="fa fa-arrow-right" aria-hidden="true"></i></asp:LinkButton> 
                
              </div>
            </div>
          </div>
        </div>
             
    </section> 



</asp:Content>

