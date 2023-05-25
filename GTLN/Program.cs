using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTLN
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size;
            int[] arr;
            do
            {
                Console.Write("Enter a size: ");
                size = int.Parse(Console.ReadLine());
                if (size > 20)
                {
                    Console.WriteLine("size should not exceed 20");
                }
            }
            while (size > 20);

            arr = new int[size];
            int i = 0;
            while (i < arr.Length)
            {
                Console.WriteLine("Enter element" + (i + 1) + ": ");
                arr[i] = int.Parse(Console.ReadLine());
                i++;
            }
            Console.Write("property list"); 
            for(int j = 0; j < arr.Length; j++)
            {
                Console.Write(arr[j]+ "\t");
            }
            int max = arr[0];
            int index = 1;
            for (int j =0; j < arr.Length; j++) {
                if (arr[j] > max)
                {
                    max = arr[j];
                    index = j+1;
                }
            }
            Console.WriteLine("The largest property value in the list is " + max + " ,at position " + index);

            Console.ReadKey();
        }
    }
}
