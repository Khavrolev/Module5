using System;

class MainClass
{
    static void Main(string[] args)
    {
       var form = CreateForm();

        WriteForm(form);

        Console.ReadKey();
    }

    private static int CheckInt(string value)
    {
        int number;
        bool success = Int32.TryParse(value, out number);

        if (success)
            return number;
        else
            return 0;
    }

    private static string[] DynNames(int count, string text)
    {
        var names = new string[count];

        for (int i = 0; i < count; i++)
        {
            Console.Write("{0} №{1}: ", text, i + 1);
            names[i] = Console.ReadLine();
        }

        return names;
    }

    private static (string, string, int, bool, int, string[], int, string[]) CreateForm()
    {
        string firstName, secondName, answerPet;
        int age, countPet = 0, countColor;
        bool hasPet;
        string[] petsName = new string[0], colors;

        Console.WriteLine("Здравствуйте, заполните информацию о себе!");

        Console.Write("Введите своё имя: ");
        firstName = Console.ReadLine();

        Console.Write("Введите свою фамилию: ");
        secondName = Console.ReadLine();

        do
        {
            Console.Write("Введите свой возраст: ");
            age = CheckInt(Console.ReadLine());
        } while (age <= 0);

        Console.Write("Если у Вас есть питомец, напишите \"Да\": ");
        answerPet = Console.ReadLine();

        if (answerPet == "Да")
            hasPet = true;
        else
            hasPet = false;

        if (hasPet) { 
            do
            {
                Console.Write("Введите количество Ваших животных: ");
                countPet = CheckInt(Console.ReadLine());
            } while (countPet <= 0);

            petsName = DynNames(countPet, "Введите имя Вашего животного");
         }

        do
        {
            Console.Write("Введите количество Ваших любимых цветов: ");
            countColor = CheckInt(Console.ReadLine());
        } while (countColor <= 0);

        colors = DynNames(countColor, "Введите имя Вашего любимого цвета");

        return (firstName, secondName, age, hasPet, countPet, petsName, countColor, colors);
    }

    private static void WriteForm((string firstName, string secondName, int age,
                                  bool hasPet, int countPet, string[] petsName, 
                                  int countColor, string[] colors) tuple)
    {
        Console.WriteLine("Ваше имя: {0}", tuple.firstName);

        Console.WriteLine("Ваша фамилия: {0}", tuple.secondName);

        Console.WriteLine("Ваш возраст: {0}", tuple.age);

        Console.WriteLine("У вас есть животные: {0}", (tuple.hasPet) ? "Да" : "Нет");

        if (tuple.hasPet)
        {
            Console.WriteLine("У вас животных: {0}", tuple.countPet);

            for (int i = 0; i < tuple.countPet; i++)
            {
                Console.WriteLine("Имя животного №{0}: {1}", i + 1, tuple.petsName[i]) ;
            }
        }

        Console.WriteLine("У вас любимых цветов: {0}", tuple.countColor);

        for (int i = 0; i < tuple.countColor; i++)
        {
            Console.WriteLine("Имя любимого цвета №{0}: {1}", i + 1, tuple.colors[i]);
        }
    }
}