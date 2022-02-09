using SDA.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SDA
{
    public partial class add_medicine : System.Web.UI.Page
    {
        public static int l; 
        protected void Page_Load(object sender, EventArgs e)
        {
            Staff staff = (Staff)Session["Staff"];
            Label2.Text = staff.Name + " is allowed to add because he/she " + staff.works(); 

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Staff staff = (Staff)Session["Staff"];
            int id;

            if (Session["ID"] != null){
                id = (int)Session["ID"];
            } else{
                id = 0;
            }





            String stat = staff.addMedicine(name.Text, Double.Parse(price.Text), int.Parse(quantity.Text),
            description.Text, int.Parse(lol.Text));
            
            id++;

            Session.Remove("ID");
            Session["ID"] = id;
            

            Label1.Text = stat;

            name.Text = null;
            price.Text = null;
            quantity.Text = null;
            description.Text = null; 

        }
    }
}