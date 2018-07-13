using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlTypes;

public partial class Movies : System.Web.UI.Page
{
    StringBuilder table = new System.Text.StringBuilder();
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!Page.IsPostBack)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = ConfigurationManager.ConnectionStrings[].ToString();
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Select * from [Movie-Table]";
            cmd.Connection = con;
            SqlDataAdapter rd=cmd.ExecuteReader();
            table.Append("<table border='1'>");
            table.Append("<tr><th>Movie Name</th><th>Year of release</th><th>Movie Plot</th><th>Movie Producer</th><th>Movie Actor</th>");
            table.Append("</tr>");
            if(rd.HasRows)
            {
                while(rd.Read())
                {
                    table.Append("<tr>");
                    table.Append("<td>"+rd[0]+"</td>");
                    table.Append("<td>"+rd[1]+"</td>");
                    table.Append("</tr>");

                }
            }
            table.Append("</table");
            PlaceHolder.Controls.Add(new Literal { Text = table.ToString() });
            rd.close();
        }

    }

    
}