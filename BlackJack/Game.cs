using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    internal class Game
    {
        Deck deck;
        public Game()
        {
            deck = new Deck();
        }

        public void Play()
        {
            Player player = new Player();
            inHand playerHand = player.Deal(deck);

            if (playerHand.IsBusted())
            {
                Console.WriteLine("You dun fucked up, son!");
                Console.WriteLine("Game Over!");
            }
            else if(playerHand.Total()==21) 
                Console.WriteLine("Player Wins!");
            else
            {
                Console.WriteLine("Player stays at "+playerHand.Total());

                Console.WriteLine();
                Console.WriteLine("Dealer Playing");
                Player dealer = new Player();
                inHand dealerHand = dealer.Deal(deck);
                if (dealerHand.IsBusted())
                {
                    Console.WriteLine("Dealer busted!");
                    Console.WriteLine("Player Wins!");
                }
                else if (dealerHand.Total() == 21)
                    Console.WriteLine("Dealer Wins!");
                else
                {
                    Console.WriteLine();
                    if (playerHand.Total() > dealerHand.Total())
                    {
                        Console.WriteLine("Player's "+ playerHand.Total() + " beats Dealer's "+ dealerHand.Total());
                        Console.WriteLine("Player Wins!");
                    }
                    else
                    {
                        Console.WriteLine("Dealer's " + dealerHand.Total() + " beats Player's "+ playerHand.Total());
                        Console.WriteLine("Game Over!");
                    }
                }
            }

        }
    }
}
