namespace LabTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            p1.Age = 31;
            p1.FirstName = "John";
            p1.LastName = "Doe";
            p1.Spouse = new Person();
            p1.Spouse.Age = 30;
            p1.Spouse.FirstName = "Jane";
            p1.Spouse.LastName = p1.LastName;
            p1.Spouse.Spouse = p1;
            string fullp1Name = p1.GetFullName();
            string fullp1SpouseName = p1.Spouse.GetFullName();
            Person.SumOfAllAges += p1.Age;
            Person.SumOfAllAges += p1.Spouse.Age;
           
            Person p2 = new Person();
            p2.Age = 44;
            p2.FirstName = "Chris";
            p2.LastName = "Wallac";
            p2.Spouse = new Person();
            p2.Spouse.Age = 45;
            p2.Spouse.FirstName = "Kim";
            p2.Spouse.LastName = p2.LastName;
            p2.Spouse.Spouse = p2;
            string fullp2Name = p2.GetFullName();
            string fullp2SpouseName = p2.Spouse.GetFullName();
            Person.SumOfAllAges += p2.Age;
            Person.SumOfAllAges += p2.Spouse.Age;

            System.Console.WriteLine(fullp1Name + " and " + fullp1SpouseName);
            System.Console.WriteLine(fullp2Name + " and " + fullp2SpouseName);
            System.Console.WriteLine("Average Age: " + Person.AverageAge());
            System.Console.WriteLine("Press any key to continue...");
            System.Console.ReadKey();
        }
    }
}
