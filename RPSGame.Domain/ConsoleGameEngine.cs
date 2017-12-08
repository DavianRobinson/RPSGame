using System.IO;

namespace RPSGame.Domain
{
    public class ConsoleGameEngine : IGameEngine
    {

        internal static TextReader _input ;
        internal static TextWriter _output;
        private TextWriter _error;      
        private bool ContinuePlaying = true;
        private Match _selectedMatch;

        public Match SelectedMatch
        {
            get
            {
                return _selectedMatch;
            }

            set
            {
                _selectedMatch= value;
            }
        }

        

      

       

        public ConsoleGameEngine( TextReader input, TextWriter output, TextWriter error)
        {
            _input = input;
            _output = output;
            _error = error;          
        }
        public void Init()
        {
            
            do
            {
                _output.WriteLine("Select Game Type, (H)uman, (R)andom, (T)actical, (Q)uit");

                var selection = _input.ReadLine();

                switch (selection)
                {
                    case "H":
                        var p1 = new HumanPlayer();
                        var p2 = new HumanPlayer();
                        SelectedMatch = new Match(p1,p2);
                        SelectedMatch.Compete();
                       _output.WriteLine( SelectedMatch.MatchSummary());                                           
                        break;
                    case "R":
                        var r1 = new HumanPlayer();
                        var r2 = new RandomComputerPlayer();
                        SelectedMatch = new Match(r1,r2);
                        SelectedMatch.Compete();
                        _output.WriteLine(SelectedMatch.MatchSummary());
                        break;
                    case "T":
                        var t1 = new HumanPlayer();
                        var t2 = new TacticalComputerPlayer();
                        SelectedMatch = new Match(t1, t2);
                        SelectedMatch.Compete();
                        _output.WriteLine(SelectedMatch.MatchSummary());
                        break;
                    case "Q":
                        ContinuePlaying = false;
                        break;
                    default:
                        _output.WriteLine("Unknown Selection");                        
                        break;
                }                
            } while (ContinuePlaying);
        }
    }
}