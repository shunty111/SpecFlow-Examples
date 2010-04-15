﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.4927
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

[assembly: global::System.Data.Objects.DataClasses.EdmSchemaAttribute()]
[assembly: global::System.Data.Objects.DataClasses.EdmRelationshipAttribute("BookShopModel", "FK_OrderLines_Books", "Book", global::System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(Bookshop.Models.Book), "OrderLines", global::System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(Bookshop.Models.OrderLine))]
[assembly: global::System.Data.Objects.DataClasses.EdmRelationshipAttribute("BookShopModel", "FK_OrderLines_Orders", "Orders", global::System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(Bookshop.Models.Order), "OrderLines", global::System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(Bookshop.Models.OrderLine))]

// Original file name:
// Generation date: 4/15/2010 3:56:27 PM
namespace Bookshop.Models
{
    
    /// <summary>
    /// There are no comments for BookShopEntities in the schema.
    /// </summary>
    public partial class BookShopEntities : global::System.Data.Objects.ObjectContext
    {
        /// <summary>
        /// Initializes a new BookShopEntities object using the connection string found in the 'BookShopEntities' section of the application configuration file.
        /// </summary>
        public BookShopEntities() : 
                base("name=BookShopEntities", "BookShopEntities")
        {
            this.OnContextCreated();
        }
        /// <summary>
        /// Initialize a new BookShopEntities object.
        /// </summary>
        public BookShopEntities(string connectionString) : 
                base(connectionString, "BookShopEntities")
        {
            this.OnContextCreated();
        }
        /// <summary>
        /// Initialize a new BookShopEntities object.
        /// </summary>
        public BookShopEntities(global::System.Data.EntityClient.EntityConnection connection) : 
                base(connection, "BookShopEntities")
        {
            this.OnContextCreated();
        }
        partial void OnContextCreated();
        /// <summary>
        /// There are no comments for Books in the schema.
        /// </summary>
        public global::System.Data.Objects.ObjectQuery<Book> Books
        {
            get
            {
                if ((this._Books == null))
                {
                    this._Books = base.CreateQuery<Book>("[Books]");
                }
                return this._Books;
            }
        }
        private global::System.Data.Objects.ObjectQuery<Book> _Books;
        /// <summary>
        /// There are no comments for OrderLines in the schema.
        /// </summary>
        public global::System.Data.Objects.ObjectQuery<OrderLine> OrderLines
        {
            get
            {
                if ((this._OrderLines == null))
                {
                    this._OrderLines = base.CreateQuery<OrderLine>("[OrderLines]");
                }
                return this._OrderLines;
            }
        }
        private global::System.Data.Objects.ObjectQuery<OrderLine> _OrderLines;
        /// <summary>
        /// There are no comments for Orders in the schema.
        /// </summary>
        public global::System.Data.Objects.ObjectQuery<Order> Orders
        {
            get
            {
                if ((this._Orders == null))
                {
                    this._Orders = base.CreateQuery<Order>("[Orders]");
                }
                return this._Orders;
            }
        }
        private global::System.Data.Objects.ObjectQuery<Order> _Orders;
        /// <summary>
        /// There are no comments for Books in the schema.
        /// </summary>
        public void AddToBooks(Book book)
        {
            base.AddObject("Books", book);
        }
        /// <summary>
        /// There are no comments for OrderLines in the schema.
        /// </summary>
        public void AddToOrderLines(OrderLine orderLine)
        {
            base.AddObject("OrderLines", orderLine);
        }
        /// <summary>
        /// There are no comments for Orders in the schema.
        /// </summary>
        public void AddToOrders(Order order)
        {
            base.AddObject("Orders", order);
        }
    }
    /// <summary>
    /// There are no comments for BookShopModel.Book in the schema.
    /// </summary>
    /// <KeyProperties>
    /// Id
    /// </KeyProperties>
    [global::System.Data.Objects.DataClasses.EdmEntityTypeAttribute(NamespaceName="BookShopModel", Name="Book")]
    [global::System.Runtime.Serialization.DataContractAttribute(IsReference=true)]
    [global::System.Serializable()]
    public partial class Book : global::System.Data.Objects.DataClasses.EntityObject
    {
        /// <summary>
        /// Create a new Book object.
        /// </summary>
        /// <param name="id">Initial value of Id.</param>
        /// <param name="author">Initial value of Author.</param>
        /// <param name="title">Initial value of Title.</param>
        /// <param name="price">Initial value of Price.</param>
        public static Book CreateBook(int id, string author, string title, decimal price)
        {
            Book book = new Book();
            book.Id = id;
            book.Author = author;
            book.Title = title;
            book.Price = price;
            return book;
        }
        /// <summary>
        /// There are no comments for Property Id in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public int Id
        {
            get
            {
                return this._Id;
            }
            set
            {
                this.OnIdChanging(value);
                this.ReportPropertyChanging("Id");
                this._Id = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value);
                this.ReportPropertyChanged("Id");
                this.OnIdChanged();
            }
        }
        private int _Id;
        partial void OnIdChanging(int value);
        partial void OnIdChanged();
        /// <summary>
        /// There are no comments for Property Author in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(IsNullable=false)]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public string Author
        {
            get
            {
                return this._Author;
            }
            set
            {
                this.OnAuthorChanging(value);
                this.ReportPropertyChanging("Author");
                this._Author = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value, false);
                this.ReportPropertyChanged("Author");
                this.OnAuthorChanged();
            }
        }
        private string _Author;
        partial void OnAuthorChanging(string value);
        partial void OnAuthorChanged();
        /// <summary>
        /// There are no comments for Property Title in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(IsNullable=false)]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public string Title
        {
            get
            {
                return this._Title;
            }
            set
            {
                this.OnTitleChanging(value);
                this.ReportPropertyChanging("Title");
                this._Title = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value, false);
                this.ReportPropertyChanged("Title");
                this.OnTitleChanged();
            }
        }
        private string _Title;
        partial void OnTitleChanging(string value);
        partial void OnTitleChanged();
        /// <summary>
        /// There are no comments for Property Price in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(IsNullable=false)]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public decimal Price
        {
            get
            {
                return this._Price;
            }
            set
            {
                this.OnPriceChanging(value);
                this.ReportPropertyChanging("Price");
                this._Price = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value);
                this.ReportPropertyChanged("Price");
                this.OnPriceChanged();
            }
        }
        private decimal _Price;
        partial void OnPriceChanging(decimal value);
        partial void OnPriceChanged();
        /// <summary>
        /// There are no comments for OrderLines in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmRelationshipNavigationPropertyAttribute("BookShopModel", "FK_OrderLines_Books", "OrderLines")]
        [global::System.Xml.Serialization.XmlIgnoreAttribute()]
        [global::System.Xml.Serialization.SoapIgnoreAttribute()]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public global::System.Data.Objects.DataClasses.EntityCollection<OrderLine> OrderLines
        {
            get
            {
                return ((global::System.Data.Objects.DataClasses.IEntityWithRelationships)(this)).RelationshipManager.GetRelatedCollection<OrderLine>("BookShopModel.FK_OrderLines_Books", "OrderLines");
            }
            set
            {
                if ((value != null))
                {
                    ((global::System.Data.Objects.DataClasses.IEntityWithRelationships)(this)).RelationshipManager.InitializeRelatedCollection<OrderLine>("BookShopModel.FK_OrderLines_Books", "OrderLines", value);
                }
            }
        }
    }
    /// <summary>
    /// There are no comments for BookShopModel.OrderLine in the schema.
    /// </summary>
    /// <KeyProperties>
    /// BookId
    /// OrderId
    /// </KeyProperties>
    [global::System.Data.Objects.DataClasses.EdmEntityTypeAttribute(NamespaceName="BookShopModel", Name="OrderLine")]
    [global::System.Runtime.Serialization.DataContractAttribute(IsReference=true)]
    [global::System.Serializable()]
    public partial class OrderLine : global::System.Data.Objects.DataClasses.EntityObject
    {
        /// <summary>
        /// Create a new OrderLine object.
        /// </summary>
        /// <param name="bookId">Initial value of BookId.</param>
        /// <param name="orderId">Initial value of OrderId.</param>
        /// <param name="quantity">Initial value of Quantity.</param>
        public static OrderLine CreateOrderLine(int bookId, int orderId, int quantity)
        {
            OrderLine orderLine = new OrderLine();
            orderLine.BookId = bookId;
            orderLine.OrderId = orderId;
            orderLine.Quantity = quantity;
            return orderLine;
        }
        /// <summary>
        /// There are no comments for Property BookId in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public int BookId
        {
            get
            {
                return this._BookId;
            }
            set
            {
                this.OnBookIdChanging(value);
                this.ReportPropertyChanging("BookId");
                this._BookId = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value);
                this.ReportPropertyChanged("BookId");
                this.OnBookIdChanged();
            }
        }
        private int _BookId;
        partial void OnBookIdChanging(int value);
        partial void OnBookIdChanged();
        /// <summary>
        /// There are no comments for Property OrderId in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public int OrderId
        {
            get
            {
                return this._OrderId;
            }
            set
            {
                this.OnOrderIdChanging(value);
                this.ReportPropertyChanging("OrderId");
                this._OrderId = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value);
                this.ReportPropertyChanged("OrderId");
                this.OnOrderIdChanged();
            }
        }
        private int _OrderId;
        partial void OnOrderIdChanging(int value);
        partial void OnOrderIdChanged();
        /// <summary>
        /// There are no comments for Property Quantity in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(IsNullable=false)]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public int Quantity
        {
            get
            {
                return this._Quantity;
            }
            set
            {
                this.OnQuantityChanging(value);
                this.ReportPropertyChanging("Quantity");
                this._Quantity = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value);
                this.ReportPropertyChanged("Quantity");
                this.OnQuantityChanged();
            }
        }
        private int _Quantity;
        partial void OnQuantityChanging(int value);
        partial void OnQuantityChanged();
        /// <summary>
        /// There are no comments for Book in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmRelationshipNavigationPropertyAttribute("BookShopModel", "FK_OrderLines_Books", "Book")]
        [global::System.Xml.Serialization.XmlIgnoreAttribute()]
        [global::System.Xml.Serialization.SoapIgnoreAttribute()]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public Book Book
        {
            get
            {
                return ((global::System.Data.Objects.DataClasses.IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Book>("BookShopModel.FK_OrderLines_Books", "Book").Value;
            }
            set
            {
                ((global::System.Data.Objects.DataClasses.IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Book>("BookShopModel.FK_OrderLines_Books", "Book").Value = value;
            }
        }
        /// <summary>
        /// There are no comments for Book in the schema.
        /// </summary>
        [global::System.ComponentModel.BrowsableAttribute(false)]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public global::System.Data.Objects.DataClasses.EntityReference<Book> BookReference
        {
            get
            {
                return ((global::System.Data.Objects.DataClasses.IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Book>("BookShopModel.FK_OrderLines_Books", "Book");
            }
            set
            {
                if ((value != null))
                {
                    ((global::System.Data.Objects.DataClasses.IEntityWithRelationships)(this)).RelationshipManager.InitializeRelatedReference<Book>("BookShopModel.FK_OrderLines_Books", "Book", value);
                }
            }
        }
        /// <summary>
        /// There are no comments for Order in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmRelationshipNavigationPropertyAttribute("BookShopModel", "FK_OrderLines_Orders", "Orders")]
        [global::System.Xml.Serialization.XmlIgnoreAttribute()]
        [global::System.Xml.Serialization.SoapIgnoreAttribute()]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public Order Order
        {
            get
            {
                return ((global::System.Data.Objects.DataClasses.IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Order>("BookShopModel.FK_OrderLines_Orders", "Orders").Value;
            }
            set
            {
                ((global::System.Data.Objects.DataClasses.IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Order>("BookShopModel.FK_OrderLines_Orders", "Orders").Value = value;
            }
        }
        /// <summary>
        /// There are no comments for Order in the schema.
        /// </summary>
        [global::System.ComponentModel.BrowsableAttribute(false)]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public global::System.Data.Objects.DataClasses.EntityReference<Order> OrderReference
        {
            get
            {
                return ((global::System.Data.Objects.DataClasses.IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Order>("BookShopModel.FK_OrderLines_Orders", "Orders");
            }
            set
            {
                if ((value != null))
                {
                    ((global::System.Data.Objects.DataClasses.IEntityWithRelationships)(this)).RelationshipManager.InitializeRelatedReference<Order>("BookShopModel.FK_OrderLines_Orders", "Orders", value);
                }
            }
        }
    }
    /// <summary>
    /// There are no comments for BookShopModel.Order in the schema.
    /// </summary>
    /// <KeyProperties>
    /// Id
    /// </KeyProperties>
    [global::System.Data.Objects.DataClasses.EdmEntityTypeAttribute(NamespaceName="BookShopModel", Name="Order")]
    [global::System.Runtime.Serialization.DataContractAttribute(IsReference=true)]
    [global::System.Serializable()]
    public partial class Order : global::System.Data.Objects.DataClasses.EntityObject
    {
        /// <summary>
        /// Create a new Order object.
        /// </summary>
        /// <param name="id">Initial value of Id.</param>
        /// <param name="price">Initial value of Price.</param>
        /// <param name="status">Initial value of Status.</param>
        public static Order CreateOrder(int id, decimal price, string status)
        {
            Order order = new Order();
            order.Id = id;
            order.Price = price;
            order.Status = status;
            return order;
        }
        /// <summary>
        /// There are no comments for Property Id in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public int Id
        {
            get
            {
                return this._Id;
            }
            set
            {
                this.OnIdChanging(value);
                this.ReportPropertyChanging("Id");
                this._Id = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value);
                this.ReportPropertyChanged("Id");
                this.OnIdChanged();
            }
        }
        private int _Id;
        partial void OnIdChanging(int value);
        partial void OnIdChanged();
        /// <summary>
        /// There are no comments for Property Price in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(IsNullable=false)]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public decimal Price
        {
            get
            {
                return this._Price;
            }
            set
            {
                this.OnPriceChanging(value);
                this.ReportPropertyChanging("Price");
                this._Price = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value);
                this.ReportPropertyChanged("Price");
                this.OnPriceChanged();
            }
        }
        private decimal _Price;
        partial void OnPriceChanging(decimal value);
        partial void OnPriceChanged();
        /// <summary>
        /// There are no comments for Property Status in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(IsNullable=false)]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public string Status
        {
            get
            {
                return this._Status;
            }
            set
            {
                this.OnStatusChanging(value);
                this.ReportPropertyChanging("Status");
                this._Status = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value, false);
                this.ReportPropertyChanged("Status");
                this.OnStatusChanged();
            }
        }
        private string _Status;
        partial void OnStatusChanging(string value);
        partial void OnStatusChanged();
        /// <summary>
        /// There are no comments for OrderLines in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmRelationshipNavigationPropertyAttribute("BookShopModel", "FK_OrderLines_Orders", "OrderLines")]
        [global::System.Xml.Serialization.XmlIgnoreAttribute()]
        [global::System.Xml.Serialization.SoapIgnoreAttribute()]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public global::System.Data.Objects.DataClasses.EntityCollection<OrderLine> OrderLines
        {
            get
            {
                return ((global::System.Data.Objects.DataClasses.IEntityWithRelationships)(this)).RelationshipManager.GetRelatedCollection<OrderLine>("BookShopModel.FK_OrderLines_Orders", "OrderLines");
            }
            set
            {
                if ((value != null))
                {
                    ((global::System.Data.Objects.DataClasses.IEntityWithRelationships)(this)).RelationshipManager.InitializeRelatedCollection<OrderLine>("BookShopModel.FK_OrderLines_Orders", "OrderLines", value);
                }
            }
        }
    }
}
