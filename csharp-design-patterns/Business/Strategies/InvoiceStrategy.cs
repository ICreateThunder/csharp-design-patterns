using csharp_design_patterns.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_design_patterns.Business.Strategies
{
    public abstract class InvoiceStrategy : IInvoiceStrategy
    {
        public abstract void Generate(Order order);

        public string GenerateInvoiceText(Order order)
        {
            StringBuilder sb = new StringBuilder();

            // Invoice Title/Date
            sb.Append(String.Format("[INVOICE]                                                             [ 2023-06-22 ]\n", DateTime.Now.ToString("MM-dd-yyyy")));

            // Invoice vertical spacing
            sb.Append("\n\n\n");

            // Invoice Table Header
            sb.AppendLine("[ DESCRIPTION ]                     | [ QUANTITY ] | [ PRICE ] | [ TAX ] | [ TOTAL ]\n");

            decimal total = 0;

            // Invoice Table Row
            foreach (var item in order.Items)
            {
                decimal tax = item.GetTax(order.Shipping.Destination);
                total += ((item.Price * item.Quantity) + tax);
                sb.AppendLine(String.Format(" {0,-34} | {1,12} | {2,9:C2} | {3,7:C2} | {4,8:C2} ", item.Description, item.Quantity, item.Price, tax, total));
            }

            // Invoice vertical spacing
            sb.AppendLine();
            sb.AppendLine("------------------------------------------------------------------------------------");
            sb.AppendLine(String.Format("                                                                          {0,8:C2} ", total));
            sb.AppendLine("------------------------------------------------------------------------------------\n\n\n");

            return sb.ToString();
        }
    }
}
