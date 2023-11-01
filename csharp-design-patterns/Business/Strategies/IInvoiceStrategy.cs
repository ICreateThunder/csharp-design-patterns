using csharp_design_patterns.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_design_patterns.Business.Strategies
{
    public interface IInvoiceStrategy
    {
        void Generate(Order order);
    }
}
