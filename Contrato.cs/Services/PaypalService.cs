namespace Contrato.Services
{
    class PaypalService : IOnlinePaymentService
    {
        public double SimpleInterestRate(double portionRate, int currentMonth)
        {
            portionRate *= 0.01 * currentMonth;
            return portionRate;
        }

        public double PaymentFee(double amount)
        {
            return amount *= 0.02;
        }
    }
}
