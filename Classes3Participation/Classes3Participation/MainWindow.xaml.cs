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

namespace Classes3Participation
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

        private void btnEnterInfo_Click(object sender, RoutedEventArgs e)
        {
            Student student1 = new Student();
            student1.FirstName = txtFirstName.Text;
            student1.LastName = txtLastName.Text;
            student1.Major = txtMajor.Text;
            student1.GPA = Convert.ToDouble(txtGPA.Text);

            Address address1 = new Address();
            address1.StreetNumber = txtStreetNumber;
            address1.StreetName = txtStreetName;
            address1.State = txtState;
            address1.City = txtCity;
            address1.Zip = txtZip;

            lboStudentInfo.Items.Add(student1);
            lboStudentInfo.Items.Add(address1);
        }
    }
}