using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Repository.ProductoxTienda
{
    public interface IProductoxTiendaRepository
    {
        Task<int> Create(Model.ProductoxTienda producto);

        Task<int> Update(Model.ProductoxTienda producto);

        Task<int> Delete(int id);
    }
}
