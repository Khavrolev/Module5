using System;

class MainClass
{
    static void Main(string[] args)
    {
        Console.Write("Напишите число: ");
        int num = int.Parse(Console.ReadLine());

        Console.Write("Напишите степень: ");
        byte power = byte.Parse(Console.ReadLine());

        int result = PowerUp(num, power);

        Console.Write("Число {0} в степени {1} = {2}", num, power, result);

        Console.ReadKey();
    }

    private static int PowerUp(int N, byte pow)
    {
        if (pow == 0)
            return 1;
        else if (pow == 1)
            return N;
        else
            return N * PowerUp(N, pow--); 
    }
}