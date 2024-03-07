using System;

namespace project34
{
    public class IntProvider: ObjectProvider<int>
    {
        public override int Generic(){
            int Int = random.Next(-100, 100);
            return Int;
        }
        public override int Convert(string value){
            return int.Parse(value);
        }
    }
}