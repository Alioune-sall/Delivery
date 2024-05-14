using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negozio
{
    internal class DeliveryBaseTakeaway : Consegna
    {
        public double Price = 0;
        public override string Delivery()
        {
            return "The takeaway is free";
        }

        public override double Costo()
        {
            return Price;
        }
    }
}
