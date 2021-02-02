namespace CardGame
{
    public interface ICardPlay
    {
        bool PlayCard(out string card);
        bool Shuffle();
        void Restart();
    }
}
