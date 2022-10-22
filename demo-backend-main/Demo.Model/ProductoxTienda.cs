using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Model
{
    public class ProductoxTienda
    {
        public int Id { get; set; }
        public int Stock { get; set; }
        public float Prize { get; set; }
        public int ProductoId { get; set; }
        public int TiendaId { get; set; }
        public int State { get; set; }
    }
}
