using IdentityLayer;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class CD_Product
    {
        public List<Product> List()
        {
            List<Product> list = new List<Product>();
            try
            {
                using (SqlConnection connection = new SqlConnection(Connection.cn))
                {
                    string query = "select IdProducto, Nombre, Descripcion, precio, stock, RutaImagen, NombreImagen, Activo from PRODUCTO";

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
                              new Product()
                              {
                                  IdProducto = Convert.ToInt32(dr["IdProducto"]),
                                  Nombre = dr["Nombre"].ToString(),
                                  Descripcion = dr["Descripcion"].ToString(),
                                  precio = Convert.ToDecimal(dr["precio"]),
                                  stock = Convert.ToInt32(dr["stock"]),
                                  RutaImagen = dr["RutaImagen"].ToString(),
                                  NombreImagen = dr["NombreImagen"].ToString(),
                                  Activo = Convert.ToBoolean(dr["Activo"])
                              }

                            );
                        }

                    }
                }

            }
            catch
            {
                list = new List<Product>();
            }
            return list;
        }
    }
}