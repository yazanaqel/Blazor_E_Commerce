using Blazor_E_Commerce.Server.Services.CategoryService;
using Blazor_E_Commerce.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Blazor_E_Commerce.Server.Controllers;
[Route("api/[controller]")]
[ApiController]
public class CategoryController : ControllerBase
{
    private readonly ICategoryService _categoryService;

    public CategoryController(ICategoryService categoryService)
    {
        _categoryService = categoryService;
    }

    [HttpGet]
    public async Task<ActionResult<List<Category>>> GetCategories()
    {
        return Ok(await _categoryService.GetCategories());
    }
}
