using System;

namespace RPSGame.Domain
{
    public class TacticalComputerPlayer : IPlayer
    {
        private string _name="Tactical";
        private Weapon _selectedWeapon;
        private Weapon? LastWeaponUsedByOpponent;

        public TacticalComputerPlayer()
        {
                
        }
        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                _name = value;
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
            if (!LastWeaponUsedByOpponent.HasValue)
            {
                int Random = new Random().Next(1, 4);
                switch (Random)
                {
                    case 1:
                        _selectedWeapon = Weapon.Rock;
                        break;
                    case 2:
                        _selectedWeapon = Weapon.Paper;

                        break;
                    case 3:
                        _selectedWeapon = Weapon.Scissors;

                        break;
                    default:

                        break;
                }
                
            }
            else
            {
                switch (LastWeaponUsedByOpponent.Value)
                {
                    case Weapon.Rock:
                        _selectedWeapon = Weapon.Paper;
                        break;
                    case Weapon.Paper:
                        _selectedWeapon = Weapon.Scissors;

                        break;
                    case Weapon.Scissors:
                        _selectedWeapon = Weapon.Rock;

                        break;
                    default:

                        break;
                }
            }

            LastWeaponUsedByOpponent = _selectedWeapon;
            ConsoleGameEngine._output.WriteLine("Selected Weapon {0}", _selectedWeapon);
            ConsoleGameEngine._output.WriteLine("Last Selected Weapon {0}", LastWeaponUsedByOpponent);

        }
    }
}
