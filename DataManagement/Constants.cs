namespace WordUnScrambler.DataManagement
{
    class Constants
    {
        //Constant for the TryCatch on Program.cs
        public const string ErrorCaught = "The application will close due to the following error: ";

        //Constant for the Data Class
            //Used in the UploadDictionary Method
        public const string DictionaryLocation = "dictionary.txt";
        

        //Constants for the Unscrambler class
            //Used in the MatchesFound Method
        public const string CaseMatchesFound = "These were the matches found for the given words: ";
        public const string CaseNoMatchesFound = "There were no matches found for the given words.";
        public const string OutputMatches = "Match found for {0}: {1}";

        //Constants for The FileReader Class
            //Used in the IsValidPath Method
        public const string CaseReadIsNotDefaultFileMsg1 = "There was an error with the given file path: ";
            //Used in the Read Method
        public const string CaseReadIsNotDefaultFileMsg2 = "The application will now restart.";
        public const string CaseReadIsNotDefaultFileMsg3 = "Please either enter the full correct path at the right step, enter " +
            "1 to input the words manually or";
        public const string CaseReadIsNotDefaultFileMsg4 = "Enter '3' to quit the application.";

        //Constants for The Input Class
            //Constants for Method UserChoiceInstructions
                //In case UserChoice = 0
        public const string CaseUserChoiceIsZeroMsg1 = "Would you like to submit your words manually or through a file?";
        public const string CaseUserChoiceIsZeroMsg2 = "Enter '1' for a manual input, '2' for a file type input or " +
            "'3' to close the application.";

                //In case UserChoice = 1
        public const string CaseUserChoiceIsOneMsg1 = " If you chose Manual Input, please enter the scrambled words. ";
        public const string CaseUserChoiceIsOneMsg2 = "If there is more than one, separate them by comas. Like so: ";
        public const string CaseUserChoiceIsOneMsg3 = "This,That";

                //In case UserChoice = 2
        public const string CaseUserChoiceIsTwoMsg1 = "If you chose the File Type Input, " +
            "please enter the full file path with its name and extension.";

                //In case UserChoice = 3
        public const string CaseUserChoiceIsThreeMsg1 = "You chose option '3'. The application will close shortly.";
        public const string CaseUserChoiceIsThreeMsg2 = "Please acknowledge by pressing any key.";

                //In case UserChoice is unrecognized
        public const string CaseUserChoiceIsNotRecognized = "There was an error with your choice. Please make sure you entered" +
            " either '1' or '2' or enter '3' to exit application.";

            //Constant for Method RepeatProgram
        public const string EndProgramMsg1 = "The program will close shortly. Please acknoledge by pressing any key.";

            //Constants for private Method EndOfAppProcess
        public const string EndOfAppProcessMsg1 = "You made it to the end of the application!? You're a ducking BEAST!";
        public const string EndOfAppProcessMsg2 = "Would you like to reapeat the Word Unscrambler application? Y/N? ";
        public const string EAPCaseUserInputIsNotRecognized = "Please choose Y to repeat the proccess or N to finish the " +
            "application.";
        public const string Yes = "Y";
        public const string No = "N";

            //Constants for Method PrintArray
        public const string CaseArrayIsNotEmpty = "The elements in the list are: ";
        public const string CaseArrayIsEmpty = "The list is empty or null. There is nothing to print.";
        


    }
}
