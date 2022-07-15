using System;
using System.IO;

namespace Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            List<int> ints = new();
            for (int i = 0; i < 100; i++)
            {
                ints.Add(random.Next(0,1000));
            }
            ints.Sort();
            foreach(int tmp in ints)
            {
                System.Console.WriteLine(tmp);
            }
            System.Console.WriteLine("\n\n\n" + BinarySearch(ints, int.Parse(System.Console.ReadLine())).ToString());
        }
        static int? BinarySearch(List<int> List,int value)
        {
            int left = 0;
            int right = List.Count - 1;
            int mid = List.Count / 2;
            while (left <= right)
            {
                if(List[mid] == value)
                {
                    return mid;
                }
                else if (List[mid] > value)
                {
                    right = mid - 1;
                }
                else if (List[mid] < value)
                {
                    left = mid + 1;
                }
                mid = (right + left) / 2;
            }
            return null ;
        }
    }
}
