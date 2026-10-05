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
        public void WypiszTablice()
        {
            foreach (int number in Numbers)
            {
                Console.Write(number + " ");
            }
        }
    }
}
