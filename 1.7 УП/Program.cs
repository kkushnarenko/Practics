using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;


using static ConsoleApp1.Program2;


namespace ConsoleApp1;

public class Program2
{
    class Task
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime deadline { get; set; }
    }

    static List<Task> tasks = new List<Task>();
    static string jsonFilePath = "task.json";
    static void Main(string[] args)
    {
        Console.WriteLine("Это ваш ежедневник");

        Console.WriteLine("Выберите действие, которое хотите совершить");
        Console.WriteLine("1. Добавить задачу");
        Console.WriteLine("2. Удалить задачу");
        Console.WriteLine("3. Изменить задачу ");
        Console.WriteLine("4. Показать все задачи");
        Console.WriteLine("5. Показать задачи на сегодня");
        Console.WriteLine("6. Показать задачи на завтра");
        Console.WriteLine("7. Показать задачи на неделю");
        Console.WriteLine("8. Показать просроченные задачи");
        Console.WriteLine("9. Показать актульные задачи");
        Console.WriteLine("q - выход из ежедневника");

        string userInput = Console.ReadLine();

        while (userInput != "q")
        {
            switch (userInput)
            {
                case "1":
                    addTask(tasks);
                    break;
                case "2":
                    deleteTask(tasks);
                    break;
                case "3":
                    editTask(tasks);
                    break;
                case "4":
                    showTask(tasks, DateTime.Now);
                    break;
                case "5":
                    showTask(tasks, DateTime.Now.AddDays(1));
                    break;
                case "6":
                    showTask(tasks, DateTime.Now.AddDays(7));
                    break;
                case "8":
                    compliteTask();
                    break;
                case "9":
                    uncompliteTask();
                    break;
            }

            Console.WriteLine("Выберите действие, которое хотите совершить");
            Console.WriteLine("1. Добавить задачу");
            Console.WriteLine("2. Удалить задачу");
            Console.WriteLine("3. Изменить задачу ");
            Console.WriteLine("4. Показать все задачи");
            Console.WriteLine("5. Показать задачи на сегодня");
            Console.WriteLine("6. Показать задачи на завтра");
            Console.WriteLine("7. Показать задачи на неделю");
            Console.WriteLine("8. Показать просроченные задачи");
            Console.WriteLine("9. Показать актульные задачи");
            Console.WriteLine("q - выход из ежедневника");

            userInput = Console.ReadLine();
            saveTask();
        }
    }
    static void addTask(List<Task> tasks)
    {
        Console.WriteLine("Введите название задачи");
        string name = Console.ReadLine();
        Console.WriteLine("Введите описание задачи");
        string description = Console.ReadLine();
        Console.WriteLine("Введите срок задачи");
        Console.WriteLine("Введите день (дд):");
        int day = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите месяц (мм):");
        int month = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите год (гггг):");
        int year = Convert.ToInt32(Console.ReadLine());

        DateTime deadline = new DateTime(year, month, day);

        Task task = new Task { Title = name, Description = description, deadline = deadline };

        tasks.Add(task);
        Console.WriteLine("Задача добавлена");
    }
    static void deleteTask(List<Task> tasks)
    {
        int index = 0;
        foreach (Task task in tasks)
        {
            Console.WriteLine($"номер задачи - {index}, задача на этот день - {task} ");
            index++;
        }

        Console.WriteLine("Введите номер задачи, чтобы удалить его");
        int choose = Convert.ToInt32(Console.ReadLine());
        if (choose >= 0 && choose < tasks.Count)
        {
            tasks.RemoveAt(choose);
            Console.WriteLine("Задача удалена");
        }
        else
        {
            Console.WriteLine("Неверный номер задачи");
        }
    }
    static void editTask(List<Task> tasks)
    {
        int index = 0;
        foreach (Task t in tasks)
        {
            Console.WriteLine($"номер задачи - {index}, задача на этот день - {t.Title} описание {t.Description} ");
            index++;
        }
        Console.WriteLine("Введите номер задачи, чтобы изменить его");
        int choose = Convert.ToInt32(Console.ReadLine());
        if (choose >= 0 && choose < tasks.Count)
        {
            tasks.RemoveAt(choose);
        }
        else
        {
            Console.WriteLine("Неверный номер задачи");
        }

        Console.WriteLine("Введите название задачи");
        string name = Console.ReadLine();
        Console.WriteLine("Введите описание задачи");
        string description = Console.ReadLine();
        Console.WriteLine("Введите срок задачи (дд:мм:гггг)");
        Console.WriteLine("Введите день (дд):");
        int day = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите месяц (мм):");
        int month = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите год (гггг):");
        int year = Convert.ToInt32(Console.ReadLine());

        DateTime deadline = new DateTime(year, month, day);

        var task = new Task { Title = name, Description = description, deadline = deadline };

        tasks.Append(task);
        Console.WriteLine("Задача изменена");
    }
    static void showTask(List<Task> tasks, DateTime time) 
    {
        Console.WriteLine("Список задач");
        foreach(Task t in tasks)
        {
            Console.WriteLine($"Название задачи: {t.Title}, описание: {t.Description}, дата: {t.deadline}");
        }
    }

    static void compliteTask()
    {
        Console.WriteLine("Просроченные задачи:");

        DateTime Time = DateTime.Now;
        
        foreach(Task t in tasks)
        {
            if(t.deadline < Time)
            {
                Console.WriteLine($"Название: {t.Title}, Описание: {t.Description}, Дата завершения: {t.deadline}");
            }
        }
    }
    static void uncompliteTask()
    {
        Console.WriteLine("Актуальные задачи");
        DateTime Time = DateTime.Now;

        foreach (Task t in tasks)
        {
            if (t.deadline > Time)
            {
                Console.WriteLine($"Название: {t.Title}, Описание: {t.Description}, Дата завершения: {t.deadline}");
            }
        }
    }
    static void saveTask()
    {
        File.WriteAllText(jsonFilePath, JsonConvert.SerializeObject(tasks, Formatting.Indented));
    }
}

