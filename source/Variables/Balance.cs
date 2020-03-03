namespace BudgetingProgram {
    public class Balance {
        public double initial {
            get => initial;
            set{
                if (value > 0) {
                    initial = value;
                }
                else {
                    System.Console.WriteLine($"Value is lower than 0. Not applying change to {this}.");
                }
            } 
        }
        public double temp {
            get => temp;
            set{
                if (value > 0) {
                    temp = value;
                }
                else {
                    System.Console.WriteLine($"Value is lower than 0. Not applying change to {this}.");
                }
            }
        }
        public double final {
            get => final;
            set {
                if (value > 0) {
                    final = value;
                }
                else {
                    System.Console.WriteLine($"Value is lower than 0. Not applying change to {this}.");
                }
            }
        }
    }
}