using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using Microsoft.Reporting.WebForms;

namespace AspNetTelephone
{
    public partial class ContactReport : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnShowReport_Click(object sender, EventArgs e)
        {
            ReportViewer1.Reset();
            ReportDataSource rptSrc = new ReportDataSource("DataSet1",GetData());
            ReportViewer1.LocalReport.DataSources.Add(rptSrc);
            ReportViewer1.LocalReport.ReportPath = "ContactList.rdlc";
            ReportViewer1.LocalReport.Refresh();
        }
        private DataTable GetData()
        {
            DataTable dt = new DataTable();
            using (SqlConnection Conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DirectoryDB"].ConnectionString))
            {
                var username = Session["username"];


                using (SqlCommand cmd = new SqlCommand("GetContactByUserName"))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Connection = Conn;
                    Conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    return dt;
                }
            }

        }
    }
}