using SDA.BLL;
using SDA.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SDA
{
    public partial class homepage : System.Web.UI.Page
    {
        static double total;
        static int last = 0;
       

            DataTable dt = new DataTable();
            DataRow dr;


        protected void Page_Load(object sender, EventArgs e)
        {
            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("Price", typeof(double));
            dt.Columns.Add("Quantity", typeof(int));
            dt.Columns.Add("Description", typeof(string));

            Staff staff = (Staff)Session["Staff"];
            staff.works();
            Observer observer = new Observer();
            List<Stock> notes = observer.notify();
            String names=""; 
            if(notes != null)
            {
                Label3.Text = "be careful " + staff.Name + "you have 1 item left of the following medicines";
                for (int i = 0; i < notes.Count; i++)
                    names += notes[i].name+ " ";

                Label4.Text = names;

            }
            else
            {
                Label3.Text = "";
                Label4.Text = "";
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Staff staff = (Staff)Session["Staff"];
            List<Stock> stock;
            if (Session["stock"] != null)
            {
                stock = (List<Stock>)Session["stock"];
            }
               


            else
            stock = new List<Stock>();
            stock.Add(staff.sellmedicine(nameid.Text));




            if(stock.Count !=0)
            if (stock[last] != null)
            {
                if (Session["dtInSession"] != null)
                {
                    dt = (DataTable)Session["dtInSession"];
                    Session.Remove("dtInSession");
                }

                dr = dt.NewRow();
                dr["Name"] = stock[last].name;
                dr["Price"] = stock[last].price;
                dr["Quantity"] = stock[last].quantity;
                dr["Description"] = stock[last].description;  
               
                total +=stock[last].price;
                
              
                
                dt.Rows.Add(dr);
                Session["dtInSession"] = dt;
                Session["stock"] = stock;
                GridView2.DataSource = dt;
                GridView2.DataBind();


             Label1.Text = "Total: " + total +"$";
                last=last+1;
                    Button2.Visible = true;
            }


            else
            {
                nameid.Text = "";
                Label1.Text = "Item not available"; 
            }

            nameid.Text = "";
           
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            List<Stock> stock = (List<Stock>)Session["stock"];
            StockDAL s = new StockDAL();
            Session.Remove("dtInSession");
            total = 0;
            Label1.Text = "";
            GridView2.DataSource=null;
            GridView2.DataBind();
            String stat = "";
            for (int i = last-1; i >= 0; i--)
            {
                  stat =  s.Delete(stock[i]);
            }



            last = 0;
            Label2.Text = stat;
            Response.Redirect("homepage.aspx"); 

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Session.Remove("dtInSession");
            Session.Remove("stock");
            total = 0;
            last = 0;
            Label1.Text = "";
            GridView2.DataSource=null;
            GridView2.DataBind();
            Response.Redirect("homepage.aspx");



        }
    }
}