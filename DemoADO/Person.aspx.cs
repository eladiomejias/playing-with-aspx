using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace DemoADO
{
    public partial class Person : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["connectionASPX"].ToString());
            con.Open();
            string query = "select * from Person";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.CommandType = CommandType.Text;

            System.Console.WriteLine($"hello console!");

            using (SqlDataReader dr = cmd.ExecuteReader())
            {
             
            }

            con.Close();
        }
    }
}