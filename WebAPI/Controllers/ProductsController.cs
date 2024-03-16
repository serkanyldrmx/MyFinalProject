using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        //Loosely coupled
        //nameing convention 
        //IoC Container -- Inversion of Controler

        IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        //Ürün Listelemek için 
        [HttpGet("getall")] //Alyans(isim) verdik
        public IActionResult GetAll()
        {
            //Swager
            //Dependency chain --

            var result= _productService.GetAll ();
            if(result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result= _productService.GetById (id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        
        
        //Ürün eklemek için 
        [HttpPost("add")]
        public IActionResult Add(Product product)
        {
            var result = _productService.Add(product);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
