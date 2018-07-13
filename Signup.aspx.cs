using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Signup : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection(@"Data Source=.\IMBD;AttachDbFilename=|Registration-Table|\Database.mdf;Integrated Security=True;User Instance=True");
        SqlCommand cmd = new SqlCommand("sp_insert", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("Username", TextBox1.Text);
        cmd.Parameters.AddWithValue("Emailid", TextBox2.Text);
        cmd.Parameters.AddWithValue("Phone", TextBox3.Text);
        cmd.Parameters.AddWithValue("Password", TextBox4.Text);
        con.Open();
        int k = cmd.ExecuteNonQuery();
        if (k != 0)
        {
            Server.Transfer("Home.aspx");
           

        }
        con.Close();
    }
}