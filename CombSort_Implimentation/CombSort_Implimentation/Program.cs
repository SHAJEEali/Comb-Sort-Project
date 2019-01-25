using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Syed Shajee Ali Rizvi :17B-003-SE");
            Console.WriteLine("Madiha Shujaat 17B-010-SE");

            CombSort g = new CombSort();
            int[] arr = new int[5];

            Console.WriteLine("Enter the elements of the array:");
            for (int i = 0; i < 5; i++)
            {
                arr[i] = Convert.ToInt16(Console.ReadLine());
            }
            Console.WriteLine("Unsorted Array:");
            for (int i = 0; i < arr.Length; ++i)
                Console.Write(arr[i] + " ");

            Console.WriteLine("\nsorted array");
            g.sort(arr);
            for (int i = 0; i < arr.Length; ++i)
                Console.Write(arr[i] + " ");
            Console.Write("\n\n");
        }
    }
    class CombSort
    {
        //function initialize gap value by dividing it by shrink factor i.e: 1.3//
        static int getNextGap(int gap)
        {
            gap = (gap * 10) / 13;
            if (gap < 1)
                return 1;
            return gap;
        }
        //gfunction for sorting by using gapvalue //
        public void sort(int[] arr)
        {
            int n = arr.Length;
            int gap = n;
            bool swapped = true;
            //this loop will run until the gap value become 1 and no swapping can be perform next//
            while (gap != 1 || swapped == true)
            {
                //calling the function to initialize the gap value//
                gap = getNextGap(gap);

                swapped = false;
                for (int i = 0; i < n - gap; i++)
                {
                    if (arr[i] > arr[i + gap])
                    {
                        //swa[p if the value is greater than the other //
                        int temp = arr[i];
                        arr[i] = arr[i + gap];
                        arr[i + gap] = temp;
                        swapped = true;
                    }
                }
            }
        }
    }
}