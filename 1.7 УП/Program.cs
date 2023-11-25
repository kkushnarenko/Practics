using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;


using static ConsoleApp1.Program2;

namespace ConsoleApp1;

public class Program2
{
    static void Main(string[] args)
    {
        List<(DateTime deadline, string task)> todoTask = new List<(DateTime deadline, string task)>();
        
        Console.WriteLine("Это ваш ежедневник");

        Console.WriteLine("Выберите действие, которое хотите совершить");
        Console.WriteLine("1. Добавить задачу");
        Console.WriteLine("2. Удалить задачу");
        Console.WriteLine("3. Изменить задачу ");
        Console.WriteLine("4. Показать задачи ");
        Console.WriteLine("5. Показать задачи на завтра ");
        Console.WriteLine("6. Показать задачи на неделю ");
        Console.WriteLine("7. Показать выполненные задачи");
        Console.WriteLine("8. Показать не выполненные задачи");
        Console.WriteLine("q - выход из ежедневника");


        string userInput = Console.ReadLine();


        while (userInput != "q")
        {

            switch (userInput)
            {
                case "1":
                    addTask(todoTask, "tasks.json");
                    break;
                case "2":
                    removeTask(todoTask, "tasks.json");
                    break;
                case "3":
                    editTask(todoTask, "tasks.json");
                    break;
                case "4":
                    showTask(todoTask);
                    break;
                case "5":
                    showTask(todoTask);
                    break;
                case "6":
                    showTask(todoTask);
                    break;
                case "7":
                    Console.WriteLine("Выполненные задачи");
                    compliteTask(todoTask);      
                    break;
                case "8":
                    Console.WriteLine("Не выполненные задачи");
                    uncompliteTask(todoTask);
                    break;

            }

            Console.WriteLine("Выберите действие, которое хотите совершить");
            Console.WriteLine("1. Добавить задачу");
            Console.WriteLine("2. Удалить задачу");
            Console.WriteLine("3. Изменить задачу ");
            Console.WriteLine("4. Показать задачи ");
            Console.WriteLine("5. Показать задачи на завтра ");
            Console.WriteLine("6. Показать задачи на неделю ");
            Console.WriteLine("7. Показать выполненные задачи");
            Console.WriteLine("8. Показать не выполненные задачи");
            Console.WriteLine("q - выход из ежедневника");


            userInput = Console.ReadLine();
        }

    }

    public static void addTask(List<(DateTime deadline, string task)> list, string fileName)
    {

        Console.WriteLine("Добавьте ваши планы на этот день");

        string taskText = Console.ReadLine();

        Console.WriteLine("Введите дедлайн ");

        Console.WriteLine("Введите день (дд):");
        int day = Convert.ToInt32(Console.ReadLine());


        Console.WriteLine("Введите месяц (мм):");
        int month = Convert.ToInt32(Console.ReadLine());


        Console.WriteLine("Введите год (гггг):");
        int year = Convert.ToInt32(Console.ReadLine());


        Console.WriteLine("Введите время (чч:мм):");
        string[] time = Console.ReadLine().Split(':');
        int hour = Convert.ToInt32(time[0]);
        int minute = Convert.ToInt32(time[1]);

        DateTime deadline = new DateTime(year, month, day, hour, minute, 0);

        list.Add((deadline, taskText));

        Console.WriteLine("Добавленные задачи");
        foreach (var (deadlines, task) in list)
        {
            Console.WriteLine($"{deadlines} - дедлайн, задача {task}");

            var json = JsonConvert.SerializeObject(list, Formatting.Indented);
            File.WriteAllText(fileName, json);
        }


    }
    public static void removeTask(List<(DateTime deadline, string task)> list, string fileName)
    {
        int index = 0;
        foreach (var (deadlines, task) in list)
        {
            Console.WriteLine($"номер задачи - {index}, задача на этот день - {task}, дедлайн {deadlines}");
            index++;
        }

        Console.WriteLine("Введите номер задачи, чтобы удалить его");
        int choose = Convert.ToInt32(Console.ReadLine());
        if (choose >= 0 && choose < list.Count)
        {
            list.RemoveAt(choose);
            Console.WriteLine("Задача удалена");
        }
        else
        {
            Console.WriteLine("Неверный номер задачи");

        }

        Console.WriteLine("Задачи на этот день");
        foreach (var (deadlines, task) in list)
        {
            Console.WriteLine($"{deadlines} - задача {task}");

            var json = JsonConvert.SerializeObject(list, Formatting.Indented);
            File.WriteAllText(fileName, json);
        }
    }
    public static void editTask(List<(DateTime deadline, string task)> list, string fileName)
    {

        int index = 0;
        foreach (var (deadlines, task) in list)
        {
            Console.WriteLine($"номер задачи - {index}, задача на этот день - {task}, дедлайн {deadlines}");
            index++;
        }

        Console.WriteLine("Введите номер задачи, чтобы удалить его");
        int choose = Convert.ToInt32(Console.ReadLine());
        if (choose >= 0 && choose < list.Count)
        {
            list.RemoveAt(choose);
            string edit = Console.ReadLine();
            string taskText = Console.ReadLine();

            Console.WriteLine("Введите дедлайн ");

            Console.WriteLine("Введите день (дд):");
            int day = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Введите месяц (мм):");
            int month = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Введите год (гггг):");
            int year = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Введите время (чч:мм):");
            string[] time = Console.ReadLine().Split(':');
            int hour = Convert.ToInt32(time[0]);
            int minute = Convert.ToInt32(time[1]);

            DateTime deadline = new DateTime(year, month, day, hour, minute, 0);

            list.Add((deadline, taskText));
            Console.WriteLine("Задача изменина");
        }
        else
        {
            Console.WriteLine("Неверный номер задачи");

        }
        Console.WriteLine("Задачи на этот день");
        foreach (var (deadlines, task) in list)
        {
            Console.WriteLine($"{deadlines} {task}");

            var json = JsonConvert.SerializeObject(list, Formatting.Indented);
            File.WriteAllText(fileName, json);
        }
    }
    public static void showTask(List<(DateTime deadline, string task)> list)
    {
        if (list.Count == 0)
        {
            Console.WriteLine("Задач нет");
        }
        else
        {
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine($"{i + 1} Задачи {list[i]}");
            }
        }
    }
    public static void compliteTask(List<(DateTime deadline, string task)> list)
    {
        DateTime today = DateTime.Now;

        foreach (var (deadlines, task) in list)
        {
            if (today >= deadlines)
            {
                Console.WriteLine($"Сегодня {today}");
                Console.WriteLine($"{deadlines} задача '{task}'прошел дедлайн ");
            }
        }
    }
    public static void uncompliteTask(List<(DateTime deadline, string task)> list)
    {
        DateTime today = DateTime.Now;

        foreach (var (deadlines, task) in list)
        {
            if (today < deadlines)
            {
                Console.WriteLine($"Сегодня {today}");
                Console.WriteLine($"{deadlines} задача '{task}'не прошел дедлайн ");
            }
        }
    }
}