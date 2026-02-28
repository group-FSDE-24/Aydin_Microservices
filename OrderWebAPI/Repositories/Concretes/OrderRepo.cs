using ProductWebAPI.DbContexts;
using ProductWebAPI.Models.Entities;
using ProductWebAPI.Repositories.Abstracts;

namespace ProductWebAPI.Repositories.Concretes;

public class OrderRepo : IOrderRepo
{
    private readonly AppDbContext _appDbContext;

    public OrderRepo(AppDbContext appDbContext)
    {
        _appDbContext = appDbContext;
    }

    public void Add(Order product)
    {
        _appDbContext.Products.Add(product);
    }

    public List<Order> GetAll()
    {
        return _appDbContext.Products;
    }

    public Order GetById(int id)
    {
        return _appDbContext.Products.FirstOrDefault(x => x.Id == id)!;
    }
}
