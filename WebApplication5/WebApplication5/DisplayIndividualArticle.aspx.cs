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
    public partial class DisplayIndividualArticle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)


        {
            if (Session["user_name"] != null)
            {
                TextBox2.Text = Session["user_name"].ToString();
                TextBox2.Enabled = false;
            }

            //Building an HTML string.
            StringBuilder html = new StringBuilder();



            String Id = Request.QueryString["Id"];
            int intTest = Convert.ToInt32(Id);

            string constr = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;

            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand(" SELECT * FROM Article WHERE ID =" + intTest))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter())
                    {
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;
                        if (!this.IsPostBack)
                        {
                            using (DataTable dt = new DataTable())
                        {
                            sda.Fill(dt);


                            
                                foreach (DataRow row in dt.Rows)
                                {
                                    

                                   this.HiddenField2.Value = row["ID"].ToString();
                                   

                                    html.Append("<div class=\"box\">");

                                    //foreach (DataColumn column in dt.Columns)
                                    //{


                                    //    if (column.ColumnName.Equals("contact_picture"))
                                    //    {
                                    //        html.Append("<img src=\"upload/");
                                    //        html.Append(row["contact_picture"]);
                                    //        html.Append("\" width=\"400px\">");

                                    //    }

                                    //}


                                    html.Append("<h3>" + row["Title"] + "</h3>");
                                    html.Append("<br>" + row["Article"] + "<br><br>");
                                    html.Append("Date:<br>" + row["Date"] + "<br><br>");
                                    html.Append("</div>");

                                }
                                PlaceHolder1.Controls.Add(new Literal { Text = html.ToString() });

                            }
                        }
                    }
                }



            }




            //if (Session["user_name"] != null)
            //{
            //    TextBox2.Text = Session["user_name"].ToString();
            //    TextBox2.Enabled = false;
            //}

            /////COMMENT
            //Building an HTML string.
            StringBuilder htmlcomment = new StringBuilder();

            String Idc = Request.QueryString["Id"];
            int intTestcomment = Convert.ToInt32(Id);
            

            string constrcomment = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;

            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand(" SELECT * FROM commenttable WHERE Article_ID =" + intTest))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter())
                    {
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;
                        if (!this.IsPostBack)
                        {
                            using (DataTable dt = new DataTable())
                            {
                                sda.Fill(dt);


                                foreach (DataRow row in dt.Rows)
                                {
                                    htmlcomment.Append("<div class=\"commentbox\">");

                                    htmlcomment.Append("<h3>" + row["user_name"] + "</h3>");
                                    htmlcomment.Append("<br>" + row["comment"] + "<br>");
                                    htmlcomment.Append("<br>" + row["gdate"] + "");
                                    htmlcomment.Append("<br>" + row["gtime"] + "");
                                    htmlcomment.Append("</div>");

                                }
                                PlaceHolder2.Controls.Add(new Literal { Text = htmlcomment.ToString() });
                            }
                        }
                    }
                }

            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            Label1.Text = DateTime.Now.ToShortDateString();
            Label1.Enabled = false;
            Label2.Text = DateTime.Now.ToShortTimeString();
            Label2.Enabled = false;


            SqlConnection con = new
               SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
            try
            {
                con.Open();

                string query = "INSERT INTO commenttable (user_name, comment, Article_ID, gdate, gtime) values(@user_name, @comment, @Article_ID, @gdate, @gtime)";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@user_name", TextBox2.Text);
                cmd.Parameters.AddWithValue("@comment", TextBox1.Text);
                cmd.Parameters.AddWithValue("@Article_ID", HiddenField2.Value);
                cmd.Parameters.AddWithValue("@gdate", Label1.Text);
                cmd.Parameters.AddWithValue("@gtime", Label2.Text);


                cmd.ExecuteNonQuery();
                //Response.Redirect("DisplayIndividualArticle.aspx");

                con.Close();
            }
            catch (Exception ex)
            {
                Response.Write("Error: " + ex.ToString());
            }
            Response.Redirect("HomeCustomer.aspx");
        }
    }
}