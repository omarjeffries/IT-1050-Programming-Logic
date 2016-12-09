namespace Lab_05
{
    class Program
    {
        static void Main(string[] args)
        {
            Board c = new Board(8);
            c.Fill();
            c.Print();
            System.Console.ReadKey();

            int width = 8;
            int height = 8;

            int[,] chessSpace = new int[width, height];
            chessSpace[0, 0] = 0;
            
            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    System.Console.Write(chessSpace [x, y] + " X ");
                }
                System.Console.WriteLine();
            }

            System.Console.WriteLine();
            

            while (true)
            {
                System.Console.WriteLine("Enter Target X Coordinate Between 0 and 7:");
                int x = int.Parse(System.Console.ReadLine());

                System.Console.WriteLine("Enter Target Y Coordinate Between 0 and 7:");
                int y = int.Parse(System.Console.ReadLine());

                System.Console.WriteLine("Enter Destination X Coordinate Between 0 and 7:");
                int dx = int.Parse(System.Console.ReadLine());

                System.Console.WriteLine("Enter Destination Y Coordinate Between 0 and 7:");
                int dy = int.Parse(System.Console.ReadLine());
            }



        }
    }
}