using Exercicio1.Entities;
using Exercicio1.Services;
using System;
using System.Globalization;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter contract data");
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Date (dd/MM/yyyy): ");
            DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            Console.Write("Contract value: ");
            double totalValue = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Contract contract = new Contract(number, date, totalValue);
            ContractService contractService = new ContractService(new PaypalPaymentService());

            Console.Write("Enter number of installments: ");
            int months = int.Parse(Console.ReadLine());

            
            Console.WriteLine("Installments:");
            contractService.ProcessContract(contract, months);
        }
    }
}
