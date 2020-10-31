

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sorting_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] list = { 156, 67, 45, 86, 35, 53, 83, 10, 43, 76 };
            Console.WriteLine("Unsorted array");
            foreach (int i in list)
            {
                Console.Write(i + " ");
            }
            Array.Sort(list);
            Console.WriteLine("\nSorted List");
            for (int i = 0; i < list.Length; i++)
            {
                Console.WriteLine(list[i] + " ");
            }
            Console.ReadLine();
        }
    }
}
