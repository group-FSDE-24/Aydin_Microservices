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

    [HttpGet("GetAll")]
    public IActionResult GetAll()
    {
        var result = _orderRepo.GetAll();

        if (result.Count == 0) return NotFound("Depoda mehsul yoxdur");

        return Ok(result);
    }

    [HttpGet("GetById/{id}")]
    public IActionResult GetById(int id)
    {
        var result = _orderRepo.GetById(id);


        return result is null ? BadRequest("Product tapilmadi") : Ok(result);
    }

    [HttpPost]
    public IActionResult AddOrder([FromBody] Order product)
    {
        _orderRepo.Add(product);
        return Ok("Product elave edildi");
    }
}
