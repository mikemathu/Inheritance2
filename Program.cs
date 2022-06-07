using System;
using EmployeeApp;

namespace EmployeeApp
{

    class Program
    {
       static void Main()
        {

            SalesPerson fred = new SalesPerson
            {
                Age = 31,
                Name = "Fred",
                SalesNumber = 50
            };

            fred.DisplayStats();
        }
    }
}