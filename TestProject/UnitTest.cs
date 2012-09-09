using System;
using System.Linq;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using Raven.Client;
using Raven.Client.Embedded;

using WpfClient.Models;

namespace TestProject
{
	[TestClass]
	public class UnitTest
	{
		[TestMethod]
		public void TestStoreProduct()
		{
			var documentStore = new EmbeddableDocumentStore { RunInMemory = true };
			documentStore.Initialize();

			using (var session = documentStore.OpenSession())
			{
				var product = new Product
				{
					Name = "Test product",
					Price = 1m
				};

				session.Store(product);
				session.SaveChanges();
			}

		}

		[TestMethod]
		public void TestListProducts()
		{
			var documentStore = new EmbeddableDocumentStore { RunInMemory = true };
			documentStore.Initialize();

			using (var session = documentStore.OpenSession())
			{
				StoreProduct(session, "Product1", 1.25m);
				StoreProduct(session, "Product2", 2.25m);
				StoreProduct(session, "Product3", 3.25m);

				var list = session.Query<Product>().ToList();
				Assert.AreEqual(3, list.Count);
			}
		}

		private static void StoreProduct(IDocumentSession session, string name, decimal price)
		{
			var product = new Product
			{
				Name = name,
				Price = price
			};

			session.Store(product);
			session.SaveChanges();
		}
	}
}
