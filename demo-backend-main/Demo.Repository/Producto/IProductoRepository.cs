using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Repository.Producto
{
    public interface IProductoRepository
    {
        Task<int> Create(Model.Producto producto);

        Task<int> Update(Model.Producto producto);

        Task<int> Delete(int id);
    }
}
