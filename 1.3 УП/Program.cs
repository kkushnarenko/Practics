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
        string[] lines = File.ReadAllLines("input.txt");
        string[] winningNumber = lines[0].Split(" ");


        List<string[]> ticketNumbers = new List<string[]>();

        for (int i = 2; i < lines.Length; i++)
        {
            ticketNumbers.Add(lines[i].Split(" "));

        }
        int WinningTicket = 0;
        string outputFileName = "output.txt";
        using (StreamWriter writer = new StreamWriter(outputFileName))

        {
            foreach (string[] ticketNumber in ticketNumbers)
            {
                WinningTicket = 0;
                foreach (string number in ticketNumber)
                {
                    if (winningNumber.Contains(number))
                    {
                        WinningTicket++;
                    }
                }
                if (WinningTicket >= 3)
                {
                    string output = "Lucky";
                    Console.WriteLine("Lucky");
                    writer.WriteLine(output);

                }
                else
                {
                    string output = "Unlucky";
                    Console.WriteLine("Unlucky");
                    writer.WriteLine(output);
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
        string path = "nums.txt";
        List<int> list = new List<int>();
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
                for (int i = 0; i < numes.Length; i++)
                {
                    if (numes[i] % 2 != 0)
                    {
                        list.Add(numes[i]);
                    }
                }

            }

        }
        using (StreamWriter sw = new StreamWriter("nums.txt", false))
        {
            foreach (int num in list)

            {

                sw.Write(num + " ");

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
        string path = "height.txt";
        using (StreamReader sr = new StreamReader(path))
        {
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                string[] heught = line.Split(' ');
                int[] height = new int[heught.Length];
                for (int i = 0; i < height.Length; i++)
                {
                    height[i] = int.Parse(heught[i]);
                }
                int output = 0;
                for (int i = 0; i < height.Length; i++)
                {
                    int mmax = 0;
                    int mmin = 1000000;
                    if (height[i] > mmax)
                    {
                        mmax = height[i];
                    }
                    if (height[i] < mmin)
                    {
                        mmin = height[i];
                    }
                    int difference = mmax - mmin;
                    mmax -= difference;
                    int[] value = new int[height.Length];
                    for (int j = 0; j < value.Length - 1; j++)
                    {
                        value[j] = mmax * mmin;
                        if (value[j] > value[j + 1])
                        {
                            output = value[j];
                        }
                    }

                }
                Console.WriteLine(output);
            }
        }

    }
}
*/