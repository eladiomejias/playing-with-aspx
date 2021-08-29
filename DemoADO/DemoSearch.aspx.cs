using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using static DemoADO.connection;

namespace DemoADO
{
    public partial class DemoSearch : System.Web.UI.Page
    {

        // Creando clase connection con sus respectivos metodos
        connection conn = new connection();

        public SqlConnection con;
        public string constr;

        protected void Page_Load(object sender, EventArgs e)
        {

            Label2.Visible = false;
            //conn.openConnection();
        }

        // Segunda clase de conexion
        public void connection2()
        {
            constr = ConfigurationManager.ConnectionStrings["connectionASPX"].ToString();
            con = new SqlConnection(constr);
            con.Open();

        }

        public void close()
        {
            con.Close();
        }

        private void rep_bind()
        {
            connection2();
            string query = "select * from Person where Nombre = '" + TextBox1.Text + "'";
            //SqlCommand cmd = new SqlCommand(query, conn.getConnection());
            //cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            connection2();
            string query = "select * from Person where Nombre = '" + TextBox1.Text.Trim() + "'";
            SqlCommand com = new SqlCommand(query, con);

            SqlDataReader dr;
            dr = com.ExecuteReader();

            if (dr.HasRows)
            {
                dr.Read();
                rep_bind();
                GridView1.Visible = true;
                TextBox1.Text = "";
                Label2.Text = "";
            }
            else
            {
                GridView1.Visible = false;
                Label2.Visible = true;
                if (string.IsNullOrEmpty(TextBox1.Text.ToString()))
                {
                    Label2.Text = "Ingreso un elemento vacio.";
                }
                else
                {
                  Label2.Text = "El termino " + TextBox1.Text.Trim() + " no se encuentra en la base de datos.";
                }
            }

            con.Close();
        }
    }
}