using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdentityLayer
{
	
   public class Product
    {
        public int IdProducto { get; set; }

        public string Nombre { get; set; }

		public string Descripcion { get; set; }

		public Brand IdMarca{ get; set; }

		public Category IdCategoria { get; set; }

		public decimal precio { get; set; }

		public int stock { get; set; }

		public string RutaImagen { get; set; }

		public string NombreImagen { get; set; }

		public bool Activo { get; set; }

        public bool Estado { get; set; }

    }
}
