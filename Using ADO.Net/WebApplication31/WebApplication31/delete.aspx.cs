﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication31
{
    public partial class delete : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string jk;
            jk = "data source=DESKTOP-P5QVRFC\\SQLEXPRESS;Initial catalog=NimapAdo;Integrated Security=true;";

            SqlConnection c1 = new SqlConnection(jk);

            string q;
            q = "delete from company where ProductId='" + TextBox1.Text + "'";

            c1.Open();

            SqlCommand cmd = new SqlCommand(q, c1);

            cmd.ExecuteNonQuery();
            Response.Write("<script>alert('data deleted successfully')</script>");

            TextBox1.Text = "";
        }
    }
}