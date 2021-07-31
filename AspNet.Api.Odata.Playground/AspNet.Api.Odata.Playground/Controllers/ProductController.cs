using AspNet.Api.Odata.Playground.Data.EF;
using AspNet.Api.Odata.Playground.DataGenerators;
using AspNet.Api.Odata.Playground.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AspNet.Api.Odata.Playground.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private DatabaseContext database;

        public ProductController(DatabaseContext database)
        {
            this.database = database ?? throw new ArgumentNullException(nameof(database));
        }

        [HttpGet]
        public IEnumerable<Product> GetProducts()
        {
            return database.Products.ToArray();
        }
    }
}
