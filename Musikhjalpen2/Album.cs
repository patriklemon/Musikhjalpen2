using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Musikhjalpen2
{
    public class Album
    {
        public string Name { get; set; }
        public List<Song> Songs { get; set; }

        public Album() { }
        public Album(string name)
        {
            Name = name;
            Songs = new List<Song>();
        }
    }

}
