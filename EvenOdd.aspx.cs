using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp060924
{
    public partial class EvenOdd : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int no = int.Parse(TextBox1.Text);
            if (no%2==0)
            {
                Label1.Text = $"{no} is Even number";
                TextBox2.Text = $"{no} is Even number";
                Response.Write($"<script>alert('{no} is Even number');</script>");
            }
            else
            {
                Label1.Text = $"{no} is Odd number";
                TextBox2.Text = $"{no} is Odd number";
                Response.Write($"<script>alert('{no} is Odd number');</script>");
            }
           
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            //Response.Redirect("PrimeNumber.aspx");
            Response.Write("<script>alert('welcome');</script>");
        }
    }
}