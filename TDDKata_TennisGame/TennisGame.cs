using System.Collections.Generic;

namespace TDDKata_TennisGame
{
    public class TennisGame
    {

        private int _firstPlayerScore;
        private int _secondPlayerScore;

        private readonly Dictionary<int, string> _scoreDictionary = new Dictionary<int, string>
        {
            {1, "Fifteen" },
            {2, "Thirty" },
            {3, "Forty" }
        };
        
        public string Score()
        {
            if (_firstPlayerScore > 0)
            {
                return _scoreDictionary[_firstPlayerScore] + "-Love";
            }
            return "Love-All";
        }

        public void SetFirstPlayerScore(int n)
        {
            _firstPlayerScore = n;
        }

        public void SetSecondPlayerScore(int n)
        {
            _secondPlayerScore = n;
        }
    }
}
