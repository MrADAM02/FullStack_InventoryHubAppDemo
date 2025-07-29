using ServerApp.Models;

var builder = WebApplication.CreateBuilder(args);

// Add CORS policy
builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(policy =>
    {
        policy.AllowAnyOrigin()
              .AllowAnyHeader()
              .AllowAnyMethod();
    });
});

var app = builder.Build();

app.UseCors();


var productList = new List<Product>
{
    new()
    {
        Id = 1,
        Name = "Laptop",
        Price = 1200.50,
        Stock = 25,
        Category = new Category { Id = 101, Name = "Electronics" }
    },
    new()
    {
        Id = 2,
        Name = "Headphones",
        Price = 50.00,
        Stock = 100,
        Category = new Category { Id = 102, Name = "Accessories" }
    }
};

app.MapGet("/api/productlist", () => productList);


app.Run();

