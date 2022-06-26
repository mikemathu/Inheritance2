using System;
using EmployeeApp;

namespace EmployeeApp
{
    class Manager : Employee
    {
        public int StockOptions { get; set; }

        // Add back the defaultctor
        public Manager() { }
        public Manager(string fullName, int age, int empId,
            float currPay, string ssn, int numbOfOpts)
            : base(fullName, age, empId, currPay, ssn, EmployeePayTypeEnum.Salaried)
        {
            // This property is defined by the Manager class.
            StockOptions = numbOfOpts;

        }

       


    }



}
