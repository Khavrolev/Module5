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

    static void SortArray(in int[] arr, out int[] sorteddesc, out int[] sortedasc)
    {
        sorteddesc = SortArrayDesc(arr);
        sortedasc = SortArrayAsc(arr);
    }

    static int[] SortArrayDesc(int[] arr)
    {
        int temp;
        int[] newArr = new int[arr.Length];
        Array.Copy(arr, newArr, arr.Length);
        for (int i = 0; i < newArr.Length; i++)
        {
            for (int j = i + 1; j < newArr.Length; j++)
            {
                if (newArr[i] < newArr[j])
                {
                    temp = newArr[i];
                    newArr[i] = newArr[j];
                    newArr[j] = temp;
                }
            }
        }

        return newArr;
    }

    static int[] SortArrayAsc(int[] arr)
    {
        int temp;
        int[] newArr = new int[arr.Length];
        Array.Copy(arr, newArr, arr.Length);
        for (int i = 0; i < newArr.Length; i++)
        {
            for (int j = i + 1; j < newArr.Length; j++)
            {
                if (newArr[i] > newArr[j])
                {
                    temp = newArr[i];
                    newArr[i] = newArr[j];
                    newArr[j] = temp;
                }
            }
        }

        return newArr;
    }

    static void ShowArray(int[] arr)
    {
        foreach(int item in arr)
        {
            Console.WriteLine(item);
        }
    }

    public static void Main(string[] args)
    {
        int[] array = GetArrayFromConsole(5);
        int[] sorteddesc;
        int[] sortedasc;

        SortArray(array, out sorteddesc, out sortedasc);

        Console.WriteLine("Первая сортировка: ");
        ShowArray(sorteddesc);

        Console.WriteLine("Вторая сортировка: ");
        ShowArray(sortedasc);

        Console.ReadKey();
    }
}