namespace hw3
{
    public sealed class JaggedArray : ArrayBase
    {
        private int[][] array;

        public JaggedArray(int[][] array)
        {
            this.array = array;
        }

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

        public override void FillArrayFromUserInput()
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Введите количество столбцов");
                int columns = int.Parse(Console.ReadLine());
                array[i] = new int[columns];

                for (int j = 0; j < columns; j++)
                {
                    Console.WriteLine($"Введите элемент массива с индексами: {i} {j}");
                    array[i][j] = int.Parse(Console.ReadLine());
                }
            }
        }

        public override void FillArrayWithRandomValues()
        {
            Random rnd = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                int columns = rnd.Next(1, 10);
                array[i] = new int[columns];

                for (int j = 0; j < columns; j++)
                {
                    array[i][j] = rnd.Next(-100, 100);
                }
            }
        }

        public void RecreateArray(int[][] newArray)
        {
            array = newArray;
        }
    }
}