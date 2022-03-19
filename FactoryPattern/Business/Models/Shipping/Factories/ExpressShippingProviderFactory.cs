using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern.Business.Models.Shipping.Factories
{
    public class ExpressShippingProviderFactory : ShippingProviderFactory
    {
        public override ShippingProvider CreateShippingProvider(string country)
        {
            return new ExpressShippingProvider();
        }
    }
}
