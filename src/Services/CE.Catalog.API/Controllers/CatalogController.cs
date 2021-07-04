using CE.Catalog.API.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CE.Catalog.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CatalogController : Controller
    {
        private readonly IProductRepository _productRepository;

        public CatalogController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        [HttpGet]
        public async Task<IEnumerable<Product>> GetAll()
        {
            return await _productRepository.GetAll();
        }

        [HttpGet("{id}")]
        public async Task<Product> GetById(Guid id)
        {
            return await _productRepository.GetById(id);
        }

        [HttpPost]
        public void Add([FromBody] Product product)
        {
            _productRepository.Add(product);
        }

        [HttpPut]
        public void Put([FromBody] Product product)
        {
            _productRepository.Update(product);
        }
    }
}
