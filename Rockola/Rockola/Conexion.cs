using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace Rockola
{

    class Conexion
    {
        SqlConnectionStringBuilder builder;
    public Conexion(){

                builder = new SqlConnectionStringBuilder();
                builder.DataSource = "";
                builder.UserID = "";
                builder.Password = "";     
                builder.InitialCatalog = "";

    }


    public DataSet metodocancion()
    {
         DataSet ds = new DataSet();
        List<Cancion> listacanciones = new List<Cancion>();

        using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
        {

            String sql = "SELECT id,nombre FROM dbo.canciones";

            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                connection.Open();
                SqlDataAdapter data = new SqlDataAdapter(command);
               
                data.Fill(ds);
               
                
                //using (SqlDataReader reader = command.ExecuteReader())
                //{
                //    while (reader.Read())
                //    {
                //        Cancion can = new Cancion();
                //        can.ID = Convert.ToInt32(reader.GetString(0));
                //        can.Nombre = reader.GetString(1);
                //        listacanciones.Add(can);
                        
                //    }
                //} 
                connection.Close();
            }
        }
        //return listacanciones;
        return ds;
    }


    public void guardarcancion(string cancion) {
        try
        {


            using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
            {
              

                String sql = "insert into canciones (nombre) values ('" + cancion + "')";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    connection.Open();
                    command.ExecuteReader();
                    connection.Close();

                }
            }
        }
        catch (SqlException e)
        {

            throw e;
        }


    }


        
        
    }
}