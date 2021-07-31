using AspNet.Api.Odata.Playground.DataGenerators;
using AspNet.Api.Odata.Playground.Model;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace AspNet.Api.Odata.Playground.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Product> GetProducts()
        {
            return SeedData.GenerateProduct(30);
        }
    }
}
