using System;
using System.Collections.Generic;
using System.IO.Packaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes3Participation
{
    class Student
        //Constructor Properties
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Major { get; set; }
        public double GPA { get; set; }
        public Address Address { get; set; }
    }

    //Default Constructor Methods
    public Student()
    {
        FirstName = "";
        LastName = "";
        Major = "";
        GPA = 0;
    }

    public Student(string firstName, string lastName, string major, double gpa)
    {
        firstName = FirstName;
        lastName = LastName;
        major = Major;
        gpa = GPA; 
    }

    public setAddress(int streetNumber, string streetName, string state, string city, int zip)
    {
        streetNumber = StreetNumber;
        streetName = streetNumber;
        state = State;
        city = City;
        zip = Zip;
    }
    public override string ToString()
    {
        string sentence1 = $"First Name: {Name} Last Name: {LastName}, Major: {Major}, GPA: {GPA}";
        string sentence2 = $"Street Number: {StreetNumber}, Street Name: {StreetName}, State: {State}, City: {City}, Zip: {Zip}";
        return sentence1;
        return sentence2;
    }