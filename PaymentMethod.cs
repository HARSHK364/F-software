using solids.Interface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solids
{
    public class PaymentMethod
    {
        public static IDoPayment Create(string paymentMethod)
        {
            switch (paymentMethod)
            {
                case "Card":
                    return new CardPayment();
                case "Upi":
                    return new UpiPayment();
                case "Yono":
                    return new YonoPayment();
                default:
                    return new Error();
                   break;

            }
        }

      
    }
}