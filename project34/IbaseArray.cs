using System;

namespace ZZ
{
    internal interface IbaseArray: IprintArray
    {
        double getAverageArrayValue();
        void fillArray(bool isNotRandom);
    }
}