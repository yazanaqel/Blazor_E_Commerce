using Blazor_E_Commerce.Shared;

namespace Blazor_E_Commerce.Client.Services.CategoryService;

public interface ICategoryService
{
    List<Category> Categories { get; set; }
    Task LoadCategories();
}
