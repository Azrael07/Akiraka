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
    public partial class logincust : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string user_name = this.TextBox1.Text;
            string user_password = this.TextBox2.Text;

            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);

            con.Open();
            string query = "SELECT * FROM users where user_name='" + user_name + "' AND user_password='" + user_password + "'";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            int i = cmd.ExecuteNonQuery();

            

                if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    int userid = Convert.ToInt16(row["id"]);


                    this.Session["user_name"] = TextBox1.Text;
                    this.Session["user_id"] = userid.ToString();
                Response.Redirect("HomeCustomer.aspx");
                }
            }
            else
            {
                Label1.Text = "Your username and password is incorrect";
                Label1.ForeColor = System.Drawing.Color.Red;
            }
            con.Close();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("registration.aspx");
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("login.aspx");
        }
    }
}