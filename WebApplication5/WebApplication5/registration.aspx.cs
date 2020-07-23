using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

namespace WebApplication5
{
    public partial class registration : System.Web.UI.Page
    {
        private object ex;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new
                SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
            try
            {
                con.Open();
                string query = "INSERT INTO users (full_name, user_name, user_password, user_email, user_phone, user_role, user_IDreg) values(@full_name ,@user_name,@user_password,@user_email, @user_phone, @user_role, @user_IDreg)";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@full_name", TextBox1.Text);
                cmd.Parameters.AddWithValue("@user_name", TextBox2.Text);
                cmd.Parameters.AddWithValue("@user_password", TextBox3.Text);
                cmd.Parameters.AddWithValue("@user_email", TextBox4.Text);
                cmd.Parameters.AddWithValue("@user_phone", TextBox5.Text);
                cmd.Parameters.AddWithValue("@user_role", TextBox6.Text);
                cmd.Parameters.AddWithValue("@user_IDreg", TextBox7.Text);

                cmd.ExecuteNonQuery();

                Response.Redirect("logincust.aspx");
                con.Close();
            }
            catch(Exception ex)
            {
                Response.Write("Error: " +ex.ToString());
            }

        }
    }
}