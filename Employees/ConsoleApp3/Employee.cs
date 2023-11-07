namespace ConsoleApp3
{
    class Employee
    {
        //private string _ssn;
        private string _name;
        private string _title;
        private int salary = 500000;

        public Employee(string ssn) 
        {
            Ssn = ssn;
            Salary = 500000;
        }
        public Employee(string ssn, string name, string title)
        {
            Ssn = ssn;
            _name = name;
            _title = title;
            salary = 500000;
        }

        public string Ssn { get; }
        

        public string Name
        {
            get
            {
                if (string.IsNullOrWhiteSpace(_name))
                {
                    return "-ukjent navn-";
                }
                else
                {
                    return _name;
                }
            }
            set { _name = value; }
        }

        public string Title
        {
            get
            {
                if (string.IsNullOrWhiteSpace(_title))
                {
                    return "-uvist-";
                }
                else
                {
                    return _title;
                }
            } set { _title = value; }
        }

        public int Salary
        {
            get { return salary; }
            set
            {
                if (salary < 500000)
                {
                    Console.WriteLine("Ny lønn har for lav verdi."); 
                }
                else
                {
                    salary = value;
                }
            }
        }

        public string InfoToString()
        {
            return $"{Ssn} {Name} {Title} {Salary}";
        }
        




    }

}