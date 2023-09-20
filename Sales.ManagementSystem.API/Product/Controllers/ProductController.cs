using Microsoft.AspNetCore.Mvc;
using Sales.ManagementSystem.Shared.Product.InputModels;

namespace Sales.ManagementSystem.API.Product.Controllers;


[Route("api/[controller]")]
[ApiController]
public class ProductController : ControllerBase
{
    public ProductController()
    {
        
    }

    [HttpPost]
    public async Task<IActionResult> NewProduct([FromBody] CreateProductInputModel model)
    {
        return Ok();
    }
}