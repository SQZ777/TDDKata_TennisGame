using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TDDKata_TennisGame
{
    [TestClass]
    public class UnitTest1
    {
        TennisGame tennisGame = new TennisGame("Lin","DZ");
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
        public void Love_Thirty()
        {
            tennisGame.SetSecondPlayerScore(2);
            ScoreShouldBe("Love-Thirty");
        }

        [TestMethod]
        public void Love_Forty()
        {
            tennisGame.SetSecondPlayerScore(3);
            ScoreShouldBe("Love-Forty");
        }

        [TestMethod]
        public void Fifteen_All()
        {
            tennisGame.SetFirstPlayerScore(1);
            tennisGame.SetSecondPlayerScore(1);
            ScoreShouldBe("Fifteen-All");
        }

        [TestMethod]
        public void Thirty_All()
        {
            tennisGame.SetFirstPlayerScore(2);
            tennisGame.SetSecondPlayerScore(2);
            ScoreShouldBe("Thirty-All");
        }

        [TestMethod]
        public void Deuce()
        {
            tennisGame.SetFirstPlayerScore(3);
            tennisGame.SetSecondPlayerScore(3);
            ScoreShouldBe("Deuce");
        }

        [TestMethod]
        public void When_4_4_Then_Deuce()
        {
            tennisGame.SetFirstPlayerScore(4);
            tennisGame.SetSecondPlayerScore(4);
            ScoreShouldBe("Deuce");
        }

        [TestMethod]
        public void Lin_Adv()
        {
            tennisGame.SetFirstPlayerScore(4);
            tennisGame.SetSecondPlayerScore(3);
            ScoreShouldBe("Lin Adv");
        }

        private void ScoreShouldBe(string expected)
        {
            var score = tennisGame.Score();
            Assert.AreEqual(expected, score);
        }
    }
}
