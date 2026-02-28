using ProductWebAPI.Models.Entities;

namespace ProductWebAPI.DbContexts;

public class AppDbContext
{
    public List<Order> Products = new List<Order>()
    {
        new Order(){Name = "Aydinin Ayaqqabisi" },
        new Order(){Name = "Coca Cola" },
        new Order(){Name = "Fanta" },
    };
}
