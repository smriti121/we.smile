using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Web.Security;

public partial class Login : System.Web.UI.Page
{
   // clsDataAccessMACET objcls = new clsDataAccessMACET();
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    //public void login()
    //{
    //    try
    //    {


    //        string ProcName = "UserAuthentication";
    //        string fieldName = "UserId,Password";
    //        object[] fieldValue = { txtUserName.Text.Trim().ToString(), txtpwd.Text.Trim() };
    //        DataTable dt = objcls.storeProcedure.getData(ProcName, fieldName, fieldValue);


    //        if (dt.Rows.Count > 0 && dt.Rows[0]["Password"] != null && dt.Rows[0]["Password"] != DBNull.Value)
    //        {
    //            string storedpassword = Convert.ToString(dt.Rows[0]["Password"]);
    //            // storedpassword = objEnc.Decrypt(storedpassword);
    //            // var username = txtuserid.Text.Trim();
    //            var password = txtpwd.Text.Trim();
    //            // var orignalpassword = ReturnHash(storedpassword.Trim(), Convert.ToString(h1.Value));
    //            //   orignalpassword = objEnc.Encrypt(orignalpassword);
    //            if (password != storedpassword)
    //            {
    //                lblMsg.Text = "User-ID or password is Invalid.";
    //                txtpwd.Focus();
    //                return;
    //            }


    //            //  Session.Clear();
    //            // ReGenerateSessionId();

    //            FormsAuthentication.Initialize();
    //            FormsAuthenticationTicket ticket = new FormsAuthenticationTicket(1, txtUserName.Text.Trim(), DateTime.Now, DateTime.Now.AddMinutes(30), false, dt.Rows[0]["Role"].ToString(), FormsAuthentication.FormsCookiePath);

    //            // Encrypt the cookie using the machine key for secure transport
    //            string hash = FormsAuthentication.Encrypt(ticket);
    //            HttpCookie cookie = new HttpCookie(FormsAuthentication.FormsCookieName, hash); // Hashed ticket

    //            cookie.HttpOnly = true;

    //            // Set the cookie's expiration time to the tickets expiration time
    //            if (ticket.IsPersistent) cookie.Expires = ticket.Expiration;

    //            // Add the cookie to the list for outgoing response
    //            Response.Cookies.Add(cookie);
    //            Session["RegId"] = dt.Rows[0]["RegNo"].ToString();
    //            Session["AppName"] = dt.Rows[0]["UserName"].ToString();
    //            Session["Userid"] = dt.Rows[0]["UserId"].ToString();

    //            // Session["ContacPerEmail"] = dt.Rows[0]["ContacPerEmail"].ToString();             
    //            //Session["NGOPANNO"] = dt.Rows[0]["NGOPANNO"].ToString();
    //            // Session["AadhaarNo"] = dt.Rows[0]["AadhaarNo"].ToString();
                 

    //           // Session["IsPaymentDone"] = dt.Rows[0]["IsPaymentDone"].ToString();

    //            Session["UserRole"] = dt.Rows[0]["Role"].ToString();
    //           // Session["TypePaper"] = dt.Rows[0]["TypePaper"].ToString();

    //            // Redirect to requested URL, or homepage if no previous page
    //            // requested
    //            string returnUrl = Request.QueryString["ReturnUrl"];
    //            switch (dt.Rows[0]["Role"].ToString().Trim())
    //            {

    //                case "ADM":

    //                    returnUrl = "Admin/Default.aspx";
    //                    Response.Redirect(returnUrl);
    //                    break;
    //                case "CND":                       
    //                            returnUrl = "Tutorials/Default.aspx";

    //                    Response.Redirect(returnUrl);
    //                    break;
    //                case "EMP":

    //                    returnUrl = "CBSE/Default.aspx";
    //                    Response.Redirect(returnUrl);
    //                    break;


    //            }
    //        }

    //        else
    //        {

    //            txtpwd.Text = "";
    //            txtUserName.Focus();
    //        }
    //    }
    //    catch
    //    {
    //    }


    //}
    protected void BtnLogin_Click(object sender, EventArgs e)
    {
        if (txtUserName.Text.Trim() == "")
        {
            lblMsg.Text = "Please Enter Userid as MobileNo";
            txtUserName.Focus();
            return;
        }
        if (txtpwd.Text.Trim() == "")
        {
            lblMsg.Text = "Please Enter Password";
            txtpwd.Focus();
            return;
        }


       // login();
    }
}