using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Week1Lab1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Bands> listOfBands = new List<Bands>();
        public string FilePath;
        
        public MainWindow()
        {
            InitializeComponent();

            // Sets File Path to the current Directory on Runtime
            FilePath = Directory.GetCurrentDirectory();

            listOfBands.Add(new Rock()
            {
                bandName = "AC / DC",
                yearFormed = new DateTime(1973, 1, 1),
                members = "Angus Young, Brian Johnson, Bon Scott"
            });
            listOfBands.Add(new Rock()
            {  
                bandName = "The Beatles",
                yearFormed = new DateTime(1960,1,1),
                members = "John Lennon, Paul McCartney, Ringo Starr"

            });
            listOfBands.Add(new Pop()
            {
                bandName = "The Spice Boys",
                yearFormed = new DateTime(2020,1,1),
                members = "Adil, Vitor, Mohamed"

            });
            listOfBands.Add(new Pop()
            {
                bandName = "The Bee Gees",
                yearFormed = new DateTime(1958,1,1),
                members = " Barry Gibb, Robin Gibb, Maurice Gibb, Don Henley"

            });
            listOfBands.Add(new Indie()
            {
                bandName = "Arctic Monkeys",
                yearFormed = new DateTime(2000,1,1),
                members = "Alex Turner, Matt Helders, Jamie Cook, Nick O'Malley, Andy Nicholson, Glyn Jones"

            });
            listOfBands.Add(new Indie()
            {
                bandName = "The Strokes",
                yearFormed = new DateTime(1998,1,1),
                members = "Julian Casablancas, Albert Hammond Jr., Nick Valensi, Fabrizio Moretti, Nikolai Fraiture"

            });

            UI_BandsListbox.ItemsSource = listOfBands;
            listOfBands.Sort();

            UI_GenreDropdown.ItemsSource = Enum.GetNames(typeof(BandGenre));
            
        }

        private void UI_BandsListbox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }

        private void UI_GenreDropdown_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void UI_SaveButton_Click(object sender, RoutedEventArgs e)
        {
            File.WriteAllText(FilePath, listOfBands.ToString());
        }
    }
}
