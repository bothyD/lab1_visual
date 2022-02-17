using System;

namespace lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] mas=new int[3];
            int[] mas = new int[] { 5,3,4};
            Console.WriteLine(HW1.QueueTime(mas, 1));
            int[] mas1 = new int[] { 10, 2, 3,3 };
            Console.WriteLine(HW1.QueueTime(mas1, 2));
            int[] mas2 = new int[] {  2, 3, 10 };
            Console.WriteLine(HW1.QueueTime(mas2, 2));
        }
    }
}
