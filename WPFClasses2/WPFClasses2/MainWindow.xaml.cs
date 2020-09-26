using System;
using System.Collections.Generic;
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

namespace WPFClasses2
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

        //Button click method
        private void btnClickMe_Click(object sender, RoutedEventArgs e)
        {//Calling the TOY class to take user entry and put it into the list box...
            Toy toy1 = new Toy();
            toy1.Manufacturer = txtManufacturer.Text;
            toy1.Name = txtToyName.Text;
            toy1.Price = Convert.ToDouble(txtToyPrice.Text);

            lstDataList.Items.Add(toy1);

        }
    }
}
