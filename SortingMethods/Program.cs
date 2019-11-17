using System;
using System.Linq;

namespace SortingMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = new int[] { 40, 12, 35, 55, 21, 80, 65 };
            ////int[] input = new int[] { 12, 21, 35, 40, 55, 65, 80 }; --> best case

            Console.WriteLine("Input values: ");
            input.ToList().ForEach(e => Console.WriteLine(e));

            Console.WriteLine("choose sorting method: ");
            string option = Console.ReadLine();
            switch (option)
            {
                case "1":
                    BubbleSort b = new BubbleSort();
                    b.Sort(input).ToList().ForEach(e => Console.WriteLine(e));
                    break;

                case "2":
                    SelectionSort s = new SelectionSort();
                    s.Sort(input).ToList().ForEach(e => Console.WriteLine(e));
                    break;

                case "3":
                    InsertionSort i = new InsertionSort();
                    i.Sort(input).ToList().ForEach(e => Console.WriteLine(e));
                    break;

                case "4":
                    ShellSort ss = new ShellSort();
                    ss.Sort(input);
                    break;

                case "5":
                    QuickSort q = new QuickSort();
                    q.Sort(input);
                    break;

                default:
                    break;
            }
        }
    }
}
