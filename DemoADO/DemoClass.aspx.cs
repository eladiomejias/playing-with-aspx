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
    public partial class DemoClass : System.Web.UI.Page
    {
        // Creando clase connection con sus respectivos metodos
         connection conn = new connection();

        protected void Page_Load(object sender, EventArgs e)
        {

            // -------- CONEXION CON CLASE ----------- //

            // Abrir conexion
            conn.openConnection();

            // Seleccionar query y tipo de comando
            string query = "select * from Person";
            SqlCommand cmd = new SqlCommand(query, conn.getConnection());
            cmd.CommandType = CommandType.Text;

            //System.Console.WriteLine($"hello console!");

            // Creando data reader y ejecutar comando cmd
            using (SqlDataReader dr = cmd.ExecuteReader())
            {
                gridView.DataSource = dr;
                gridView.DataBind();
            }

            // Cerrar conexion
            conn.closeConnection();


            // ------------- WORKING WITH USING --------------- //

         
            using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["connectionASPX"].ToString()))
            {
                connection.Open();
                string query2 = "select * from Person";
                using (var q = new SqlCommand(query2, connection))
                {
                    using (SqlDataReader reader = q.ExecuteReader())
                    {
                        gridView2.DataSource = reader;
                        gridView2.DataBind();
                    }
                }
            }


            // -------------------------------------------
            

        }
    }

}