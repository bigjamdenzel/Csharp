using System;
using System.Threading;

public class Exercise1
{
    public static void Main()
    {
        int i;
       

        Console.WriteLine("The first 10 natural number are:");

        for (i = 1; i <= 10; i++)
        {
            Console.Write("{0} ", i);
        }

        Thread.Sleep(5000);
    }
}
