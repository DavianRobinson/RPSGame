namespace RPSGame.Domain
{
    public interface IGameEngine
    {
        Match SelectedMatch { get; set; }

        void Init();
    }
}