using System;
using EmployeeApp;

namespace EmployeeApp
{

    class Program
    {
       static void Main()
        {
            //char.CompareTo();
            //IComparable<>;
            //SalesPerson.Equals(Manager);
            //string

            /* SalesPerson fred = new SalesPerson
             {
                 Age = 31,
                 Name = "Fred",
                 SalesNumber = 50
             };

             fred.DisplayStats();*/

            //COMPARABLE GENERICS
            string one = "Hello World!";
            string two = "Hello World!";
            if (one.Equals(two))
                Console.WriteLine("they are the same");
            else
                Console.WriteLine("Not the same");
        }
    }
}