using InvoiceInterface;
using InvoiceModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryInvoice
{
    public class FactoryInvoices
    {
        static public IInvoice GetInvoice(int invoiceType)
        {
            IInvoice objInvoice;

            if (invoiceType == 1)
            {
                objInvoice = new InvoiceWithHeader();

            }
            else if (invoiceType == 2)
            {
                objInvoice = new InvoiceWithoutHeader();
            }
            else
            {
                return null;
            }
            return objInvoice;
        }
    }
}
