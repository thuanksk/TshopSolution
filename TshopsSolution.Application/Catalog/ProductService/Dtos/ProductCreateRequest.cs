using System;
using System.Collections.Generic;
using System.Text;

namespace TshopsSolution.Application.Catalog.ProductService.Dtos
{
    public class ProductCreateRequest
    {
        public string Name { set; get; }
        public decimal Price { set; get; }
    }
}
