using System;

namespace Contrato.Services
{
    interface IOnlinePaymentService
    {
        double SimpleInterestRate(double portionValue, int currentMonth);
        double PaymentFee(double amount);
    }
}
