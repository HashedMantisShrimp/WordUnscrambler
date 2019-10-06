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
                    Console.WriteLine(Constants.CaseReadIsNotDefaultFileMsg2);
                    Console.WriteLine(Constants.CaseReadIsNotDefaultFileMsg3);
                    Console.WriteLine(Constants.CaseReadIsNotDefaultFileMsg4);
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
                    //Review this piece of code later
                    string root = Path.GetPathRoot(path);
                    string[] fileInput = File.ReadAllLines(path).ToArray();
                    bool IsStringNull = string.IsNullOrEmpty(root.Trim(new char[] { '\\', '/' })) == false;
                    if ( (fileInput != null && fileInput.Length>0) || (IsStringNull) ) {
                        isValid = true;
                    }
                    else {
                        isValid = false;
                    }
                }
                

            }
            catch (Exception ex)
            {
                isValid = false;
                Console.WriteLine(Constants.FileReaderExceptionHandler + ex.Message);
            }
            return isValid;
        }
    }
}
