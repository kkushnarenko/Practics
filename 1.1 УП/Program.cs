/*

using System;
using System.Collections.Generic;
using System.Security.Cryptography;
namespace Day1kush
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[10]; for (int i = 0; i < 10; i++)
            {
                nums[i] = RandomNumberGenerator.GetInt32(10);
            }
            int minNums = 1000;
            int indexNums = 0; for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(nums[i]);
                if (nums[i] < minNums)
                {
                    minNums = nums[i];
                    indexNums = i;
                }
            }
            Console.WriteLine($"Номер минимального элементаа массива {indexNums}");
        }
    }
}
*/


/*
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
namespace Day1kush
{
    class Program
    {
        static void Main(string[] args)
        {
            List<float> nums = new List<float>();
            float sum = 0;
            float average = 0;
            for (int i = 0; i < 10;)
            {
                float addNums = Convert.ToInt32(Console.ReadLine());

                if (addNums == 0)
                {
                    i = 10;
                }
                sum = sum + addNums;
                nums.Add(addNums);
            }
            Console.WriteLine(sum);
            average = sum / nums.Count;
            Console.WriteLine(average);
        }
    }
}
*/


/*
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
namespace Day1kush
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> lines = new List<string>();
            var maxLine = 0;
            var minLine = 1000;

            for (int i = 0; i < 10;)
            {
                string addLine = Console.ReadLine();
                if (addLine == "")
                {
                    i = 10;
                }
                lines.Add(addLine);
            }
            if (lines.Count == 0)
            {
                Console.WriteLine("Список пуст");
            }
            foreach (string line in lines)
            {
                if (line.Length > maxLine)
                {
                    maxLine = line.Length;
                }
                if ((line.Length != 0) && (line.Length < minLine))
                {
                    minLine = line.Length;
                }
            }
            Console.WriteLine($"Длина самой короткой строки {minLine}");
            Console.WriteLine($"Длина самой длинной строки {maxLine}");
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
        Console.Write("Введите start ");
        int start = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите end ");
        int end = Convert.ToInt32(Console.ReadLine());
        int[] random = new int[0];
        RandomNumber(start, end, random);
    }
    public static void RandomNumber(int start, int end, int[] n)
    {
        List<int> number = new List<int>();
        Random rndl = new Random();
        for (int i = start; i <= end; i++)
        {
            int addNums = rndl.Next(start, end + 1);
            number.Add(addNums);
            n = number.ToArray();
            Console.Write($"{n[i - 1]} ");
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
        string teht = Console.ReadLine();
        string start = "start";
        string end = "end";
        teht = start + " " + teht + " " + end;
        string[] word = teht.Split(new char[] { ' ' });
        foreach (string s in word)
        {
            Console.WriteLine(s);
        }
        Console.WriteLine(word.Length);
    }
}
*/
