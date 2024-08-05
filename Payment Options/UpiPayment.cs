using solids.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solids
{
    public class UpiPayment : PaymentGateway, IUpiPayment
    {
        public void UpiPaymentProcess(Payment payment)
        {
            DoPaymentProcess(payment);
        }

        public override void DoPaymentProcess(Payment payment)
        {
            Console.WriteLine("Processing Upi Payment");
            Console.WriteLine("Transaction successfull");
        }
    }
}


  