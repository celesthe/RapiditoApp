using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace RapiditoWEBAPP.Models
{
    public class EnvioPedido
    {
        public int ID { get; set; }
        [DisplayName("Direccion de Origen")]
        public string DireccionOrigen { get; set; }
        [DisplayName("Direccion geografica de origen")]
        public string UbicacionGeograficaOrigen { get; set; }
        [DisplayName("Quien lo envia")]
        public int IdCliente { get; set; }
        [DisplayName("Producto a entregar")]
        public string productoAentregar { get; set; }
        [DisplayName("Peso del producto")]
        public int idCuotaPesoE { get; set; }
        [DisplayName("Direccion Destino")]
        public string DireccionDestino { get; set; }
        [DisplayName("Direccion geografica de destino")]
        public string UbicacionGeograficaDestino { get; set; }
        [DisplayName("Quien recibe ")]
        public string NombreClienteRecibe { get; set; }
        [DisplayName("DPI ")]
        public string doctoIdentificacion { get; set; }
    }
}
