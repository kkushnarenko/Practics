/*
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
namespace ConsoleApp1;
public class Program
{
    static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        if (n > 0)
        {
            int product = 1;
            for (int i = 1; i <= n; i++)
            {
                if (i % 3 == 0)
                {
                    product = product * i;
                }
            }
            Console.WriteLine($"произведение всех чисел кратные трем {product}");

        }

    }
}
*/


/*

using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.IO;
using static System.Net.Mime.MediaTypeNames;

namespace ConsoleApp1;
public class Program
    {
        static void Main(string[] args)
        {
            string path = "nusmTask2.txt";
            double sum = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;

                while ((line = reader.ReadLine()) != null)
                {
                    string[] nums = line.Split(';');
                    double[] numes = new double[nums.Length];
                    for (int i = 0; i < numes.Length; i++)
                    {
                        numes[i] = double.Parse(nums[i]);

                    }
                    foreach (double nume in numes)
                    {
                        if (nume > 0)
                        {
                            sum += nume;
                        }
                    }

                }
            }
            Console.WriteLine(sum);
        }
    }
*/


/*

using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.IO;
using static System.Net.Mime.MediaTypeNames;

namespace ConsoleApp1;
public class Program
    {
        static void Main(string[] args)
        {
            int attitude = 0;
            string path = "numsTask3.txt";
            int mmin = 100000;
            int mmax = 0;
            using (StreamReader sr = new StreamReader(path))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] nums = line.Split(",");
                    int[] numes = new int[nums.Length];
                    for (int i = 0; i < nums.Length; i++)
                    {
                        numes[i] = int.Parse(nums[i]);
                    }
                    foreach (int n in numes)
                    {
                        if (mmin > n)
                        {
                            mmin = n;
                        }
                        if (mmax < n)
                        {
                            mmax = n;
                        }
                    }
                }
            }
            attitude = mmax / mmin;
            Console.WriteLine(attitude);


        }
    }
*/


/*

using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.IO;
using static System.Net.Mime.MediaTypeNames;

namespace ConsoleApp1;
public class Program
    {
        static void Main(string[] args)
        {
            string path = "numsTask4.txt";
            int counter = 0;
            using (StreamReader sr = new StreamReader(path))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] nums = line.Split(" ");
                    int[] number = new int[nums.Length];
                    for (int i = 0; i < nums.Length; i++)
                    {
                        number[i] = int.Parse(nums[i]);
                    }
                    for (int i = 1; i < number.Length; i++)
                    {
                        if (number[i] == number[i - 1])
                        {
                            counter++;
                        }
                    }
                }
            }
            Console.WriteLine(counter);

        }
    }
*/



/*
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.IO;
using static System.Net.Mime.MediaTypeNames;

namespace ConsoleApp1;
public class Program
    {
        static void Main(string[] args)
        {
            double x1 = 3;
            double y1 = 4;
            double y2 = -2;
            double x2 = -1;
            Console.Write("Введите x ");
            double x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите y ");
            double y = Convert.ToInt32(Console.ReadLine());

            if (x <= x1 && y <= y1 && y >= y2 && x >= x2)
            {
                Console.WriteLine("Точка принадлежит заштрихованной области");
            }
            else
            {
                Console.WriteLine("Точка не принадлежит заштрихованной области");
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
            Console.Write("Введите a ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите b ");
            double b = Convert.ToDouble(Console.ReadLine());
            if (a > -2 && b > -3 && a < 2 && b > -3 && a < 2 && b < 2 && a > -2 && b < 2)
            {
                Console.WriteLine("Точка принадлежит заштрихованной области");
            }
            else
            {
                Console.WriteLine("Точка не принадлежит заштрихованной области");
            }

        }
    }

*/



