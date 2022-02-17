using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    public class HW1
    {
        public static int MinElement(int[] mas)
        {
            int kol = mas.Length;
            int element = 0;
            int min = mas[0];
            for (int i = 1; i < kol; i++)
            {
                if (min > mas[i])
                {
                    min = mas[i];
                    element = i;
                }
            }
            return element;
        }
        public static long QueueTime(int[] customers, int n)
        {
            int kol = customers.Length;

            if (kol > n)
            {
                int kol_in_order = kol - n;
            }
            else
            {
                int max = customers[0];
                for (int i = 1; i < kol; i++)
                {
                    if (max < customers[i]) max = customers[i];
                }
                return max;
            }
            int[] kas = new int[n];
            for (int i = 0; i < n; i++)
            {
                kas[i] = customers[i];
            }
            int c = n;
            while (kol > c)
            {
                int min = MinElement(kas);
                kas[min] += customers[c];
                c++;
            }
            int time_order = kas[0];
            for (int i = 1; i < n; i++)
            {
                if (time_order < kas[i]) time_order = kas[i];
            }
            return time_order;
        }
    }

}
