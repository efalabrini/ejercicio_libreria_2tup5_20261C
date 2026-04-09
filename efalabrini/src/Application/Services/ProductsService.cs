using Domain.Entities;

namespace Application.Services;

public class ProductsService
{
    public List<Product> Get()
    {
        var list = new List<Product>();
        var prod1 = new Product(1,"Disco Pepe", 50000);
        var prod2 = new Product(1,"Disco Juan", 60000);

        list.Add(prod1);
        list.Add(prod2);

        return list; 
    }
}