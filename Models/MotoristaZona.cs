using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace RapiditoWEBAPP.Models
{
    public class MotoristaZona
    {
        public int ID { get; set; }
        [DisplayName("Zona")]
        public int IdZonaM { get; set; }

        [DisplayName("Motorista")]
        public int IdMotoristaM { get; set; }
    }
}
