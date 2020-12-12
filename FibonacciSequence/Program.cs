using System;
using System.Collections.Generic;

namespace FibonacciSequence
{
    class Program
    {
        static void GetSequence(int lastElement)
        {
            const short FirstElementSequence = 0;
            int nextElementSequence = 0;
            int currentElementSequence = 0;
            int previousElementSequence = 0;

            if (lastElement == FirstElementSequence)
            {
                Console.Write($"{FirstElementSequence}");
            }
            else if (lastElement < FirstElementSequence)
            {
                const short SecondElementNegativeSequence = -1;
                List<int> negativeSequence = new List<int>();
                currentElementSequence = SecondElementNegativeSequence;
                negativeSequence.Add(FirstElementSequence);
                while (nextElementSequence >= lastElement)
                {
                    negativeSequence.Add(currentElementSequence);
                    nextElementSequence = previousElementSequence + currentElementSequence;
                    previousElementSequence = currentElementSequence;
                    currentElementSequence = nextElementSequence;
                }
                negativeSequence.Reverse();
                foreach (int elementSequence in negativeSequence)
                {
                    Console.Write($"{elementSequence } ");
                }
            }
            else
            {
                const short SecondElementPositiveSequence = 1;
                Console.Write($"{FirstElementSequence} ");
                currentElementSequence = SecondElementPositiveSequence;
                while (nextElementSequence <= lastElement)
                {
                    Console.Write($"{currentElementSequence} ");
                    nextElementSequence = previousElementSequence + currentElementSequence;
                    previousElementSequence = currentElementSequence;
                    currentElementSequence = nextElementSequence;
                }
            }
            Console.WriteLine("\n");
        }
        static void Main(string[] args)
        {
            int lastElementSeqience = 0;
            ConsoleKeyInfo consoleKeyExit;
            do
            {
                Console.Clear();
                Console.WriteLine("\t\t\t\tThe Fibonacci series");
                Console.Write("Enter number: ");
                lastElementSeqience = Convert.ToInt32(Console.ReadLine());
                GetSequence(lastElementSeqience);
                Console.Write("To end the program press 'Y' or press any key to continue: ");
                consoleKeyExit = Console.ReadKey();
                Console.WriteLine("\n");
            } while (consoleKeyExit.Key == ConsoleKey.Y);
        }
    }
}
