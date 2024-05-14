using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negozio
{
    internal class StandardDelivery : DeliveryDecorator
    {
        public double Price;
        public StandardDelivery(Consegna tipo) : base(tipo)
        {
            Price = 5.99;
        }

        public override string Delivery()
        {
            return base.Delivery() + " instead standard delivery costs is " + Price;
            //return "Standard delivery costs is " + Price;
        }
        public double Costo()
        {
            return base.Costo() + Price; 
        }
    }
}
