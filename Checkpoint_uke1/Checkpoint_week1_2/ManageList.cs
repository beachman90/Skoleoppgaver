namespace Checkpoint_week1_2
{
    public class ManageList
    {
        public static void AddToList(List<Consultant> consultantList)
        {

            Console.Write("Input name og consultant: ");
            string name = Console.ReadLine();

            Console.Write("\nInput consultant phonenumber: ");
            string phoneNumber = Console.ReadLine();


            Consultant consultant1 = new(name, phoneNumber);
            consultantList.Add(consultant1);

        }

        public static void WriteListToConsole(List<Consultant> consultantList)
        {
            foreach (Consultant consultant in consultantList)
            {
                Console.WriteLine(consultant.InfoToString());
            }
        }
    }
}