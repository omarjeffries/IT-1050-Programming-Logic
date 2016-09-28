namespace LabTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("[Person 1 Info]");
            Person p1 = new Person();
            System.Console.Write("Enter Your First Name: ");
            p1.FirstName = System.Console.ReadLine();
            System.Console.Write("Enter Your Last Name: ");
            p1.LastName = System.Console.ReadLine();
            System.Console.Write("Enter Your Age: ");
            p1.Age = int.Parse(System.Console.ReadLine());
            p1.Spouse = new Person();
            System.Console.Write("Enter Your Spouse First Name: ");
            p1.Spouse.FirstName = System.Console.ReadLine();
            System.Console.Write("Enter Your Spouse Age: ");
            p1.Spouse.Age = int.Parse(System.Console.ReadLine());
            string fullp1Name = p1.GetFullName();
            string fullp1SpouseName = p1.Spouse.GetFullName();
            Person.SumOfAllAges += p1.Age;
            Person.SumOfAllAges += p1.Spouse.Age;

            System.Console.WriteLine("[Person 2 Info]");
            Person p2 = new Person();
            System.Console.Write("Enter Your First Name: ");
            p2.FirstName = System.Console.ReadLine();
            System.Console.Write("Enter Your Last Name: ");
            p2.LastName = System.Console.ReadLine();
            System.Console.Write("Enter Your Age: ");
            p2.Age = int.Parse(System.Console.ReadLine());
            p2.Spouse = new Person();
            System.Console.Write("Enter Your Spouse First Name: ");
            p2.Spouse.FirstName = System.Console.ReadLine();
            System.Console.Write("Enter Your Spouse Age: ");
            p2.Spouse.Age = int.Parse(System.Console.ReadLine());
            string fullp2Name = p2.GetFullName();
            string fullp2SpouseName = p2.Spouse.GetFullName();
            Person.SumOfAllAges += p2.Age;
            Person.SumOfAllAges += p2.Spouse.Age;

            System.Console.WriteLine("[Results]");
            System.Console.WriteLine(fullp1Name + " and " + fullp1SpouseName);
            System.Console.WriteLine(fullp2Name + " and " + fullp2SpouseName);
            System.Console.WriteLine("Average Age: " + Person.AverageAge());
            System.Console.WriteLine("Press any key to continue...");
            System.Console.ReadKey();
        }
    }
}
