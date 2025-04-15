using Interfaces_Mcvey_Cason;
using System;

namespace interfaces_Mcvey_Cason
{
    class Program
    {
        static void Main(string[] args)
        {
            // Game
            Game myGame = new Game("T", "Sandbox", "Terraria");
            // Prints from the Game class
            Console.WriteLine(myGame.Describle());
            // Prints from the Game class
            myGame.PlayGame();

            // Movie
            Movie myMovie = new Movie("PG", "Adventure/Comedy", "Sonic the Hedgehog 2");
            // Prints from the Movie class
            Console.WriteLine(myMovie.Describle());
            // Prints from the Movie class
            myMovie.PlayMovie();
        }
    }
}
