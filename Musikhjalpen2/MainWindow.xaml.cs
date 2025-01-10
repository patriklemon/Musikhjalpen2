using System;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Musikhjalpen2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private SongHandler _songHandler; // Instanser av SongHandler, som ansvarar för att hantera låtar och artister.
        private SongHandler songHandler;


        public MainWindow()
        {
            InitializeComponent();
            _songHandler = new SongHandler(); // Skapa en instans av SongHandler för intern användning.
            songHandler = new SongHandler(); // Skapa en separat instans (redundant här).

        }

        int vote = 0;
        int saldo = 50;
        int song = 0;
        
        List<int> _wishlist = new List<int>
        {

        };

        string[] numbers = new string[]
        {
                 "ett", "två", "tre", "fyra", "fem", "sex", "sju", "åtta", "nio", "tio",
                 "elva", "tolv", "tretton", "fjorton", "femton", "sexton", "sjutton", "arton", "nitton",
                 "tjugo", "tjugoett", "tjugotvå", "tjugotre", "tjugofyra", "tjugofem", "tjugosex", "tjugosju", "tjugooåtta", "tjugonio",
                 "trettio", "trettioett", "trettiotvå", "trettiotre", "trettiofyra", "trettiofem", "trettiosex", "trettiosju", "trettioåtta", "trettionio",
                 "fyrtio", "fyrtioett", "fyrtiotvå", "fyrtiotre", "fyrtiofyra", "fyrtiofem", "fyrtiosex", "fyrtiosju", "fyrtioåtta", "fyrtionio",
                 "femtio", "femtioett", "femtiotvå", "femtiotre", "femtiofyra", "femtiofem", "femtiosex", "femtiosju", "femtioåtta", "femtionio",
                 "sextio", "sextioett", "sextiotvå", "sextiotre", "sextiofyra", "sextiofem", "sextiosex", "sextiosju", "sextioåtta", "sextionio",
                 "sjuttio", "sjuttioett", "sjuttiotvå", "sjuttiotre", "sjuttiofyra", "sjuttiofem", "sjuttiosex", "sjuttiosju", "sjuttioåtta", "sjuttionio",
                 "åttio", "åttioett", "åttiotvå", "åttiotre", "åttiofyra", "åttiofem", "åttiosex", "åttiosju", "åttioåtta", "åttionio",
                 "nittio", "nittioett", "nittiotvå", "nittiotre", "nittiofyra", "nittiofem", "nittiosex", "nittiotosju", "nittioåtta", "nittionio",
                 "hundra", "hundraett", "hundratvå", "hundratre", "hundrafyra", "hundrafem", "hundrasex", "hundrasju", "hundraåtta", "hundranio", "hundratio",
                 "hundraelva", "hundratolv", "hundratretton", "hundrafjorton", "hundrafemton", "hundrasexton", "hundrasjutton", "hundraarton", "hundranitton",
                 "hundratjugo", "hundratjugoett", "hundratjugotvå", "hundratjugotre", "hundratjugoFyra", "hundratjugofem", "hundratjugosex", "hundratjugosju", "hundratjugoåtta", "hundratjugonio",
                 "hundratrettio", "hundratrettioett", "hundratrettiotvå", "hundratrettiotre", "hundratrettiofyra", "hundratrettiofem", "hundratrettiosex", "hundratrettiosju", "hundratrettioåtta", "hundratrettionio",
                 "hundrafyrtio", "hundrafyrtioett", "hundrafyrtiotvå", "hundrafyrtiotre", "hundrafyrtiofyra", "hundrafyrtiofem", "hundrafyrtiosex", "hundrafyrtiosju", "hundrafyrtioåtta", "hundrafyrtionio",
                 "hundrafemtio", "hundrafemtioett", "hundrafemtiotvå", "hundrafemtiotre", "hundrafemtiofyra", "hundrafemtiofem", "hundrafemtiosex", "hundrafemtiosju", "hundrafemtioåtta", "hundrafemtionio",
                 "hundrasextio", "hundrasextioett", "hundrasextiotvå", "hundrasextiotre", "hundrasextiofyra", "hundrasextiofem", "hundrasextiosex", "hundrasextiosju", "hundrasextioåtta", "hundrasextionio",
                 "hundrasjuttio", "hundrasjuttioett", "hundrasjuttitvå", "hundrasjuttitre", "hundrasjuttiofyra", "hundrasjuttiofem", "hundrasjuttiosex", "hundrasjuttiosju", "hundrasjuttioåtta", "hundrasjuttionio",
                 "hundraåttio", "hundraåttioett", "hundraåttiotvå", "hundraåttiotre", "hundraåttiofyra", "hundraåttiofem", "hundraåttiosex", "hundraåttiosju", "hundraåttioåtta", "hundraåttionio",
                 "hundranittio", "hundranittioett", "hundranittiotvå", "hundranittiotre", "hundranittiofyra", "hundranittiofem", "hundranittiosex", "hundranittiosju", "hundranittioåtta", "hundranittionio",
                 "tvåhundra", "tvåhundraett", "tvåhundratvå", "tvåhundratre", "tvåhundrafyra", "tvåhundrafem", "tvåhundrasex", "tvåhundrasju", "tvåhundraåtta", "tvåhundranio","tvåhundratio"
        };

        private void btnWish_Click(object sender, RoutedEventArgs e) // Hanterar önskelistan när användaren trycker på knappen Önska
        {
            if (double.TryParse(txtboxWishSongNumber.Text, out double wishedSong))
            {
                int wishSongNumber = (int)Math.Truncate(wishedSong); //https://learn.microsoft.com/en-us/dotnet/api/system.math.truncate?view=net-9.0
                MessageBox.Show($"Din röst på {wishedSong} har registrerats som {wishSongNumber}");

                song = wishSongNumber;
                vote++;
                _wishlist.Add(song);
            }
            else
            {
                MessageBox.Show("Ogiltig inmatning! Vänligen ange ett giltigt nummer.");
            }
        }

        private void btnVisaSaldo_Click(object sender, RoutedEventArgs e)
        {

            MessageBox.Show($"Du har röstat på {vote}st låtar. Det har get {vote * saldo}kr till Musikhjälpen"); //Inte helt nöjd med vote*saldo här. Det går nog att göra snyggare. Men det funkar för detta.
        }

        private int StringToValueConverter(string input) //Konverterar en textrepresentation av ett nummer till motsvarande heltalsvärde.
        {
            input = input.ToLower(); // konvertera till små bokstäver
            int index = Array.IndexOf(numbers, input); // Hitta index
            return index + 1; // Lägg till 1 för att få rätt nummer
        }



        private void btnTextToSpeech_Click(object sender, RoutedEventArgs e) //konvertering av text till nummer
        {
            
            int value1 = StringToValueConverter("hundratjugofem");
            int value2 = StringToValueConverter("ett");
            int value3 = StringToValueConverter("tvåhundratio");

            // Visa resultaten i en MessageBox
            MessageBox.Show($"Konverterade värden:\n125 ➞ {value1}\n1 ➞ {value2}\n210 ➞ {value3}");

            // Testa med textrutan
            string userInput = txtboxWishSongNumber.Text;
            if (!string.IsNullOrWhiteSpace(userInput))
            {
                int userValue = StringToValueConverter(userInput);
                MessageBox.Show($"Inmatningen '{userInput}' konverterades till {userValue}");
            }
        }

        private void FindMostVotedSong()
        {
            int[] mostVotedSongs = new int[100];
            int maxValue = mostVotedSongs.Max(); // Hitta maxvärdet i arrayen
            int maxIndex = mostVotedSongs.ToList().IndexOf(maxValue); // visar index av maxvärdet

            MessageBox.Show($"Du vill allra helst höra låt nummer {maxValue}");
        }

        private void btnMostPopularSong_Click(object sender, RoutedEventArgs e)
        {
            FindMostVotedSong();
            
        }
            
        public void GetAllArtists() // hämtar alla artister och söker efter specifika låtar baserat på inmatning
        {
            int songNumber;
            if (int.TryParse(txtboxWishSongNumber.Text, out songNumber))
            {
                bool found = false;

                // hämtar artister via SongHandler
                var songHandler = new SongHandler();
                var artists = songHandler.GetArtists(); // Hämta listan över artister

                // söker igenom alla artister och deras album
                foreach (var artist in artists)
                {
                    foreach (var album in artist.Albums)
                    {
                        foreach (var song in album.Songs)
                        {
                            if (song.Number == songNumber)
                            {
                                MessageBox.Show($"Röst registrerad för låten: {song.Name}");
                                song.Votes++;  // ökar röster för den valda låten
                                found = true;
                                break;
                            }
                        }

                        if (found) break;
                    }

                    if (found) break;
                }

                if (!found)
                {
                    MessageBox.Show("Hittade ingen låt med det numret.");
                }
            }
            else
            {
                MessageBox.Show("Ogiltigt nummer.");
            }
        }

        private void btnGetAllArtists_Click(object sender, RoutedEventArgs e)
        {
            SongHandler songHandler = new SongHandler();
            songHandler.AssignUniqueSongNumbers(); // tilldela unika låtnummer

            MessageBox.Show("Låtnummer har tilldelats!");
        }

        private void btnArtist_Click(object sender, RoutedEventArgs e)
        {
            string albumName = txtboxWishSongNumber.Text; // Hämta albumnamnet från TextBox

            SongHandler songHandler = new SongHandler(); // Skapa ett objekt av SongHandler
            string artistName = songHandler.GetArtistNameByAlbum(albumName); // Hitta artisten

            MessageBox.Show(artistName); // Visa resultatet i en MessageBox
        }                //den till den här klassen, vilket vi inte får göra. CS0103

        private void btnMostPopularArtist_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Anropa metoden från SongHandler
                Artist mostPopularArtist = songHandler.GetMostPopularArtist();

                // Visa resultatet i en MessageBox
                if (mostPopularArtist != null)
                {
                    MessageBox.Show($"Den mest populära artisten är {mostPopularArtist.Name} med totalt flest röster!");
                }
                else
                {
                    MessageBox.Show("Kunde inte hitta någon artist.");
                }
            }
            catch (Exception ex)
            {
                // Fånga och visa eventuella fel för att felsöka
                MessageBox.Show($"Ett fel inträffade: {ex.Message}");
            }
        }


    }
}