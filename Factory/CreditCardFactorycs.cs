using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class CreditCardFactory
    {
        public ICreditCard GetCreditCard(string cardType)
        {
            ICreditCard cardDetails = null;
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
            return cardDetails;
        }
    }
}
