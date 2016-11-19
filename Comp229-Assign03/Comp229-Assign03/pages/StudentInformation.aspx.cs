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
    public partial class StudentInformation : System.Web.UI.Page
    {
        private object studentID;

        protected void Page_Load(object sender, EventArgs e)
        {
if (!IsPostBack)
            {
                bindList();
            }
        }
        protected void bindList()
        {
            studentID = Convert.ToInt32(Request.QueryString["MyID"]);
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Comp229Assign03ConnectionString"].ToString());

            
            SqlCommand comm = new SqlCommand("SELECT s.StudentID, s.LastName, s.FirstMidName, c.CourseID, c.courseID, c.Title FROM Students s JOIN Enrollments e on(s.StudentID = e.StudentID) JOIN Courses c ON(e.CourseID = c.CourseID)where s.StudentID = @StudentID", connection);
            comm.Parameters.Add("@StudentID", System.Data.SqlDbType.Int);
            comm.Parameters["@StudentID"].Value = studentID;
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

        protected void Delete_Row(object sender, GridViewDeleteEventArgs e)
        {
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Comp229Assign03ConnectionString"].ToString());
            SqlCommand comm = new SqlCommand("DELETE From Enrollments WHERE StudentID=@StudentID", connection);
            SqlCommand command = new SqlCommand("DELETE From Enrollments WHERE StudentID=@StudentID", connection);

            comm.Parameters.Add("@StudentsID", System.Data.SqlDbType.Int);
            comm.Parameters["@StudentID"].Value = Convert.ToInt32(Request.QueryString["MyID"]);

            command.Parameters.Add("@StudentsID", System.Data.SqlDbType.Int);
            command.Parameters["@StudentID"].Value = Convert.ToInt32(Request.QueryString["MyID"]);

            try
            {
                connection.Open();
                comm.ExecuteNonQuery();

                command.ExecuteNonQuery();
                Response.Redirect("~/pages/home.aspx");
            }
            catch (Exception ex)
            {
                Response.Write("<script> alert('error: " + ex.Message + "'); </script>");
            }
            finally
            {
                connection.Close();
            }
        }


        }
    }
