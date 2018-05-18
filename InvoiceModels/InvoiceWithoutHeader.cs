using InvoiceInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceModels
{
    public class InvoiceWithoutHeader : IInvoice
    {
        public void Print()
        {
            Console.WriteLine("Invoice With Header");
        }
    }
}
