
namespace LabOne
{
    class Program
    {
        static void Main(string[] args)
        {
            //Lab 1

            string firstName;

            string middleInitial;

            string lastName;

            int age;

            bool isCitizen;

            bool canVote;

            bool atLeast18;

            int heightFeet;

            double heightInches;

            double totalHeightCM;

            System.Console.Write("What is your First Name? ");
            firstName = System.Console.ReadLine();

            System.Console.Write("What is your Middle Initial? ");
            middleInitial = System.Console.ReadLine();

            System.Console.Write("What is your last name? ");
            lastName = System.Console.ReadLine();

            System.Console.WriteLine("My full name is " + firstName + " " + middleInitial + ". " + lastName);

            System.Console.Write("How tall are you in feet? ");
            heightFeet = int.Parse(System.Console.ReadLine());

            System.Console.Write("How many additional inches are you? ");
            heightInches = double.Parse(System.Console.ReadLine());

            heightFeet = (heightFeet * 12);
            totalHeightCM = ((heightFeet + heightInches) * 2.54);

            System.Console.WriteLine("My height in Centimeters equals " + totalHeightCM);

            System.Console.Write("How old are you? ");
            age = int.Parse(System.Console.ReadLine());

            System.Console.Write("Are you a citizen? True or False: ");
            isCitizen = bool.Parse(System.Console.ReadLine());

            atLeast18 = (age >= 18);
            canVote = (isCitizen && atLeast18);
            
            System.Console.WriteLine("Can I vote? " + canVote);
            
            System.Console.WriteLine("Press any key to continue...");
            System.Console.ReadKey();
        }
    }
}
