using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] bubble = new int [10];
            int t;

            Console.WriteLine("Hi there! Lets sore some numbers!");
            Console.WriteLine("Press Enter to Continue!");
            Console.WriteLine("Please enter 10 numbers!");

            for (int i = 0; i < 10; i++)
            {
                int number = Convert.ToInt32(Console.ReadLine());
                bubble[i] = number;
            }

            Console.Write("\n your unsorted array is: ");

            foreach (int input in bubble)
                Console.Write(input + " ");

            for (int p = 0; p <= bubble.Length -2 ; p++)
            {
                for (int i = 0; i <= bubble.Length -2; i++)
                {
                    if (bubble[i] > bubble[i + 1 ])
                    {
                        t = bubble[i + 1];
                        bubble[i + 1] = bubble[i];
                        bubble[i] = t;
                    }

                }
                
            }
            Console.Write("\n");
            Console.Write("\n" + "Sorted Array:");
            foreach (int input in bubble)
            {
                Console.Write("\n" + input + "");
                 Console.WriteLine("\n");
            }
            
        }
    }
}
