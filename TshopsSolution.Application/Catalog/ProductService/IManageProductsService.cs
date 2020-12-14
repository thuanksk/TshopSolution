using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TshopsSolution.Application.Catalog.ProductService.Dtos;
using TshopsSolution.Application.Dtos;

namespace TshopsSolution.Application.Catalog.ProductService
{
    public interface IManageProductsService
    {
        Task<int> Create(ProductCreateRequest request);
        Task<int> Update(ProductEditRequest request);
        Task<int> Delete(int productId);
        Task<List<ProductViewModel>> GetAll();
        Task<PageViewModel<ProductViewModel>> GetAllPaging(string keywork, int pageIndex, int pageSize);

    }
}
