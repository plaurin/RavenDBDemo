using System;
using System.Collections.Generic;
using System.Linq;

using Raven.Client;

using WpfClient.Models;

namespace WpfClient
{
    public class InitRepository
    {
        public static void CreateCustomer(IAsyncDocumentSession session, string name, AddressOptions addressOptions)
        {
            var entity = new Customer { Name = name };

            if (addressOptions == AddressOptions.Home || addressOptions == AddressOptions.HomeAndBusines)
                entity.Addresses.Add(CreateAddress(AddressOptions.Home));

            if (addressOptions == AddressOptions.Business || addressOptions == AddressOptions.HomeAndBusines)
                entity.Addresses.Add(CreateAddress(AddressOptions.Business));

            session.Store(entity);
        }

        public static Address CreateAddress(AddressOptions addressOptions)
        {
            var random = new Random((int)(DateTime.Now.Ticks % Int32.MaxValue));

            return new Address
            {
                Type = addressOptions,
                AddressDesc = random.Next(1000, 10000) + " " + RandomStreet(random.Next()) + ", " + RandomCity(random.Next()) + ", QC",
                PostalCode = RandomPostalCode(random),
                Country = "Canada"
            };
        }

        public static void CreateProduct(IAsyncDocumentSession session, string name, decimal price)
        {
            var entity = new Product { Name = name, Price = price };

            session.Store(entity);
        }

        public static string CreateOrder(IDocumentSession session)
        {
            var random = new Random((int)(DateTime.Now.Ticks % Int32.MaxValue));

            var products = session.Query<Product>().ToList();
            var customers = session.Query<Customer>().ToList();
            if (!customers.Any())
                return "Init required";

            var customer = customers.ElementAt(random.Next() % customers.Count());
            var address = customer.Addresses.SingleOrDefault(a => a.Type == AddressOptions.Home)
                          ?? customer.Addresses.First();

            var order = new Order
            {
                Date = DateTime.Today,
                Customer = customer.Name,
                ShippingAddress = address.AddressDesc + ", " + address.Country + " " + address.PostalCode
            };

            for (var i = 0; i < random.Next(2, 4); i++)
            {
                order.OrderLines.Add(CreateOrderLine(products, random));
            }

            order.GrandTotal = order.OrderLines.Sum(l => l.Total);

            session.Store(order);

            return String.Empty;
        }

        public static OrderLine CreateOrderLine(List<Product> products, Random random)
        {
            var product = products.ElementAt(random.Next() % products.Count());
            var quantity = random.Next(1, 5);
            return new OrderLine
            {
                Product = product.Name,
                Quantity = quantity,
                Total = product.Price * quantity
            };
        }

        private static string RandomStreet(int next)
        {
            switch (next % 4)
            {
                case 0: return "St-Laurent";
                case 1: return "Notre-Dame";
                case 2: return "Principale";
                default: return "Papineau";
            }
        }

        private static string RandomCity(int next)
        {
            switch (next % 3)
            {
                case 0: return "Montréal";
                case 1: return "Laval";
                default: return "Longueuil";
            }
        }

        private static string RandomPostalCode(Random random)
        {
            return "H" + random.Next(0, 9) + (char)random.Next(65, 90) + " "
                + random.Next(0, 9) + (char)random.Next(65, 90) + random.Next(0, 9);
        }
    }
}