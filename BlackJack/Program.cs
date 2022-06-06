using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    class Program
    {
        static void Main(string[] args) {
            while (true)
            {
                Console.WriteLine("Welcome to C# BlackJack");
                Game game = new Game();
                game.Play();
                Console.WriteLine("Press E to exit the game: ");
                string playAgain = Console.ReadLine().ToUpper();
                if (playAgain == "E") break;
            }
        }
    }
}
