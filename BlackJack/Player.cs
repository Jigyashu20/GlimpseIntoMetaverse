using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    internal class inHand
    {
        ArrayList cards;
        public inHand()
        {
            cards = new ArrayList();
        }

        public void AddCard(Card card)
        {
            cards.Add(card);
        }

        public bool IsBusted()
        {
            return this.Total() > 21;
        }

        public int Total()
        {
            int total = 0;
            foreach (Card card in cards)
            {
                total += card.Value;
            }
            return total;
        }
        public override string ToString()
        {
            string s = "Hand: ";
            foreach (Card card in cards)
            {
                s += card + " ";
            }
            s += "\nTotal: ";
            s += Total();
            return s;
        }
    }
    internal class Player
    {
        private inHand hand;

        public Player()
        {
            hand = new inHand();
        }

        public inHand Deal(Deck deck)
        {
            DealCards(2, deck);
            Console.WriteLine();

            bool playing = true;
            while (playing)
            {
                Console.Write("Would you like to Hit (H) or Stay (S)?: ");
                string response = Console.ReadLine();
                response = response.ToUpper();
                if(response == "H")
                {
                    DealCards(1, deck);
                    playing = !hand.IsBusted();
                }
                else if (response == "S")
                {
                    playing = false;
                }
                else
                {
                    Console.WriteLine("Invalid Input");
                }
            }

            return hand;
        }

        public void DealCards(int num, Deck deck)
        {
            string cardString = (num == 1) ? "card" : "cards";
            Console.WriteLine("Dealing new " + cardString);
            for (int i = 0; i < num; i++)
            {
                hand.AddCard(deck.GetCard());
            }
            Console.WriteLine(this.ToString());
        }

        public override string ToString()
        {
            return hand.ToString();
        }
    }
}
