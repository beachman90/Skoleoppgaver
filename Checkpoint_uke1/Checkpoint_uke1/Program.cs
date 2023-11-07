using System.Runtime.Intrinsics.X86;

namespace Checkpoint_uke1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Consultant> consultantList = new();
            
            Consultant consultant1 = new("Monkey Man", "81549300");
            consultantList.Add(consultant1);

            Consultant consultant2 = new("Face Palm", "12345678");
            consultantList.Add(consultant2);

            Consultant consultant3 = new("Smack Sparrow", "22059023");
            consultantList.Add(consultant3);

            foreach(Consultant consultant in consultantList)
            {
                Console.WriteLine(consultant.InfoToString());
            }
            
            consultant1.Phonenumber = "95928134";
            Console.WriteLine(consultant1.InfoToString());            
        }
    }
}