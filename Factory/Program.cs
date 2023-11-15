using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class Program
    {
        static void Main(string[] args)
        {
            ICreditCard cardDetails = null;
            Console.WriteLine("Enter card type name");
            string cardType = Console.ReadLine();

            //ICreditCard cardDetails = CreditCardFactory.GetCreditCard("Platinum");

            if (cardType == "Bonus")
            {
                cardDetails = new Bonus();
            }
            else if (cardType == "Visa")
            {
                cardDetails = new Visa();
            }
            else if (cardType == "Platinum")
            {
                cardDetails = new Platinum();
            }
            if (cardDetails != null)
            {
                Console.WriteLine("CardType : " + cardDetails.GetCardType());
                Console.WriteLine("CreditLimit : " + cardDetails.GetCreditLimit());
                Console.WriteLine("AnnualCharge :" + cardDetails.GetAnnualCharge());
            }
            else
            {
                Console.Write("Invalid Card Type");
            }
            Console.ReadLine();
        }
    }
}

