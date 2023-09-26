using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdentityLayer
{

    public class SaleDetail
    {
        public int IdDetalleVenta { get; set; }

        public int IdVenta { get; set; }

        public Product Producto { get; set; }

        public int Cantidad { get; set; }

        public decimal Total { get; set; }

        public string IdTransaccion { get; set; }

    }
}
