using DataAccessLayer;
using DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.IServices;

namespace Onion_Architecture.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;

        }

        [HttpGet("GetAll")]

        public async Task<ActionResult<IEnumerable<ProductReadDTO>>> GetAll()
        {
            var products = await _productService.GetAll(); 
            return Ok(products);
        }


        [HttpGet("GetById/{id}")]

        public async Task<ActionResult<ProductReadDTO>> GetById(int id)
        {
            var Product = await _productService.GetById(id);
            return Ok(Product);
        }

        [HttpPost("Add")]

        public async Task<ActionResult<ProductCreateDTO>> AddProduct(ProductCreateDTO productCreateDTO)
        {
            var createdProduct = await _productService.Add(productCreateDTO);
            return Ok(createdProduct);
        }

        [HttpPut("Update")]

        public async Task<ActionResult<ProductReadDTO>> UpdateProduct(ProductUpdateDTO productUpdateDTO)
        {
            var updateProduct = await _productService.Update(productUpdateDTO);
            return Ok(updateProduct);
        }

        [HttpDelete("Delete/{id}")]

        public async Task<bool> Delete(int id)
        {
            var product = await _productService.DeleteById(id);
            return true;
        }
    } 
}