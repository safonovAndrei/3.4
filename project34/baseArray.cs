using System;
namespace project34
{
    public abstract class baseArray: IbaseArray
    {
        public abstract double getAverageArrayValue();
        public void fillArray(bool isNotRandom)
        {
            if (isNotRandom)
            {
                getFormUserArray();
            }
            else
            {
                getRandomArray();
            }
        }
        public baseArray(bool isNotRandom)
        {
            fillArray(isNotRandom);
        }
        public abstract void printArray();
        protected abstract void getRandomArray();
        protected abstract void getFormUserArray();
    }
} 