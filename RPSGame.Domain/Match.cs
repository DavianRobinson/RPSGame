using System.Text;

namespace RPSGame.Domain
{
    public class Match
    {
        private readonly IPlayer _player1;
        private readonly IPlayer _player2;
       

        int  _numberofGames=3;
        GameResult[] GameResults;
        ScoreCard _scoreCard;        

        public Match(IPlayer player1, IPlayer player2)
        {
            _player1 = player1;
            _player2 = player2;
           GameResults = new GameResult[_numberofGames];
            _scoreCard = new ScoreCard();
        }

        public GameResult[] Compete()
        {

            for (int i = 0; i < _numberofGames; i++)
            {
               ConsoleGameEngine._output.WriteLine("Round {0}", i + 1);

                _player1.Select();                
                _player2.Select();

                 GameResults[i] = ProcessGame();
                if (_scoreCard._player1Score > _numberofGames / 2 || _scoreCard._player2Score > _numberofGames / 2)
                    break;
            }     

            return GameResults;
        }

        public GameResult ProcessGame()
        {

            if (_player1.SelectedWeapon == _player2.SelectedWeapon)
            { _scoreCard._draw++; return GameResult.DrawGameResult;  }
            else if ((_player1.SelectedWeapon == Weapon.Rock) && (_player2.SelectedWeapon == Weapon.Scissors) ||
                     (_player1.SelectedWeapon == Weapon.Paper) && (_player2.SelectedWeapon == Weapon.Rock) ||
                     (_player1.SelectedWeapon == Weapon.Scissors) && (_player2.SelectedWeapon == Weapon.Paper))
            { _scoreCard._player1Score++; return new GameResult(_player1.SelectedWeapon, _player2.SelectedWeapon); }
            else
            { _scoreCard._player2Score++; return new GameResult(_player2.SelectedWeapon, _player1.SelectedWeapon); }        


        }

        public string MatchSummary() 
        {
            var sb = new StringBuilder("Match Summary").AppendLine();

            foreach (var item in GameResults)
            {
                if(item!=null)
                sb.AppendLine( item.ToString());
            }

            sb.AppendLine();
            sb.AppendLine("**** Score Card *****");
            sb.AppendLine(_scoreCard.GetOverallWinner());

            return sb.ToString();          
        }
    }
}
