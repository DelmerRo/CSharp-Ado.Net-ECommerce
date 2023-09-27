using System;
using System.Collections.Generic;
using System.Data.SqlClient;

using System.Data;
using IdentityLayer;
   

namespace DataLayer
{
    public class CD_Users
    {
        public List<User> List() {

            List<User> list = new List<User>();

            try
            {
                using (SqlConnection connection = new SqlConnection(Connection.cn)){
                    
                    string query = "select IdUsuario, Nombres, Apellidos, Correo, Clave, Reestablecer, Activo from USUARIO";

                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.CommandType = CommandType.Text;

                    connection.Open();


                    using (SqlDataReader dr = cmd.ExecuteReader() ){
                        while (dr.Read())
                        {
                            list.Add(
                              new User()
                              {
                                  IdUsuario = Convert.ToInt32(dr["IdUsuario"]),
                                  Nombres = dr["Nombres"].ToString(),
                                  Apellidos = dr["Apellidos"].ToString(),
                                  Correo = dr["Correo"].ToString(),
                                  Clave = dr["Clave"].ToString(),
                                  Reestablecer = Convert.ToBoolean(dr["Reestablecer"]),
                                  Activo = Convert.ToBoolean(dr["Activo"]),
                              }

                              );
                        }
                    }
                }
            }
            catch
            {
                list = new List<User>();
            }

            return list;
        }
    }
}
