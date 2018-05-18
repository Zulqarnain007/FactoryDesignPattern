using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InvoiceInterface;

namespace InvoiceModels
{
    public class InvoiceWithHeader : IInvoice
    {
        public void Print()
        {
            Console.WriteLine("Invoice With Header");
        }
    }
}
