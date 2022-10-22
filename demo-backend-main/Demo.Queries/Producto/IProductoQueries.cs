using Demo.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Queries.Producto
{
    public interface IProductoQueries
    {
        //Task<PersonByIdViewModel> GetById(int id);
        Task<IEnumerable<ProductoViewModel>> GetAll();
    }
}
