using System;

namespace project34
{
    internal interface IbaseArray: IprintArray
    {
        double getAverageArrayValue();
        void fillArray(bool isNotRandom);
    }
}