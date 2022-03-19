namespace FactoryPattern.Business.Models.Commerce.Invoice
{
    public interface IInvoice
    {
        public byte[] GenerateInvoice();
    }
}
