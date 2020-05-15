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
    
    public partial class Registeration : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            var firstname = txtFirstname.Text.Trim();
            var lastname = txtLastname.Text.Trim();
            var email = txtEmail.Text.Trim();
            var username = txtUsername.Text.Trim();
            var password = txtPasword.Text.Trim();
            var contact = txtContact.Text.Trim();

            using (SqlConnection Conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DirectoryDB"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("RegisterUser"))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@firstname", firstname);
                    cmd.Parameters.AddWithValue("@lastname", lastname);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);
                    cmd.Parameters.AddWithValue("@contact", contact);
                    cmd.Connection = Conn;
                    Conn.Open();
                    int result = Convert.ToInt32(cmd.ExecuteScalar());

                    if (result == -1)
                        lblErrorMessage.Text = "Username already taken.";
                    else if (result == -2)
                        lblErrorMessage.Text = "Email is aleardy registered.";
                    else
                        lblSuccessMessage.Text = "User Aded Successfully.";
                }
            }
        }
    }
}