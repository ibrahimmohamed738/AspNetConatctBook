using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace AspNetTelephone
{
    public partial class addContact : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["username"] == null)
                Response.Redirect("Login.aspx");
        }

        protected void btnAddContact_Click(object sender, EventArgs e)
        {

            using (SqlConnection Conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DirectoryDB"].ConnectionString))
            {
                var username = Session["username"];
                var firstname = txtfirstname.Text.Trim();
                var lastname = txtLastname.Text.Trim();
                var contactno = txtContactno.Text.Trim();
                var email = txtemail.Text.Trim();
                var address = txtAddress.Text.Trim();
                var city = txtCity.Text.Trim();

                using (SqlCommand cmd = new SqlCommand("AddContact"))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@firstname", firstname);
                    cmd.Parameters.AddWithValue("@lastname", lastname);
                    cmd.Parameters.AddWithValue("@contactno", contactno);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@address", address);
                    cmd.Parameters.AddWithValue("@city", city);
                    cmd.Connection = Conn;
                    Conn.Open();
                
                    if (cmd.ExecuteNonQuery() > 0)
                        lblSuccessMessage.Text = "Conatct Added Successfully";
                    else
                        lblErrorMessage.Text = "Error while adding Contact";
                }
            }

        }
    }
}