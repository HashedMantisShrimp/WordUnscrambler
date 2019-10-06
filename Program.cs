using System;
using WordUnScrambler.Workers;
using WordUnScrambler.DataManagement;

namespace WordUnScrambler
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Input User = new Input();
                Unscrambler Unscramble = new Unscrambler();
                int r; //result of tryparse

                do
                {
                    User.UserChoiceInstructions(Data.UserChoice); //choose to use manual or file input
                    var _userInput = Console.ReadLine() ?? string.Empty;
                    Data.UserChoice = (_userInput == string.Empty || !int.TryParse(_userInput, out r))
                    ? 4 : Convert.ToInt32(_userInput); //If user input is unrecognized, the choice is set to 4 by default

                    do
                    {
                        if (Data.UserChoice == 4 || (Data.UserChoice!= 1 || Data.UserChoice!=2 || Data.UserChoice!=3))
                        {
                            User.UserChoiceInstructions(Data.UserChoice); // In case user chose unrecognized option
                            _userInput = Console.ReadLine() ?? string.Empty;
                            Data.UserChoice = (_userInput == string.Empty || !int.TryParse(_userInput, out r))
                            ? 4 : Convert.ToInt32(_userInput);
                        }
                        Data.RepeatProcess = (Data.UserChoice == 1 || Data.UserChoice == 2 || Data.UserChoice == 3) ? false : true;
                    } while (Data.RepeatProcess);

                    User.UserChoiceInstructions(Data.UserChoice); //When recognized option is chosen, program keeps running
                    Data.UserFileListInput = Console.ReadLine() ?? string.Empty;

                    if (User.AcquireTypeOfUserInpput(Data.UserChoice, Data.UserFileListInput) != null)
                    {
                        Unscramble.MatchesFound(Data.ScrambledWords); //Looks for matches if there wasnt an error in file path case
                        User.RepeatProgram(); //Does user want to repeat the prorgam?
                    }
                } while (Data.ContinueWordUnscrambler);
                //User.PrintArray(Data.Dictionary);
                //Console.ReadKey();
            }
            catch (Exception ex)
            { Console.WriteLine(Constants.ErrorCaught + ex.Message); }
           
        }
        
    }
    
}
