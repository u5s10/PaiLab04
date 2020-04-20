using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LoginApp
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["Logged"] != null)
            {
                Response.Redirect("Logged");
            }
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            var username = txtLogin.Text.ToString();
            var password = txtPassword.Text.ToString();
            using (var dbContext = new TestDatabaseEntities())
            {
                var test = dbContext.tblUser.Where(x => x.login == username && x.password == password);
                var testList = test.ToList();
                if(testList.Count == 0)
                {
                    lblError.Text = "Incorrect login or password";
                }
                else
                {
                    Session["Logged"] = true;
                    Response.Redirect("Logged");
                }
                
            }
        }
    }
}