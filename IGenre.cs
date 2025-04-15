using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_Mcvey_Cason
{
    internal interface IGenre
    {
        // Automatic Property
        public string Esrb { get; set; }

        public string Genre { get; set; }

        public string Title { get; set; }

        // Describle is for Movie and Game class
        public string Describle();

    }
}
