using Application.Services;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace web.Controllers;

[ApiController]
[Route("[controller]")]
public class ProductsController : ControllerBase
{

    private readonly ProductsService _productsService;

    [HttpGet()]
    public ActionResult<List<Product>> Get()
    {
        return _productsService.Get();
    }

    public ProductsController(ProductsService productsService)
    {
        _productsService = productsService;
    }

}
