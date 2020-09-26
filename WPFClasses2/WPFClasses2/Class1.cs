using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace WPFClasses2
{//declaring and getting/setting constructors for the class
    class Toy
    {public string Manufacturer { get; set; }
    public string Name { get; set; }
    public double Price { get; set; }
    private string Aisle { get; set; }
//default constructor...
    public Toy()
        {
            Manufacturer = "";
            Name = "";
            Price = 0;
            Aisle = "";
        }
        //overload contructor...
     public Toy(string manufacturer, string name, double price, string aisle)
        {
            manufacturer = Manufacturer;
            name = Name;
            price = Price;
            aisle = Aisle;
        }
        //Override constructor...display info from user into the list box...
        public override string ToString()
        {
            string sentence = $"Manufacturer: {Manufacturer}, Name: {Name}, Price: {Price}";
            return sentence;
        }

        // Get AISLE info and display to a message box....I could not get this section of code to work correctly.  :(
        //public string Aisle1()
        //{
        //    aisle = Manufacturer.Substring(0, 1).ToUpper();

        //    aisle = Price.ToString();

        //    aisle = Aisle;
        //    return Aisle;
        //}

        //MessageBox.Show(SelectedToy.Aisle1());
    }
}
