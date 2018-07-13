using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class Login : System.Web.UI.Page
{
    SqlCommand cmd = new SqlCommand();
    SqlConnection con = new SqlConnection();
    SqlDataAdapter sda = new SqlDataAdapter();
    DataSet ds = new DataSet();
    protected void Page_Load(object sender, EventArgs e)
    {
        con.ConnectionString = "Data source=DESKTOP-NTNSU4D;initial catalog=Login-Table;integrated Security=true";
        con.Open();
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        cmd.CommandText = "Select* from Login-Table where Email='"+TextBox1.Text+"'and Password='"+TextBox2.Text+"'";
        cmd.Connection = con;
        sda.SelectCommand = cmd;
        sda.Fill(ds, "Login-Table");
        if (ds.Tables[0].Rows.Count > 0)
        {
            Server.Transfer("Movies List.aspx");
        }
        else
            Server.Transfer("Admin Login.aspx");
    }
}