using System;

namespace RPSGame.Domain
{
    public class ScoreCard
    {
        public int _player1Score { get; set; }
        public int _player2Score { get; set; }
        public int _draw { get; set; }

        public String GetOverallWinner()
        {
            string overallWinner = "";
            if (_player1Score > _player2Score)
            { overallWinner = "Player 1 is the overall Winner"; }
            else if (_player2Score > _player1Score)
            { overallWinner  = "Player 2 is the overall Winner"; }
            else if (_player1Score == _player2Score)
                { overallWinner = "Draw"; }
            return overallWinner;
        }
    }
}
