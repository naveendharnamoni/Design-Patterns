using FactoryPattern.Business.Models.Commerce;
using FactoryPattern.Business.Models.Commerce.Invoice;
using FactoryPattern.Business.Models.Commerce.Summary;
using FactoryPattern.Business.Models.Shipping;
using FactoryPattern.Business.Models.Shipping.Factories;

namespace FactoryPattern.Business
{
    public class SwedenPurchaseProviderFactory : IPurchaseProviderFactory
    {
        public IInvoice CreateInvoice(Order order)
        {
            if(order.Recipient.Country != order.Sender.Country)
            {
                return new NoVATInvoice();
            }

            return new VATInvoice();    
        }

        public ShippingProvider CreateShippingProvider(Order order)
        {
            ShippingProviderFactory shippingProviderFactory;

            if(order.Sender.Country != order.Recipient.Country)
            {
                shippingProviderFactory = new GlobalExpressShippingProviderFactory();
            }
            else
            {
                shippingProviderFactory = new StandardShippingProviderFactory();
            }

            return shippingProviderFactory.GetShippingProvider(order.Sender.Country);
        }

        public ISummary CreateSummary(Order order)
        {
            // Translate email to Swedish
            return new EmailSummary();
        }
    }
}
