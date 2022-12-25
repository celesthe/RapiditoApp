using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace RapiditoWEBAPP.Models
{
    public class TipoPersonas
    {
        public int ID { get; set; }
        [DisplayName("Tipo persona")]
        public string TipoPersona { get; set; }
        [DisplayName("Estado")]
        public int Estado { get; set; }
    }
}
