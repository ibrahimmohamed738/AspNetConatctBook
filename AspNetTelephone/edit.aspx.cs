using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace AspNetTelephone
{
    public partial class edit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["username"] == null)
                Response.Redirect("Login.aspx");

            if (IsPostBack)
                return;

            int userId = Convert.ToInt32(Request.QueryString["id"].ToString());

            using (SqlConnection Conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DirectoryDB"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("GetContactByID"))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@UserId", userId);
                    cmd.Connection = Conn;
                    Conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        txtfirstname.Text = reader.GetString(0);
                        txtLastname.Text = reader.GetString(1);
                        txtContactno.Text = reader.GetString(2);
                        txtemail.Text = reader.GetString(3);
                        txtAddress.Text = reader.GetString(4);
                        txtCity.Text = reader.GetString(5);
                    }
                   


                }
            }

        }

        protected void BtnEdit_Click(object sender, EventArgs e)
        {
            int userId = Convert.ToInt32(Request.QueryString["id"].ToString());
            var firstname = txtfirstname.Text.Trim();
            var lastname = txtLastname.Text.Trim();
            var contactno = txtContactno.Text.Trim();
            var email = txtemail.Text.Trim();
            var address = txtAddress.Text.Trim();
            var city = txtCity.Text.Trim();

            using (SqlConnection Conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DirectoryDB"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("UpdateContact"))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@UserId", userId);
                    cmd.Parameters.AddWithValue("@firstname", firstname);
                    cmd.Parameters.AddWithValue("@lastname", lastname);
                    cmd.Parameters.AddWithValue("@contactno", contactno);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@address", address);
                    cmd.Parameters.AddWithValue("@city", city);
                    cmd.Connection = Conn;
                    Conn.Open();
                    cmd.ExecuteNonQuery();
                    Response.Redirect("MyContact.aspx");



                }
            }

        }
    }
}