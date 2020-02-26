using System;
using System.IO;

namespace BudgetingProgram {
    public class Misc {
        /* This class includes some methods that don't
           particularly fit into any other class. */
        public string YesOrNo(string text) {
            /* Asks a yes or no question and returns the answer */
            Console.Write(text);
            bool loop = true;
            while (loop == true) {
                string ans = Console.ReadLine();
                if (ans == "Y" || ans == "y") {
                    return ans.ToUpper();
                }
                else if (ans == "N" || ans == "n") {
                    return ans.ToUpper();
                }
                else {
                    Console.Write("\nSorry, that is an invalid response.\nPlease try again : ");
                }
            }
            /* It *should* be impossible to reach this point,
               but I need it to keep the compiler from complaining. */
            throw new ArgumentException("\n\n\nI'm not sure how you even got here. If you are reading this, you fucked up somewhere REALLY bad.\n\n\n");
        }
        public bool ParseYesOrNo(string text) {
            /* This parse could have been included in YesOrNo,
               but I have more flexibility if I separate them. */

            /* Convert Y/N into a boolean */
            if (text == "Y") {
                return true;
            }
            else if (text == "N") {
                return false;
            }
            else {
                throw new ArgumentException("\n\n\nSomething's not right, obviously. The method ParseYesOrNo needs Y or N to actually work.\n\n\n");
            }
        }
    }
}