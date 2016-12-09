namespace Lab_05
{
    class Board
    {
        public int Size;
        public string[][] Grid;

        public Board(int size)
        {
            this.Size = size;
            this.Grid = new string[size][];

            for (int i = 0; i < size; i++)
            {
                this.Grid[i] = new string[size];
            }
        }

        public void Fill()
        {
            for (int i=0; i < 8; i++)
            {
                for (int j=0; j < 8; j++)
                {
                    this.Grid[i][j] = " X ";
                }
            }
       
        }

        public void Print()
        {
            foreach (string[] row in Grid)
            {
                System.Console.WriteLine();

                foreach (string stringValue in row)
                {
                    System.Console.Write(stringValue);
                }
            }
        }

    }
}
