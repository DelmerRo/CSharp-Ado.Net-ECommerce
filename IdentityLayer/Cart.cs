using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdentityLayer
{
    public class Cart
    {
        public int IdCarrito { get; set; }

        public Customer Cliente { get; set; }

        public Product Producto { get; set; }

        public int Cantidad { get; set; }
    }
}
