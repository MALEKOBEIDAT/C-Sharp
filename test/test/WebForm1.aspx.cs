using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace test
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
           // lblclick.Text = "Helloe Malek";

            Label lbl=new Label();
            this.Controls.Add(lbl);
            lbl.Text = "Hello";

            Label lbl2=new Label();
            this.Controls.Add(lbl2);
            lbl2.Text= "Hello2";





            



            






        }
    }
}