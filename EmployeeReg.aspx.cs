using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp060924
{
    public partial class EmployeeReg : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int empid;
            string name;
            string gender;
            string dpt;
            
            if (this.IsValid)//true
            {
                
                empid = int.Parse(TextBox1.Text);
                name = TextBox2.Text;
                if (RadioButton1.Checked)
                {
                    gender = RadioButton1.Text;
                }
                else
                {
                    gender = RadioButton2.Text;
                }
                dpt = DropDownList1.SelectedItem.Text;
                //database connectivity
                SqlConnection con = new SqlConnection("Data Source=Desktop-ABKHEEV;Initial Catalog=tempdb;Integrated Security=True;TrustServerCertificate=True");
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "insert into tblEmployee values(@empid,@name,@gender,@dept)";
                cmd.Parameters.AddWithValue("@empid", empid);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@gender", gender);
                cmd.Parameters.AddWithValue("@dept",dpt);

                int n=cmd.ExecuteNonQuery();
                if (n > 0)
                {
                    Response.Write("<script>alert('Record inserted Successfully..');</script>");
                }
                else
                {
                    Response.Write("<script>alert('Record not inserted!!!');</script>");
                }

            }
            else
            {
                Response.Write("<script>alert('Invalid Data provided!!!');</script>");
            }
        }
    }
}