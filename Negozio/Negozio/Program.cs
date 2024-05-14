using System.Security.Cryptography.X509Certificates;

namespace Negozio
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var consegna = new DeliveryBaseTakeaway();
           
            while (true)
            {
                
                Console.WriteLine("inserisci \n 1 per asport \n 2 per Srandart delivery\n 3 per Express delivery\n altro per uscire\n Effettua una scelta ");
                int  scelta = int.Parse(Console.ReadLine());
                
                if ( scelta == 1)
                {
                    Console.WriteLine(consegna.Delivery());
                }
                else if ( scelta == 2) 
                {
                    var consegna1 = new StandardDelivery(consegna);
                    Console.WriteLine(consegna1.Delivery());
                }
                else if ( scelta == 3)
                {
                    var consegna2 = new ExpressDelivery(consegna);
                    Console.WriteLine(consegna2.Delivery());
                }
                else if ( scelta == 4)
                {
                    var consegna3 = new GiftPackingDelivery(consegna);
                    Console.WriteLine(consegna3.Delivery());
                }
                else
                {
                    break;
                }
            }
        }
    }
}
