using Demo.Queries.Producto;
using Demo.Queries.ProductoxTienda;
using Demo.Repository.Producto;
using Demo.Repository.ProductoxTienda;
using Microsoft.AspNetCore.Mvc;

namespace Demo.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoxTiendaController:ControllerBase
    {
        private readonly IProductoxTiendaRepository _productoxTiendaRepository;
        private readonly IProductoxTiendaQueries _productoxTiendaQueries;

        public ProductoxTiendaController(IProductoxTiendaRepository productoxTiendaRepository, IProductoxTiendaQueries productoxTiendaQueries)
        {
            _productoxTiendaRepository = productoxTiendaRepository;
            _productoxTiendaQueries = productoxTiendaQueries;
        }

        [HttpGet]
        public async Task<ActionResult> GetAll()
        {
            var result = await _productoxTiendaQueries.GetAll();
            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult> Create([FromBody] Model.ProductoxTienda productoxTienda)
        {
            var result = await _productoxTiendaRepository.Create(productoxTienda);
            return Ok(result);
        }

        [HttpPut]
        public async Task<ActionResult> Update([FromBody] Model.ProductoxTienda productoxTienda)
        {
            var result = await _productoxTiendaRepository.Update(productoxTienda);
            return Ok(result);
        }

        [HttpDelete]
        [Route("{id}")]
        public async Task<ActionResult> Delete([FromRoute] int id)
        {
            var result = await _productoxTiendaRepository.Delete(id);
            return Ok(result);
        }
    }
}
