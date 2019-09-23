using System;
using System.Linq;
using WordUnScrambler.DataManagement;

namespace WordUnScrambler.Workers
{
    class Input
    { 
        public Array AcquireTypeOfUserInpput(int userChoice, string userInput) {
            if (userChoice == 1)
            {
                Data.ScrambledWords = userInput.Split(',').ToArray();
                return Data.ScrambledWords;
            }
            else
            {
                Data.ScrambledWords = FileReader.Read(userInput,false); 
                return Data.ScrambledWords;
            }
        }

        public bool UserChoiceInstructions(int userChoice1) {
            if (userChoice1 == 1)
            {
                Console.WriteLine();
                Console.WriteLine(" If you chose Manual Input, please enter the scrambled words. " +
                    "If there is more than one, separate them by comas. Like so:");
                Console.WriteLine("This,That");
                return Data.RepeatProcess = false;
            }
            else if (userChoice1 == 2)
            {
                Console.WriteLine();
                Console.WriteLine("If you chose the File Type Input, " +
                "please enter the full file path with its name and extension.");
                return Data.RepeatProcess = false;
            }
            else if (userChoice1 == 0)
            {
                Console.WriteLine("Would you like to submit your words manually or through a file?");
                Console.WriteLine("Enter '1' for a manual input, '2' for a file type input or '3' to close the application.");
                return Data.RepeatProcess;
            }
            else if (userChoice1 == 3)
            {
                Console.WriteLine();
                Console.WriteLine("You chose option '3'. The application will close shortly.");
                Console.WriteLine("Please acknowledge by pressing any key.");
                Console.ReadKey();
                System.Environment.Exit(1);
                return Data.RepeatProcess = false;
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("There was an error with your choice. Please make sure you entered either" +
                    "'1' or '2' or enter '3' to exit application.");
                return Data.RepeatProcess = true;
            }
        }

        public bool RepeatProgram()
        {
            if (EndOfAppProcess().Equals('Y'))
            {
                Data.UserChoice = 0;
                Console.WriteLine();
                return Data.ContinueWordUnscrambler = true;
            }
            else
            {
                Console.WriteLine("The program will close shortly. Please acknoledge by pressing any key.");
                Console.ReadKey();
                return Data.ContinueWordUnscrambler= false;
            }
        }

        private char EndOfAppProcess()
        {
            char r; //result of tryparse
            var _userInput = string.Empty;

            Console.WriteLine();
            Console.WriteLine("You made it to the end of the application!? You're a ducking BEAST!");
            Console.Write("Would you like to reapeat the Word Unscrambler application? Y/N? ");
            _userInput = Console.ReadLine() ?? string.Empty;

            do
            {
                if ((_userInput == string.Empty || !Char.TryParse(_userInput, out r)) ||
                   (!_userInput.Equals("Y", StringComparison.OrdinalIgnoreCase) && 
                   !_userInput.Equals("N", StringComparison.OrdinalIgnoreCase)))
                {
                    do
                    {
                        Console.WriteLine("Please choose Y to repeat the proccess or N to finish the application.");
                        _userInput = Console.ReadLine() ?? string.Empty;
                    } while (_userInput == string.Empty || !Char.TryParse(_userInput, out r));
                }

            } while (!_userInput.Equals("Y", StringComparison.OrdinalIgnoreCase) && 
            !_userInput.Equals("N", StringComparison.OrdinalIgnoreCase));
            return Convert.ToChar(_userInput.ToUpper());
        }

        public void PrintArray(Array printedArray)
        {
            Console.WriteLine();

            if (printedArray != null && printedArray.Length > 0)
            {
                Console.WriteLine("The elements in the list are: ");
                foreach (var element in printedArray)
                {
                    Console.WriteLine(element);
                }
            }
            else
            {
                Console.WriteLine("The list is empty or null. There is nothing to print.");
            }
        }
    }
}
