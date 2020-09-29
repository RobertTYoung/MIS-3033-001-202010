using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
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

namespace _P__JSON___Pokemon
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            string url = @"https://pokeapi.co/api/v2/pokemon?offset=0&limit=1150";
            PokemonNameAPI Nameapi;
            using (var client = new HttpClient())
            {
                string results = client.GetStringAsync(url).Result;

                Nameapi = JsonConvert.DeserializedObject<PokemonNameAPI>(results);
            }

            foreach (var pokemon in Nameapi.results)
            {
                cboPokemon.Items.Add(pokemon);
            }
        }

        private void cboPokemon_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
