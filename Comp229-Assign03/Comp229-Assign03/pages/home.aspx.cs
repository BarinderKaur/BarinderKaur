using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Comp229_Assign03.pages
{
    public partial class home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            bindList();
        }

        protected void bindList()
        {

            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Comp229Assign03ConnectionString"].ToString());

            
            SqlCommand comm = new SqlCommand("SELECT * FROM Students", connection);
            try
            {
                connection.Open();
                SqlDataReader reader = comm.ExecuteReader();
                GridView1.DataSource = reader;
                GridView1.DataBind();
                reader.Close();
            }
            finally
            {
                connection.Close();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/pages/addnew.aspx");
        }
        protected void GridView_RowSelection(object sender, EventArgs e)
        {
            GridViewRow row = GridView1.SelectedRow;
            string StudentID = row.Cells[1].Text;

            Response.Redirect("~/pages/StudentInformation.aspx?MyID=" + StudentID);
        }
    }
}