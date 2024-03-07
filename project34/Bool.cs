using System;

namespace project34
{
    public class IntProvider: ObjectProvider<bool>
    {
        public override bool Generic(){
            bool Bool = random.Next(0, 2);
            return Bool;
        }
        public override bool Convert(string value){
            return bool.Parse(value);
        }
    }
}