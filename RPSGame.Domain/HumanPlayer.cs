using System;

namespace RPSGame.Domain
{
    public class HumanPlayer : IPlayer
    {
        public const string CHOOSEOPTION = "Choose an option (R)ock, (P)aper, (S)cissors";
        private string _name;
        private Weapon _selectedWeapon;

        public HumanPlayer()
        {

        }
        public HumanPlayer(string playerName)
        {
            _name = playerName;
        }
        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public Weapon SelectedWeapon
        {
            get
            {
                return _selectedWeapon;
            }
            set
            {
                    _selectedWeapon = value;
            }
        }

       

        public void Select()
        {

            ConsoleGameEngine._output.WriteLine(CHOOSEOPTION);
            string userinput= ConsoleGameEngine._input.ReadLine();

            switch (userinput)
            {
                case "R":
                    _selectedWeapon = Weapon.Rock;
                    break;
                case "P":
                    _selectedWeapon = Weapon.Paper;
                    break;
                case "S":
                    _selectedWeapon = Weapon.Scissors;
                    break;
                default:
                   
                    break;
            }          
        }
    }
}
