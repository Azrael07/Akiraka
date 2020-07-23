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
    public partial class UploadArticle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            TextBox22.Text = DateTime.Now.ToShortDateString();
            TextBox22.Enabled = false;
        }
       

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new
               SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
            try
            {
                con.Open();

                string file_name = contact_picture.FileName.ToString() + "";
                contact_picture.PostedFile.SaveAs(Server.MapPath("~/upload/") + file_name);

                string query = "INSERT INTO Article (Title, Date, Article, contact_picture, webpage) values(@Title ,@Date,@Article, '"+file_name+"', @webpage)";

                SqlCommand cmd = new SqlCommand(query, con);
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

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
               
            }
        }
    }
}