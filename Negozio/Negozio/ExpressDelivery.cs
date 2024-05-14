using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Negozio
{
    internal class ExpressDelivery : DeliveryDecorator
    {
        public double Price;
       
        public ExpressDelivery(Consegna tipo) : base(tipo)
        {
            Price = 9.99;
        }

        public override string Delivery()
        {
            return base.Delivery() + " instead Express delivery costs is " + Price;
           
        }

        public double Costo()
        {
            return base.Costo() + Price;
        }
    }
}