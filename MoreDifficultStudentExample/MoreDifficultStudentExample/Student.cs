﻿using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace MoreDifficultStudentExample
{
    class Student
    { public int SoonerID { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public bool IsOnProbation { get; set; }

        public double GPA { get; set; }
        public double BursarBalance;
        public Student()
        {
            SoonerID = -1;
            FirstName = FirstName;
            LastName = LastName;
            IsOnProbation = false;
            GPA = 0;
            BursarBalance = 10000;
        }

        public Student(int id, string fName, string lName, double BursarBalance)
        {
            SoonerID = id;
            FirstName = fName;
            LastName = lName;
            IsOnProbation = false;
            GPA = 0;
            this.BursarBalance = BursarBalance; 
        }

        public void MakePayment(double amount)
        {
            if (amount > 0)
            {
                BursarBalance = BursarBalance - amount;
            }
            else
            {
                throw new Exception();
            }
        }
        //public double CheckBalance()
        //{

        //}
    }
}
