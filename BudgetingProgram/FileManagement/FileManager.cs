using System;
using System.IO;

namespace BudgetingProgram {
    class FileManager {
        /* Get Documents directory */
        private static string CurrentPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        // Create variable that stores the path to folder //
        private static string FileFolder = CurrentPath + @"\BudgetingProgram";
        /* Create path for stored file */
        public static string FileLocation = FileFolder + @"\SavingsFile.txt";
        public bool CheckForFile(string pathToFile) {
            /* Check to see if the stored file exists */
            if (File.Exists(FileLocation) == true) {
                return true;
            }
            else {
                return false;
            }
        }
        public void CreateFile() {
            // Create the folder if it doesn't exist //
            try {
                DirectoryInfo di = Directory.CreateDirectory(FileFolder);
            }
            catch (Exception e) {
                Console.WriteLine($"Creating directory failed with exception {e}.");
            }

            // This should just run the method up above me if needed //

            /* Create the stored file if file doesn't exist */
            if (CheckForFile(FileLocation) == false) {
                File.Create(FileLocation);
            }
            else return;
        }
    }
}