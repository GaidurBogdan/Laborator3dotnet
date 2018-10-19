using System;

namespace ClassLibrary
{
    public class Product
    {
        public Product(string name, string description, DateTime startdate, double price, int vat)
        {
            Name = name;
            Description = description;
            StartDate = startdate;
            EndDate = DateTime.Now;
            Price = price;
            VAT = vat;
            Id = Guid.NewGuid();
        }

        public Guid Id { get; private set; }

        public string Name { get; private set; }

        public string Description { get; private set; }
        public DateTime EndDate { get; private set; }
        public DateTime StartDate { get; private set; }
        public double Price { get { return Price; } private set{} }
        public int VAT { get; private set; }

        public double computeVAT()
        {
            return Price * VAT / 100;
        }

        public bool IsValid()
        {
            return EndDate > StartDate;
        }
    }
}
