using FactoryPattern.Business.Models.Commerce;
using FactoryPattern.Business.Models.Commerce.Invoice;
using FactoryPattern.Business.Models.Commerce.Summary;
using FactoryPattern.Business.Models.Shipping;

namespace FactoryPattern.Business
{
    public interface IPurchaseProviderFactory
    {
        ShippingProvider CreateShippingProvider(Order order);
        IInvoice CreateInvoice(Order order);
        ISummary CreateSummary(Order order);
    }
}
