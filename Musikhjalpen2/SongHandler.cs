using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Musikhjalpen2
{
    public class SongHandler
    {
        #region Artists
        private List<Artist> _artists = new List<Artist>()
         {
         new Artist()
         {
             Name = "Sting",
             Albums = new List<Album>()
             {
                 new Album()
                 {
                     Name = "The Dream of the Blue Turtles",
                     Songs = new List<Song>()
                     {
                         new Song() { Name = "If You Love Somebody Set Them Free", Votes = 3500 },
                         new Song() { Name = "Russians", Votes = 12000 },
                         new Song() { Name = "Moon over Bourbon Street", Votes = 0 },
                         new Song() { Name = "Fortress Around Your Heart", Votes = 7000 }
                     }
                 },
                 new Album()
                 {
                     Name = "Ten Summoner's Tales",
                     Songs = new List<Song>()
                     {
                         new Song() { Name = "Fields of Gold", Votes = 500 },
                         new Song() { Name = "She's Too Good for Me", Votes = 2500 },
                         new Song() { Name = "Seven Days", Votes = 10000 },
                         new Song() { Name = "It's Probably Me", Votes = 8000 },
                         new Song() { Name = "Shape of My Heart", Votes = 3000 }
                     }
                 }
             }
         },
         new Artist()
         {
             Name = "Adele",
             Albums = new List<Album>()
             {
                 new Album()
                 {
                     Name = "25",
                     Songs = new List<Song>()
                     {
                         new Song() { Name = "Hello", Votes = 15000 },
                         new Song() { Name = "Send My Love", Votes = 11000 },
                         new Song() { Name = "I Miss You", Votes = 5000 }
                     }
                 }
             }
         },
         new Artist()
         {
             Name = "The Beatles",
             Albums = new List<Album>()
             {
                 new Album()
                 {
                     Name = "Abbey Road",
                     Songs = new List<Song>()
                     {
                         new Song() { Name = "Come Together", Votes = 12000 },
                         new Song() { Name = "Something", Votes = 8000 },
                         new Song() { Name = "Octopus's Garden", Votes = 7000 },
                         new Song() { Name = "Here Comes The Sun", Votes = 13000 }
                     }
                 },
                 new Album()
                 {
                     Name = "Let It Be",
                     Songs = new List<Song>()
                     {
                         new Song() { Name = "Let It Be", Votes = 15487 },
                         new Song() { Name = "Across The Universe", Votes = 11000 },
                         new Song() { Name = "The Long And Winding Road", Votes = 9000 }
                     }
                 }
             }
         },
         new Artist()
         {
             Name = "Coldplay",
             Albums = new List<Album>()
             {
                 new Album()
                 {
                     Name = "A Head Full of Dreams",
                     Songs = new List<Song>()
                     {
                         new Song() { Name = "Adventure of a Lifetime", Votes = 14000 },
                         new Song() { Name = "Hymn for the Weekend", Votes = 12000 },
                         new Song() { Name = "Up&Up", Votes = 10000 },
                         new Song() { Name = "Everglow", Votes = 8000 }
                     }
                 }
             }
         },
         new Artist()
         {
             Name = "Ed Sheeran",
             Albums = new List<Album>()
             {
                 new Album()
                 {
                     Name = "Divide",
                     Songs = new List<Song>()
                     {
                         new Song() { Name = "Shape of You", Votes = 15000 },
                         new Song() { Name = "Castle on the Hill", Votes = 13000 },
                         new Song() { Name = "Galway Girl", Votes = 11000 },
                         new Song() { Name = "Perfect", Votes = 14000 },
                         new Song() { Name = "Happier", Votes = 9000 }
                     }
                 },
                 new Album()
                 {
                     Name = "Plus",
                     Songs = new List<Song>()
                     {
                         new Song() { Name = "The A Team", Votes = 7000 },
                         new Song() { Name = "Lego House", Votes = 8000 },
                         new Song() { Name = "Drunk", Votes = 3000 }
                     }
                 }
             }
         }

         };
        #endregion
        public void GetArtistNameByAlbum()
        {
            foreach(Album alb in _artists)
            {
                if(txtboxWishSongNumber.Text == alb)
                {
                    alb.Show()

                }
            }
        }
    }

    
}
