using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary
{
    public class ProductRepository
    {
        public ProductRepository(List<Product> products)
        {
            ProductsList = new List<Product>(products);
        }

        private List<Product> ProductsList { get; set; }

        public List<Product> RetrieveActiveProducts()
        {

            return (from product in ProductsList
                    where product.StartDate < product.EndDate
                    select product).ToList();
        }

        public List<Product> RetrieveInactiveProducts()
        {
            return (from product in ProductsList
                    where product.StartDate > product.EndDate
                    select product).ToList();
        }

        public List<Product> RetrieveAllOrderByPriceDescending() 
        {
            var products = new List<Product>();
            
            products = 
                new List<Product>
                ((from product in ProductsList select product).OrderByDescending(Product => Product.Price));

            return products;
        }

        public List<Product> RetrieveAllOrderByPriceAscending()
        {
            var products = new List<Product>();

            products =
                new List<Product>
                ((from product in ProductsList select product).OrderBy(Product => Product.Price));

            return products;
        }

        public List<Product> RetrieveAllByName(string productName)
        {
 
           return (from product in ProductsList where product.Name.Equals(productName) select product).ToList();
        }

        public List<Product> RetrieveAllByDate(DateTime startDate, DateTime endDate)
        {
            var products = new List<Product>();

            products =
                new List<Product>
                ((from product in ProductsList
                  where product.StartDate >= startDate && product.EndDate <= endDate
                  select product));

            return products;
        }
    }
}
