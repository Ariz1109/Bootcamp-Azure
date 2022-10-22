using Dapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Repository.Producto
{
    public class ProductoRepository:IProductoRepository
    {
        private readonly string _connectionString;

        public ProductoRepository(IConfiguration configuration)
        {
            _connectionString = configuration["ConnectionStrings:SQL"];
        }

        public async Task<int> Create(Model.Producto producto)
        {
            int result;
            var parameters = new DynamicParameters();
            parameters.Add("@Name", producto.Name);
            parameters.Add("@Description", producto.Description);
            parameters.Add("@CategoriaId", producto.CategoriaId);
            parameters.Add("@MarcaId", producto.MarcaId);
            parameters.Add("@State", 1);

            using (var connection = new SqlConnection(_connectionString))
            {
                result = await connection.ExecuteAsync("[dbo].[Usp_Ins_Producto]", parameters, commandType: CommandType.StoredProcedure);
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
                result = await connection.ExecuteAsync("[dbo].[Usp_Del_Producto]", parameters, commandType: CommandType.StoredProcedure);
            }

            return result;
        }

        public async Task<int> Update(Model.Producto producto)
        {
            int result;
            var parameters = new DynamicParameters();
            parameters.Add("@Name", producto.Name);
            parameters.Add("@Description", producto.Description);
            parameters.Add("@Photo", "none");
            parameters.Add("@CategoriaId", producto.CategoriaId);
            parameters.Add("@MarcaId", producto.MarcaId);
            parameters.Add("@State", 1);

            using (var connection = new SqlConnection(_connectionString))
            {
                result = await connection.ExecuteAsync("[dbo].[Usp_Upd_Producto]", parameters, commandType: CommandType.StoredProcedure);
            }

            return result;
        }
    }
}
