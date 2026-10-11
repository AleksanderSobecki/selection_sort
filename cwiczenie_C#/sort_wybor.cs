using System;
using System.Collections.Generic;
using System.Text;

namespace cwiczenie_C_
{
    public class sort_wybor
    {
        public int[]? Numbers;
        public int ZnajdzMax(int StartIndex)
        {
            var max = 0;
            var IndexMax = StartIndex;

            for (var i = StartIndex; i < Numbers.Length; i++)
            {
                if (Numbers[i] > max)
                {
                    max = Numbers[i];
                    IndexMax = i;

                }
            }
            return IndexMax;
        }

        public int ZnajdzMin(int StartIndex)
        {
            var min = Numbers[StartIndex];
            var IndexMin = StartIndex;
            for (var i = StartIndex; i < Numbers.Length; i++)
            {
                if (Numbers[i] < min)
                {
                    min = Numbers[i];
                    IndexMin = i;
                }
            }
            return IndexMin;
        }
        public void SortujMalejaco()
        {
            for (int i = 0; i < Numbers.Length; i++)
            {
                var IndexMax = ZnajdzMax(i);
                var temp = Numbers[i];

                Numbers[i] = Numbers[IndexMax];
                Numbers[IndexMax] = temp;
            }
        }
        public void SortujRosnaco()
        {
            for (int i = 0; i < Numbers.Length; i++)
            {
                var IndexMin = ZnajdzMin(i);
                var temp = Numbers[i];
                Numbers[i] = Numbers[IndexMin];
                Numbers[IndexMin] = temp;
            }
        }
        public void WypiszTablice()
        {
            foreach (int number in Numbers)
            {
                Console.Write(number + " ");
            }
        }
    }
}
