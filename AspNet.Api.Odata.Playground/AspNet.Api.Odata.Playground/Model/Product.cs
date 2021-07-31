using System;

namespace AspNet.Api.Odata.Playground.Model
{
    public class Product
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public DateTime Manufactured { get; set; }
        public DateTime Released { get; set; }
    }
}
