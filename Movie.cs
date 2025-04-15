using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_Mcvey_Cason
{
    internal class Movie : IGenre
    {
        // Automatic Property
        public string Esrb { get; set; }
        public string Genre { get; set; }
        public string Title { get; set; }

        // Implement constructor
        public Movie(string esrbParam, string genreParam, string titleParam)
        {
            Esrb = esrbParam;
            Genre = genreParam;
            Title = titleParam;
        }

        // Prints this Console for movie
        public void PlayMovie()
        {
            Console.WriteLine($"{Title} is starting, SSsssshhhhh!");
        }

        // Return a string for the Program class
        public string Describle()
        {
            return $"{Title} is a {Genre} movie, rated {Esrb}";
        }
    }
}
