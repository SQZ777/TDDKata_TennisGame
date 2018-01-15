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

        private void ScoreShouldBe(string expected)
        {
            var score = tennisGame.Score();
            Assert.AreEqual(expected, score);
        }
    }
}
