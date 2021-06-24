using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProductApp.Application.Interfaces.Repositories;

namespace ProductApp.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository productRepository;
        public ProductController(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            //var list = await productRepository.GetAllAsync();
            return Ok("list");
        }
    }
}
