using System;

namespace BudgetingProgram {
    public class Start     {
        // Startup Method //
        public static void Main(string[] args) {
            Start Start = new Start();
            Saving save = new Saving();

            // Get Initial Balances //
            Balance init = Start.GetInitialBalance();
            Paycheck payinit = Start.GetPaycheckAmount();

            // This is to hopefully give the main functions the ability to restart. //
            bool restart = Start.Run();
            while (restart == false) restart = Start.Run();
        }
        public bool Run() {

            // Initialize 
            FileManager filemanager = new FileManager();
            Balance balance = new Balance();

            // Copy balance to an editable variable while keeping the original intact. //
            balance.temp = balance.initial;

            // Check if save file exists and create one if needed //
            if (!filemanager.CheckForFile(FileManager.FileLocation)) {
                string file = filemanager.CreateFile();
            }

            return false;
        }
        public Balance GetInitialBalance() {
            // Create a new balance object //
            Balance balance = new Balance();

            // Set up error loop //
            bool loop = true;
            bool invalid = false;

            while (loop == true) {
                
                /* Ask for amount in account after paycheck
                   is included and parse as a double */
                Console.Clear();
                if (invalid == true) {
                    // Error handler //
                    Console.WriteLine("Sorry, that is not a valid input.\n");
                }

                try {
                    Console.Write("Please enter your balance after your paycheck : ");
                    balance.initial = double.Parse(Console.ReadLine());

                    // Allows the user to continue if entry is valid //
                    loop = false;
                }
                catch(Exception) {
                    invalid = true;
                }
            }
            return balance;
        }
        public Paycheck GetPaycheckAmount() {

            // This method is very similar to GetInitialBalance(), but with minor tweaks //

            // Initialize new paycheck //
            Paycheck paycheck = new Paycheck();

            bool loop = true;
            bool invalid = false;

            while (loop == true) {

                // Ask for paycheck amount and parse string as a double //
                Console.Clear();
                if (invalid == true) {
                    Console.WriteLine("Sorry, that is not a valid input.\n");
                }
                
                try {
                    Console.Write("Please enter your balance after your paycheck : ");
                    paycheck.Amount = double.Parse(Console.ReadLine());
                    loop = false;
                }
                catch(IndexOutOfRangeException) {
                    invalid = true;
                }
                catch(FormatException) {
                    invalid = true;
                }
            }
            return paycheck;
        }
    }
}