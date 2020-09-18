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

namespace WPF1
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

        private void btnEnter_Click(object sender, RoutedEventArgs e)
        {
            //Retrieve information the user enters into the text boxes.

            string name = txtName.Text;
            string address = txtAddress.Text;
            int zipCode = txtZipCode.PersistId;

            //Call the EntryForm class, using the following object:

            EntryForm entry = new EntryForm(name, address, zipCode);

            lstUserInfo.Items.Add(entry.name + " " + entry.address + " " + entry.zipCode);
        }
    }
}
