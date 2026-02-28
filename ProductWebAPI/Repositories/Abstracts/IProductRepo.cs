using ProductWebAPI.Models.Entities;

namespace ProductWebAPI.Repositories.Abstracts;

public interface IProductRepo
{
    List<Product> GetAll();
    Product GetById(int id);
    void Add(Product product);
}
