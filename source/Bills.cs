using System;

namespace BudgetingProgram {
    public class Bills : Misc {
        Balance Balance = new Balance();

        /* Default save percentage */
        public static double SavePercentAmount {get; set;} = 0.20;
        public static double InsuranceCost {get; set;} = 75;
        public double SavePercent() {
            // Tells user current amount, and asks to confirm. //
            bool Continue = ParseYesOrNo(YesOrNo($"The current save amount is {SavePercentAmount*100}%.\nIs that fine with you? : "));
            if (Continue == true) {
                // Apply percentage //
                double Subtract = 1-SavePercentAmount;
                Balance.temp = Balance.temp * Subtract;
                return Balance.temp;
            }
            else if (Continue == false) {
                // Redefine percentage //
                Console.Write("What percent of your paycheck would you like to save? : ");

                bool loop = true;
                while (loop == true) {
                    try {
                        SavePercentAmount = double.Parse(Console.ReadLine()) * .01;
                        return SavePercentAmount;
                    }
                    catch(FormatException) {
                        Console.Write("\nThat's not a percent. Please try again : ");
                    }
                }
            }
            // Should never get here //
            throw new Exception("\n\n\nDon't know how you got here. If you are reading this, you done diddly messed up.\n\n\n");
        }
        public double Insurance() {
            bool Continue = ParseYesOrNo(YesOrNo($"The current insurance amount is {InsuranceCost}. Is that fine with you?"));
            if (Continue == true) {
                Balance.temp = Balance.temp - InsuranceCost;
                if (Balance.temp >= 0) {
                    return InsuranceCost;
                }
                else {
                    Continue = ParseYesOrNo(YesOrNo("Woah! You don't make enough money to do that!\nWould you like to start over?"));
                    if (Continue == false) {
                        return -1;
                    }
                    else {
                        // insert restart here //
                    }
                }
            }
            else if (Continue == false) {
                Console.Write("How much are you saving for insurance for this paycheck? : ");

                bool loop = true;
                while (loop == true) {
                    try {
                        InsuranceCost = double.Parse(Console.ReadLine());
                        return InsuranceCost;
                    }
                    catch(FormatException) {
                        Console.WriteLine("That's not a valid input. Please try again. : ");
                    }
                }
            }
            // Should never get here //
            throw new Exception("\n\n\nDon't know how you got here. If you are reading this, you done diddly messed up.\n\n\n");
        }
    }
}