using SDA.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SDA
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

       
        protected void Btn1_Click(object sender, EventArgs e)
        {
            Staff staff = new Staff();

            String stat = staff.Login(txt_Username.Text, txt_password.Text);

            if (stat == "Correct")
            {
                Session.Remove("Staff");
                Session["Staff"] = staff;
                Response.Redirect("homepage.aspx");
            }

            else
            {
                Label1.Text = stat;
            }
        }
    }
}