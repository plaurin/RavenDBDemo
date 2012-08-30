using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

using Raven.Client.Document;

using WpfClient.Models;

namespace WpfClient
{
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        #region Init

        private void InitButtonClick(object sender, RoutedEventArgs e)
        {
            this.ErrorMessage.Content = string.Empty;

            var documentStore = new DocumentStore { Url = "http://asus:8081/" };
            documentStore.Initialize();

            using (var session = documentStore.OpenAsyncSession())
            {
                InitRepository.CreateCustomer(session, "Guy Barette", AddressOptions.HomeAndBusines);
                InitRepository.CreateCustomer(session, "Mario Cardinal", AddressOptions.Home);
                InitRepository.CreateCustomer(session, "Pascal Laurin", AddressOptions.Business);

                InitRepository.CreateProduct(session, "NuGet", 45.67m);
                InitRepository.CreateProduct(session, "Topshelf", 38.41m);
                InitRepository.CreateProduct(session, "Git-tf", 52.89m);

                session.SaveChangesAsync();
            }
        }

        private void ClearButtonClick(object sender, RoutedEventArgs e)
        {
            this.ErrorMessage.Content = string.Empty;

            var documentStore = new DocumentStore { Url = "http://asus:8081/" };
            documentStore.Initialize();

            using (var session = documentStore.OpenSession())
            {
                foreach (var customer in session.Query<Customer>()) session.Delete(customer);
                foreach (var product in session.Query<Product>()) session.Delete(product);
                foreach (var order in session.Query<Order>()) session.Delete(order);

                session.SaveChanges();
            }
        }

        private void CreateOrderButtonClick(object sender, RoutedEventArgs e)
        {
            this.ErrorMessage.Content = string.Empty;

            var documentStore = new DocumentStore { Url = "http://asus:8081/" };
            documentStore.Initialize();

            using (var session = documentStore.OpenSession())
            {
                var msg = InitRepository.CreateOrder(session);

                if (string.IsNullOrWhiteSpace(msg))
                    session.SaveChanges();
                else 
                    this.ErrorMessage.Content = msg;
            }
        }

        #endregion

        #region CRUD

        private void CreateButtonClick(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(this.CreateProductNameTextBox.Text))
            {
                decimal price;
                if (decimal.TryParse(CreateProductPriceTextBox.Text, out price))
                {
                    CreateProduct(this.CreateProductNameTextBox.Text, price);

                    ErrorMessage.Content = string.Empty;
                }
                else
                {
                    ErrorMessage.Content = "Price";
                }
            }
            else
            {
                ErrorMessage.Content = "Name";
            }
        }

        private void SearchButtonClick(object sender, RoutedEventArgs e)
        {
            var name = this.ReadProductNameTextBox.Text;
            
            decimal price;
            var result = decimal.TryParse(this.ReadProductPriceTextBox.Text, out price) 
                ? SearchProduct(name, price) 
                : SearchProduct(name, null);

            ReadProductResultListBox.Items.Clear();
            foreach (var product in result)
            {
                ReadProductResultListBox.Items.Add(product.Name);
            }

            ErrorMessage.Content = string.Empty;
        }

        private void UpdateFetchButtonClick(object sender, RoutedEventArgs e)
        {
            var documentStore = new DocumentStore { Url = "http://asus:8081/" };
            documentStore.Initialize();

            using (var session = documentStore.OpenSession())
            {
                UpdateProductFetchListBox.Items.Clear();
                foreach (var product in session.Query<Product>())
                {
                    UpdateProductFetchListBox.Items.Add(product);
                }
            }
        }

        private void UpdateProductFetchListBoxSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var product = e.AddedItems.OfType<Product>().FirstOrDefault();
            if (product != null)
            {
                this.UpdateProductNameTextBox.Text = product.Name;
                this.UpdateProductPriceTextBox.Text = product.Price.ToString(CultureInfo.InvariantCulture);
            }
            else
            {
                this.UpdateProductNameTextBox.Text = string.Empty;
                this.UpdateProductPriceTextBox.Text = string.Empty;
            }
        }

        private void UpdateButtonClick(object sender, RoutedEventArgs e)
        {
            var product = this.UpdateProductFetchListBox.SelectedItems.OfType<Product>().FirstOrDefault();
            if (product != null)
            {
                if (!string.IsNullOrWhiteSpace(this.UpdateProductNameTextBox.Text))
                {
                    decimal price;
                    if (decimal.TryParse(UpdateProductPriceTextBox.Text, out price))
                    {
                        UpdateProduct(product.Id, this.UpdateProductNameTextBox.Text, price);

                        ErrorMessage.Content = string.Empty;
                    }
                    else
                    {
                        ErrorMessage.Content = "Price";
                    }
                }
                else
                {
                    ErrorMessage.Content = "Name";
                }
            }
            else
            {
                ErrorMessage.Content = "No selection";
            }
        }

        private void DeleteFetchButtonClick(object sender, RoutedEventArgs e)
        {
            var documentStore = new DocumentStore { Url = "http://asus:8081/" };
            documentStore.Initialize();

            using (var session = documentStore.OpenSession())
            {
                DeleteProductFetchListBox.Items.Clear();
                foreach (var product in session.Query<Product>())
                {
                    DeleteProductFetchListBox.Items.Add(product);
                }
            }
        }

        private void DeleteButtonClick(object sender, RoutedEventArgs e)
        {
            var product = this.DeleteProductFetchListBox.SelectedItems.OfType<Product>().FirstOrDefault();
            if (product != null)
            {
                DeleteProduct(product.Id);
            }
            else
            {
                ErrorMessage.Content = "No selection";
            }
        }

        #endregion

        private static void CreateProduct(string name, decimal price)
        {
            var documentStore = new DocumentStore { Url = "http://asus:8081/" };
            documentStore.Initialize();

            using (var session = documentStore.OpenSession())
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

        private static IEnumerable<Product> SearchProduct(string name, decimal? price)
        {
            var documentStore = new DocumentStore { Url = "http://asus:8081/" };
            documentStore.Initialize();

            using (var session = documentStore.OpenSession())
            {
                IQueryable<Product> query = session.Query<Product>();

                if (!string.IsNullOrWhiteSpace(name)) 
                    query = query.Where(product => product.Name.StartsWith(name));

                if (price != null)
                    query = query.Where(product => product.Price > price);

                return query;
            }
        }

        private static void UpdateProduct(long productId, string name, decimal price)
        {
            var documentStore = new DocumentStore { Url = "http://asus:8081/" };
            documentStore.Initialize();

            using (var session = documentStore.OpenSession())
            {
                var product = session.Load<Product>(productId);

                product.Name = name;
                product.Price = price;

                session.Store(product);
                session.SaveChanges();
            }
        }

        private static void DeleteProduct(long productId)
        {
            var documentStore = new DocumentStore { Url = "http://asus:8081/" };
            documentStore.Initialize();

            using (var session = documentStore.OpenSession())
            {
                var product = session.Load<Product>(productId);

                session.Delete(product);
                session.SaveChanges();
            }
        }
    }
}
