using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using Autenticacion.Models;
using System.Data.SqlClient;
using System.Data;

namespace Autenticacion.Logica
{
    public class LO_Usuario
    {
        public Usuarios EncontrarUsuario(string correo, string clave)
        {

            Usuarios objeto = new Usuarios();


            using (SqlConnection conexion = new SqlConnection("Data Source=CLIENTE01146; Initial Catalog=Registro; Integrated Security=true"))
            {

                string query = "select Nombres,Correo,Clave,IdRol from USUARIOS where Correo = @pcorreo and Clave = @pclave";

                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@pcorreo", correo);
                cmd.Parameters.AddWithValue("@pclave", clave);
                cmd.CommandType = CommandType.Text;


                conexion.Open();


                using (SqlDataReader dr = cmd.ExecuteReader())
                {

                    while (dr.Read())
                    {

                        objeto = new Usuarios()
                        {
                            Nombres = dr["Nombres"].ToString(),
                            Correo = dr["Correo"].ToString(),
                            Clave = dr["Clave"].ToString(),
                            IdRol = (Rol)dr["IdRol"],

                        };
                    }

                }
            }
            return objeto;

        }
    }
}