using JSON_Pokemon;
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

namespace JSON_Pokemon
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            string webService = @"https://pokeapi.co/api/v2/pokemon";

            //HttpClient client = new HttpClient();
            Characters characters;
            using (var client = new HttpClient())
            {
                var results = client.GetStringAsync(webService).Result;

                characters = JsonConvert.DeserializeObject<Characters>(results);
            }

            foreach (var character in characters.results)
            {
                cboCharacters.Items.Add(character);
            }

        }
        private void cboCharacters_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var character = (Character)cboCharacters.SelectedItem;
            var uri = new Uri(character.front_default);
            var img = new BitmapImage(uri);
            imgCharacter.Source = img;
            lblHeightWeight.Content = $"{ character.name} has a height of {character.height}, and a weight of {character.weight}";
        }
    }
}

