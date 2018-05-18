using InvoiceInterface;
using FactoryInvoice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            int invoiceType = 0;
            IInvoice obj;
            Console.WriteLine("Enter the Invoice Type.");
            invoiceType = Convert.ToInt16(Console.ReadLine());
            obj = FactoryInvoices.GetInvoice(invoiceType);
            obj.Print();

            Console.ReadKey();
        }
    }
}
