using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication5
{
    public partial class HomeCustomer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!this.IsPostBack)
            {
                if (Session["user_name"] != null)
                {
                    LoginNotify.Text = Session["user_name"].ToString();
                    LoginNotify.Visible = true;
                    LinkButton1.Visible = true;
                    ImageButton1.Visible = false;
                    ImageButton2.Visible = true;
                    
                }

                //Populating a Database from Database.
                DataTable dt = this.GetData();
                //Building an HTML string.
                StringBuilder html = new StringBuilder();




                //Building the data rows.
                foreach (DataRow row in dt.Rows)
                {
                    //html.Append("<a href=\"DisplayIndividualArticle.aspx?id=" + row["Id"] + "\">");
                    html.Append("<div class=\"box\" onClick=\"window.location.href='DisplayIndividualArticle.aspx?id=" + row["Id"] + "'\">");


                    /////////////////////////////////////////////////////////////////////////

                    html.Append("<div class=\"pic\">");
                    foreach (DataColumn column in dt.Columns)
                    {
               

                        if (column.ColumnName.Equals("contact_picture"))
                        {
                            html.Append("<img src=\"upload/");
                            html.Append(row["contact_picture"]);
                            html.Append("\" width=\"100px\">");

                        }
                        
                    }
                    html.Append("</div>");

                    html.Append("<h3>" + row["Title"] + "</h3>");
                    html.Append("<a href=\"DisplayIndividualArticle.aspx?id=" + row["Id"] + "\"></a>" + "<br>");
                    html.Append("Date:<br>" + row["Date"] + "<br>");
                 




                    /////////////////////////////////////////////////////////////////////////


                    /*  foreach (DataColumn column in dt.Columns)
                      {
                          html.Append("<td>");

                          if (column.ColumnName.Equals("contact_picture"))
                          {
                              html.Append("<img src=\"upload/");
                              html.Append(row["contact_picture"]);
                              html.Append("\" width=\"200px\">");
                          }
                          else
                          {
                              html.Append(row[column.ColumnName]);
                          }
                          html.Append("<td>");
                      }
                      */

                    /////////////////////////////////////////////////////////////////////////





                    //if (Session["user_name"] == null)
                    // {
                    //   Response.Redirect("login.aspx");
                    // }
                    // else {


                    html.Append("</div>");
                    // }
                }
                //Append the HTML to Placeholder.
                PlaceHolder1.Controls.Add(new Literal { Text = html.ToString() });

            }

        }

        private DataTable GetData()
        {
            string constr = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM Article"))
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

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {

        }

        protected void ImageButton1_Click1(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("logincust.aspx");
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("HomeCustomer.aspx");
        }

        protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("displayprofile.aspx");
        }

       
    }
}