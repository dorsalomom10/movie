using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class MasterPage : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["page"] == "login")
        {
            top_nav_content.InnerHtml = "<ul><li>";
            top_nav_content.InnerHtml += "<a href=''> דף כניסה </a>";
            top_nav_content.InnerHtml += "</li></ul>";
        }

        else if (Session["u_name"] != null)
        {
            string u_n_login = " שלום ";
            if(Session["u_name"].ToString() == "admin")
            {
                u_n_login += "בוס";
                spr.InnerText = "|";
                admin.InnerText = "דף ניהול";
            }
            else
            {
                u_n_login += Session["u_name"].ToString();
            }

            u_n_login += " מה שלומך ? ";
            u_name.InnerText = u_n_login;
            logout.InnerText = " התנתק";
            v_counter.InnerText = "  מספר כניסות לאתר: " + Application["counter"].ToString();
        }


        
    }
         
}
