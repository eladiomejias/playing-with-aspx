using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;

namespace DemoADO
{
    public partial class Demo : System.Web.UI.Page
    {

        private DataTable dataTable = new DataTable();

        protected void Page_Load(object sender, EventArgs e)
        {

            // --------------------------------------------

            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["connectionASPX"].ToString());
            con.Open();
            string query = "select * from Person";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.CommandType = CommandType.Text;

            System.Console.WriteLine($"hello console!");

            using (SqlDataReader dr = cmd.ExecuteReader())
            {
                GridView1.DataSource = dr;
                GridView1.DataBind();
            }
            // -------------------------------------------


            // llenado con dataSet
            // create data adapter
            using (SqlDataAdapter dataAdapter= new SqlDataAdapter("SELECT * FROM Person ", con))
            {
                // create the DataSet 
                DataSet dataSet = new DataSet();
                // fill the DataSet using our DataAdapter 
                dataAdapter.Fill(dataSet);
                ///gridView2.DataSource = dataSet;
            }

            SqlDataAdapter da = new SqlDataAdapter();
            // DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            da.SelectCommand = new SqlCommand("SELECT * FROM Person ", con);
            da.Fill(dt);
            gridView2.DataSource = dt;

            // ------------------------------------------
            // Cerrar conexion
            con.Close();

        }
    }
}