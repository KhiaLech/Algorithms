using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace Algorithms
{
    class InsertionSort
    {
        void sort(List<int> arr)
        {
            int n = arr.Count;
            for (int i = 1; i < n; ++i)
            {
                int key = arr[i];
                int j = i - 1;

                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }

                arr[j + 1] = key;
            }
        }

        static void printArray(List<int> arr)
        {
           
            foreach (int i in arr)
            {
                Console.Write(i.ToString() + "  ");
            }

        }

        public static void Main()
        {
            List<int> arr;
            List<int> aList = new List<int>();

            var fileStream = new System.IO.FileStream("C:/Users/61478/OneDrive - Swinburne University/Diploma/Prog/Algorithms/Unsorted_Numbers.csv", FileMode.Open, FileAccess.Read);
            using (var streamReader = new StreamReader(fileStream))
            {
                int line;
                while ((line = Convert.ToInt32(streamReader.ReadLine())) != 0)
                {
                    aList.Add(line);
                }
            }

            arr = aList.ToList();
            for (int i = 0; i < arr.Count; i++)
            {
                Console.WriteLine(arr[i]);
            }

            InsertionSort ob = new InsertionSort();
            ob.sort(arr);

            Console.WriteLine("SORTED NUMBERS USING INSERTION SORT");
            printArray(arr);


            Console.WriteLine(Environment.NewLine + Environment.NewLine + "Would you like to start a binary search for the values 575154, 182339, 17132, 773788, 296934, 991395, 303270, 45231, 580, 629822?");
            var userdecision = Console.ReadLine();
            if (userdecision == "yes")
            {

               int k = arr.BinarySearch(575154);
                Console.WriteLine("575154 is in position " + k + " of the list");

                k = arr.BinarySearch(182339);
                Console.WriteLine("182339 is in position " + k + " of the list");

                 k = arr.BinarySearch(17132);
                Console.WriteLine("17132 is in position " + k + " of the list");

                 k = arr.BinarySearch(773788);
                Console.WriteLine("773788 is in position " + k + " of the list");

                 k = arr.BinarySearch(296934);
                Console.WriteLine("296934 is in position " + k + " of the list");

                 k = arr.BinarySearch(991395);
                Console.WriteLine("991395 is in position " + k + " of the list");

                 k = arr.BinarySearch(303270);
                Console.WriteLine("303270 is in position " + k + " of the list");

                 k = arr.BinarySearch(45231);
                Console.WriteLine("45231 is in position " + k + " of the list");

                 k = arr.BinarySearch(580);
                Console.WriteLine("580 is in position " + k + " of the list");

                 k = arr.BinarySearch(629822);
                Console.WriteLine("629822 is in position " + k + " of the list");

            }
            else
            {
                Console.WriteLine("goodbye");
            }
                       
            Console.ReadKey();
             
        }
    }
}
 