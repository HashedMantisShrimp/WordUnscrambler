using System;
using System.Collections.Generic;
using System.Linq;
using WordUnScrambler.DataManagement;

namespace WordUnScrambler.Workers
{
    class Unscrambler
    {
        private MatchedWords MatchBuilder(string scrambledWord_, string word_) {
            MatchedWords matchedWord = new MatchedWords { SramcbledWord = scrambledWord_, Word = word_ };
            return matchedWord;
        }

        public List<MatchedWords> Matcher(string [] _scrambledWords, string[] _dictionary) {
            var _matchedwords = new List<MatchedWords>();
            
            foreach (string _scrambledWord in _scrambledWords)
            {
                foreach (string _word in _dictionary)
                {
                    if (_scrambledWord.Equals(_word, StringComparison.OrdinalIgnoreCase))
                    {
                         _matchedwords.Add(MatchBuilder(_scrambledWord, _word));
                    }
                    else {
                        var scrambledWordArray = _scrambledWord.ToLower().ToCharArray();
                        var wordArray = _word.ToLower().ToCharArray();

                        Array.Sort(scrambledWordArray);
                        Array.Sort(wordArray);

                        var sortedScrambledArray = new string(scrambledWordArray);
                        var sortedWordArray = new string(wordArray);

                        if (sortedScrambledArray.Equals(sortedWordArray, StringComparison.OrdinalIgnoreCase)) {
                            _matchedwords.Add(MatchBuilder(_scrambledWord, _word));
                        }
                    }
                }
            }
            return _matchedwords;
        }

        public void MatchesFound(string[] scrambledWords) {
           string[] wordList = Data.Dictionary;

           List<MatchedWords> Matches = Matcher(scrambledWords, wordList);

           if (Matches.Any()) {
               Console.WriteLine();
               Console.WriteLine("These were the matches found for the given words: ");
               foreach (var element in Matches) {
                   Console.WriteLine("Match found for {0}: {1}", element.SramcbledWord,element.Word);
               }
           } else{
               Console.WriteLine();
               Console.WriteLine("There were no matches found for the words given.");
           }
        }
    }
}
