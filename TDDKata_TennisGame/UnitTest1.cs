using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TDDKata_TennisGame
{
    [TestClass]
    public class UnitTest1
    {
        TennisGame tennisGame = new TennisGame();
        [TestMethod]
        public void Love_All()
        {
            ScoreShouldBe("Love-All");
        }

        [TestMethod]
        public void Fifteen_Love()
        {
            ScoreShouldBe("Fifteen-Love");
        }

        private void ScoreShouldBe(string expected)
        {
            var score = tennisGame.Score();
            Assert.AreEqual(expected, score);
        }
    }

    public class TennisGame
    {
        public string Score()
        {
            return "Love-All";
        }
    }
}
