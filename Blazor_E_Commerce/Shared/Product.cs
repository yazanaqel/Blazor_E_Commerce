using System.Text.Json.Serialization;

namespace Blazor_E_Commerce.Shared;

public class Product
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string Image { get; set; } = "https://via.placeholder.com/300x300";
    public bool IsPublic { get; set; }
    public bool IsDeleted { get; set; }
    public DateTime? DateCreated { get; set; } = DateTime.Now;
    public DateTime? DateUpdated { get; set; }
    public int Views { get; set; }

    public Category? Category { get; set; }
    public int CategoryId { get; set; }
    public List<ProductVariant> Variants { get; set; } = new List<ProductVariant>();
}
