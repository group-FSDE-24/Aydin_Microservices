using ProductWebAPI.Models.Entities;

namespace ProductWebAPI.DbContexts;

public class AppDbContext
{
    public List<Customer> Customers = new List<Customer>()
    {
        new Customer(){Name = "Aydinin Ayaqqabisi" },
        new Customer(){Name = "Coca Cola" },
        new Customer(){Name = "Fanta" },
    };
}
