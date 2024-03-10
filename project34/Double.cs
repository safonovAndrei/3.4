using System;

namespace project34
{
    public class doubleProvider: objectProvider<double>
    {
        public override double Generate(){
            double Double = random.NextDouble();
            return Double;
        }
        public override double Convert(string value){
            return int.Parse(value);
        }
    }
}