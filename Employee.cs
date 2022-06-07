namespace EmployeeApp
{
    partial class Employee
    {
        // Field data.
        private string _empName;
        private int _empAge;
        private int _empId;
        private float _currPay;        
        private string _empSSN;

        private EmployeePayTypeEnum _payType;

        // Properties!
        public string Name
        {
            get { return _empName; }
            set
            {
                if (value.Length > 15)
                {
                    Console.WriteLine("Error! Name length exceeds 15 characters!");
                }
                else
                {
                    _empName = value;
                }
            }
        }
        public int Id
        {
            get { return _empId; }
            set { _empId = value; }
        }
        public float Pay
        {
            get { return _currPay; }
            set { _currPay = value; }
        }
        public int Age
        {
            get { return _empAge; }
            set { _empAge = value; }
        }
        public string SocialSecurityNumber
        {
            get { return _empSSN; }
            private set => _empSSN = value;

        }
        public EmployeePayTypeEnum PayType
        {
            get => _payType;
            set => _payType = value;
        }

        // Constructors.
        public Employee() { }
        // Add to the Employee base class.
        public Employee(string name, int age, int id, float pay, string empSsn, EmployeePayTypeEnum payType)
        {
            Name = name;
            Id = id;
            Age = age;
            Pay = pay;
            SocialSecurityNumber = empSsn;
            PayType = payType;
        }
        public Employee(string name, int id, float pay, int age)
        {
            _empName = name;
            _empId = id;
            _currPay = pay;
            _empAge = age;
        }

        public Employee(string name, int id, float pay, string empSsn)
        : this(name, 0, id, pay, empSsn, EmployeePayTypeEnum.Salaried)
        {
        }
       

        // Methods.
        public void GiveBonus(float amount)
        {
            Pay = this switch
            {
                { PayType: EmployeePayTypeEnum.Commission }
                => Pay += .10F * amount,
                { PayType: EmployeePayTypeEnum.Hourly }
                => Pay += 40F * amount / 2080F,
                { PayType: EmployeePayTypeEnum.Salaried }
                => Pay += amount,
                _ => Pay += 0
            };
        }
        public void DisplayStats()
        {
            Console.WriteLine("Name: {0}", _empName);
            Console.WriteLine("ID: {0}", _empId);
            Console.WriteLine("Age: {0}", _empAge);
            Console.WriteLine("Pay: {0}", _currPay);
        }
               
       


    }
}
