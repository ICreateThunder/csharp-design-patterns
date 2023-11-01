using csharp_design_patterns.Business.Models;
using csharp_design_patterns.Business.Strategies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_design_patterns
{
    public class Program
    {
        static void Main(string[] args)
        {
            /* [STRATEGY PATTERN]
             * 
             * Components:
             * 
             * - Context     : Able to select which strategy best suits at runtime
             * - IStrategy   : Interface provides layer of abstraction between business logic and lower level implementation
             * - Stategy     : Lower level implementation
             *
             * Demonstration:
             * 
             * - Context     : Order
             * - IStrategy   : IInvoiceStrategy | InvoiceStrategy
             * - Strategy    : FileInvoiceStrategy
             * 
             */

            Item item = new Item("Website", "Development of website", (decimal)300.0, 1, ItemType.Technology);
            ShippingDetails shipping = new ShippingDetails(CountryCode.UK);
            Order order = new Order(0, new List<Item> { item }, shipping, new FileInvoiceStrategy());

            order.Invoice();
        }
    }
}
