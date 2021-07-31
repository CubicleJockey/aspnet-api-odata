using AspNet.Api.Odata.Playground.Model;
using Bogus;

namespace AspNet.Api.Odata.Playground.Fakers
{
    public class ProductFaker : Faker<Product>
    {
        public ProductFaker()
        {
            RuleFor(product => product.Id, prop => prop.Random.Guid());
            RuleFor(product => product.Name, prop => prop.Commerce.Product());
            RuleFor(product => product.Description, prop => prop.Lorem.Paragraphs(2));
            RuleFor(product => product.Manufactured, prop => prop.Date.Past());
            RuleFor(product => product.Released, prop => prop.Date.Future());
        }
    }
}
