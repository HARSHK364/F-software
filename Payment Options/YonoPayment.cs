using solids.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solids
{
    public class YonoPayment : PaymentGateway, IYonoPayment
    {
        public void YonoPaymentProcess(Payment payment)
        {
            DoPaymentProcess(payment);
        }

        public override void DoPaymentProcess(Payment payment)
        {
            Console.WriteLine("Processing Card Payment");
            Console.WriteLine("Transaction successfull");
        }
    }
}
