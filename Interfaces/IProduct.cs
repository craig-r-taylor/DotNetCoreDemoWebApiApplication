using DotNetCoreDemoWebApiApplication.Models;
using System.Collections.Generic;

namespace DotNetCoreDemoWebApiApplication.Interfaces
{
    public interface IProduct
    {
        List<Product> GetProducts();
        Product GetProductById(int id);
        Product GetProductByName(string name);

    }
}
