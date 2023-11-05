﻿using Blazor_E_Commerce.Shared;
using System.Net.Http.Json;

namespace Blazor_E_Commerce.Client.Services.CategoryService;

public class CategoryService : ICategoryService
{
	private readonly HttpClient _http;

	public List<Category> Categories { get; set; } = new List<Category>();

	public CategoryService(HttpClient http)
	{
		_http = http;
	}

	public async Task LoadCategories()
	{
		Categories = await _http.GetFromJsonAsync<List<Category>>("api/Category");
	}
}
