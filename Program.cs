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
            /*  string one = "Hello World";
              string two = "Hello World!";
              if (one.Equals(two))
              {
                  Console.Write("String :");
                  Console.Write("they are the same");
              }

              else
              {
                  Console.Write("String :");
                  Console.Write("Not the same");


              }

              Object o = one;
              Object t = two;
              if (o.Equals(t))
              {
                  Console.WriteLine();
                  Console.Write("Object :");
                  Console.Write("they are the same");
              }

              else
              {
                  Console.WriteLine();
                  Console.Write("Object :");
                  Console.Write("Not the same");
              }*/

            //USING COMPARABLE INTERFACE
            string one = "Hello World!";
            string two = "Hello World!";

            if (((IComparable<string>)one).CompareTo(two) 
                == 0)
                Console.WriteLine("They are the same");
            else
                Console.WriteLine("Not the same");

        }
    }
}