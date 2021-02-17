using System;

namespace FibonacciSequence
{
    class Program
    {
        static void GetSequence(int lastElement)
        {
            const short FirstElementSequence = 0;
            const short SecondElementPositiveSequence = 1;
            int nextElementSequence = 0;
            int currentElementSequence = 0;
            int previousElementSequence = 0;
            if (lastElement == FirstElementSequence)
            {
                Console.Write($"{FirstElementSequence}");
            }
            else
            {
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
            Console.WriteLine("\t\t\t\tThe Fibonacci series");
            Console.Write("Enter number: ");
            lastElementSeqience = Convert.ToInt32(Console.ReadLine());
            GetSequence(lastElementSeqience);
        }
    }
}
