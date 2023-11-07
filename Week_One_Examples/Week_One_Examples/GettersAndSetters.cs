namespace Week_One_Examples
{
    class GettersAndSetters
    {
        //Example 1: Basic Getter and Setter

        public class Person
        {
            private string _name;

            // Getter for retrieving the name
            public string GetName()
            {
                return _name;
            }

            // Setter for setting the name
            public void SetName(string name)
            {
                _name = name;
            }
        }

        // Usage:
        Person person = new Person();
        person.SetName("John");
        string name = person.GetName(); // Get the name
        Console.WriteLine(name); // Outputs "John"
        


        
            
            //Example 2: C# Property with Automatic Getters and Setters

            public class Person
        {
            public string Name { get; set; } // Automatic getter and setter
        }

        // Usage:
        Person person = new Person();
        person.Name = "Jane"; // Set the name
        string name = person.Name; // Get the name
        Console.WriteLine(name); // Outputs "Jane"





            //Example 3: Custom Getter and Setter Logic

            public class TemperatureSensor
        {
            private double _temperature;

            public double Temperature
            {
                get { return _temperature; } // Getter
                set
                {
                    if (value >= -20 && value <= 100)
                    {
                        _temperature = value;
                    }
                    else
                    {
                        Console.WriteLine("Invalid temperature value.");
                    }
                }
            }
        }

        // Usage:
        TemperatureSensor sensor = new TemperatureSensor();
        sensor.Temperature = 25; // Set the temperature
        double temp = sensor.Temperature; // Get the temperature
        Console.WriteLine(temp); // Outputs 25

        sensor.Temperature = 150; // Try to set an invalid temperature








    }
}