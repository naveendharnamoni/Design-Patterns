using FactoryPattern.Business.Models.Commerce;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern.Business.Models.Shipping
{
    public class ExpressShippingProvider : ShippingProvider
    {
        public override string GenerateShippingLabelFor(Order order)
        {
            return "Express shipping provider";
        }
    }
}
