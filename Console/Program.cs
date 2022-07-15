using System;
using System.IO;

namespace Console
{
    class Program
    {
        static string Movement;
        static void Main(string[] args)
        {
            Hanoi(10);
            //File.WriteAllText("Out.txt",Movement);
        }
        static void Hanoi(int n,string a = "a",string b = "b",string c = "c")
        {
            if (n > 0)
            {
                Hanoi(n - 1, a, c, b);
                System.Console.WriteLine(a + "  To   " + c);
                //Movement += a + "  To   " + c + "\n";
                Hanoi(n - 1, b, a, c);
            }
        }
    }
}
