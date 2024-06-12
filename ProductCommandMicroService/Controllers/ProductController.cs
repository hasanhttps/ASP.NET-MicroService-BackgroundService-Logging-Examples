using Microsoft.AspNetCore.Mvc;
using ProductCommandMicroService.Repositories.Abstracts;

namespace ProductCommandMicroService.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProductController : ControllerBase {

    // Fields

    private readonly IProductRepository _productRepository;

    // Constructor

    public ProductController(IProductRepository productRepository) { 
        _productRepository = productRepository;
    }

    // Methods

    [HttpGet("GetProductById")] 
    public async Task<IActionResult> GetProductById(int productid) { 
        var result = await _productRepository.GetByIdAsync(productid);
        return Ok(result);
    }

    [HttpGet("GetAllProduct")]
    public async Task<IActionResult> GetAllProduct() {
        var result = await _productRepository.GetAllAsync();
        return Ok(result);
    }
}
