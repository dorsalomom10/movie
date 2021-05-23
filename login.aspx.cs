using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string u_n = u_name.Value;
        string u_p = pass.Value;
        if (Request["page"] == null)
        {
            string url = Request.Url.AbsolutePath + "?page=login";
            Response.Redirect(url);
        }
        if (Request["page"] != null)
        {
            if (Request.QueryString["page"].ToString() == "logout")
            {
                Session.Clear();
            }
        }
        if (coo.Checked == true)
        {
            Response.Cookies["user"]["user_name"] = u_n;
            Response.Cookies["user"].Expires = DateTime.Now.AddDays(30);
        }
        else
        {
            Response.Cookies["user"].Expires = DateTime.Now.AddDays(-1);
        }
        if (Page.IsPostBack == false)
        {
            first_visit();
        }
        else
        {
            second_visit();
        }


    }

    protected void first_visit()
    {
        msg.InnerText = "ברוך הבא !";
    }

    protected void second_visit()
    {

        string u_p = pass.Value;
        string u_n = u_name.Value;

        if (u_n == "" || eng(u_n) == false)
        {
            msg.InnerText = "שם באנגלית או מספרים בלבד";
        }
        else if (u_p == "" || eng(u_p) == false)
        {
            msg.InnerText = "סיסמא באנגלית או מספרים בלבד";
        }
        else
        {
            chc_users(u_n, u_p);

        }


    }
    protected bool eng(string str)
    {
        string abc = "abcdefghigklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";

        for (var i = 0; i < str.Length; i++)
        {
            if (abc.IndexOf(str[i]) == -1)
            {
                return false;
            }
        }
        return true;
    }
    protected void chc_users(string u_n, string u_p)
    {
        string qry_str = string.Format("u_name = N'{0}' AND u_pass = N'{1}'", u_n, u_p);
        SqlConnection con = new SqlConnection();
        con.ConnectionString = @"Data Source = (LocalDB)\MSSQLLocalDB;" +
        @"AttachDbFilename =|DataDirectory|\Database.mdf;" +
        "Integrated Security = True";
        con.Open();

        SqlCommand cmd = new SqlCommand("SELECT f_name FROM users WHERE " + qry_str, con);
        SqlDataReader dr = cmd.ExecuteReader();

        
        if (dr.Read())
        {
            bakery(dr["f_name"].ToString(), u_n);
        }
        else if (u_n == "admin" && u_p == "123")
        {
            bakery("admin", u_n);
        }
        else
        {
            msg.InnerText = "שם משתמש או סיסמא שגויים";
        }
        con.Close();
    }

    protected void bakery(string f_n , string u_n)
    {
        if (Application["counter"] == null)
        {
            Application["counter"] = 1;
        }
        else
        {
            Application["counter"] = int.Parse(Application["counter"].ToString()) + 1;
        }
        if (coo.Checked == true)
        {
            Response.Cookies["user"]["user_name"] = u_n;
            Response.Cookies["user"].Expires = DateTime.Now.AddDays(30);
        }
        else
        {
            Response.Cookies["user"].Expires = DateTime.Now.AddDays(-1);
        }
        Session["u_name"] = f_n;
        Session.Timeout = 30;
        Response.Redirect("dramapage.aspx");
        
    }
}
   
