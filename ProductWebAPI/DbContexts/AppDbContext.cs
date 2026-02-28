using ProductWebAPI.Models.Entities;

namespace ProductWebAPI.DbContexts;

public class AppDbContext
{
    public List<Product> Products = new List<Product>()
    {
        new Product(){Name = "Aydinin Ayaqqabisi" },
        new Product(){Name = "Coca Cola" },
        new Product(){Name = "Fanta" },
    };
}
