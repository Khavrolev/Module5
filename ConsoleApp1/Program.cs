using System;

class MainClass
{
    static int[] GetArrayFromConsole(int num = 5)
    {
        var result = new int[num];

        for (int i = 0; i < result.Length; i++)
        {
            Console.WriteLine("Введите элемент массива номер {0}", i + 1);
            result[i] = int.Parse(Console.ReadLine());
        }

        return result;
    }

    static int[] SortArray(int[] arr)
    {
        int temp;

        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[i] > arr[j])
                {
                    temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }
 //           Console.WriteLine(arr[i]);
        }

        return arr;
    }

    static void ShowArray(int[] arr, bool flag = false)
    {
        int[] result = arr;

        if (flag)
        {
            result = SortArray(arr);
        }

        foreach(int item in result)
        {
            Console.WriteLine(item);
        }
    }

    public static void Main(string[] args)
    {
        int[] array = GetArrayFromConsole(10);
 //       int[] sortarray = SortArray(array);
        ShowArray(array, true);

        Console.ReadKey();
    }
}