using Microsoft.AspNetCore.Mvc;
using ProductWebAPI.Models.Entities;
using ProductWebAPI.Repositories.Abstracts;

namespace ProductWebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class OrderController : ControllerBase
{
    private readonly IOrderRepo _orderRepo;

    public OrderController(IOrderRepo orderRepo)
    {
        _orderRepo = orderRepo;
    }

    [HttpGet("GetAllOrder")]
    public IActionResult GetAllOrder()
    {
        var result = _orderRepo.GetAll();

        if (result.Count == 0) return NotFound("Order yoxdur");

        return Ok(result);
    }

    [HttpGet("GetOrderById/{id}")]
    public IActionResult GetOrderById(int id)
    {
        var result = _orderRepo.GetById(id);


        return result is null ? BadRequest("Order tapilmadi") : Ok(result);
    }

    [HttpPost]
    public IActionResult AddOrder([FromBody] Order product)
    {
        _orderRepo.Add(product);
        return Ok("Order elave edildi");
    }
}
