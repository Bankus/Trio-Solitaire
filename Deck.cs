using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Trio_Solitaire
{
    class Deck
    {
        private Card[] cards { get; set; } = new Card[52];

        public  Deck() 
        {
            string cardSuit;
            for (int i = 0; i < 4; i++)
            {
                switch (i)
                {
                    default:
                        cardSuit = "Hearts";
                        break;
                    case 1:
                        cardSuit = "Diamonds";
                        break;
                    case 2:
                        cardSuit = "Clubs";
                        break;
                    case 3:
                        cardSuit = "Spades";
                        break;
                }
                for (int j = 0; j < 13; j++)
                {
                    Card add = new Card(j, cardSuit);
                    cards.Append<Card>(add);
                }

            }
            this.shuffle();
        }

        public void shuffle()
        {
            Random random = new Random();

            for (int k = 0; k < cards.Length; k++)
            {
                int randomIndexToSwap = random.Next(cards.Length);
                Card temp = cards[k];
                cards[randomIndexToSwap] = cards[k];
                cards[k] = temp;
            }
            Console.WriteLine(cards.ToString());
        }

        public void deal() //TODO: return to this once form is a bit more built-up
        {

        }

    }
}
