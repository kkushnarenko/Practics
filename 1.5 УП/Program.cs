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
        string path = "numsTask1.5.txt";
        using (StreamReader sr = new StreamReader(path))
        {
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                string[] nums = line.Split(" ");
                int[] numes = new int[nums.Length];
                for (int i = 0; i < numes.Length; i++)
                {
                    numes[i] = int.Parse(nums[i]);
                }
                int mmin = 1000000;

                for (int i = 0; i < numes.Length; i++)
                {
                    if (numes[i] < mmin)
                    {
                        mmin = numes[i];

                    }
                }
                int product = 1;
                bool foundMmin = false;
                foreach (int i in numes)
                {

                    if (i == mmin)
                    {
                        foundMmin = true;
                    }
                    else if (foundMmin)
                    {
                        product *= i;
                    }
                }
                Console.WriteLine(product);
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
    static void Sort(double[] a)
    {
        var len = a.Length;
        for (int i = 0; i < len; i++)
        {
            for (int j = 0; j < len - i - 1; j++)
            {
                if (a[j] > a[j + 1])
                {
                    double b = a[j];
                    a[j] = a[j + 1];
                    a[j + 1] = b;
                }
            }
        }
    }
    static void Main(string[] args)
    {
        string path = "numsTask2.5.txt";
        using (StreamReader sr = new StreamReader(path))
        {
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                string[] nums = line.Split(';');
                double[] numes = new double[nums.Length];
                for (int i = 0; i < nums.Length; i++)
                {
                    numes[i] = double.Parse(nums[i]);
                }
                Sort(numes);
                foreach (double num in numes)
                {

                    Console.Write(num + " ");

                }
                Console.WriteLine();

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
        string path = "numsTask3.5.txt";
        using (StreamReader sr = new StreamReader(path))
        {
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                string[] nums = line.Split(" ");
                int[] numes = new int[nums.Length];
                for (int i = 0; i < numes.Length; i++)
                {
                    numes[i] = int.Parse(nums[i]);
                }
                int mmin = 10000;

                for (int i = 0; i < numes.Length; i++)
                {
                    if (numes[i] < mmin)
                    {
                        mmin = numes[i];
                    }
                }
                int average = 0;
                int sum = 0;
                int count = 0;
                bool FoundMmin = false;
                foreach (int num in numes)
                {
                    if (FoundMmin == false)
                    {
                        if (num == mmin)
                        {
                            FoundMmin = true;
                            continue;
                        }
                        sum += num;
                        count++;
                    }
                    else if (num == mmin)
                    {
                        FoundMmin = true;
                        break;
                    }
                }
                if (count > 0)
                {
                    average = sum / count;
                }
                else
                {
                    average = 0;
                }
                Console.WriteLine(average);
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
        string path = "numsTask4.5.txt";
        using (StreamReader sr = new StreamReader(path))
        {
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                string[] nums = line.Split(" ");
                int[] numes = new int[nums.Length];
                for (int i = 0; i < numes.Length; i++)
                {
                    numes[i] = int.Parse(nums[i]);
                }
                int mmax = 0;
                for (int i = 0; i < numes.Length; i++)
                {
                    if (numes[i] > mmax)
                    {
                        mmax = numes[i];
                    }
                }
                int mmaxPlusOne = mmax + 1;
                int mmaxMinusOne = mmax - 1;
                int sum = mmaxPlusOne + mmaxMinusOne;
                Console.WriteLine(sum);
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
        string path = "numesTask5.5.txt";
        using (StreamReader sr = new StreamReader(path))
        {
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                string[] nums = line.Split(" ");
                int[] numes = new int[nums.Length];
                for (int i = 0; i < numes.Length; i++)
                {
                    numes[i] = int.Parse(nums[i]);

                }
                int mmax = 0;
                int mmin = 10000;
                for (int i = 0; i < numes.Length; i++)
                {
                    if (numes[i] > mmax)
                    {
                        mmax = numes[i];
                    }
                    if (numes[i] < mmin)
                    {
                        mmin = numes[i];
                    }
                }
                int average = 0;
                int sum = 0;
                int count = 0;
                int start = Array.IndexOf(numes, mmin);
                int end = Array.IndexOf(numes, mmax);

                for (int i = start + 1; i < end; i++)
                {
                    sum += numes[i];
                    count++;
                }
                average = sum / count;
                Console.WriteLine(average);

            }
        }
    }
}

*/



