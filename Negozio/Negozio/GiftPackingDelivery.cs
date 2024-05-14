using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negozio
{
    internal class GiftPackingDelivery : DeliveryDecorator
    {
        public double Price;
    
        public GiftPackingDelivery(Consegna tipo) : base(tipo)
        {
            Price = 3.99;          
        }

        public override string Delivery()
        {
            return base.Delivery() + " instead gift packing delivery costs is " + Price;
            //return "Delivery with gift packing costs is " + Price;
        }
        public double Costo()
        {
            return base.Costo() + Price;
        }
    }
}
