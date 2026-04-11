using Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductosController : ControllerBase
    {
        private static readonly List<Producto> Productos = new List<Producto>
        {
            new Producto { Id = 1, Nombre = "Comodore 64", Precio = 1200 },
            new Producto { Id = 2, Nombre = "Notepad", Precio = 3500 },
            new Producto { Id = 3, Nombre = "Kindle", Precio = 900 }
        };

        [HttpGet]
        public ActionResult<IEnumerable<Producto>> GetAll()
        {
            return Ok(Productos);
        }

        [HttpGet("{id}")]
        public ActionResult<Producto> GetById(int id)
        {
            var producto = Productos.FirstOrDefault(p => p.Id == id);

            if (producto == null)
            {
                return NotFound(new { mensaje = $"No existe un producto con ID {id}" });
            }

            return Ok(producto);
        }


    }
}