using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Policy;
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
        PokemonNameAPI Pokemonapi;
        public MainWindow()
        {
            InitializeComponent();

            //string url = @"https://pokeapi.co/api/v2/pokemon?offset=0&limit=1150";
            //PokemonNameAPI Nameapi;
            //using (var client = new HttpClient())
            //{
            //    string results = client.GetStringAsync(url).Result;

            //    Nameapi = JsonConvert.DeserializedObject<PokemonNameAPI>(results);
            //}

            //PokemonNameAPI Pokemonapi;
            using (var client = new HttpClient())
            {
                string AllPokemonURL = @"https://pokeapi.co/api/v2/pokemon?offset=0&limit=1100";

                string json = client.GetStringAsync(AllPokemonURL).Result;

                Pokemonapi = JsonConvert.DeserializeObject<PokemonNameAPI>(json);
            }

            foreach (var pokemon in Pokemonapi.results)
            {
                cboPokemon.Items.Add(pokemon);
            }
        }
        PokemonStatsAPI PokemonSapi;
        private void cboPokemon_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Pokemon SelectedPokemon = (Pokemon)cboPokemon.SelectedItem;
            

            //PokemonStatsAPI PokemonSapi;
            using (var client = new HttpClient())
            {
                string SelectedPokemonURL = SelectedPokemon.url; ;

                string json = client.GetStringAsync(SelectedPokemonURL).Result;

                PokemonSapi = JsonConvert.DeserializeObject<PokemonStatsAPI>(json);
            }

            //PokemonStatsAPI selectedCharacter = (PokemonStatsAPI)cboPokemon.SelectedItem;

            Uri uri = new Uri(PokemonSapi.sprites.front_default);
            BitmapImage picture = new BitmapImage(uri);

            imagePokemon.Source = picture;

            txtHeight.Text = Convert.ToString(PokemonSapi.Height);
            txtWeight.Text = Convert.ToString(PokemonSapi.Weight);
            //lblPokemonName.Content = $"{PokemonNameAPI.results.name}";
        }
    }
}
