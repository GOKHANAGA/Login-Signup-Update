﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UserInterface
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["userName"]!=null)
            {
                Label1.Text = string.Format("Merhaba {0}", Session["userName"].ToString());
            }
            else
            {
                Response.Redirect("userLogin.aspx");
            }

        }
    }
}