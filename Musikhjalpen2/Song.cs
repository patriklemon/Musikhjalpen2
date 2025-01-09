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

        // Konstruktor som tar emot ett namn
        //public Song(string name)
        //{
        //    Name = name;
        //}

        // Metod för att tilldela unika numrering av låtar
        public static void AssignUniqueSongNumbers(List<Artist> artists)
        {
            int songNumber = 1; // Starta numreringen från 1

            // Gå igenom alla artister, deras album och deras låtar
            foreach (var artist in artists)
            {
                foreach (var album in artist.Albums)
                {
                    foreach (var song in album.Songs)
                    {
                        song.Number = songNumber;  // Tilldela låten ett unikt nummer
                        songNumber++;  // Öka numret för nästa låt
                    }
                }
            }
        }
    }



}
