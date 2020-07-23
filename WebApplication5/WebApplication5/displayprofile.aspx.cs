using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Text;
using System.Configuration;
using System.Data.SqlClient;

namespace WebApplication5
{
    public partial class displayprofile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user_name"] == null)
            {
                Response.Redirect("HomeCustomer.aspx");
            }

            if (!this.IsPostBack)
            {
                DataTable dt = this.GetData();
                StringBuilder html = new StringBuilder();
                foreach (DataRow row in dt.Rows)
                {
                    html.Append("<div class=\"box1\">");
                    html.Append("<h3>"+ row["full_name"] + "</h3>");
                    html.Append("Username:" + row["user_name"] + "<br><br>");
                    html.Append("password:" + row["user_password"] + "<br><br>");
                    html.Append("Email Address" + row["user_email"] + "<br><br>");
                    html.Append("<a href=\"EditProfile.aspx?Id=" + row["id"] + "\">Edit Profile</a>");
                }
                PlaceHolder1.Controls.Add(new Literal { Text = html.ToString() });
            }



        }
        private DataTable GetData()
        {
            int userid = Convert.ToInt16(Session["user_id"]);
            string constr = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * from users WHERE Id="+userid+" AND user_name ='" + Session["user_name"].ToString() +"'")) 
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter())
                    {
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;
                        using (DataTable dt = new DataTable())
                        {
                            sda.Fill(dt);
                            return dt;
                        }
                    }
                }
            }
        }
    }
}