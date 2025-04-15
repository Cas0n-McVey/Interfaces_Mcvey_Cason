using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_Mcvey_Cason
{
    internal class Game : IGenre
    {
        // Automatic Property
        public string Esrb { get; set; }
        public string Genre { get; set; }
        public string Title { get; set; }

        // Implement constructor
        public Game(string esrbParam, string genreParam, string titleParam)
        {
            Esrb = esrbParam;
            Genre = genreParam;
            Title = titleParam;
        }

        // Prints this Console for game
        public void PlayGame()
        {
            Console.WriteLine($"{Title} is starting! Game ON!");
        }

        // Return a string for the Program class
        public string Describle()
        {
            return $"{Title} is a {Genre} game, rated {Esrb}!";
        }


    }
}
