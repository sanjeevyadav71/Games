using System;
using System.Collections.Generic;

namespace CardGame.CardModels
{
    public class CardDeck
    {
        public List<Card> CardList { get; set; }
        
        public CardDeck()
        {
            CardList = new List<Card>(Constants.MAX_CARDS);
            Intialize();
            ShuffleAll();
        }

        public void ShuffleAll()
        {
            Shuffle(0);
        }

        public void Shuffle(int startIndex)
        {

            Random randGenerator = new Random();

            for (int i = startIndex; i < CardList.Count; i++)
            {
                int rand = i + randGenerator.Next(CardList.Count - i);

                var temp = CardList[rand];
                CardList[rand] = CardList[i];
                CardList[i] = temp;

            }
        }

        private void Intialize()
        {
            for (short i = 1; i <= Constants.MAX_CARDS; i++)
            {
                CardList.Add(new Card
                {
                    Value = i
                });
            }
        }

        public Card this[int index]
        {
            get => CardList[index];
            set => CardList[index] = value;
        }
    }
}
