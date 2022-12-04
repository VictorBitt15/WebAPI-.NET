using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Supermarket.API.Domain.Models;
using Supermarket.API.Domain.Repositories;
using Supermarket.API.Domain.Services;

namespace Supermarket.API.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _produtoRepository;

        public ProductService(IProductRepository productRepository)
        {
            _produtoRepository = productRepository;
        }
        public async Task<IEnumerable<Product>> ListAsync()
        {
            return await _produtoRepository.ListAsync();
        }
    }
}