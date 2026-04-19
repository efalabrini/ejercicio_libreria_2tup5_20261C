using Domain.Entities;

using Microsoft.AspNetCore.Mvc;

namespace web.Controllers;

[ApiController]
[Route("[controller]")]

public class ProductsController : ControllerBase
{
    [HttpGet()]
    public ActionResult<List<Product>> Get()
    {
        
    }
}