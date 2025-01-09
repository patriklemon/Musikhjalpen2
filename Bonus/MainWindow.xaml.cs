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

namespace Bonus
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnProgramledare_Click(object sender, RoutedEventArgs e)
        {
            // Lista över programledarnamn
            List<string> names = new List<string>
            {
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

            // Hämta bokstav från textbox
            string inputLetter = txtboxBokstav.Text;

            if (string.IsNullOrEmpty(inputLetter) || inputLetter.Length != 1 || !char.IsLetter(inputLetter[0]))
            {
                MessageBox.Show("Skriv in en giltig bokstav!");
                return;
            }

            char letter = char.ToUpper(inputLetter[0]); // Konvertera till versal för att säkerställa jämförelse

            // a) Räkna namn som börjar på den angivna bokstaven
            int count = CountNamesByStartingLetter(letter, names);

            // b) Hämta personer som börjar på den angivna bokstaven
            List<string> people = GetPeopleByStartingLetter(letter, names);

            // Visa resultat i en MessageBox
            MessageBox.Show($"Antal programledare som börjar på '{letter}': {count}\n" +
                            $"Programledare: {string.Join(", ", people)}");
        }


        // Metod för att räkna antalet namn som börjar på en viss bokstav
        public int CountNamesByStartingLetter(char letter, List<string> names)
        {
            int count = 0;

            foreach (string name in names)
            {
                if (!string.IsNullOrEmpty(name) && char.ToUpper(name[0]) == char.ToUpper(letter))
                {
                    count++;
                }
            }

            return count;
        }

        // Metod för att hämta namn som börjar på en viss bokstav
        public List<string> GetPeopleByStartingLetter(char letter, List<string> names)
        {
            List<string> result = new List<string>();

            foreach (string name in names)
            {
                if (!string.IsNullOrEmpty(name) && char.ToUpper(name[0]) == char.ToUpper(letter))
                {
                    result.Add(name);
                }
            }

            return result;
        }

        
    }
}