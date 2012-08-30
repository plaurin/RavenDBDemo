using System;
using System.Collections.Generic;

namespace WpfClient.Models
{
    public class Customer
    {
        public Customer()
        {
            this.Addresses = new List<Address>();
        }

        public string Id { get; set; }
        public string Name { get; set; }
        public List<Address> Addresses { get; private set; }
    }
}
