using System.Threading.Channels;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new();
            
            Employee dude = new("22059037181", "John Doe", "Pirate");
            //Console.WriteLine(dude.InfoToString()); 
            employees.Add(dude);

            Employee newDude = new("23059227191");
            employees.Add(newDude);

            Employee lastDude = new("0605195423987", "Jan Peder", "Retired");
            employees.Add(lastDude);

            foreach(Employee employee in employees)
            {
                Console.WriteLine(employee.InfoToString());
                WriteFile(employees);
            }

            Console.WriteLine();

            ReadFile();


        }

        static void ReadFile(string fileName = "data.txt")
        {
            string projectDir = AppContext.BaseDirectory.Substring(0, AppContext.BaseDirectory.LastIndexOf(@"\bin") + 1);
            string path = projectDir + @"files\data.txt";

            string allTextFromFile = File.ReadAllText(path);
            // TODO: print string to console.
            Console.WriteLine("\n"+allTextFromFile);
        }

        static void WriteFile(List<Employee> employees, string fileName = "data.txt")
        {
            string projectDir = AppContext.BaseDirectory.Substring(0, AppContext.BaseDirectory.LastIndexOf(@"\bin") + 1);
            string path = projectDir + @"files\data.txt";

            List<string> employeesAsStrig = new();

            foreach (Employee employee in employees)
            {
                employeesAsStrig.Add(employee.InfoToString());
            }
            

            foreach (Employee employee in employees)
            {
                // TODO: Find correct file write method.
                File.WriteAllLines(path, employeesAsStrig);
                
            }
        }
    }

    

}