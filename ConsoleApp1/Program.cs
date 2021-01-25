using System;

class MainClass
{
    static void Main(string[] args)
    {
        Console.Write("Напишите число: ");
        decimal num = decimal.Parse(Console.ReadLine());

        decimal fac = Factorial(num);

        Console.Write("Факториал числа: {0}", fac);

        Console.ReadKey();
    }

    static decimal Factorial(decimal x)
    {
        if (x == 0)
        {
            return 1;
        }
        else
        {
            return x * Factorial(x - 1);
        }
    }
}