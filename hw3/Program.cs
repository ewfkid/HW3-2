﻿namespace hw3
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            OneDimensionalArray oneDimensionalArray =
                new OneDimensionalArray(new int[] { 1, 2, 3, 4 });
            oneDimensionalArray.PrintArray();
            Console.WriteLine("Среднее значение в одномерном массиве: " + oneDimensionalArray.GetAverage());

            TwoDimensionalArray twoDimensionalArray =
                new TwoDimensionalArray(new int[,] { { 1, 2, 3, 4, 5 }, { 1, 2, 3, 4, 5 } });
            twoDimensionalArray.PrintArray();
            Console.WriteLine("Среднее значение в двумерном массиве: " + twoDimensionalArray.GetAverage());

            JaggedArray jaggedArray = new JaggedArray(new int[][]
            {
                new int[] { 1, 2, 3 },
                new int[] { 4, 5, 6, 7 },
                new int[] { 8, 9 }
            });
            jaggedArray.PrintArray();
            Console.WriteLine("Среднее значение в зубчатом массиве: " + jaggedArray.GetAverage());

            OneDimensionalArray dimensionalArray = new OneDimensionalArray(new int[10]);
            Console.WriteLine("Массив, заполненный рандомными значениями : ");
            dimensionalArray.FillArrayWithRandomValues();
            dimensionalArray.PrintArray();
            dimensionalArray.FillArrayFromUserInput();
            Console.WriteLine("Массив, заполненный пользователем с клавиатуры : ");
            dimensionalArray.PrintArray();
            dimensionalArray.RecreateArray(new int[] { 1, 2, 3, 4, 5 });
            Console.WriteLine("Пересозданный массив: ");
            dimensionalArray.PrintArray();
        }
    }
}