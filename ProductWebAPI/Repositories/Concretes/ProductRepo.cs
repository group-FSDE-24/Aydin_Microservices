using ProductWebAPI.DbContexts;
using ProductWebAPI.Models.Entities;
using ProductWebAPI.Repositories.Abstracts;

namespace ProductWebAPI.Repositories.Concretes;

public class ProductRepo : IProductRepo
{
    private readonly AppDbContext _appDbContext;

    public ProductRepo(AppDbContext appDbContext)
    {
        _appDbContext = appDbContext;
    }

    public void Add(Product product)
    {
        _appDbContext.Products.Add(product);
    }

    public List<Product> GetAll()
    {
        return _appDbContext.Products;
    }

    public Product GetById(int id)
    {
        return _appDbContext.Products.FirstOrDefault(x => x.Id == id)!;
    }
}
