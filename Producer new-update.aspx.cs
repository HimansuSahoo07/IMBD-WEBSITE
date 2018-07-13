using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Producer_new_update : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection(@"Data Source=.\IMBD;AttachDbFilename=|Actor-Table|\Database.mdf;Integrated Security=True;User Instance=True");
        SqlCommand cmd = new SqlCommand("sp_insert", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("Producer name", TextBox1.Text);
        cmd.Parameters.AddWithValue("PSex", TextBox3.Text);
        cmd.Parameters.AddWithValue("DOB", TextBox4.Text);
        cmd.Parameters.AddWithValue("Sex", TextBox5.Text);
        con.Open();
        int k = cmd.ExecuteNonQuery();
        if (k != 0)
        {
            Server.Transfer("Home.aspx");

        }
        con.Close();
    }
}