using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Actor_Update_new : System.Web.UI.Page
{
    SqlCommand cmd = new SqlCommand();
    SqlConnection con = new SqlConnection();
    SqlDataAdapter sda = new SqlDataAdapter();
    DataSet ds = new DataSet();
    protected void Page_Load(object sender, EventArgs e)
    {
        con.ConnectionString = "Data source=DESKTOP-NTNSU4D;initial catalog=Actor-Table;integrated Security=true";
        con.Open();
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection(@"Data Source=.\IMBD;AttachDbFilename=|Actor-Table|\Database.mdf;Integrated Security=True;User Instance=True");
        SqlCommand cmd = new SqlCommand("sp_insert", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("Actor name", TextBox1.Text);
        cmd.Parameters.AddWithValue("DOB", TextBox2.Text);
        cmd.Parameters.AddWithValue("Bio", TextBox3.Text);
        cmd.Parameters.AddWithValue("Sex", TextBox4.Text);
        con.Open();
        int k = cmd.ExecuteNonQuery();
        if (k != 0)
        {
            Server.Transfer("Home.aspx");

        }
        con.Close();
    }
}