using System.Text;

namespace FactoryPattern.Business.Models.Commerce.Invoice
{
    public class GSTInvoice : IInvoice
    {
        public byte[] GenerateInvoice()
        {
            return 
                Encoding
                .Default
                .GetBytes("Hello world from a GST Invoice");
        }
    }
}
