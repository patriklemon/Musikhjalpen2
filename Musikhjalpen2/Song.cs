using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Musikhjalpen2
{
    public class Song
    {
        public string Name { get; set; }
        public int Number { get; set; }
        public int Votes { get; set; }

        public Song(string name)
        {
            Name = name;
        }
    }
}
