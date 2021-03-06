﻿using System;

namespace BudgetingProgram {
    public class Start     {
        // Startup Method //
        public static void Main(string[] args) {
            Start Start = new Start();
            Saving save = new Saving();

            // Get Initial Balances //
            Start.GetInitialBalance();
            Start.GetPaycheckAmount();

            // This is to hopefully give the main functions the ability to restart. //
            bool restart = Start.Run();
            while (restart == false) restart = Start.Run();
        }
        public bool Run() {
            FileManager file = new FileManager();

            // Copy balance to an editable variable while keeping the original intact. //
            GlobalVariables.TempBalance = GlobalVariables.InitialBalance;

            // Check if save file exists and create one if needed //
            file.CreateFile();



            return false;
        }
        public void GetPaycheckAmount() {
            bool loop = true;
            bool invalid = false;

            while (loop == true) {

                // Ask for paycheck amount and parse string as a double //
                Console.Clear();
                if (invalid == true) {
                    Console.WriteLine("Sorry, that is not a valid input.\n");
                }
                Console.Write("Please enter your balance after your paycheck : ");
                
                try {
                    GlobalVariables.PaycheckAmount = double.Parse(Console.ReadLine());
                    loop = false;
                }
                catch(IndexOutOfRangeException) {
                    invalid = true;
                }
                catch(FormatException) {
                    invalid = true;
                }
            }
        }
        public void GetInitialBalance() {
            bool loop = true;
            bool invalid = false;

            while (loop == true) {
                
                /* Ask for amount in account after paycheck
                   is included and parse as a double */
                Console.Clear();
                if (invalid == true) {
                    Console.WriteLine("Sorry, that is not a valid input.\n");
                }
                Console.Write("Please enter your balance after your paycheck : ");
                
                try {
                    GlobalVariables.InitialBalance = double.Parse(Console.ReadLine());
                    loop = false;
                }
                catch(IndexOutOfRangeException) {
                    invalid = true;
                }
                catch(FormatException) {
                    invalid = true;
                }
            }
        }
    }
}