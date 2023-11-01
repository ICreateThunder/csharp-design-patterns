using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_design_patterns.Business.Models
{
    [Flags]
    public enum ItemType
    {
        None = 0b_0000_0000,  // 0
        Food = 0b_0000_0001,  // 1
        Technology = 0b_0000_0010,  // 2
        Consulting = 0b_0000_0100,  // 4
    }

    public class Item
    {
        // Attributes
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public ItemType Type { get; set; }

        // Constructors
        public Item() { }

        public Item(string name, string description, decimal price, int quantity, ItemType type) 
        {
            Name = name;
            Description = description;
            Price = price;
            Quantity = quantity;
            Type = type;
        }

        public Item(Item other)
        {
            Name = other.Name;
            Description = other.Description;
            Price = other.Price;
            Quantity = other.Quantity;
            Type = other.Type;
        }

        // Methods
        public decimal GetTax(CountryCode destination)
        {
            switch (destination)
            {
                case CountryCode.UK:
                    return Price * (decimal)0.20;
                case CountryCode.EU:
                    return Price * (decimal)0.25;
                case CountryCode.USA:
                    return Price * (decimal)0.05;
                default:
                    return 0;
            }

        }
    }
}
