using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenParcial2.Modelos
{
    public class Entrada
    {
        public int IdEntrada { get; set; }
        public int IdProducto { get; set; }
        public int Cantidad { get; set; }
        public DateTime FechaEntrada { get; set; }
        public int IdProveedor { get; set; }
    }
}
