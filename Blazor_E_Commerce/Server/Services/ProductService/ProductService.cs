﻿using Blazor_E_Commerce.Server.Data;
using Blazor_E_Commerce.Server.Services.CategoryService;
using Blazor_E_Commerce.Shared;
using Microsoft.EntityFrameworkCore;

namespace Blazor_E_Commerce.Server.Services.ProductService;

public class ProductService: IProductService
{
    private readonly ICategoryService _categoryService;
    private readonly DataContext _context;

    public ProductService(ICategoryService categoryService, DataContext context)
    {
        _categoryService = categoryService;
        _context = context;
    }

    public async Task<List<Product>> GetAllProducts()
    {
        return await _context.Products.Include(p => p.Variants).ToListAsync();
    }

    public async Task<Product> GetProduct(int id)
    {
        Product product = await _context.Products
            .Include(p => p.Variants)
            .ThenInclude(v => v.Edition)
            .FirstOrDefaultAsync(p => p.Id == id);

        product.Views++;

        await _context.SaveChangesAsync();

        return product;
    }


    public async Task<List<Product>> GetProductsByCategory(string categoryUrl)
    {
        Category category = await _categoryService.GetCategoryByUrl(categoryUrl);
        return await _context.Products.Include(p => p.Variants).Where(p => p.CategoryId == category.Id).ToListAsync();
    }

    public async Task<List<Product>> SearchProducts(string searchText)
    {
        return await _context.Products
            .Where(p => p.Title.Contains(searchText) || p.Description.Contains(searchText))
            .ToListAsync();
    }
}