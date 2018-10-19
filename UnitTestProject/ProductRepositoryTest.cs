using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace ProductRepositoryTest
{
    [TestClass]
    public class ProductRepositoryTest
    {
        private ClassLibrary.ProductRepository  productRepository;

        [TestInitialize]
        public void Initialize()
        {
            var productsList = new List<ClassLibrary.Product>();

            var product1 = new ClassLibrary.Product("Parfum", "Este un parfum", System.DateTime.Now.AddDays(-2), 450, 25);
            var product2 = new ClassLibrary.Product("Bicicleta", "Este scumpa", System.DateTime.Now.AddDays(-4), 320, 25);
            var product3 = new ClassLibrary.Product("Morcovi", "E legume", System.DateTime.Now.AddDays(-5), 320, 25);
            var product4 = new ClassLibrary.Product("Pat", "Este un pat de apa", System.DateTime.Now.AddDays(-2), 320, 25);
            var product5 = new ClassLibrary.Product("Salam", "Este expirat", System.DateTime.Now.AddDays(2), 320, 25);
            var product6 = new ClassLibrary.Product("calculator", "Are tastatura", System.DateTime.Now.AddDays(-10), 320, 25);
            var product7 = new ClassLibrary.Product("Mouse", "Nu are fir", System.DateTime.Now.AddDays(-11), 320, 25);
            var product8 = new ClassLibrary.Product("Scaun", "Are 4 picioare", System.DateTime.Now.AddDays(-12), 320, 25);
            var product9 = new ClassLibrary.Product("Birou", "Este in centru", System.DateTime.Now.AddDays(-20), 320, 25);
            var product10 = new ClassLibrary.Product("Camera", "Nu are obiectiv", System.DateTime.Now.AddDays(-22), 320, 25);
            var product11 = new ClassLibrary.Product("Ceapa", "Este iute", System.DateTime.Now.AddDays(-44), 100, 25);

            productsList.Add(product1);
            productsList.Add(product2);
            productsList.Add(product3);
            productsList.Add(product4);
            productsList.Add(product6);
            productsList.Add(product7);
            productsList.Add(product8);
            productsList.Add(product9);
            productsList.Add(product10);
            productsList.Add(product11);



            productRepository = new ClassLibrary.ProductRepository(productsList);
        }

        [TestMethod]
        public void When_RetrieveActiveProducts_ShouldReturn10Products()
        {
            Assert.IsTrue(productRepository.RetrieveActiveProducts().Count == 10);
        }

        [TestMethod]
        public void When_RetrieveInactiveProducts_ShouldReturn0Products()
        {
            Assert.IsTrue(productRepository.RetrieveInactiveProducts().Count == 0);
        }

        [TestMethod]
        public void When_RetireveAllByName_WhenNameIsFound()
        {
            Assert.IsTrue(productRepository.RetrieveAllByName("Bicicleta").Count == 1);
        }

        [TestMethod]
        public void When_RetrievingAllByDate_ShouldFind_2()
        {
            Assert.IsTrue(productRepository.RetrieveAllByDate(System.DateTime.Now.AddDays(-1),System.DateTime.Now.AddDays(1)).Count == 0);
        }

    }
}
