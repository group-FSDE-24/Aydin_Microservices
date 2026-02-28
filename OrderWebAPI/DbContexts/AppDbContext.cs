using OrderWebAPI.Models.Entities;

namespace OrderWebAPI.DbContexts;

public class AppDbContext
{
    public List<Order> Orders = new List<Order>()
    {
        new Order(){Name = "Aydinin Ayaqqabisi" },
        new Order(){Name = "Coca Cola" },
        new Order(){Name = "Fanta" },
    };
}
