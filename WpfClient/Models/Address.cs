using System;

namespace WpfClient.Models
{
    public class Address
    {
        public AddressOptions Type { get; set; }
        public string AddressDesc { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
    }

    public enum AddressOptions
    {
        None,
        Home,
        Business,
        HomeAndBusines
    }
}