namespace Contrato.Services
{
    class PaypalService : IOnlinePaymentService
    {
        public double SimpleInterestRate(double portionValue, int currentMonth)
        {
            portionValue *= 0.01 * currentMonth;
            return portionValue;
        }

        public double PaymentFee(double amount)
        {
            return amount *= 0.02;
        }
    }
}
