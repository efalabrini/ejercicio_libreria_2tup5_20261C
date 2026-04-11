using Domain.Entities;
namespace Aplication.Services;

public class ProductService
{
    public List<Product> Get()
    {
        var list = new List<Product>();
        var prod1 = new Product(1,"Disco 1",1000);
        var prod2 = new Product(2,"Disco 2",1300);
        
        list.Add(prod1);
        list.Add(prod2);
        return list;
    }
}