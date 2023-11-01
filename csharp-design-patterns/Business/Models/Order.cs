using csharp_design_patterns.Business.Strategies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_design_patterns.Business.Models
{
    public class Order
    {
        // Attributes
        public int Id { get; set; }
        public List<Item> Items { get; set; }
        public ShippingDetails Shipping {  get; set; }
        public IInvoiceStrategy InvoiceStrategy { get; set; }

        // Constructor
        public Order() { }

        public Order(int id, List<Item> items, ShippingDetails shipping, IInvoiceStrategy invoiceStrategy)
        {
            Id = id;
            Items = items;
            Shipping = shipping;
            InvoiceStrategy = invoiceStrategy;
        }

        public Order(Order other)
        {
            Items = other.Items;
            Shipping = other.Shipping;
            InvoiceStrategy = other.InvoiceStrategy;
        }

        // Methods
        public void Invoice()
        {
            InvoiceStrategy.Generate(this);
        }
    }
}
