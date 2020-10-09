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
using static ChuckNorrisJokes.jokes;

namespace ChuckNorrisJokes
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private object JsonConvert;

        public MainWindow()
        {
            InitializeComponent();

            string datasetUrl = "https://api.chucknorris.io/";

            AllJokes alljokies
;

            using (var client = new HttpClient())
            {
                string json = client.GetStringAsync(datasetUrl).Result;

                alljokies = JsonConvert.DeserializeObject<AllJokes>(json);
            }

            foreach (var item in alljokies.results)
            {
                cboJokeCategories.Items.Add(item);
            }
        }

        private void cboJokeCategories_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedCategory = (ResultObject)cboJokeCategories.SelectedItem;

            string datasetUrl2 = "https://api.chucknorris.io/jokes/categories" + selectedCategory;

            RandomJoke randomJoke;

            using (var client = new HttpClient())
            {
                string json = client.GetStringAsync(datasetUrl2).Result;

                randomJoke = JsonConvert.DeserializeObject<RandomJoke>(json);
            }
        }

        private void btnSelectMe_Click(object sender, RoutedEventArgs e)
        {
            string jokeApiUrl = @"https://api.chucknorris.io/jokes/random";

            using (var client = new HttpClient())
            {
                string json = client.GetStringAsync(jokeApiUrl).Result;

                var jokeQuote = JsonConvert.DeserializeObject<jokes>(json);
                tboJokeOutput.Text = $"{value}";
            }

        }
    }
}
