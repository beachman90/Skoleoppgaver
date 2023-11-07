namespace Checkpoint_week1_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
       
          List<Consultant> consultantList = new();
            
            
           while(true)
            {
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("\nSelect a number:\n");
                Console.WriteLine("1. Exit program");
                Console.WriteLine("2. Add consultant to list");
                Console.WriteLine("3. Write list to console.");
                Console.WriteLine("4. Empty the list");
                Console.WriteLine("5. Save list to file.");
                Console.WriteLine("6. Load list from file and print to screen\n");

                var input = int.Parse(Console.ReadLine());

                switch (input)
                {
                    case 1:
                        Console.WriteLine("Exiting program.");
                        Environment.Exit(0);
                        break;

                    case 2:
                        Console.Clear();
                        Console.WriteLine("2. Add consultant to list\n");
                        ManageList.AddToList(consultantList);
                        Console.WriteLine("\nInfo stored.");
                        Console.ReadLine();
                        Console.Clear();
                        break;

                    case 3:
                        Console.Clear();
                        Console.WriteLine("3. Write list to console\n\n");
                        ManageList.WriteListToConsole(consultantList);
                        Console.WriteLine("\n\nPress any key to go back to menu");
                        Console.ReadLine() ;
                        Console.Clear();
                        break;

                    case 4:
                        Console.Clear();
                        Console.WriteLine("Are you sure you want to empty the list?\n");
                        Console.WriteLine("1. Yes\n2. No\n");
                        int emptyListInput = int.Parse(Console.ReadLine());
                        if(emptyListInput == 1)
                        {
                            consultantList.Clear();
                            Console.Clear() ;
                        } else if (emptyListInput == 2)
                        {
                            break;
                        } else
                        {
                            Console.WriteLine("\nInvalid input given.\nGoing back to menu.");
                            Console.ReadLine();
                        }
                        break;

                    case 5:
                        Console.WriteLine(5);
                        break;

                    case 6:
                        Console.WriteLine(6);
                        break;

                    default:
                        Console.WriteLine("Choose a valid option using a number.");
                        break;

                }





            }
        }
    }

    class FileHandling
    {
        public void CopyToFile(string sourceFilePath, string destinationFilPath)
        {
            string projectDir = AppContext.BaseDirectory.Substring(0, AppContext.BaseDirectory.LastIndexOf(@"\bin") + 1);
            string path = projectDir + @"files\data.txt";

            try
            {
                File.Copy(sourceFilePath, destinationFilPath, true);
                Console.WriteLine("List copied to file.");
            } catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public void FileToConsole(string filePath)
        {
            string projectDir = AppContext.BaseDirectory.Substring(0, AppContext.BaseDirectory.LastIndexOf(@"\bin") + 1);
            string path = projectDir + @"files\data.txt";

            if(File.Exists(path))
            {
                string fileContent = File.ReadAllText(path);
                Console.WriteLine(fileContent);
            }
            else
            {
                Console.WriteLine("File does not exist");
            }

        }
    }
}