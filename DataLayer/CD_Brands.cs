using IdentityLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;


namespace DataLayer
{
    public class CD_Brands
    {
        public List<Brand> List()
        {
            List<Brand> list = new List<Brand>();

            try
            {
                using (SqlConnection connection = new SqlConnection(Connection.cn))
                {
                    string query = "select IdMarca, Descripcion, Activo from  MARCA";

                    SqlCommand cmd = new SqlCommand(query, connection)
                    {
                        CommandType = CommandType.Text
                    };

                    connection.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            list.Add(
                              new Brand()
                              {
                                  IdMarca = Convert.ToInt32(dr["IdMarca"]),
                                  Descripcion = dr["Descripcion"].ToString(),
                                  Activo = Convert.ToBoolean(dr["Activo"])

                              }

                              );
                        }
                    }
                }
            }
            catch
            {
                list = new List<Brand>();
            }
           return list; 
        }
    }
}