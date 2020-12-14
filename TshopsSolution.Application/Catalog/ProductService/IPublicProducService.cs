using System;
using System.Collections.Generic;
using System.Text;
using TshopsSolution.Application.Catalog.ProductService.Dtos;
using TshopsSolution.Application.Dtos;

namespace TshopsSolution.Application.Catalog.ProductService
{
    public interface IPublicProducService
    {
        PageViewModel<ProductViewModel> GetAllByCategoryId(int categoryID, int pageIndex, int pageSize);

    }
}
