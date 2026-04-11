using Application;
using Microsoft.AspNetCore.Mvc;

namespace web.Controllers;

[ApiController]
[Route("[controller]")]

public class ProductosControllers : ControllerBase
{
    [HttpGet("/api/productos")]
    public string ListarProductos()
    {
        return "falta ejercicio 2";
    }
}