using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace DemoADO
{
    public class connection
    {

        // Inicializar las variables de la conexion
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["connectionASPX"].ToString());
        //SqlConnection con;

        // Metodo para abrir la conexion y conectarse con el connection string
        public void openConnection()
        {

            try
            {
                //con = new SqlConnection(ConnectionString);
                con.Open();
            }
            catch(Exception e)
            {
                Console.WriteLine("OOPs, something went wrong.\n" + e);
            }
            /*
            finally
            {   
                // Cerrar conexion en finally
                con.Close();
            }*/

        }

        // Metodo para cerrar la conexion
        public void closeConnection()
        {
            if (con.State == System.Data.ConnectionState.Open)
                con.Close();
            con.Dispose();
        }

        // Obtener el parametro SQL Connection y devolver
        public SqlConnection getConnection()
        {
            return con;
        }

    }
}