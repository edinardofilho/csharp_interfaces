using Exercicio1.Entities;
using System;

namespace Exercicio1.Services
{
    class ContractService
    {
        public IOnlinePaymentService PaymentService { get; private set; }

        public ContractService(IOnlinePaymentService paymentService)
        {
            PaymentService = paymentService;
        }

        public void ProcessContract(Contract contract, int months)
        {
            DateTime date = contract.Date;
            
            for (int i = 1; i <= months; i++)
            {
                double amount = contract.TotalValue / months;
                amount = amount + PaymentService.MonthInterest(amount, i);
                amount = amount + PaymentService.PaymentFee(amount);

                date = date.AddMonths(1);

                contract.Installments.Add(new Installment(date, amount));
            }

            foreach (Installment i in contract.Installments)
            {
                Console.WriteLine(i.ToString());
            }
        }
    }
}
