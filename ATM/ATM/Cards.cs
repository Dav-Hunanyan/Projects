using System;
using System.Collections.Generic;

namespace ATM
{
    class Cards
    {
        public List<Card> cards;
        public Cards()
        {
            cards = new List<Card>();
        }

        public void Print()
        {
            for (int i = 0; i < cards.Count; i++)
            {
                Console.Write((i + 1) + "."); cards[i].Print_name();
            }
        }
    }
}
