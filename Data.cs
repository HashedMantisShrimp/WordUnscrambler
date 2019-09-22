using System;
using WordUnScrambler.Workers;

namespace WordUnScrambler.DataManagement
{
    struct Data
    {
        public static int UserChoice { get; set; }
        public static bool RepeatProcess { get; set; }
        public static bool ContinueWordUnscrambler { get; set; }
        public static string UserFileListInput { get; set; }
        public const string DictionaryLocation = "C:\\Users\\Paulo Lukeny\\source\\repos\\WordUnScrambler\\WordUnScrambler\\bin\\Debug\\dictionary.txt";
        public static string[] ScrambledWords { get; set; }
        public static string[] Dictionary { get; set; }

        static Data()
        {
            UploadDictionary();
            Data.RepeatProcess = true;
            Data.ContinueWordUnscrambler = false;
            Data.UserChoice = 0;
        }

        private static Array UploadDictionary()
        {
            Data.Dictionary = FileReader.Read(Data.DictionaryLocation,true);
            return Data.Dictionary;
        }
    }
}
