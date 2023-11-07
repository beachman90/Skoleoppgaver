namespace Checkpoint_uke1
{
    class Consultant
    {
        private string _name;
        private string _phonenumber;


        public Consultant(string name, string phonenumber)
        {
            _name = name;
            _phonenumber = phonenumber;
        }

        public Consultant(string name)
        {
            _name = name;
        }

        public string Name { get { return _name; } }

        public string Phonenumber
        {
            get { return _phonenumber; }
            set { _phonenumber = value; }
        }

        public string InfoToString()
        {
            return $"Name: {Name.PadRight(15)} |    PhoneNumber: {Phonenumber}";
        }
    }
}