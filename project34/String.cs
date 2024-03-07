using System;

namespace project34
{
    public class IntProvider: ObjectProvider<string>
    {
        public override string Generic(){
            string symbols = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ01234567890!@#$%^&*()-=_+~<>?.,;:|\/";
            //string String = symbols[random.Next(0, symbols.Length)] + symbols[random.Next(0, symbols.Length)] + symbols[random.Next(0, symbols.Length)] + symbols[random.Next(0, symbols.Length)] + symbols[random.Next(0, symbols.Length)] + symbols[random.Next(0, symbols.Length)] + symbols[random.Next(0, symbols.Length)] + symbols[random.Next(0, symbols.Length)] + symbols[random.Next(0, symbols.Length)] + symbols[random.Next(0, symbols.Length)];
            int length = 10;
            char[] chars = new char[length];
            for (int i = 0; i < length; i++)
            {
                chars[i] = symbols[random.Next(0, symbols.Length)];
            }
            return new string(chars);
        }
        public override string Convert(string value){
            return value;
        }
    }
}