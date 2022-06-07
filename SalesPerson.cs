using EmployeeApp;

namespace EmployeeApp
{
    class SalesPerson : Employee
    {
        public int SalesNumber { get; set; }


        // As a general rule, all subclasses should explicitly call an appropriate
        // base class constructor.
        public SalesPerson(string fullName, int age, int empId,
         float currPay, string ssn, int numbOfSales)
         : base(fullName, age, empId, currPay, ssn,
         EmployeePayTypeEnum.Commission)
        {
            // This belongs with us!
            SalesNumber = numbOfSales;
        }
    }
}
