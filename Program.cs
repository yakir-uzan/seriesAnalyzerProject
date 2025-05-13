using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seriesAnalyzerProject
{
    internal class Program
    {

        static void Menu()
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Please choose what you want to do:\r\nA. Enter a series. (Replace the current series)\r\nB. Display the series in the order it was entered.\r\nC. Display the series in the reverse order it was entered.\r\nD. Display the series in sorted order (lowest to highest).\r\nE. Display the maximum value of the series.\r\nF. Display the minimum value of the series.\r\nG. Display the average of the series.\r\nH. Display the number of elements in the series.\r\nI. Display the sum of the series.\r\nj. Exit.");
                string input = Console.ReadLine();
                switch (input)
                {
                    case a:
                        replaseSeries();
                        break:
                    case b:
                        showSeries();
                        break:
                    case c:
                        reversedSeries();
                        break:
                    case d:
                        sortedSeries();
                        break:
                    case e:
                        showMax();
                        break:
                    case f:
                        showMin();
                        break:
                    case g:
                        showAverage();
                        break:
                    case h:
                        numElement();
                        break:
                    case i:
                        sumSeries();
                        break:
                    case j:
                        exit();
                        flag = false;
                        break:
                                                              
                           
                    





                }

            }

            
        }
        static void Main(string[] args)
        {
            Menu();
        }
    }
}
