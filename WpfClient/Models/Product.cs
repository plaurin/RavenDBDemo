using System;

namespace WpfClient.Models
{
    public class Product
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        public override string ToString()
        {
            return "Id: " + Id + ", Name: " + Name + ", Price: " + Price;
        }
    }
}