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

namespace Participation1_FirstWPFApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            txtUsersName.Text = string.Empty;
            btnCalculate.IsEnabled = true;
        }

        private void btnCalculate_Click(object sender, RoutedEventArgs e)
        {
            int userage = DateTime.Today.Year - dtpBirthDate.SelectedDate.Value.Year;

            string message = $"Hi {txtUsersName}, your currnet age is {userage}!";
        }

        private void txt_KeyDown(object sender, KeyEventArgs e)
        {
            btnCalculate.IsEnabled = ShouldWeEnableTheButton();
        }

        private bool ShouldWeEnableTheButton()
        {
            bool result = false;
            if (txtUsersName.Text != string.Empty
                && dtpBirthDate.Text != string.Empty)
            {
                result = true;
            }
            return result;
        }
    }
}
