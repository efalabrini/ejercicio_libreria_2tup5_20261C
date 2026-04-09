namespace Application.Services;


public class ProductoService
{
    public List<Producto> Get()
    {
       var list =  new List<Producto>() //creamos una lista de productos
       var prod1 = new Producto(1, "Disco Pepe", 50000); //creamos un producto con sus atributos
       var prod2 = new Producto(1, "Disco Juan", 60000);

       list.Add(prod1); //agregamos el producto a la lista
       list.Add(prod2);

       return list; //retornamos la lista de productos
        
    }
}