using System;
namespace project34
{
        internal class Program
    {
        static void Main(string[] args)
        {
            IPrintable[] arrays = new IPrintable[8];
            intProvider newInt = new intProvider();
            boolProvider newBool = new boolProvider();
            doubleProvider newDouble = new doubleProvider();
            stringProvider newString = new stringProvider();
            
            Console.WriteLine("Ввести массивы не случайно? (Yes, No): ");
            string answer = Console.ReadLine();
            bool userAnswer;
            if(answer == "Yes")
            {
                userAnswer = true;
            }
            
            else
            {
                userAnswer = false;
            }
            
            arrays[0] = new oneDimensionalArray<int>(userAnswer, newInt);
            arrays[1] = new oneDimensionalArray<bool>(userAnswer, newBool);
            arrays[2] = new oneDimensionalArray<double>(userAnswer, newDouble);
            arrays[3] = new oneDimensionalArray<string>(userAnswer, newString);
            arrays[4] = new twoDimensionalArray<int>(userAnswer, newInt);
            arrays[5] = new twoDimensionalArray<bool>(userAnswer, newBool);
            arrays[6] = new twoDimensionalArray<double>(userAnswer, newDouble);
            arrays[7] = new twoDimensionalArray<string>(userAnswer, newString);
            
            for (int i = 0; i < arrays.Length; i++)
            {
                Console.WriteLine("");
                arrays[i].printArray();
            }
        }
    }
}