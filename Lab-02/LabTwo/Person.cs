namespace LabTwo
{
    class Person
    {
        public int Age;
        public string FirstName;
        public string LastName;
        public Person Spouse;
        public static double SumOfAllAges;

        public static double AverageAge()
        {
            return Person.SumOfAllAges / 4;
        }

        public string GetFullName()
        {
            string fullName = FirstName + " " + LastName;
            return fullName;
        }

        public void PrintNameAndAge()
        {
            System.Console.WriteLine(this.GetFullName());
            System.Console.WriteLine(this.Age);
        }
    }
}
