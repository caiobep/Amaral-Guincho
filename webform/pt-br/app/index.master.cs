﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class pt_br_app_index : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
      if(Session[log] = "null"){
        Response.Redirect("~/pt-br/index.html");
      }
    }
}
