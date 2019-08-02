using System;
using System.Globalization;
using Contrato.Entities;
using Contrato.Services;

namespace Contrato
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter contract data");
                Console.Write("Number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Data (dd/MM/yyyy): ");
                DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                Console.Write("Contract value: ");
                double totalValue = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Contract contract = new Contract(number, date, totalValue);

                Console.Write("Enter number of installments: ");
                int months = int.Parse(Console.ReadLine());

                PaymentService paymentService = new PaymentService(months, new PaypalService());

                Console.WriteLine("Installments: ");

                paymentService.GenerateInstallments(contract);                
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
