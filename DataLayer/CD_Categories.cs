using IdentityLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class CD_Categories
    {
        public List<Category> List()
        {
            List<Category> list = new List<Category>();
            try
            {
                using (SqlConnection connection = new SqlConnection(Connection.cn))
                {
                    string query = "select IdCategoria, Descripcion, Activo from Categoria";

                    SqlCommand cmd = new SqlCommand(query, connection)
                    {
                        CommandType = CommandType.Text
                    };
                    connection.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            list.Add(new Category()
                            {
                                IdCategoria = Convert.ToInt32(dr["IdCategoria"]),
                                Descripcion = dr["Descripcion"].ToString(),
                                Activo = Convert.ToBoolean(dr["Activo"])
                            });
                        }
                    }
                }


            }
            catch
            {
                list = new List<Category>();
            }
            return list;
        }
    }
}
