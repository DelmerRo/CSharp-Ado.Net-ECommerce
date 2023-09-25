using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdentityLayer
{

	public class Customer
    {
		public int IdCliente { get; set; }

		public string Nombres { get; set; }

		public string Apellidos { get; set; }

		public string Correo { get; set; }

		public string Clave { get; set; }

		public bool Reestablecer { get; set; }

	}
}
