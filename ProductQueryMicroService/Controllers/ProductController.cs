using Microsoft.AspNetCore.Mvc;
using ProductQueryMicroService.Entities.Concretes;
using ProductQueryMicroService.Repositories.Abstracts;

namespace ProductQueryMicroService.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProductController : ControllerBase {
    
    // Field

    private readonly IProductRepository _productRepository;

    //Constructor

    public ProductController(IProductRepository productRepository) {
        _productRepository = productRepository;
    }

    // Methods

    [HttpPost("AddProduct")]
    public async Task<IActionResult> AddProduct([FromBody] Product product) {
        await _productRepository.AddAsync(product);
        return Ok("Ugurla Elave edildi.");
    }

    [HttpDelete("DeleteProduct")]
    public async Task<IActionResult> DeleteProduct(int productid) {

        await _productRepository.DeleteAsync(productid);
        return Ok("Ugurla silindi.");
    }

    [HttpPost("UpdateProduct")]
    public async Task<IActionResult> UpdateProduct([FromBody] Product product) {
        await _productRepository.Update(product);
        return Ok("Ugurla Elave edildi.");
    }
}
