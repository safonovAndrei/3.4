using System;

namespace project34
{
    public class IntProvider: ObjectProvider<double>
    {
        public override double Generic(){
            double Double = random.NextDouble(-100, 100);
            return Double;
        }
        public override double Convert(string value){
            return int.Parse(value);
        }
    }
}