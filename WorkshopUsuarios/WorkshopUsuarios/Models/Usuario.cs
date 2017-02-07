using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WorkshopUsuarios.Models
{
    public class Usuario
    {
        public int Id { get; set; }

        public string Nombre { get; set; }

        public string ApellidoPaterno { get; set; }

        public string ApellidoMaterno { get; set; }

    }
}