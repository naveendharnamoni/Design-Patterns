using FactoryPattern.Business.Models.Commerce;
using FactoryPattern.Business.Models.Commerce.Invoice;
using FactoryPattern.Business.Models.Commerce.Summary;
using FactoryPattern.Business.Models.Shipping;
using FactoryPattern.Business.Models.Shipping.Factories;

namespace FactoryPattern.Business
{
    public class AustraliaPurchaseProviderFactory : IPurchaseProviderFactory
    {
        public IInvoice CreateInvoice(Order order)
        {
            return new GSTInvoice();
        }

        public ShippingProvider CreateShippingProvider(Order order)
        {
            var shippingProviderFactory = new StandardShippingProviderFactory();

            return shippingProviderFactory.GetShippingProvider(order.Sender.Country);
        }

        public ISummary CreateSummary(Order order)
        {
            return new CsvSummary();
        }
    }
}
