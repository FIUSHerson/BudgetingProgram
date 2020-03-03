using System;

namespace BudgetingProgram
{
    public struct Paycheck
    {
        public static double Amount {
            get => Amount;
            set {
                if (value > 0) Amount = value;
            }
        }
    }
}