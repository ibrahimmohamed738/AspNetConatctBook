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
    public partial class delete : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int userId = Convert.ToInt32(Request.QueryString["id"].ToString());

            using (SqlConnection Conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DirectoryDB"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("DeleteContact"))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@UserId", userId);
                    cmd.Connection = Conn;
                    Conn.Open();
                    cmd.ExecuteNonQuery(); 
                    Response.Redirect("MyContact.aspx");
                   

                }
            }

        }
    }
}