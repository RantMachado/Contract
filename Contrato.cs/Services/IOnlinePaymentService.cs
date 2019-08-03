using System;

namespace Contrato.Services
{
    interface IOnlinePaymentService
    {
        double SimpleInterestRate(double portionRate, int currentMonth);
        double PaymentFee(double amount);
    }
}
