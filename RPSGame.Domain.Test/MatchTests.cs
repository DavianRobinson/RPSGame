using NUnit.Framework;

namespace RPSGame.Domain.Test
{
    [TestFixture]
    class MatchTests
    {
      [TestCase(Weapon.Rock, Weapon.Scissors)]
      [TestCase(Weapon.Scissors, Weapon.Paper)]
      [TestCase(Weapon.Paper, Weapon.Rock)]
        public void Player1_Wins_Match(Weapon weaponPlayer1, Weapon weaponPlayer2)
      {
            //Arrange 
            var p1 = new HumanPlayer("Bob");
            p1.SelectedWeapon = weaponPlayer1;
            var p2 = new HumanPlayer("Joe");
            p2.SelectedWeapon = weaponPlayer2;

            var match = new Match(p1,p2);
            var expected = new GameResult(p1.SelectedWeapon, p2.SelectedWeapon);

            //Act
            var actual = match.ProcessGame();

            //Assert
            Assert.AreEqual(actual.ToString(), expected.ToString());
      }
        [TestCase(Weapon.Scissors, Weapon.Rock)]
        [TestCase(Weapon.Paper, Weapon.Scissors)]
        [TestCase(Weapon.Rock, Weapon.Paper)]
        public void Player1_Lose_Match(Weapon weaponPlayer1, Weapon weaponPlayer2)
        {
            //Arrange 
            var p1 = new HumanPlayer("Bob");
            p1.SelectedWeapon = weaponPlayer1;
            var p2 = new HumanPlayer("Joe");
            p2.SelectedWeapon = weaponPlayer2;

            var match = new Match(p1, p2);
            var expected = new GameResult(p2.SelectedWeapon, p1.SelectedWeapon);

            //Act
            var actual = match.ProcessGame();

            //Assert
            Assert.AreEqual(actual.ToString(), expected.ToString());
        }

        [TestCase(Weapon.Rock,Weapon.Rock)]
        [TestCase(Weapon.Scissors, Weapon.Scissors)]
        [TestCase(Weapon.Paper, Weapon.Paper)]        
        public void Same_Moves_Result_in_Draw_Match(Weapon weaponPlayer1,Weapon weaponPlayer2)
        {
            //Arrange 
            var p1 = new HumanPlayer("Bob");
            p1.SelectedWeapon = weaponPlayer1;
            var p2 = new HumanPlayer("Joe");
            p2.SelectedWeapon = weaponPlayer2;

            var match = new Match(p1, p2);
            var expected = GameResult.DrawGameResult;

            //Act
            var actual = match.ProcessGame();

            //Assert
            Assert.AreEqual(actual.ToString(), expected.ToString());
        }
    }
}
