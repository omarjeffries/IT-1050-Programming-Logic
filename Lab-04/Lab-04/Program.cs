namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("When are you going to the movies? Matinee or Evening ");
            string movieTime = System.Console.ReadLine();
            double totalPeople;

            if (movieTime == "Matinee")
            {
                System.Console.WriteLine();
                System.Console.WriteLine("You are watching a matinee movie.");

                System.Console.WriteLine("How many Children are going? ");
                double child = double.Parse(System.Console.ReadLine());
                double conversionChild = child * 3.99;
                System.Console.WriteLine(conversionChild);

                System.Console.WriteLine("How many Adults are going? ");
                double adult = double.Parse(System.Console.ReadLine());
                double conversionAdult = adult * 5.99;
                System.Console.WriteLine(conversionAdult);

                System.Console.WriteLine("How many Seniors are going? ");
                double seniors = double.Parse(System.Console.ReadLine());
                double conversionSeniors = seniors * 4.50;
                System.Console.WriteLine(conversionSeniors);

                totalPeople = (child + adult + seniors);
                System.Console.WriteLine("Total Tickets: " + totalPeople);
                System.Console.WriteLine("Total Cost: " + conversionChild + conversionAdult + conversionSeniors);
            }

            else if (movieTime == "Evening")
            {
                System.Console.WriteLine();
                System.Console.WriteLine("You are watching an evening movie.");

                System.Console.WriteLine("How many Children are going? ");
                double child = double.Parse(System.Console.ReadLine());
                double conversionChild = child * 3.99;
                System.Console.WriteLine(conversionChild);

                System.Console.WriteLine("How many Adults are going? ");
                double adult = double.Parse(System.Console.ReadLine());
                double conversionAdult = adult * 5.99;
                System.Console.WriteLine(conversionAdult);

                System.Console.WriteLine("How many Seniors are going? ");
                double seniors = double.Parse(System.Console.ReadLine());
                double conversionSeniors = seniors * 4.50;
                System.Console.WriteLine(conversionSeniors);

                totalPeople = (child + adult + seniors);
                System.Console.WriteLine("Total Tickets: " + totalPeople);
                double totalCost = (conversionChild + conversionAdult + conversionSeniors);
                System.Console.WriteLine(totalCost);

                if (totalPeople >= 3)
                {
                    double finalTotal = totalCost - 4.50;
                    System.Console.WriteLine("Cost with discounts: " + finalTotal);
                }
            }

            else
            {
                System.Console.WriteLine("You are not going to the movies.");
            }

            System.Console.WriteLine("Do you want anything from the Concession Stand? Yes or No ");
            string snacks = System.Console.ReadLine();
            double smallsoda;
            double largesoda;
            double hotdogs;
            double popcorns;
            double candies;
            double concessionStand;

            if (snacks == "Yes")
            {
                System.Console.WriteLine("How many small sodas?");
                smallsoda = double.Parse(System.Console.ReadLine());
                smallsoda = (smallsoda * 3.50);

                System.Console.WriteLine("How many large sodas?");
                largesoda = double.Parse(System.Console.ReadLine());
                largesoda = (largesoda * 5.99);

                System.Console.WriteLine("How many hot dogs?");
                hotdogs = double.Parse(System.Console.ReadLine());
                hotdogs = (hotdogs * 3.99);

                System.Console.WriteLine("How many popcorns?");
                popcorns = double.Parse(System.Console.ReadLine());
                popcorns = (popcorns * 4.50);

                System.Console.WriteLine("How many candies?");
                candies = double.Parse(System.Console.ReadLine());
                candies = (candies * 1.99);

                concessionStand = (smallsoda + largesoda + hotdogs + popcorns + candies);

                if ((popcorns > 0) && (largesoda > 0))
                {
                    System.Console.WriteLine("Total cost of snacks with discount: " + (concessionStand - 2));
                }

                if (candies >= 5.97)
                {
                    System.Console.WriteLine("Candy Discount: " + (7.96 - 1.99));
                }

                concessionStand = (smallsoda + largesoda + hotdogs + popcorns + candies);

                System.Console.WriteLine("Total cost of snacks: " + concessionStand);


            }

            else
            {
                System.Console.WriteLine("Enjoy your movie with no snacks.");
            }

            System.Console.WriteLine();
            System.Console.WriteLine("Press any key to end...");
            System.Console.ReadKey();

        }
    }
}
