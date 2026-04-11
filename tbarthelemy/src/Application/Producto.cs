namespace Application;

public class Producto
{
    public int Id { get; set; }

    public string Nombre { get; set; }

    public float Precio { get; set; }

    public static List<Producto> listaProducto = new List<Producto>();

    public static void AddProducto(Producto producto)
    {
        listaProducto.Add(producto);
    }
    public static List<Producto> ListProduct()
    {
        return listaProducto;
    }
}