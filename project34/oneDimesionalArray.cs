using System;

namespace project34
{
    
    public sealed class oneDimensionalArray<Z>: baseArray<Z>
    {

        private bool isNotRandom = false;
        private Z[] array;

        public oneDimensionalArray(bool isNotRandom, objectProvider<Z> inputProvider): base(isNotRandom, inputProvider){ }

        protected override void getRandomArray()
        {
            Random random = new Random();
            array = new Z[random.Next(1, 10)];
            for (int i = 0; i < array.Length; i++)
            {   
                array[i] = Provider.Generate();
            }
        }
        
        protected override void getFromUserArray()
        {
            Console.Write("Длина одномерного массива: ");
            array = new Z[int.Parse(Console.ReadLine())];
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"Введите {i + 1} элемент массива: ");
                array[i] = Provider.Convert(Console.ReadLine());
            }
        }

        public override void printArray() 
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]}; ");
            }
            Console.WriteLine(" ");
        }
    }
}