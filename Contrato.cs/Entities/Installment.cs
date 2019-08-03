using System;
using System.Globalization;

namespace Contrato.Entities
{
    class Installment
    {
        public DateTime DueDate { get; private set; }
        public double InstallmentAmount { get; private set; }

        public Installment(DateTime dueDate, double installmentAmout)
        {
            DueDate = dueDate;
            InstallmentAmount = installmentAmout;
        }

        public override string ToString()
        {
            return DueDate.ToString("dd/MM/yyyy") + " - " + InstallmentAmount.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
