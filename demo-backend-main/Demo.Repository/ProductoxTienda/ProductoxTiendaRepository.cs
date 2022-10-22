using Dapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Repository.ProductoxTienda
{
    public class ProductoxTiendaRepository:IProductoxTiendaRepository
    {
        private readonly string _connectionString;

        public ProductoxTiendaRepository(IConfiguration configuration)
        {
            _connectionString = configuration["ConnectionStrings:SQL"];
        }

        public async Task<int> Create(Model.ProductoxTienda productoxTienda)
        {
            int result;
            var parameters = new DynamicParameters();
            parameters.Add("@Stock", productoxTienda.Stock);
            parameters.Add("@Prize", productoxTienda.Prize);
            parameters.Add("@ProductoId", productoxTienda.ProductoId);
            parameters.Add("@TiendaId", productoxTienda.TiendaId);
            parameters.Add("@State", 2);

            using (var connection = new SqlConnection(_connectionString))
            {
                result = await connection.ExecuteAsync("[dbo].[Usp_Ins_ProductoxTienda]", parameters, commandType: CommandType.StoredProcedure);
            }

            return result;
        }

        public async Task<int> Delete(int id)
        {
            int result;
            var parameters = new DynamicParameters();
            parameters.Add("@Id", id);

            using (var connection = new SqlConnection(_connectionString))
            {
                result = await connection.ExecuteAsync("[dbo].[Usp_Del_ProductoxTienda]", parameters, commandType: CommandType.StoredProcedure);
            }

            return result;
        }

        public async Task<int> Update(Model.ProductoxTienda productoxTienda)
        {
            int result;
            var parameters = new DynamicParameters();
            parameters.Add("@Name", productoxTienda.Stock);
            parameters.Add("@Description", productoxTienda.Prize);
            parameters.Add("@ProductoId", productoxTienda.ProductoId);
            parameters.Add("@TiendaId", productoxTienda.TiendaId);
            parameters.Add("@State", productoxTienda.State);

            using (var connection = new SqlConnection(_connectionString))
            {
                result = await connection.ExecuteAsync("[dbo].[Usp_Upd_Producto]", parameters, commandType: CommandType.StoredProcedure);
            }

            return result;
        }
    }
}
