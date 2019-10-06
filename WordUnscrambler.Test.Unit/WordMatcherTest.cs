using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordUnScrambler.Workers;

namespace WordUnscrambler.Test.Unit
{
    [TestClass]
    public class WordMatcherTest //Change the name to "UnscramblerTest"?
    {
        private readonly Unscrambler _Unscrambler = new Unscrambler();
        [TestMethod]
        public void ScrambledWordsArrayMatchesWithTwoWords()
        {
            string[] ScrambledWords = { "vElOeV", "quAliFy", "Paragraph", "Glass" };
            string[] Words = { "Evolve", "Qualify" };

           var _matchedWords = _Unscrambler.Matcher(ScrambledWords, Words);

            Assert.IsTrue(_matchedWords.Count==2);
            Assert.IsTrue(_matchedWords[0].SramcbledWord.Equals("vElOeV"));
            Assert.IsTrue(_matchedWords[0].Word.Equals("Evolve"));
            Assert.IsTrue(_matchedWords[1].SramcbledWord.Equals("quAliFy"));
            Assert.IsTrue(_matchedWords[1].Word.Equals("Qualify"));

        }
    }
}
