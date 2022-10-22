using Demo.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Queries.ProductoxTienda
{
    public interface IProductoxTiendaQueries
    {
        Task<IEnumerable<ProductoxTiendaViewModel>> GetAll();
    }
}
