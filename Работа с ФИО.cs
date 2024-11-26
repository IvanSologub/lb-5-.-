using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<string> fullNameList = new List<string>();
        
        Console.Write("Введите ваше ФИО (например, Сологуб Иван Павлович): ");
        string fullName = Console.ReadLine();
        fullNameList.Add(fullName);

        while (true)
        {
            Console.WriteLine("\nВыберите операцию:");
            Console.WriteLine("1) Вытащить фамилию, имя или отчество отдельно.");
            Console.WriteLine("2) Отсортировать фамилию по возрастанию или убыванию.");
            Console.WriteLine("3) Изменить своё имя, фамилию, отчество.");
            Console.WriteLine("4) Вывести полное ФИО.");
            Console.WriteLine("5) Проверить наличие слова в фамилии.");
            Console.WriteLine("0) Выход.");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    ExtractNameParts(fullName);
                    break;
                case "2":
                    SortSurname(fullName);
                    break;
                case "3":
                    fullName = ChangeFullName(fullName);
                    break;
                case "4":
                    Console.WriteLine($"Ваше полное ФИО: {fullName}");
                    break;
                case "5":
                    CheckSurnameContainsWord(fullName);
                    break;
                case "0":
                    return;
                default:
                    Console.WriteLine("Неверный выбор. Попробуйте снова.");
                    break;
            }
        }
    }

    static void ExtractNameParts(string fullName)
    {
        string[] parts = fullName.Split(' ');

        if (parts.Length == 3)
        {
            Console.WriteLine($"Фамилия: {parts[0]}");
            Console.WriteLine($"Имя: {parts[1]}");
            Console.WriteLine($"Отчество: {parts[2]}");
        }
        else
        {
            Console.WriteLine("Неверный формат ФИО. Убедитесь, что вы ввели фамилию, имя и отчество.");
        }
    }

    static void SortSurname(string fullName)
    {
        string surname = fullName.Split(' ')[0];
        char[] surnameChars = surname.ToCharArray();
        
        Console.WriteLine("Выберите порядок сортировки: 1) Возрастание 2) Убывание");
        string order = Console.ReadLine();

        if (order == "1")
        {
            Array.Sort(surnameChars);
            Console.WriteLine($"Отсортированная фамилия по возрастанию: {new string(surnameChars)}");
        }
        else if (order == "2")
        {
            Array.Sort(surnameChars);
            Array.Reverse(surnameChars);
            Console.WriteLine($"Отсортированная фамилия по убыванию: {new string(surnameChars)}");
        }
        else
        {
            Console.WriteLine("Неверный выбор порядка сортировки.");
        }
    }

    static string ChangeFullName(string fullName)
    {
        Console.Write("Введите новое ФИО (например, Сологуб Иван Павлович): ");
        return Console.ReadLine();
    }

    static void CheckSurnameContainsWord(string fullName)
    {
        string surname = fullName.Split(' ')[0];
        Console.Write("Введите слово для проверки наличия в фамилии: ");
        string word = Console.ReadLine();

        if (surname.Contains(word, StringComparison.OrdinalIgnoreCase))
        {
            Console.WriteLine($"Слово '{word}' содержится в вашей фамилии.");
        }
        else
        {
            Console.WriteLine($"Слово '{word}' не найдено в вашей фамилии.");
        }
    }
}
