using System;

namespace project34
{
    public sealed class twoDimensionalArray<Z>: baseArray<Z>
    {
        private Z[,] array;

        public twoDimensionalArray(bool isNotRandom, objectProvider<Z> inputProvider): base(isNotRandom, inputProvider){ }

        protected override void getFromUserArray()
        {
            Console.WriteLine("Ширина двумерного массива: ");
            int length = int.Parse(Console.ReadLine());
            Console.WriteLine("Длина двумерного массива: ");
            int width = int.Parse(Console.ReadLine());
            array = new Z[width, length];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.WriteLine($"Введите элемент с координатой ({j + 1}; {i + 1}): ");
                    array[i, j] = Provider.Convert(Console.ReadLine());
                }
            }
        }

        protected override void getRandomArray()
        {
            Random random = new Random();
            int length = random.Next(3, 10);
            int width = random.Next(3, 10);
            array = new Z[width, length];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = Provider.Generate();
                }
            }
        }

        public override void printArray()
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}