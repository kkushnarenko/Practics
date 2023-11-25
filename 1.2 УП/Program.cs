/*

using System;
using System.Collections.Generic;
using System.Security.Cryptography;
namespace ConsoleApp1;
public class Program
{
    static void Main(string[] args)
    {
        int a = 300;
        int[] nums = new int[100]; for (int i = 0; i < 100; i++)
        {
            nums[i] = a;
            a -= 3; Console.WriteLine(nums[i]);
        }
    }
}
*/


/*

using System;
using System.Collections.Generic;
using System.Security.Cryptography;
namespace ConsoleApp1;
public class Program
{
    static void Main(string[] args)
    {
        int a = 1; int[] nums = new int[10];
        for (int i = 0; i < 10; i++)
        {
            if (a % 2 != 0)
            {
                nums[i] = a;
                a++;
            }
            Console.WriteLine(nums[i]);
            a++;
        }
    }
}
*/


/*

using System;
using System.Collections.Generic;
using System.Security.Cryptography;
namespace ConsoleApp1;
public class Program
{
    static void Main(string[] args)
    {
        int n = 6; int[,] matrix = new int[n, n];
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (i == 0 || j == 0)
                {
                    matrix[i, j] = 1;
                }
                else if (i != 0 || j != 0)
                {
                    matrix[i, j] = matrix[i - 1, j] + matrix[i, j - 1];
                }
            }
        }
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write($"{matrix[i, j]} \t");
            }
            Console.WriteLine();
        }
    }
}
*/


/*

using System;
using System.Collections.Generic;
using System.Security.Cryptography;
namespace ConsoleApp1;

public class Program
{
    static void Main(string[] args)
    {
        int[,] temperature = new int[12, 30];
        for (int i = 0; i < 12; i++)
        {
            for (int j = 0; j < 30; j++)
            {
                temperature[i, j] = RandomNumberGenerator.GetInt32(-10, 25);
            }
        }
        average(temperature);
        Sort(temperature);
    }
    static void average(int[,] temperature)
    {
        int[] average = new int[12]; int sum = 0;
        for (int i = 0; i < 12; i++)
        {
            sum = 0; for (int j = 0; j < 30; j++)
            {
                sum += temperature[i, j];
            }
            average[i] = sum / 30;
        }
        for (int i = 0; i < 12; i++)
        {
            Console.WriteLine($"Средняя температура месяца {i + 1} это {average[i]} градусов.");
        }
    }

    static void Sort(int[,] a)
    {
        int rows = a.GetLength(0);
        int cols = a.GetLength(1);
        int swap = 0;
        bool swapped;
        for (int i = 0; i < rows; i++)
        {
            swapped = false;
            for (int j = 0; j < cols - 1; j++)
            {
                if (a[i, j] > a[i, j + 1])
                {
                    swap = a[i, j];
                    a[i, j] = a[i, j + 1];
                    a[i, j + 1] = swap;
                    swapped = true;
                }
            }
            if (!swapped)
            {
                break;
            }
        }
    }
}

*/


/*

using System;
using System.Collections.Generic;
using System.Security.Cryptography;
namespace ConsoleApp1;

public class Program
{
    static int[] Randomer()
    {
        Random rnd = new Random();
        int[] days = new int[30];
        for (int i = 0; i < days.Length; i++)
        {
            days[i] = rnd.Next(-30, 30);

        }
        return days;
    }
    static void Main(string[] args)
    {
        int temperature = 0;

        Dictionary<string, int[]> month = new Dictionary<string, int[]>
        {
            { "Январь", Randomer() },
            { "Февраль", Randomer() },
            { "Март", Randomer() },
            { "Апрель", Randomer() },
            { "Май", Randomer() },
            { "Июнь", Randomer() },
            { "Июль", Randomer() },
            { "Август", Randomer() },
            { "Сентябрь", Randomer() },
            { "Октябрь", Randomer() },
            { "Ноябрь", Randomer() },
            { "Декабрь", Randomer() }

        };
        Dictionary<string, int> average = new Dictionary<string, int>();

        foreach (var temp in month)
        {
            int sum = 0;
            foreach (var value in temp.Value)
            {
                sum += value;
            }
            int averageMonth = sum / 30;
            average.Add(temp.Key, averageMonth);
        }
        Console.WriteLine($"Средняя температура по месяцам");

        List<KeyValuePair<string, int>> keys = average.ToList();
        keys = keys.OrderBy(a => a.Value).ToList();
        foreach (var key in keys)
        {
            Console.WriteLine($"{key.Key}, средняя температура {key.Value}");
        }

    }
}

*/