using Microsoft.AspNetCore.Mvc;
using ProductWebAPI.Models.Entities;
using ProductWebAPI.Repositories.Abstracts;

namespace ProductWebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProductController : ControllerBase
{
    private readonly IProductRepo _productRepo;

    public ProductController(IProductRepo productRepo)
    {
        _productRepo = productRepo;
    }

    [HttpGet("GetAllProduct")]
    public IActionResult GetAllProduct()
    {
        var result = _productRepo.GetAll();

        if (result.Count == 0) return NotFound("Depoda mehsul yoxdur");

        return Ok(result);
    }

    [HttpGet("GetProductById/{id}")]
    public IActionResult GetProductById(int id)
    {
        var result = _productRepo.GetById(id);


        return result is null ? BadRequest("Product tapilmadi") : Ok(result);
    }

    [HttpPost("AddProduct")]
    public IActionResult AddProduct([FromBody] Product product)
    {
        _productRepo.Add(product);
        return Ok("Product elave edildi");
    }
}
