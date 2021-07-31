using AspNet.Api.Odata.Playground.Fakers;
using AspNet.Api.Odata.Playground.Model;
using System.Collections.Generic;

namespace AspNet.Api.Odata.Playground.DataGenerators
{
    public static class SeedData
    {
        /// <summary>
        /// Generate any number of products.
        /// </summary>
        /// <param name="amount">Default amount is 10 products</param>
        /// <returns>Generated products</returns>
        public static IEnumerable<Product> GenerateProduct(int amount = 10)
        {
            var productFakes = new ProductFaker();
            ICollection<Product> products = new List<Product>();

            for(var i = 0; i < amount; i++)
            {
                products.Add(productFakes.Generate());
            }

            return products;
        }
    }
}
