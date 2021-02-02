namespace CardGame
{
    public interface ICardPlay
    {
        bool PlayCard(out string card);
        void Shuffle();
        void Restart();
    }
}
