namespace Week_One_Examples
{
    class WorkingWithFiles 
    {
        //Method for Writing Strings from a List to a Text File:


        class FileHandler
        {
            public static void WriteListToFile(string filePath, List<string> lines)
            {
                try
                {
                    File.WriteAllLines(filePath, lines);
                    Console.WriteLine("Text has been written to the file.");
                }
                catch (IOException ex)
                {
                    Console.WriteLine("Error writing to the file: " + ex.Message);
                }
            }
        }



        //Method for Reading Text from a File and Printing to the Console:


        class FileHandler
        {
            public static void ReadFileAndPrintToConsole(string filePath)
            {
                if (File.Exists(filePath))
                {
                    try
                    {
                        string[] lines = File.ReadAllLines(filePath);
                        Console.WriteLine("Text read from the file:");
                        foreach (string line in lines)
                        {
                            Console.WriteLine(line);
                        }
                    }
                    catch (IOException ex)
                    {
                        Console.WriteLine("Error reading the file: " + ex.Message);
                    }
                }
                else
                {
                    Console.WriteLine("The file does not exist.");
                }
            }
        }



        //You can call these methods like this:

        class Program
        {
            static void Main()
            {
                string filePath = "sample.txt";
                List<string> linesToWrite = new List<string>
        {
            "Line 1",
            "Line 2",
            "Line 3"
        };

                FileHandler.WriteListToFile(filePath, linesToWrite);

                FileHandler.ReadFileAndPrintToConsole(filePath);
            }
        }








    }




}