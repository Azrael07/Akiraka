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
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                String contact_id = Request.QueryString["Id"];
                int intTest = Convert.ToInt32(contact_id);

                string constr = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;

                using (SqlConnection con = new SqlConnection(constr))
                {
                    using (SqlCommand cmd = new SqlCommand("Select * FROM contacts WHERE Id=" + intTest))
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
                                    String contactid = row["Id"].ToString();
                                    String contact_name = row["contact_name"].ToString();
                                    String contact_phone = row["contact_phone"].ToString();
                                    String contact_email = row["contact_email"].ToString();
                                    String contact_address = row["contact_address"].ToString();
                                    String contact_gender = row["contact_gender"].ToString();
                                    String contact_relationship = row["contact_relationship"].ToString();


                                    DateTime contact_dob = DateTime.Parse(row["Contact_dob"].ToString());
                                    string contact_dob_string = contact_dob.ToString("yyyy-MM-dd");

                                    this.HiddenField_Id.Value = contactid;
                                    this.TextBox1.Text = contact_name;
                                    this.TextBox2.Text = contact_phone;
                                    this.TextBox3.Text = contact_email;
                                    this.TextBox4.Text = contact_address;
                                    this.RadioButtonList1.Text = contact_gender;
                                    this.DropDownList1.Text = contact_relationship;
                                    this.TextBox5.Text = contact_dob_string;
                                }
                            }
                        }
                    }
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

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new
        SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);

            try
            {
                con.Open();
                String query = "INSERT INTO Contacts (contact_name, contact_phone, contact_email, contact_address, contact_gender, contact_relationship, contact_dob) values(@contact_name, @contact_phone, @contact_email, @contact_address, @contact_gender, @contact_relationship, @contact_dob)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@contact_name", TextBox1.Text);
                cmd.Parameters.AddWithValue("@contact_phone", TextBox2.Text);
                cmd.Parameters.AddWithValue("@contact_email", TextBox3.Text);
                cmd.Parameters.AddWithValue("@contact_address", TextBox4.Text);
                cmd.Parameters.AddWithValue("@contact_gender", RadioButtonList1.Text);
                cmd.Parameters.AddWithValue("@contact_relationship", DropDownList1.Text);
                cmd.Parameters.AddWithValue("@contact_dob", TextBox5.Text);

                cmd.ExecuteNonQuery();

                Response.Redirect("DisplayData.aspx");
                con.Close();
            }
            catch (Exception ex)
            {
                Response.Write("Error: " + ex.ToString());


            }
        }

        protected void HiddenField1_ValueChanged(object sender, EventArgs e)
        {

        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString); ;
                string query = "DELETE FROM contacts WHERE Id=@contactid";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@contactid", HiddenField_Id.Value);

                con.Open();
                cmd.ExecuteNonQuery();

                Response.Redirect("DisplayData.aspx");
                con.Close();
            }
            catch (Exception ex)
            {
                Response.Write("Error: " + ex.ToString());
            }
        }
    }
}