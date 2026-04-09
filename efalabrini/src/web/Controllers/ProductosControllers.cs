using Microsoft.AspNetCore.Mvc;
using Domain.Entities;


namespace web.Controllers;

[ApiController]
[Route("[controller]")]
public class ProductosControllers : ControllerBase
{
    private readonly ProductoService _productoService; //sin inyeccion de dependencias con new(), es una variable de instancia


    [HttpGet()]
    public ActionResult<List<Producto>> Get()
    {
       return _productoService.Get(); //retorna la lista de productos obtenida del servicio
        
    }

    public ProductosControllers(ProductoService productoService) //constructor que recibe el servicio de productos por inyeccion de dependencias
    {
        _productoService = productoService; //asignamos el servicio a la variable de instancia
    }
}