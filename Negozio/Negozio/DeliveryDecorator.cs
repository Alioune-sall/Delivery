using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negozio
{
    internal class DeliveryDecorator : Consegna
    {
        public Consegna _type;
        public double Price = 0;

        public DeliveryDecorator(Consegna type)
        {
            _type = type;
        }

        public override string Delivery()
        {
           return _type.Delivery();
        }


        public override double Costo()
        {
            return Price;
        }

    }
}
