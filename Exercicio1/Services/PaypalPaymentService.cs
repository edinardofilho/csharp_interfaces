namespace Exercicio1.Services
{
    class PaypalPaymentService : IOnlinePaymentService
    {
        double IOnlinePaymentService.MonthInterest(double amount, int month)
        {
            return amount * month * 0.01;
        }

        double IOnlinePaymentService.PaymentFee(double amount)
        {
            return amount * 0.02;
        }
    }
}
