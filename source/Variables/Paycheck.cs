using System;

namespace BudgetingProgram
{
    public class Paycheck
    {
        public double Amount {
            get => Amount;
            set {
                if (value > 0) Amount = value;
            }
        }
    }
}