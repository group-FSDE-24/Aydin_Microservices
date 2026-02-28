using ProductWebAPI.DbContexts;
using ProductWebAPI.Models.Entities;
using ProductWebAPI.Repositories.Abstracts;

namespace ProductWebAPI.Repositories.Concretes;

public class CustomerRepo : ICustomerRepo
{
    private readonly AppDbContext _appDbContext;

    public CustomerRepo(AppDbContext appDbContext)
    {
        _appDbContext = appDbContext;
    }

    public void Add(Customer product)
    {
        _appDbContext.Customers.Add(product);
    }

    public List<Customer> GetAll()
    {
        return _appDbContext.Customers;
    }

    public Customer GetById(int id)
    {
        return _appDbContext.Customers.FirstOrDefault(x => x.Id == id)!;
    }
}
