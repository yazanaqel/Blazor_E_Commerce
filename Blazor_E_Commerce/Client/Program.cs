using Blazor_E_Commerce.Client;
using Blazor_E_Commerce.Client.Services.CartService;
using Blazor_E_Commerce.Client.Services.CategoryService;
using Blazor_E_Commerce.Client.Services.ProductService;
using Blazor_E_Commerce.Client.Services.StatsService;
using Blazored.LocalStorage;
using Blazored.Toast;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.Services.AddScoped<IProductService,ProductService>();
builder.Services.AddScoped<ICategoryService, CategoryService>();
builder.Services.AddScoped<ICartService, CartService>();
builder.Services.AddScoped<IStatsService, StatsService>();

builder.Services.AddOptions();
builder.Services.AddAuthorizationCore();
builder.Services.AddScoped<AuthenticationStateProvider, CustomAuthStateProvider>();

builder.Services.AddBlazoredLocalStorage();
builder.Services.AddBlazoredToast();

await builder.Build().RunAsync();
