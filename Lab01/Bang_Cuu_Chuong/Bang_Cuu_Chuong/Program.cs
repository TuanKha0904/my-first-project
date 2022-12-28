using System;

class Bang_Cuu_Chuong
{
    static void Main()
    {
        for (int i = 2; i < 10; i++)
        {
            Console.WriteLine("Cuu Chuong {0}", i);
            for (int j = 1; j < 11; j++)
            {
                Console.WriteLine("{0} x {1} = {2}", i, j, i * j);
            }
            Console.WriteLine();
        }
        Console.ReadLine();
    }
}