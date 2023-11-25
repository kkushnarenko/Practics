/*

using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.IO;

namespace ConsoleApp1;
public class Program
{
    static void Main(string[] args)
    {
        string path = "numsTask1.6.txt";
        using (StreamReader sr = new StreamReader(path))
        {
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                string[] text = line.Split(' ');
                foreach (string word in text)
                {
                    if (word.Length % 2 != 0)
                    {
                        Console.WriteLine(word);
                    }
                }
            }
        }


    }
}
*/


/*

using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.IO;


namespace ConsoleApp1;
public class Program
{
    static void Main(string[] args)
    {
        string path = "numsTask2.6.txt";
        string[] lines = File.ReadAllLines(path);
        string longString = string.Join(" ", lines);
        Console.WriteLine(longString);
    }
}
*/


/*
//Задание 2

using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.IO;


namespace ConsoleApp1;
public class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите число ");
        int n = Convert.ToInt32(Console.ReadLine());
        if (n % 10 == 0)
        {
            Console.WriteLine($"{n} четное и делится на 10");
        }
        else if (n % 2 == 0 && n % 10 != 0)
        {
            Console.WriteLine($"{n} четное, но не делится на 10");
        }
        else
        {
            Console.WriteLine($"{n} нечетное и не делится на 10");
        }
    }
}
*/


/*

using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.IO;

namespace ConsoleApp1;
public class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите число a = ");
        int sum = 0;
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите положительные числа");
        while (true)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            if (n % a == 0)
            {
                sum += n;
            }
            else if (n < 0)
            {
                break;
            }
        }
        Console.WriteLine($"Сумма поожительных чисел, которое делится на a = {sum}");

    }
}
*/


/*

using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.IO;


namespace ConsoleApp1;
public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите количество срок ");
        int n = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите количество столбцов ");
        int m = Convert.ToInt32(Console.ReadLine());

        int[,] matrix = new int[n, m + 1];
        Console.WriteLine("Вывод матрицы без добавления столбца");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                matrix[i, j] = RandomNumberGenerator.GetInt32(0, 1 + 1);
            }
        }
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();

        Console.WriteLine("Вывод матрицы c добавлением столбца");

        for (int i = 0; i < n; i++)
        {
            int count = 0;
            for (int j = 0; j < m; j++)
            {
                if (matrix[i, j] == 1)
                {
                    count++;
                }

            }
            if (count % 2 != 0)
            {
                matrix[i, m] = 1;
            }
            else
            {
                matrix[i, m] = 0;
            }
        }
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m + 1; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}

*/


/*

//Задание 5

using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.IO;


namespace ConsoleApp1;
public class Program
{
    static void Main(string[] args)
    {
        Random rndl = new Random();
        double[] nums = new double[rndl.Next(1, 20)];
        for (int i = 0; i < nums.Length; i++)
        {
            nums[i] = rndl.NextDouble() * 20 - 10;
        }
        int positive = 0;
        int negative = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] >= 0)
            {
                positive++;
            }
            else
            {
                negative++;
            }
            Console.Write($"{nums[i]} ");

        }
        double[] positiveNums = new double[nums.Length - negative];
        double[] ngativeNums = new double[nums.Length - positive];
        int positiveIndex = 0;
        int negativeIndex = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] >= 0)
            {
                positiveNums[positiveIndex++] = nums[i];
            }
            else
            {
                ngativeNums[negativeIndex++] = nums[i];
            }
        }
        foreach (int i in positiveNums)
        {
            Console.WriteLine(i);
        }
        foreach (int i in ngativeNums)
        {
            Console.WriteLine(i);
        }

    }
}

*/

