using System;
using System.Collections.Generic;

namespace TDDKata_TennisGame
{
    public class TennisGame
    {

        private int _firstPlayerScore;
        private int _secondPlayerScore;
        private string _firstPlayerName;
        private string _secondPlayerName;
        private readonly Dictionary<int, string> _scoreDictionary = new Dictionary<int, string>
        {
            {0, "Love"},
            {1, "Fifteen"},
            {2, "Thirty"},
            {3, "Forty"}
        };

        public TennisGame(string firstPlayerName, string secondPlayerName)
        {
            this._firstPlayerName = firstPlayerName;
            this._secondPlayerName = secondPlayerName;
        }

        public string Score()
        {
            return IsSameScore()
                ? (IsDeuce() ? Deuce() : SameScore())
                : (ReadyForWin() ? AdvOrWinPlayer() : NormalScore());
        }

        private bool IsSameScore()
        {
            return _firstPlayerScore == _secondPlayerScore;
        }

        private static string Deuce()
        {
            return "Deuce";
        }

        private bool IsDeuce()
        {
            return _firstPlayerScore >= 3;
        }

        private string SameScore()
        {
            return _scoreDictionary[_firstPlayerScore] + "-All";
        }

        private string AdvOrWinPlayer()
        {
            return AdvPlayer() + (IsAdv() ? " Adv" : " Win");
        }

        private bool ReadyForWin()
        {
            return _firstPlayerScore > 3 || _secondPlayerScore > 3;
        }

        private string AdvPlayer()
        {
            return _firstPlayerScore > _secondPlayerScore ? _firstPlayerName : _secondPlayerName;
        }

        private bool IsAdv()
        {
            return Math.Abs(_firstPlayerScore - _secondPlayerScore) == 1;
        }

        private string NormalScore()
        {
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
