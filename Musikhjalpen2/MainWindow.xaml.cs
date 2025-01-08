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
        public MainWindow()
        {
            InitializeComponent();
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

        private void btnWish_Click(object sender, RoutedEventArgs e)
        {
            string wishedSong = txtboxWishSongNumber.Text;

            //double wishSongNumber = Convert.ToInt32(wishedSong); Försökte med en koverterare först men det funkade inte

            int wishSongNumber = (int)Math.Truncate(double.Parse(wishedSong.ToString())); //Hittade Math.Trancute på https://stackoverflow.com/questions/47866486/convert-object-to-int-without-rounding

            MessageBox.Show($"Din röst på {wishedSong} har registrerats som {wishSongNumber}");

            song = wishSongNumber;
            vote++;
            if (wishedSong != null) //Om wishedSong inte är tom så ska den lägga till värdet i _wishlist. FUnkar dock inte än
                {_wishlist.Add(song); }
        }

        private void btnVisaSaldo_Click(object sender, RoutedEventArgs e)
        {

            MessageBox.Show($"Du har röstat på {vote}st låtar. Det har get {vote * saldo}kr till Musikhjälpen"); //Inte helt nöjd med vote*saldo här. Det går nog att göra snyggare. Men det funkar för detta.
        }

        private int StringToValueConverter()
        {
            string value = txtboxWishSongNumber.Text; // Tog inspiration här https://code-maze.com/csharp-find-index-of-value-in-string-array/
            int index = Array.IndexOf(numbers, value);
            return index;
        }

        private int StringToValueConverter2()
        {
            {
                string value = txtboxWishSongNumber.Text;
                string trimmed = value.TrimStart(); //Oklart om denna metod får användas. Den tar bort whitespaces. Hittades här: https://kodify.net/csharp/strings/remove-whitespace/
                int index = Array.IndexOf(numbers, trimmed);
                /*string[] index = Array.ConvertAll(value.Split(','), p => p.Trim());*/ //Denna är ifrån https://stackoverflow.com/questions/1977340/perform-trim-while-using-split
                return index; //Får dock inte dessa att prata med btnTextToSpeech_Click nedan
            }
        }

        private void btnTextToSpeech_Click(object sender, RoutedEventArgs e)
        {
            StringToValueConverter();
            StringToValueConverter2();
            
        }

        private void FindMostVotedSong()
        {
            int[] mostVotedSongs = new int[100];
            int maxValue = mostVotedSongs.Max();
            int maxIndex = mostVotedSongs.ToList().IndexOf(maxValue);

            MessageBox.Show($"Du vill allra helst höra låt nummer {maxValue}"); //Detta funkar inte men det syns kanske vad jag försökt göra. Får bara värde 0 då _wishlist troligen inte tar emot värde.
        }

        private void btnMostPopularSong_Click(object sender, RoutedEventArgs e)
        {
            FindMostVotedSong();
            
        }
            //Påbörjat bonusuppgiften
            string[] names = {
            "Brita Zackari", "Christer Lundberg", "Daniel Adams-Ray",
            "Ehsan Noroozi", "Emil Hansius", "Emma Knyckare",
            "Farah Abadi", "Felix Sandman", "Gina Dirawi",
            "Jason Diakité", "Jason Diakitée", "Kalle Zackari Wahlström",
            "Klas Eriksson", "Kodjo Akolor", "Linnea Henriksson",
            "Little Jinder", "Martina Thun", "Molly Sandén",
            "Nour El Refai", "Oscar Zia", "Sarah Dawn Finer",
            "Sofia Dalén", "Tina Mehrafzoon", "Kitty Jutbring",
            "William Spetz", "Ametist Azordegan", "Anis Don Demina",
            "Assia Dahir", "Daniel Hallberg", "Henrik Torehammar",
            "Howlin' Pelle", "Linnea Henriksson", "Linnéa Wikblad",
            "Miriam Bryant", "Petter Askergren"
            };

        public void GetAllArtists()
        {
            string allTheArtists = Name.Artist; //har ingen aning om jag ska kunna filtrera ut bara artisterna ur SongHandler. Uppgift 7
        }

        private void btnGetAllArtists_Click(object sender, RoutedEventArgs e)
        {
            GetAllArtists();
        }

        public void btnArtist_Click(object sender, RoutedEventArgs e)
        {
            GetArtistByAlbum(); //Metoden ligger i Songhandler och vill inte prata med denna klass. Alla rekommendation jag hittar på google säger att jag ska flytta
        }                       //den till den här klassen, vilket vi inte får göra. CS0103

        public void GetMostPopularArtist()
        {

        }

        private void btnMostPopularArtist_Click(object sender, RoutedEventArgs e) //Uppgift 10
        {
            GetMostPopularArtist();
        }
    }
}