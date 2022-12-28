using System;

class PTB2
{
    static void Main()
    {
        float a, b, c, x1, x2, delta;
        Console.Write("Enter A: ");
        a = Single.Parse(Console.ReadLine());
        Console.Write("Enter B: ");
        b = Single.Parse(Console.ReadLine());
        Console.Write("Enter C: ");
        c = Single.Parse(Console.ReadLine());   
        if (a == 0)
        {
            if (b == 0)
                Console.WriteLine("No solution");
            else
            {
                x1 = -c / b;
                Console.WriteLine("x = {0}", x1);
            }
        }
        else
        {
            delta = (b * b) - (4 * a * c);
            if (delta < 0)
                Console.WriteLine("No solution");
            else if (delta == 0)
                Console.WriteLine("Douple solution: {0}", (-b / (2*a)));
            else
            {
                x1 = (float)(-b + Math.Sqrt(delta)) / (2 * a);
                x2 = (float)(-b - Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine("Has two solution: x1 = {0} , x2 = {1}", x1, x2);
            }    
        }

        Console.ReadLine();
    }
}