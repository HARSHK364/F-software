using solids.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solids
{
    public abstract class PaymentGateway : IDoPayment
    {
        public abstract void DoPaymentProcess(Payment payment);

    }

}
