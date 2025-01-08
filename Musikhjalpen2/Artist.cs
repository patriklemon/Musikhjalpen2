using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Musikhjalpen2
{
    public class Artist(string Name, string Albums)
    {
        public string Name { get; set; }
        public List<string> Albums;

        
    }
}
