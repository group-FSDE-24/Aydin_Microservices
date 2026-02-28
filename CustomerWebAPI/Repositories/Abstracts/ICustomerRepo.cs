using ProductWebAPI.Models.Entities;

namespace ProductWebAPI.Repositories.Abstracts;

public interface ICustomerRepo
{
    List<Customer> GetAll();
    Customer GetById(int id);
    void Add(Customer product);
}
