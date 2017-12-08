using System;

namespace RPSGame.Domain
{
    public class GameResult
    {
        Weapon _winner;
        Weapon _loser;

        public static GameResult DrawGameResult
        {
            get
            {
                return new GameResult();
            }
        }
        private GameResult()
        {

        }
        public GameResult(Weapon winner, Weapon loser)
        {
           
            if (winner ==loser) throw new InvalidOperationException("winner cannot be equal to loser");
            _winner = winner;
            _loser = loser;
            
        }

        public override string ToString()
        {
            if (_winner == _loser)
                return "Draw";

            return _winner.ToString() + " Beats " + _loser.ToString();
        }

    }



}