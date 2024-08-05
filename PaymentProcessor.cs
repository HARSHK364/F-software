using solids.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solids
{
    public class PaymentProcessor
    {
        private readonly IDoPayment _paymentGateway;

        public PaymentProcessor(IDoPayment paymentGateway)
        {
            _paymentGateway = paymentGateway;
        }

        public void DoPaymentProcess(Payment payment)
        {
            _paymentGateway.DoPaymentProcess(payment);
        }
    }
}
