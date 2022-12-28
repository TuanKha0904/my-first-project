using System;

// giải phương trình ax + b = 0
class PTB1
{
    static void Main()
    {
        float a, b, x;
        Console.Write("Enter A: ");
        a = Single.Parse(Console.ReadLine());
        Console.Write("Enter B: ");
        b = Single.Parse(Console.ReadLine());
        if (a == 0)
            Console.WriteLine("No solution");
        else
        {
            x = -b / a;
            Console.WriteLine("X = {0}", x);
        }
        Console.ReadLine();
    }
}