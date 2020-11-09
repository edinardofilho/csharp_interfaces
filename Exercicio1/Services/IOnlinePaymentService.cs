namespace Exercicio1.Services
{
    interface IOnlinePaymentService
    {
        double MonthInterest(double amount, int month);
        double PaymentFee(double amount);
    }
}
