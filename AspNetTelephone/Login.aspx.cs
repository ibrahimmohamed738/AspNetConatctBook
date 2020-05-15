using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace AspNetTelephone
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            var username = txtUsername.Text.Trim();
            var password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
                lblErrorMessage.Text = "Username and Password is required";
            else
            {
                using (SqlConnection Conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DirectoryDB"].ConnectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("CheckLogin"))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Username", username);
                        cmd.Parameters.AddWithValue("@Password", password);
                        cmd.Connection = Conn;
                        Conn.Open();
                        SqlDataReader reader = cmd.ExecuteReader();
                        reader.Read();
                        if (reader.HasRows)
                        {
                            int userId = reader.GetInt32(0);
                            var User = reader.GetString(1);
                            Session["username"] = User;
                            Response.Redirect("AddContact.aspx");
                        }
                        else
                            lblErrorMessage.Text = "Invalid username or password.";

                    }
                }
            }
        }
    }
}