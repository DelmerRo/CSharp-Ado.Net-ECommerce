﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdentityLayer
{
   public class User
    {
        public int IdUsuario { get; set; }

        public string Nombres { get; set; }

        public string Apellidos { get; set; }

        public string Correo { get; set; }

        public string Clave { get; set; }

        public bool Reestablecer { get; set; }

        public bool Activo { get; set; }
    }
}
