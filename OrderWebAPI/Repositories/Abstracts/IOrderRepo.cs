using OrderWebAPI.Models.Entities;

namespace OrderWebAPI.Repositories.Abstracts;

public interface IOrderRepo
{
    List<Order> GetAll();
    Order GetById(int id);
    void Add(Order product);
}
