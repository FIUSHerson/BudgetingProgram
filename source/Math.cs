using System;

namespace BudgetingProgram {
    public class Math {
        public bool GreaterThanZero(double a, double b) {
            /* Just a check to make sure balance doesn't go below 0.
               Probably will delete this later since the variables take care of it. */
            if (a - b > 0) {
                return true;
            }
            else {
                return false;
            }
        }
    }
}