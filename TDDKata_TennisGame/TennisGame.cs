using System.Collections.Generic;

namespace TDDKata_TennisGame
{
    public class TennisGame
    {

        private int _firstPlayerScore;
        private int _secondPlayerScore;

        private readonly Dictionary<int, string> _scoreDictionary = new Dictionary<int, string>
        {
            {0, "Love"},
            {1, "Fifteen"},
            {2, "Thirty"},
            {3, "Forty"}
        };

        public string Score()
        {
            if (_firstPlayerScore == _secondPlayerScore)
            {
                if (_firstPlayerScore >= 3)
                {
                    return "Deuce";
                }
                return _scoreDictionary[_firstPlayerScore] + "-All";
            }
            return _scoreDictionary[_firstPlayerScore] + "-" + _scoreDictionary[_secondPlayerScore];

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
