using System;
using System.IO;
using System.Collections.Generic;

namespace BudgetingProgram {
    public class FileWriter {
        public static string[] LoadFile(string file) {
            // Check to see if file exists //
            FileManager f = new FileManager();
            if (f.CheckForFile(FileManager.FileLocation)) {
                // This should load the file and store each file in a list. //
                return File.ReadAllLines(file);
            }
            else throw new FileNotFoundException();
        }
        public void SaveFile(string file, string[] content) {
            try {
                // Write lines to file //
                File.WriteAllLines(file, content);
            }
            catch (Exception e) {
                // If writing to file fails //
                Console.WriteLine($"File failed to write to file due to {e}.");
            }
        }
    }
}