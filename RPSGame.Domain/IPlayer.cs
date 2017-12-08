namespace RPSGame.Domain
{
    public interface IPlayer
    {
        string Name { get; set; }
        Weapon SelectedWeapon { get; set; }
        void Select();

    }
}
