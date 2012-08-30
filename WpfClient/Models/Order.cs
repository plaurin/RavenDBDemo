using System;
using System.Collections.Generic;

namespace WpfClient.Models
{
    public class Order
    {
        public Order()
        {
            this.OrderLines = new List<OrderLine>();
        }

        public long Id { get; set; }
        public DateTime Date { get; set; }
        public string Customer { get; set; }
        public string ShippingAddress { get; set; }
        public decimal GrandTotal { get; set; }
        public List<OrderLine> OrderLines { get; private set; }
    }
}