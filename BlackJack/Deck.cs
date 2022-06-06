using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    class Card
     {
        public int Value { get; }

       public Card(int value)
      {
        this.Value = value;
      }

    public override string ToString()
      {
        return Value.ToString();
     }
     }
    internal class Deck
    {
        Random random;
        public Deck()
        {
            random = new Random();
        }

        public Card GetCard()
        {
            int rank = random.Next(1, 11);
            Card c = new Card(rank);
            return c;
        }
    }
}
