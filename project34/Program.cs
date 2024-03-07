using System;
namespace project34
{
        internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("3.2");
            
            IbaseArray[] arrays = new IbaseArray[3];
            
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
            arrays[0] = new oneDimensionalArray(userAnswer);
            arrays[1] = new twoDimensionalArray(userAnswer);
            arrays[2] = new jagged(userAnswer);            

            for(int i = 0; i < arrays.Length; i++)
            {
                arrays[i].printArray();
                Console.WriteLine($"average value = {arrays[i].getAverageArrayValue()}");
            }

            Console.WriteLine("3.3");

            IprintArray[] arrays2 = new IprintArray[4];
            arrays2[0] = new oneDimensionalArray(userAnswer);
            arrays2[1] = new twoDimensionalArray(userAnswer);
            arrays2[2] = new jagged(userAnswer);
            arrays2[3] = new week();
            
            for (int i = 0; i < arrays2.Length; i++)
            {
                Console.WriteLine("");
                arrays2[i].printArray();
            }
        }
    }
}