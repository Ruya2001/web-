﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KFMS_PROJECT
{
    public partial class logout : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            FormsAuthentication.SignOut();
            Session.Abandon();
            Session.Clear();
            Response.Cookies.Clear();
            Response.Redirect("~/src/login.aspx");

        }
    }
}