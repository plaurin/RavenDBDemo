﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Data.EntityClient;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml.Serialization;

[assembly: EdmSchemaAttribute()]
#region EDM Relationship Metadata

[assembly: EdmRelationshipAttribute("Model1", "CustomerAddress", "Customer", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(DatabaseDemo.Customer), "Address", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(DatabaseDemo.Address))]
[assembly: EdmRelationshipAttribute("Model1", "OrderAddress", "Order", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(DatabaseDemo.Order), "Address", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(DatabaseDemo.Address))]
[assembly: EdmRelationshipAttribute("Model1", "OrderCustomer", "Order", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(DatabaseDemo.Order), "Customer", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(DatabaseDemo.Customer))]
[assembly: EdmRelationshipAttribute("Model1", "OrderLineProduct", "OrderLine", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(DatabaseDemo.OrderLine), "Product", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(DatabaseDemo.Product))]
[assembly: EdmRelationshipAttribute("Model1", "OrderOrderLine", "Order", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(DatabaseDemo.Order), "OrderLine", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(DatabaseDemo.OrderLine))]

#endregion

namespace DatabaseDemo
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class Model1Container : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new Model1Container object using the connection string found in the 'Model1Container' section of the application configuration file.
        /// </summary>
        public Model1Container() : base("name=Model1Container", "Model1Container")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new Model1Container object.
        /// </summary>
        public Model1Container(string connectionString) : base(connectionString, "Model1Container")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new Model1Container object.
        /// </summary>
        public Model1Container(EntityConnection connection) : base(connection, "Model1Container")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Product> Products
        {
            get
            {
                if ((_Products == null))
                {
                    _Products = base.CreateObjectSet<Product>("Products");
                }
                return _Products;
            }
        }
        private ObjectSet<Product> _Products;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Order> Orders
        {
            get
            {
                if ((_Orders == null))
                {
                    _Orders = base.CreateObjectSet<Order>("Orders");
                }
                return _Orders;
            }
        }
        private ObjectSet<Order> _Orders;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Address> Addresses
        {
            get
            {
                if ((_Addresses == null))
                {
                    _Addresses = base.CreateObjectSet<Address>("Addresses");
                }
                return _Addresses;
            }
        }
        private ObjectSet<Address> _Addresses;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Customer> Customers
        {
            get
            {
                if ((_Customers == null))
                {
                    _Customers = base.CreateObjectSet<Customer>("Customers");
                }
                return _Customers;
            }
        }
        private ObjectSet<Customer> _Customers;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<OrderLine> OrderLines
        {
            get
            {
                if ((_OrderLines == null))
                {
                    _OrderLines = base.CreateObjectSet<OrderLine>("OrderLines");
                }
                return _OrderLines;
            }
        }
        private ObjectSet<OrderLine> _OrderLines;

        #endregion

        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Products EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToProducts(Product product)
        {
            base.AddObject("Products", product);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Orders EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToOrders(Order order)
        {
            base.AddObject("Orders", order);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Addresses EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToAddresses(Address address)
        {
            base.AddObject("Addresses", address);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Customers EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToCustomers(Customer customer)
        {
            base.AddObject("Customers", customer);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the OrderLines EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToOrderLines(OrderLine orderLine)
        {
            base.AddObject("OrderLines", orderLine);
        }

        #endregion

    }

    #endregion

    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="Model1", Name="Address")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Address : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Address object.
        /// </summary>
        /// <param name="id">Initial value of the Id property.</param>
        /// <param name="number">Initial value of the Number property.</param>
        /// <param name="streetName">Initial value of the StreetName property.</param>
        /// <param name="city">Initial value of the City property.</param>
        /// <param name="province">Initial value of the Province property.</param>
        /// <param name="country">Initial value of the Country property.</param>
        /// <param name="postalCode">Initial value of the PostalCode property.</param>
        /// <param name="addressType">Initial value of the AddressType property.</param>
        public static Address CreateAddress(global::System.Int32 id, global::System.String number, global::System.String streetName, global::System.String city, global::System.String province, global::System.String country, global::System.String postalCode, global::System.String addressType)
        {
            Address address = new Address();
            address.Id = id;
            address.Number = number;
            address.StreetName = streetName;
            address.City = city;
            address.Province = province;
            address.Country = country;
            address.PostalCode = postalCode;
            address.AddressType = addressType;
            return address;
        }

        #endregion

        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.Int32 _Id;
        partial void OnIdChanging(global::System.Int32 value);
        partial void OnIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Number
        {
            get
            {
                return _Number;
            }
            set
            {
                OnNumberChanging(value);
                ReportPropertyChanging("Number");
                _Number = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Number");
                OnNumberChanged();
            }
        }
        private global::System.String _Number;
        partial void OnNumberChanging(global::System.String value);
        partial void OnNumberChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String StreetName
        {
            get
            {
                return _StreetName;
            }
            set
            {
                OnStreetNameChanging(value);
                ReportPropertyChanging("StreetName");
                _StreetName = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("StreetName");
                OnStreetNameChanged();
            }
        }
        private global::System.String _StreetName;
        partial void OnStreetNameChanging(global::System.String value);
        partial void OnStreetNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String City
        {
            get
            {
                return _City;
            }
            set
            {
                OnCityChanging(value);
                ReportPropertyChanging("City");
                _City = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("City");
                OnCityChanged();
            }
        }
        private global::System.String _City;
        partial void OnCityChanging(global::System.String value);
        partial void OnCityChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Province
        {
            get
            {
                return _Province;
            }
            set
            {
                OnProvinceChanging(value);
                ReportPropertyChanging("Province");
                _Province = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Province");
                OnProvinceChanged();
            }
        }
        private global::System.String _Province;
        partial void OnProvinceChanging(global::System.String value);
        partial void OnProvinceChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Country
        {
            get
            {
                return _Country;
            }
            set
            {
                OnCountryChanging(value);
                ReportPropertyChanging("Country");
                _Country = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Country");
                OnCountryChanged();
            }
        }
        private global::System.String _Country;
        partial void OnCountryChanging(global::System.String value);
        partial void OnCountryChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String PostalCode
        {
            get
            {
                return _PostalCode;
            }
            set
            {
                OnPostalCodeChanging(value);
                ReportPropertyChanging("PostalCode");
                _PostalCode = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("PostalCode");
                OnPostalCodeChanged();
            }
        }
        private global::System.String _PostalCode;
        partial void OnPostalCodeChanging(global::System.String value);
        partial void OnPostalCodeChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String AddressType
        {
            get
            {
                return _AddressType;
            }
            set
            {
                OnAddressTypeChanging(value);
                ReportPropertyChanging("AddressType");
                _AddressType = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("AddressType");
                OnAddressTypeChanged();
            }
        }
        private global::System.String _AddressType;
        partial void OnAddressTypeChanging(global::System.String value);
        partial void OnAddressTypeChanged();

        #endregion

    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("Model1", "CustomerAddress", "Customer")]
        public Customer Customer
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Customer>("Model1.CustomerAddress", "Customer").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Customer>("Model1.CustomerAddress", "Customer").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<Customer> CustomerReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Customer>("Model1.CustomerAddress", "Customer");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Customer>("Model1.CustomerAddress", "Customer", value);
                }
            }
        }
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("Model1", "OrderAddress", "Order")]
        public Order Order
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Order>("Model1.OrderAddress", "Order").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Order>("Model1.OrderAddress", "Order").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<Order> OrderReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Order>("Model1.OrderAddress", "Order");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Order>("Model1.OrderAddress", "Order", value);
                }
            }
        }

        #endregion

    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="Model1", Name="Customer")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Customer : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Customer object.
        /// </summary>
        /// <param name="id">Initial value of the Id property.</param>
        /// <param name="name">Initial value of the Name property.</param>
        public static Customer CreateCustomer(global::System.Int32 id, global::System.String name)
        {
            Customer customer = new Customer();
            customer.Id = id;
            customer.Name = name;
            return customer;
        }

        #endregion

        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.Int32 _Id;
        partial void OnIdChanging(global::System.Int32 value);
        partial void OnIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Name
        {
            get
            {
                return _Name;
            }
            set
            {
                OnNameChanging(value);
                ReportPropertyChanging("Name");
                _Name = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Name");
                OnNameChanged();
            }
        }
        private global::System.String _Name;
        partial void OnNameChanging(global::System.String value);
        partial void OnNameChanged();

        #endregion

    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("Model1", "CustomerAddress", "Address")]
        public EntityCollection<Address> Addresses
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<Address>("Model1.CustomerAddress", "Address");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<Address>("Model1.CustomerAddress", "Address", value);
                }
            }
        }

        #endregion

    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="Model1", Name="Order")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Order : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Order object.
        /// </summary>
        /// <param name="id">Initial value of the Id property.</param>
        /// <param name="date">Initial value of the Date property.</param>
        public static Order CreateOrder(global::System.Int32 id, global::System.String date)
        {
            Order order = new Order();
            order.Id = id;
            order.Date = date;
            return order;
        }

        #endregion

        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.Int32 _Id;
        partial void OnIdChanging(global::System.Int32 value);
        partial void OnIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Date
        {
            get
            {
                return _Date;
            }
            set
            {
                OnDateChanging(value);
                ReportPropertyChanging("Date");
                _Date = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Date");
                OnDateChanged();
            }
        }
        private global::System.String _Date;
        partial void OnDateChanging(global::System.String value);
        partial void OnDateChanged();

        #endregion

    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("Model1", "OrderAddress", "Address")]
        public Address ShippingAddress
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Address>("Model1.OrderAddress", "Address").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Address>("Model1.OrderAddress", "Address").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<Address> ShippingAddressReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Address>("Model1.OrderAddress", "Address");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Address>("Model1.OrderAddress", "Address", value);
                }
            }
        }
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("Model1", "OrderCustomer", "Customer")]
        public Customer Customer
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Customer>("Model1.OrderCustomer", "Customer").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Customer>("Model1.OrderCustomer", "Customer").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<Customer> CustomerReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Customer>("Model1.OrderCustomer", "Customer");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Customer>("Model1.OrderCustomer", "Customer", value);
                }
            }
        }
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("Model1", "OrderOrderLine", "OrderLine")]
        public EntityCollection<OrderLine> OrderLines
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<OrderLine>("Model1.OrderOrderLine", "OrderLine");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<OrderLine>("Model1.OrderOrderLine", "OrderLine", value);
                }
            }
        }

        #endregion

    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="Model1", Name="OrderLine")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class OrderLine : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new OrderLine object.
        /// </summary>
        /// <param name="id">Initial value of the Id property.</param>
        /// <param name="quantity">Initial value of the Quantity property.</param>
        public static OrderLine CreateOrderLine(global::System.Int32 id, global::System.String quantity)
        {
            OrderLine orderLine = new OrderLine();
            orderLine.Id = id;
            orderLine.Quantity = quantity;
            return orderLine;
        }

        #endregion

        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.Int32 _Id;
        partial void OnIdChanging(global::System.Int32 value);
        partial void OnIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Quantity
        {
            get
            {
                return _Quantity;
            }
            set
            {
                OnQuantityChanging(value);
                ReportPropertyChanging("Quantity");
                _Quantity = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Quantity");
                OnQuantityChanged();
            }
        }
        private global::System.String _Quantity;
        partial void OnQuantityChanging(global::System.String value);
        partial void OnQuantityChanged();

        #endregion

    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("Model1", "OrderLineProduct", "Product")]
        public Product Product
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Product>("Model1.OrderLineProduct", "Product").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Product>("Model1.OrderLineProduct", "Product").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<Product> ProductReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Product>("Model1.OrderLineProduct", "Product");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Product>("Model1.OrderLineProduct", "Product", value);
                }
            }
        }
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("Model1", "OrderOrderLine", "Order")]
        public Order Order
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Order>("Model1.OrderOrderLine", "Order").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Order>("Model1.OrderOrderLine", "Order").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<Order> OrderReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Order>("Model1.OrderOrderLine", "Order");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Order>("Model1.OrderOrderLine", "Order", value);
                }
            }
        }

        #endregion

    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="Model1", Name="Product")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Product : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Product object.
        /// </summary>
        /// <param name="id">Initial value of the Id property.</param>
        /// <param name="name">Initial value of the Name property.</param>
        /// <param name="price">Initial value of the Price property.</param>
        public static Product CreateProduct(global::System.Int32 id, global::System.String name, global::System.String price)
        {
            Product product = new Product();
            product.Id = id;
            product.Name = name;
            product.Price = price;
            return product;
        }

        #endregion

        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.Int32 _Id;
        partial void OnIdChanging(global::System.Int32 value);
        partial void OnIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Name
        {
            get
            {
                return _Name;
            }
            set
            {
                OnNameChanging(value);
                ReportPropertyChanging("Name");
                _Name = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Name");
                OnNameChanged();
            }
        }
        private global::System.String _Name;
        partial void OnNameChanging(global::System.String value);
        partial void OnNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Price
        {
            get
            {
                return _Price;
            }
            set
            {
                OnPriceChanging(value);
                ReportPropertyChanging("Price");
                _Price = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Price");
                OnPriceChanged();
            }
        }
        private global::System.String _Price;
        partial void OnPriceChanging(global::System.String value);
        partial void OnPriceChanged();

        #endregion

    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("Model1", "OrderLineProduct", "OrderLine")]
        public OrderLine OrderLine
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<OrderLine>("Model1.OrderLineProduct", "OrderLine").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<OrderLine>("Model1.OrderLineProduct", "OrderLine").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<OrderLine> OrderLineReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<OrderLine>("Model1.OrderLineProduct", "OrderLine");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<OrderLine>("Model1.OrderLineProduct", "OrderLine", value);
                }
            }
        }

        #endregion

    }

    #endregion

    
}
