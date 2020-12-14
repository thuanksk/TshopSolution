using System;
using System.Collections.Generic;
using System.Text;
using TshopSolution.Data.Entites;
using TshopSolution.Data.EF;
using TshopsSolution.Application.Dtos;
using System.Threading.Tasks;
using TshopsSolution.Application.Catalog.ProductService.Dtos;

namespace TshopsSolution.Application.Catalog.ProductService
{
    public class ManageProductService : IManageProductsService
    {

        private readonly TshopDBcontext _context;
        public ManageProductService(TshopDBcontext context)
        {

            _context = context;
        }
        public async Task<int> Create(ProductCreateRequest request)
        {
            var product = new Product()
            {
                Price = request.Price,
            };
            _context.Products.Add(product);
            return await _context.SaveChangesAsync();
        }

        public async Task<int> Delete(int productId)
        {
            throw new NotImplementedException();
        }

        public async Task<List<ProductViewModel>> GetAll()
        {
            throw new NotImplementedException();
        }

        public async Task<PageViewModel<ProductViewModel>> GetAllPaging(string keywork, int pageIndex, int pageSize)
        {
            throw new NotImplementedException();
        }

        public async Task<int> Update(ProductEditRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
