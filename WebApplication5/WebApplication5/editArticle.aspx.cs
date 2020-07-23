using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication5
{
    public partial class editArticle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                String Article_id = Request.QueryString["Id"];
                int intTest = Convert.ToInt32(Article_id);

                String constr = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
                using (SqlConnection con = new SqlConnection(constr))
                {
                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM Article WHERE Id=" + intTest))
                    {
                        using (SqlDataAdapter sda = new SqlDataAdapter())
                        {
                            cmd.Connection = con;
                            sda.SelectCommand = cmd;
                            using (DataTable dt = new DataTable())
                            {
                                sda.Fill(dt);
                                foreach (DataRow row in dt.Rows)
                                {
                                    string articleid = row["Id"].ToString();
                                    string Title = row["Title"].ToString();
                                    string Date = row["Date"].ToString();
                                    string Article = row["Article"].ToString();
                                    string contact_picture = row["contact_picture"].ToString();
                                    string webpage = row["webpage"].ToString();

                                    this.HiddenField1.Value = articleid;
                                    this.TextBox11.Text = Title;
                                    this.TextBox22.Text = Date;
                                    this.TextBox33.Text = Article;
                                    this.DropDownList1.Text = webpage;






                                }
                            }
                        }
                    }

                }
                    }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
            try
            {
                SqlConnection con = new
               SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
                con.Open();

                string file_name = contact_picture.FileName.ToString() + "";
                contact_picture.PostedFile.SaveAs(Server.MapPath("~/upload/") + file_name);

                string query = "UPDATE Article SET Title=@Title, Date=@Date, Article=@Article, webpage=@webpage WHERE Id=@Id";
                

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Id", HiddenField1.Value);
                cmd.Parameters.AddWithValue("@Title", TextBox11.Text);
                cmd.Parameters.AddWithValue("@Date", TextBox22.Text);
                cmd.Parameters.AddWithValue("@Article", TextBox33.Text);
                
                cmd.Parameters.AddWithValue("@webpage", DropDownList1.Text);

                cmd.ExecuteNonQuery();
                Response.Redirect("WebForm3.aspx");

                con.Close();
            }
            catch (Exception ex)
            {
                Response.Write("Error: " + ex.ToString());
            }


        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            try
            {
                SqlConnection con = new
               SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);

                String query = "DELETE FROM Article WHERE Id = @Id";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Id", HiddenField1.Value);

                con.Open();
                cmd.ExecuteNonQuery();

                Response.Redirect("editArticle.aspx");
                con.Close();

            }
            catch(Exception ex)
            {
                Response.Write("Error:" + ex.ToString());
            }
        }
    }
}