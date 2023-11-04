using Blazor_E_Commerce.Shared;

namespace Blazor_E_Commerce.Server.Services.CategoryService;

public interface ICategoryService
{
    Task<List<Category>> GetCategories();

    Task<Category> GetCategoryByUrl(string categoryUrl);
}