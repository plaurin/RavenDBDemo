using System;

namespace WpfClient.Models
{
    public class OrderLine
    {
        public string Product { get; set; }
        public double Quantity { get; set; }
        public decimal Total { get; set; }
    }
}