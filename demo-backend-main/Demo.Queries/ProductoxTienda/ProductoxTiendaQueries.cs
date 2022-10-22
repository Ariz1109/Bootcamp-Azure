using Demo.ViewModel;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace Demo.Queries.ProductoxTienda
{
    public class ProductoxTiendaQueries:IProductoxTiendaQueries
    {
        private readonly string _connectionString;

        public ProductoxTiendaQueries(IConfiguration configuration)
        {
            _connectionString = configuration["ConnectionStrings:SQL"];
        }

        public async Task<IEnumerable<ProductoxTiendaViewModel>> GetAll()
        {
            IEnumerable<ProductoxTiendaViewModel> result = new List<ProductoxTiendaViewModel>();

            using (var connection = new SqlConnection(_connectionString))
            {
                result = await connection.QueryAsync<ProductoxTiendaViewModel>("[dbo].[Usp_Sel_ProductoxTienda]", commandType: CommandType.StoredProcedure);
            }

            return result;
        }
    }
}
