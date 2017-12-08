using System;

namespace RPSGame.Domain
{
    public class RandomComputerPlayer : IPlayer
    {
        private string _name="Random";
        private Weapon _selectedWeapon;

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
    }
}
