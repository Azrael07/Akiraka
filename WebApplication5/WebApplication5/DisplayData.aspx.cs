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
    public partial class DisplayData : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                if (Session["user_name"] == null)
                {
                    Response.Redirect("Login.aspx");
                }
                else
                {

                    //Populating a Database from Database.
                    DataTable dt = this.GetData();
                    //Building an HTML string.
                    StringBuilder html = new StringBuilder();


                    //Building the data rows.
                    foreach (DataRow row in dt.Rows)
                    {
                        html.Append("<div class=\"box\">");

                        //to get data from the database and then connecting it to the variable. its string os thats why we use .toString(male/female)
                        string cgender = row["contact_gender"].ToString();

                        if (cgender == "Male")
                        {
                            html.Append("<img src =\"Images/male.png\" width=\"50px\">");
                        }
                        else
                        {
                            html.Append("<img src =\"Images/female.png\" width=\"50px\">");
                        }
                        DateTime dateandtime = (DateTime)row["contact_dob"];
                        var contact_dob = dateandtime.ToString("MM/dd/yyyy");

                        html.Append("<h3>" + row["contact_name"] + "</h3>");
                        html.Append("Phone Number:<br>" + row["contact_phone"] + "<br><br>");
                        html.Append("Email:<br>" + row["contact_email"] + "<br><br>");
                        html.Append("Home Address:<br>" + row["contact_address"] + "<br><br>");
                        html.Append("Relationship:<br>" + row["contact_relationship"] + "<br><br>");
                        html.Append("Gender:<br>" + row["contact_gender"] + "<br><br>");
                        html.Append("Date of Birth:<br>" + contact_dob + "<br><br>");
                        html.Append("<a href=\"Webform1.aspx?id=" + row["id"] + "\">Edit</a>");
                        html.Append("</div>");
                    }
                    //Append the HTML to Placeholder.
                    PlaceHolder1.Controls.Add(new Literal { Text = html.ToString() });
                }
            }


        }

        private DataTable GetData()
        {
            string constr = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM contacts"))
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

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("login.aspx");
        }
    }
}