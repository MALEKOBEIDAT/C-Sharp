using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _30_11_2022_tasks
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            double box1=Convert.ToDouble(TextBox1.Text);
            double box2=Convert.ToDouble(TextBox2.Text);


            double res=box1+box2;
            TextBox3.Text = res.ToString();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            double box1=Convert.ToDouble(TextBox1.Text);
            double box2=Convert.ToDouble(TextBox2.Text);
            double res=box1-box2;
            TextBox3.Text= res.ToString();


        }

        protected void Button3_Click(object sender, EventArgs e)
        {

            double box1 = Convert.ToDouble(TextBox1.Text);
            double box2 = Convert.ToDouble(TextBox2.Text);
            double res = box1 * box2;
            TextBox3.Text = res.ToString();


        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            double box1 = Convert.ToDouble(TextBox1.Text);
            double box2 = Convert.ToDouble(TextBox2.Text);
            double res = box1 / box2;
            TextBox3.Text = res.ToString();

        }
    }
}