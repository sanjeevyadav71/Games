using CardGame.CardModels;

namespace CardGame
{
    public class CardPlay : ICardPlay
    {
        int top;
        CardDeck DeckOfCards;

        public CardPlay()
        {
            top = 0;
            DeckOfCards = new CardDeck();
        }

        public bool PlayCard(out string card)
        {
            if (top >= Constants.MAX_CARDS)
            {
                card = string.Empty;
                return false;
            }

            var topCard = DeckOfCards[top];
            card = topCard.ToString();
            top++;
            
            return true;
        }

        public void Restart()
        {
            top = 0;
            DeckOfCards.ShuffleAll();
        }

        public void Shuffle()
        {
            DeckOfCards.Shuffle(top);
        }
    }
}
