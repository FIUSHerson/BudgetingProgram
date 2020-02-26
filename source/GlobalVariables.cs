using System;

namespace BudgetingProgram
{
    public static class GlobalVariables
    {
        public static double InitialBalance {
            get => InitialBalance;
            set {
                if (value > 0) InitialBalance = value;
            }
        }
        public static double TempBalance {
            get => InitialBalance;
            set {
                if (value > 0) TempBalance = value;
            }
        }
        public static double PaycheckAmount {
            get => InitialBalance;
            set {
                if (value > 0) PaycheckAmount = value;
            }
        }
        public static double FinalBalance {
            get => InitialBalance;
            set {
                if (value > 0) FinalBalance = value;
            }
        }
        public static string[] LoadedFile = FileWriter.LoadFile();
    }
}