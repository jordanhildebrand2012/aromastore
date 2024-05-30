using Core.Entities;
using Core.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public class ProductRepository : IProductRepository
    {
        private readonly IGenericRepository<Product> _productRepo;
        private readonly IGenericRepository<ProductBrand> _productBrandRepo;
        private readonly IGenericRepository<ProductType> _productTypeRepo;
        public ProductRepository(
            IGenericRepository<Product> productRepo, IGenericRepository<ProductBrand> productBrandRepo, IGenericRepository<ProductType> productTypeRepo)
        {
            _productRepo = productRepo;
            _productBrandRepo = productBrandRepo;
            _productTypeRepo = productTypeRepo;
        }

        public async Task<Product> GetProductByIdAsync(int id)
        {
            return await _productRepo.GetByIdAsync(id);
        }

        public async Task<IReadOnlyList<Product>> GetProductsAsync()
        {
            return await _productRepo.ListsAllAsync();
        }

        public async Task<IReadOnlyList<ProductBrand>> GetProductsBrandAsync()
        {
            return await _productBrandRepo.ListsAllAsync();
        }

        public async Task<IReadOnlyList<ProductType>> GetProductsTypeAsync()
        {
            return await _productTypeRepo.ListsAllAsync();
        }
    }
}