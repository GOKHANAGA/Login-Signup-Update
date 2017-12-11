using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UserInterface
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //if (Session["userName"] == null)
            //    btnLogout.Visible = false;
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            Session["userName"] = null;
            Session["userID"] = null;
            Response.Redirect("index.aspx");

        }
    }
}