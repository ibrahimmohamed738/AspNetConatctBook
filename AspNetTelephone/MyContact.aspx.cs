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
    public partial class MyContact : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["username"] == null)
                Response.Redirect("Login.aspx");

            using (SqlConnection Conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DirectoryDB"].ConnectionString))
            {
                var username = Session["username"];
               

                using (SqlCommand cmd = new SqlCommand("GetContactByUserName"))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Connection = Conn;
                    Conn.Open();
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    RepContact.DataSource = dt;
                    RepContact.DataBind();
                }
            }
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            using (SqlConnection Conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DirectoryDB"].ConnectionString))
            {
                var username = Session["username"];
                var search = txtfirstname.Text.Trim();


                using (SqlCommand cmd = new SqlCommand("SerachContact"))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@firstname", search+"%");
                    cmd.Connection = Conn;
                    Conn.Open();
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    RepContact.DataSource = dt;
                    RepContact.DataBind();
                }
            }
        }
    }
}