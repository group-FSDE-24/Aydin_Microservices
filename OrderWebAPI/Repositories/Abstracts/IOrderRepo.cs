using ProductWebAPI.Models.Entities;

namespace ProductWebAPI.Repositories.Abstracts;

public interface IOrderRepo
{
    List<Order> GetAll();
    Order GetById(int id);
    void Add(Order product);
}
