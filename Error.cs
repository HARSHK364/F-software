using solids.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solids
{
    public class Error : PaymentMethod, IDoPayment
    {
        public void DoPaymentProcess(Payment payment)
        {
            Console.WriteLine("Invalid Payment Option");
        }

    }
}
