using System;
using System.Linq;
using WordUnScrambler.DataManagement;
using System.IO;

namespace WordUnScrambler.Workers
{
    class FileReader
    {

        public static string[] Read(string filePath, bool IsDefaultFile)
        {
            
            if (IsValidPath(filePath))
            {
                var FileContentArray = File.ReadAllLines(filePath).ToArray(); // needs to be tested
                return FileContentArray;
            }
            else
            {
                if (!IsDefaultFile)
                {
                    Console.WriteLine();
                    Console.WriteLine("The given path is invalid!");
                    Console.WriteLine("The application will now restart, please enter the full correct path at the right step" +
                        " or enter '3' to quit the application.");
                    Console.WriteLine();
                    Data.UserChoice = 0;
                    Data.ContinueWordUnscrambler = true;
                }
                return null;
            }
        }

        private static bool IsValidPath(string path, bool allowRelativePaths = false)
        {
            bool isValid = true;

            try
            {
                string fullPath = Path.GetFullPath(path);

                if (allowRelativePaths)
                {
                    isValid = Path.IsPathRooted(path);
                }
                else
                {
                    string root = Path.GetPathRoot(path);
                    isValid = string.IsNullOrEmpty(root.Trim(new char[] { '\\', '/' })) == false;
                }
                string[] fileInput = File.ReadAllLines(path).ToArray();

            }
            catch (Exception ex)
            {
                isValid = false;
            }
            return isValid;
        }
    }
}
