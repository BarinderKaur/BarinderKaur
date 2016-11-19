using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Comp229_Assign003.pages
{
    public partial class addnew : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Comp229Assign03ConnectionString"].ToString());
            SqlCommand comm = new SqlCommand("INSERT INTO Students ( FirstMidName, LastName, EnrollmentDate) VALUES(@FirstMidName, @LastName, @EnrollmentDate)", connection);
            comm.Parameters.Add("@FirstMidName", System.Data.SqlDbType.VarChar);
            comm.Parameters["@FirstMidName"].Value = TextBox1.Text;

            comm.Parameters.Add("@LastName", System.Data.SqlDbType.VarChar);
            comm.Parameters["@LastName"].Value = TextBox2.Text;

            comm.Parameters.Add("@EnrollmentDate", System.Data.SqlDbType.Date);
            comm.Parameters["@EnrollmentDate"].Value = Convert.ToDateTime(TextBox3.Text);

            try
            {
                connection.Open();
                comm.ExecuteNonQuery();
                Response.Redirect("~/pages/home.aspx");

            }
            catch (Exception ex)
            {
                Response.Write("<script> alert('Error:" + ex.Message + "'); </script>");
            }
            finally
            {
                connection.Close();
            }
            }
            }
        }
  
