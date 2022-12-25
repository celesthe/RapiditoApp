using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace RapiditoWEBAPP.Models
{
    public class Persona
    {
        public int ID { get; set; }
        [DisplayName("Nombres")]
        public string Nombres { get; set; }
        [DisplayName("Apellidos")]
        public string Apellidos { get; set; }
        [DisplayName("Nit")]
        public string Nit { get; set; }
        [DisplayName("Telefono")]
        public string Telefono { get; set; }
        [DisplayName("Tipo Persona")]
        public int IdTipoPersonaP { get; set; }
        [DisplayName("Activo")]
        public int Estado { get; set; }
    }
}
