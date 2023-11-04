using Blazor_E_Commerce.Shared;

namespace Blazor_E_Commerce.Client.Services.CartService;

public interface ICartService
{
    event Action OnChange;
    Task AddToCart(CartItem item);
    Task<List<CartItem>> GetCartItems();
    Task DeleteItem(CartItem item);
    Task EmptyCart();
}
