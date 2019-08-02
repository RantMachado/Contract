﻿using System;
using System.Globalization;
using Contrato.Entities;

namespace Contrato.Services
{
    class PaymentService
    {
        public int Months { get; private set; }
        private IOnlinePaymentService _onlinePaymentService;

        public PaymentService(int months, IOnlinePaymentService onlinePaymentService)
        {
            Months = months;
            _onlinePaymentService = onlinePaymentService;
        }

        public void GenerateInstallments(Contract contrato)
        {
            double portion = contrato.TotalValue / Months;

            for (int i = 1; i <= Months; i++)
            {
                double portionAmount = _onlinePaymentService.SimpleInterestRate(portion, i);
                double result = portion + portionAmount;
                double tax = _onlinePaymentService.PaymentFee(result);
                result += tax;
                contrato.Date = contrato.Date.AddMonths(1);
                contrato.AddInstallments(new Installment(contrato.Date, result));                
            }

            foreach (var item in contrato.ListInstallments)
            {
                Console.WriteLine(item);
            }
        }
    }
}
