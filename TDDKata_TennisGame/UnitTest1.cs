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
            tennisGame.SetFirstPlayerScore(1);
            ScoreShouldBe("Fifteen-Love");
        }

        [TestMethod]
        public void Thirty_Love()
        {
            tennisGame.SetFirstPlayerScore(2);
            ScoreShouldBe("Thirty-Love");
        }

        [TestMethod]
        public void Forty_Love()
        {
            tennisGame.SetFirstPlayerScore(3);
            ScoreShouldBe("Forty-Love");
        }

        [TestMethod]
        public void Love_Fifteen()
        {
            tennisGame.SetSecondPlayerScore(1);
            ScoreShouldBe("Love-Fifteen");
        }

        [TestMethod]
        public void Love_Forty()
        {
            tennisGame.SetSecondPlayerScore(2);
            ScoreShouldBe("Love-Thirty");
        }

        private void ScoreShouldBe(string expected)
        {
            var score = tennisGame.Score();
            Assert.AreEqual(expected, score);
        }
    }
}
