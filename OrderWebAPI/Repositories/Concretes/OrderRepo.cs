using OrderWebAPI.DbContexts;
using OrderWebAPI.Models.Entities;
using OrderWebAPI.Repositories.Abstracts;

namespace OrderWebAPI.Repositories.Concretes;

public class OrderRepo : IOrderRepo
{
    private readonly AppDbContext _appDbContext;

    public OrderRepo(AppDbContext appDbContext)
    {
        _appDbContext = appDbContext;
    }

    public void Add(Order product)
    {
        _appDbContext.Orders.Add(product);
    }

    public List<Order> GetAll()
    {
        return _appDbContext.Orders;
    }

    public Order GetById(int id)
    {
        return _appDbContext.Orders.FirstOrDefault(x => x.Id == id)!;
    }
}
