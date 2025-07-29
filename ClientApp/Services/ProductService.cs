using System.Text.Json;
using static ClientApp.Pages.FetchProducts;

namespace ClientApp.Services;

public class ProductService
{
    private readonly HttpClient _http;

    public ProductService(HttpClient http)
    {
        _http = http;
    }

    public async Task<Product[]?> GetProductsAsync()
    {
        try
        {
            var response = await _http.GetAsync("api/productlist");
            response.EnsureSuccessStatusCode();

            var json = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<Product[]>(json, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            });
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Fetch error: {ex.Message}");
            return null;
        }
    }
}