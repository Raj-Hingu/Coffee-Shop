using CoffeeShop.Models.Interfaces;

namespace CoffeeShop.Models.Services
{
    public class ProductRepository : IProductRepository
    {
        private List<Product> ProductsList = new List<Product>()
        {
            new Product{Id =1, Name = "Americano", Price = 25 , Detail = "A freshly pulled shots of espresso with hot water to achieve the size of a standard cup of brewed coffee.", ImageUrl="../images/Americano.png" },
            new Product{Id =2, Name = "Mocha", Price = 30 , Detail = "A freshly pulled shots of espresso with hot water to achieve the size of a standard cup of brewed coffee.", ImageUrl= "../images/Americano.png" },
            new Product{Id =3, Name = "Cafe au Lait", Price = 35 , Detail = "A freshly pulled shots of espresso with hot water to achieve the size of a standard cup of brewed coffee.", ImageUrl="../images/Americano.png" },

        };
        public IEnumerable<Product> GetAllProducts()
        {
            return ProductsList;
        }

        public Product GetProductDetail(int id)
        {
            return ProductsList.FirstOrDefault(p => p.Id == id);
        }

        public IEnumerable<Product> GetTrendingProducts()
        {
            return ProductsList.Where(p => p.IsTrendingProduct);
        }
    }
}
