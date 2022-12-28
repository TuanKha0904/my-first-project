using System;

class UCLN_BCNN
{
    static void Main()
    {
        int a, b, min;
        float ucln, bcnn;
        Console.Write("Enter first number: ");
        a = Int32.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        b = Int32.Parse(Console.ReadLine());
        min = (a < b) ? a : b;
        for (int i = min; i > 0; i--)
            if ((a % i == 0) && (b % i == 0))
            {
                ucln = i;
                bcnn = (a * b) / ucln;
                Console.WriteLine("UCLN: {0}  ;  BCNN: {1}", ucln, bcnn);
                break;
            }
        Console.ReadLine();
    }
}