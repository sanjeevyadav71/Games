using System;

namespace CardGame.CardModels
{
    public class Card
    {
        private int _value;
        public int Value
        {
            get => _value;
            set
            {
                if (value < 1 && value > Constants.MAX_CARDS)
                    throw new ArgumentOutOfRangeException($"Value of card should be in the range of 1 to {Constants.MAX_CARDS} (both inclusive)");
                _value = value;

                SetRankAndSuit(value);
            }
        }

        public Rank Rank { get; private set; }
        public Suit Suit { get; private set; }
        public override string ToString()
        {
            return Rank + " of " + Suit;
        }
        private void SetRankAndSuit(int value)
        {
            Rank = (Rank)(value % 13 == 0 ? 13 : value % 13);
            Suit = (Suit) Math.Ceiling(value / 13.0);
        }
    }
}