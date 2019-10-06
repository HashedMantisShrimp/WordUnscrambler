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
                Console.WriteLine(Constants.CaseUserChoiceIsOneMsg1);
                Console.Write(Constants.CaseUserChoiceIsOneMsg2);
                Console.WriteLine(Constants.CaseUserChoiceIsOneMsg3);
                return Data.RepeatProcess = false;
            }
            else if (userChoice1 == 2)
            {
                Console.WriteLine();
                Console.WriteLine(Constants.CaseUserChoiceIsTwoMsg1);
                return Data.RepeatProcess = false;
            }
            else if (userChoice1 == 0)
            {
                Console.WriteLine(Constants.CaseUserChoiceIsZeroMsg1);
                Console.WriteLine(Constants.CaseUserChoiceIsZeroMsg2);
                return Data.RepeatProcess;
            }
            else if (userChoice1 == 3)
            {
                Console.WriteLine();
                Console.WriteLine(Constants.CaseUserChoiceIsThreeMsg1);
                Console.WriteLine(Constants.CaseUserChoiceIsThreeMsg2);
                Console.ReadKey();
                System.Environment.Exit(1);
                return Data.RepeatProcess = false;
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine(Constants.CaseUserChoiceIsNotRecognized);
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
                Console.WriteLine(Constants.EndProgramMsg1);
                Console.ReadKey();
                return Data.ContinueWordUnscrambler= false;
            }
        }

        private char EndOfAppProcess()
        {
            char r; //result of tryparse
            var _userInput = string.Empty;

            Console.WriteLine();
            Console.WriteLine(Constants.EndOfAppProcessMsg1);
            Console.Write(Constants.EndOfAppProcessMsg2);
            _userInput = Console.ReadLine() ?? string.Empty;

            do
            {
                if ((_userInput == string.Empty || !Char.TryParse(_userInput, out r)) ||
                   (!_userInput.Equals(Constants.Yes, StringComparison.OrdinalIgnoreCase) && 
                   !_userInput.Equals(Constants.No, StringComparison.OrdinalIgnoreCase)))
                {
                    do
                    {
                        Console.WriteLine(Constants.EAPCaseUserInputIsNotRecognized);
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
                Console.WriteLine(Constants.CaseArrayIsNotEmpty);
                foreach (var element in printedArray)
                {
                    Console.WriteLine(element);
                }
            }
            else
            {
                Console.WriteLine(Constants.CaseArrayIsEmpty);
            }
        }
    }
}
