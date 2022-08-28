using System;
using System.Linq;
using EmployeeApp;

namespace EmployeeApp
{

    class Program
    {
        public class FileFormatException : Exception
        {
            //Default Constructor. Calling the Exception constructor using base();
            public FileFormatException() : base()
            {

            }

            //Constructor taking a string and instead of handling itself it lets the inherited constructor hanlde it instead;
            public FileFormatException(String s) : base (s)
            {
             throw new FileFormatException("Your file is not well formatted"); //error message
            }

        }
       static void Main()
        {
            //char.CompareTo();
            //IComparable<>;
            //SalesPerson.Equals(Manager);
            //string
            //string.Contains();

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
            /*    string one = "Hello World!";
                string two = "Hello World!";

                if (((IComparable<string>)one).CompareTo(two) 
                    == 0)
                    Console.WriteLine("They are the same");
                else
                    Console.WriteLine("Not the same");*/

            /* Object[] arr = new Object[10];
             Manager m = new Manager();
             Object obj = m; //Casting manager to object
             arr[0] = obj;*/

            //IList

            //PRIMITIVE TYPES
            /*    char
                bool
                double
                long
                int
                short
                byte*/

            /*int i =  123;
            long l = 123;
           // Object o = (Object)i;
           // Object o2 = (Object)l;


            if (i.Equals(l))
            {
                Console.Write("they are the same");
            }

            else
            {
                Console.Write("Not the same");
            }*/

           



         






        }
    }
}