using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Musikhjalpen2
{
    public class Artist
    {
        public string Name { get; set; }
        public List<Album> Albums { get; set; }

        public Artist() { }
        public Artist(string name)
        {
            Name = name;
            Albums = new List<Album>();
        }
    }
}
