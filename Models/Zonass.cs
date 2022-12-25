using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace RapiditoWEBAPP.Models
{
    public class Zonass
    {
        public int ID { get; set; }
        [DisplayName("Numero de zona")]
        public string Zona { get; set; }
        public string Departamento { get; set; }
        public string Municipio { get; set; }
        public int Estado { get; set; }
    }
}
