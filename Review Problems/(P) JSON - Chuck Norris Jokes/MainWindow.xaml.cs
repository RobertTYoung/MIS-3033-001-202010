using Newtonsoft.Json;
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

namespace _P__JSON___Chuck_Norris_Jokes
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            string url = @"https://api.chucknorris.io/jokes/categories";
            ChuckNorrisAPI api;
            using (var client = new HttpClient())
            {
                //string results = client.GetStringAsync(url).Result;

                //api = JsonConvert.DeserializeObject<ChuckNorrisAPI>(results);

                string jsonResults = client.GetStringAsync(url).Result;

                string[] cats = JsonConvert.DeserializeObject<String[]>(jsonResults);

                foreach (var category in cats)
                {
                    cboCategory.Items.Add(category);
                }

            }

            //foreach (var category cats)
            //{
            //    cboCategory.Items.Add(category);
            //}

            //jsonResults = client.GetStringAsync(@"https://api.chucknorris.io/jokes/categories").Results;

            //string[] cats = JsonConvert.DeserializeObject<String[]>(jsonResults);
        }

        private void btnGetQuote_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
