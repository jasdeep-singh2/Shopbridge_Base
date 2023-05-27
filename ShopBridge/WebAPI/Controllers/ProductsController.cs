using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace WebAPI.Controllers
{
    public class ProductsController : BaseAPIController
    {
        private readonly DataContext _dataContext;
        public ProductsController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetProducts()
        {
            return await _dataContext.Products.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetProduct(Guid id)
        {
            return await _dataContext.Products.FindAsync(id);
        }

    }
}
