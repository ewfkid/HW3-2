namespace hw3
{
    public sealed class TwoDimensionalArray(int[,] array) : Array
    {
        public override double GetAverage()
        {
            int total = 0;
            int count = 0;
    
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    total += array[i, j];
                    count++;
                }
            }

            return Math.Round((double)total / count, 2);
        }

        public override void PrintArray()
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }

}

