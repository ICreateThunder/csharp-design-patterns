using csharp_design_patterns.Business.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_design_patterns.Business.Strategies
{
    public class FileInvoiceStrategy : InvoiceStrategy
    {
        public override void Generate(Order order)
        {
            using (var stream = new StreamWriter($"invoice_{Guid.NewGuid()}.txt"))
            {
                stream.Write(GenerateInvoiceText(order));
                stream.Flush();
            }
        }
    }
}
