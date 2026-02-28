using Microsoft.AspNetCore.Mvc;
using ProductWebAPI.Models.Entities;
using ProductWebAPI.Repositories.Abstracts;

namespace ProductWebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CustomerController : ControllerBase
{
    private readonly ICustomerRepo _orderRepo;

    public CustomerController(ICustomerRepo orderRepo)
    {
        _orderRepo = orderRepo;
    }

    [HttpGet("GetAllCustomer")]
    public IActionResult GetAllCustomer()
    {
        var result = _orderRepo.GetAll();

        if (result.Count == 0) return NotFound("Depoda mehsul yoxdur");

        return Ok(result);
    }

    [HttpGet("GetCustomerById/{id}")]
    public IActionResult GetCustomerById(int id)
    {
        var result = _orderRepo.GetById(id);


        return result is null ? BadRequest("Product tapilmadi") : Ok(result);
    }

    [HttpPost]
    public IActionResult AddCustomer([FromBody] Customer product)
    {
        _orderRepo.Add(product);
        return Ok("Product elave edildi");
    }
}
