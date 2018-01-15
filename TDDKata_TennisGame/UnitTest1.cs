using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TDDKata_TennisGame
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Love_All()
        {
            var tennisGame = new TennisGame();
            var score = tennisGame.Score();
            Assert.AreEqual("Love-All",score);
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
