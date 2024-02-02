namespace hw3
{
    public sealed class TwoDimensionalArray : ArrayBase
    {
        private int[,] array;

        public TwoDimensionalArray(int[,] array)
        {
            this.array = array;
        }

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

        public override void FillArrayFromUserInput()
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.WriteLine($"Введите элемент массива с индексом {i} {j}");
                    array[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }

        public override void FillArrayWithRandomValues()
        {
            Random rnd = new Random();


            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = rnd.Next(-100, 100);
                }
            }
        }

        public void RecreateArray(int[,] newArray)
        {
            array = newArray;
        }
    }
}