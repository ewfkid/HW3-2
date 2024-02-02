namespace hw3
{
    public sealed class OneDimensionalArray : ArrayBase
    {
        private int[] array;

        private int length;

        bool userFilled = false;

        public OneDimensionalArray(bool userFilled, int length)
        {
            array = new int[length];

            if (userFilled)
            {
                FillArrayFromUserInput();
            }
            else
            {
                FillArrayWithRandomValues();
            }
        }


        public OneDimensionalArray(int[] array)
        {
            this.array = array;
        }

        public override double GetAverage()
        {
            int total = 0;
            foreach (int value in array)
            {
                total += value;
            }

            return Math.Round((double)total / array.Length, 2);
        }

        public override void PrintArray()
        {
            foreach (int value in array)
            {
                Console.Write(value + " ");
            }

            Console.WriteLine();
        }

        public override void FillArrayFromUserInput()
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"Введите элемент массива с индексом {i}");

                array[i] = int.Parse(Console.ReadLine());
            }
        }

        public override void FillArrayWithRandomValues()
        {
            Random rnd = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(-1000, 1000);
            }
        }

        public void RecreateArray(int[] newArray)
        {
            array = newArray;
        }
    }
}