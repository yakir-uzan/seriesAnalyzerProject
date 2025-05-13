using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seriesAnalyzerProject
{
    internal class Program
    {
        static int[] inputUsers()
        {
            string[] input;
            int[] output;
            bool flag = true;
            while (true)
            {
                flag = true;
                Console.WriteLine("please enter 3 positive numbers: ");
                input = Console.ReadLine().Split(' ');
                output = new int[input.Length];
                for (int i = 0;i<input.Length;i++)
                {
                    if (int.TryParse(input[i], out int x) && x>0 )
                    {
                        output[i] = x;
                    }
                    else
                        flag = false;
                }
                if (flag && output.Length >=3)
                    return output;
            }
        }
        static void Menu()
        {
            int[] series = inputUsers();
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Please choose what you want to do:\r\nA. Enter a series. (Replace the current series)\r\nB. Display the series in the order it was entered.\r\nC. Display the series in the reverse order it was entered.\r\nD. Display the series in sorted order (lowest to highest).\r\nE. Display the maximum value of the series.\r\nF. Display the minimum value of the series.\r\nG. Display the average of the series.\r\nH. Display the number of elements in the series.\r\nI. Display the sum of the series.\r\nj. Exit.");
                string input = Console.ReadLine();
                switch (input)
                {
                    case "a":
                        series = inputUsers();
                        break;
                    case "b":
                        showSeries(series);
                        break;
                    case "c":
                        reversedSeries(series);
                        break;
                    case "d":
                        sortedSeries(series);
                        break;
                    case "e":
                        showMax(series);
                        break;
                    case "f":
                        showMin(series);
                        break;
                    case "g":
                        showAverage(series);
                        break;
                    case "h":
                        lenSeries(series);
                        break;
                    case "i":
                        sumSeries(series);
                        break;
                    case "j":
                        flag = false;
                        break;
                }

            }
        }
        static void showSeries(int[] series)
        {
            foreach (int num in series)
            {
                Console.Write(num + ",");
            }
        }
        static void reversedSeries(int[] series)
        {
            int lenSeries = series.Length;
            for (int i = lenSeries - 1; i >= 0; i--)
            {
                Console.Write(series[i] + ",");
            }
        }
        static int[] sortedSeries(int[] series)
        {
            int[] sorted = series;
             Array.Sort(sorted);
             return sorted;
        }
        static void showMax(int[] series)
        {
            int [] sorted = sortedSeries(series);
            Console.WriteLine(sorted[sorted.Length -1]);
        }
        static int showMin(int[] series)
        {
            int[] sorted = sortedSeries(series);
            return sorted[0];
        }
        static int showAverage(int[] series)
        {
            int sun = sumSeries(series);
            return sun / lenSeries(series);
        }
        static int lenSeries(int[] series)
        {
            int count = 0;
            for (int i = 0; i < series.Length; i++)
                count += 1;
           return count;
        }
        static int sumSeries(int[] series)
        {
            int sum = 0;
            for (int i = 0; i < series.Length; i++)
                sum += series[i];
             return sum;
        }
        static void Main(string[] args)
        {
            
            Menu();
            Console.WriteLine(",");
            Console.WriteLine(",");
        }
    }
}
