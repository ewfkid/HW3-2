namespace hw3
{
    public sealed class OneDimensionalArray(int[] array) : Array
    {
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
    }
}