using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RapiditoWEBAPP.Models
{
    public class Usuarios
    {
        public int ID { get; set; }
        [DisplayName("Usuario")]
        public string Username { get; set; }
        [DisplayName("Contraseña")]
        [DataType(DataType.Password)]
        public string password { get; set; }
        [DisplayName("Persona")]
        public int idPersonaU { get; set; }
        [DisplayName("Estado")]
        public int Estado { get; set; }
        [DisplayName("Fecha Registro")]
        public DateTime FechaRegistro { get; set; }
    }
}
