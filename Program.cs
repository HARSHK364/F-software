using solids;
class Program
{
    static void Main(string[] args)
    {

        var payment = new Payment { Amount = "1000.00", Method = "Upi" };

        var paymentProcessor = new PaymentProcessor(PaymentMethod.Create(payment.Method));

        paymentProcessor.DoPaymentProcess(payment);
    }
}