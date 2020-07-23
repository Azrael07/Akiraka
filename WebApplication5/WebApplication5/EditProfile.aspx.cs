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
    public partial class EditProfile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                String user_id = Request.QueryString["Id"];
                int intTest = Convert.ToInt32(user_id);
                string constr = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
                using (SqlConnection con = new SqlConnection(constr))
                {
                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM users where Id=" + intTest))
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
                                    string userid = row["Id"].ToString();
                                    string full_name = row["full_name"].ToString();
                                    string user_name = row["user_name"].ToString();
                                    string user_password = row["user_password"].ToString();
                                    string user_email = row["user_email"].ToString();

                                    this.HiddenField1.Value = userid;
                                    this.TextBox1.Text = full_name;
                                    this.TextBox2.Text = user_name;
                                    this.TextBox3.Text = user_password;
                                    this.TextBox4.Text = user_email;
                                    

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
                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);

                string query = "UPDATE users SET full_name=@full_name, user_name=@user_name, user_password=@user_password, user_email=@user_email WHERE Id=@userid";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@userid", HiddenField1.Value);
                cmd.Parameters.AddWithValue("@full_name", TextBox1.Text);
                cmd.Parameters.AddWithValue("@user_name", TextBox2.Text);
                cmd.Parameters.AddWithValue("@user_password", TextBox3.Text);
                cmd.Parameters.AddWithValue("@user_email", TextBox4.Text);

                con.Open();
                cmd.ExecuteNonQuery();

                Response.Redirect("displayprofile.aspx");
                con.Close();
            }
            catch(Exception ex)
            {
                Response.Write("Error: " + ex.ToString());
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);

                string query = "DELETE FROM users WHERE Id=@userid";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@userid", HiddenField1.Value);

                con.Open();
                cmd.ExecuteNonQuery();
                Response.Redirect("displayprofile.aspx");
                con.Close();
            }
            catch(Exception ex)
            {
                Response.Write("Error: " + ex.ToString());
            }
        }
    }
}