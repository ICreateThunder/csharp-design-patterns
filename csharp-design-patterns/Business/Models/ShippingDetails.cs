using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_design_patterns.Business.Models
{
    [Flags]
    public enum CountryCode
    {
        None = 0b_0000_0000,
        UK = 0b_0000_0001, 
        EU = 0b_0000_0010, 
        USA = 0b_0000_0100
    }

    public class ShippingDetails
    {
        // Attributes
        public CountryCode Destination {  get; set; }

        // Constructors
        public ShippingDetails() { }

        public ShippingDetails(CountryCode destination) 
        {
            Destination = destination;
        }

        public ShippingDetails(ShippingDetails other)
        {
            Destination = other.Destination;
        }

    }
}
