namespace hw3
{
    public sealed class JaggedArray(int[][] array) : Array
    {
        public override double GetAverage()
        {
            int total = 0;
            int count = 0;

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    total += array[i][j];
                    count++;
                }
            }

            return Math.Round((double)total / count, 2);
        }

        public override void PrintArray()
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    Console.Write(array[i][j] + " ");
                }

                Console.WriteLine();
            }
        }
    } 
}
