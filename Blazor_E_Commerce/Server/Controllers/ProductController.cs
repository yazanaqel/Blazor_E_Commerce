using Blazor_E_Commerce.Server.Services.ProductService;
using Blazor_E_Commerce.Shared;
using Microsoft.AspNetCore.Mvc;

namespace Blazor_E_Commerce.Server.Controllers;
[ApiController]
[Route("api/[controller]")]
public class ProductController : ControllerBase
{

    private readonly IProductService _productService;

    public ProductController(IProductService productService)
    {
        _productService = productService;
    }

    [HttpGet]
    public async Task<ActionResult<List<Product>>> GetAllProducts()
    {
        return Ok(await _productService.GetAllProducts());
    }

    [HttpGet("Category/{categoryUrl}")]
    public async Task<ActionResult<List<Product>>> GetProductsByCategory(string categoryUrl)
    {
        return Ok(await _productService.GetProductsByCategory(categoryUrl));
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Product>> GetProduct(int id)
    {
        return Ok(await _productService.GetProduct(id));
    }

    [HttpGet("Search/{searchText}")]
    public async Task<ActionResult<List<Product>>> SearchProducts(string searchText)
    {
        return Ok(await _productService.SearchProducts(searchText));
    }
}
