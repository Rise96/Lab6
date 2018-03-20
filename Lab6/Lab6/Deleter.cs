using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab6
{
    class Deleter
    {
        public List<int> Delete(List<int> array)
        {
            int difference = DifferenceBetweenFirstAndLast(array);
            for (int i = 0; i < array.Count(); i++)
            {
                if (array[i] % difference == 0)
                {
                    array.RemoveAt(i);
                    i--;
                }
            }
            return array;
        }

        public int DifferenceBetweenFirstAndLast(List<int> array)
        {
            int difference = Math.Abs(Math.Abs(array[0]) - Math.Abs(array.Last()));
            return difference;
        }
    }
}
