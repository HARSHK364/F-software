using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solids.Interface
{
    public interface IUpiPayment : IDoPayment
    {
        void UpiPaymentProcess(Payment payment);
    }

}
