using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            string line;
            FileStream aFile = new FileStream("C:/Users/61478/OneDrive - Swinburne University/Diploma/Prog/Algorithms/unsorted_numbers.csv", FileMode.Open);
            StreamReader sr = new StreamReader(aFile);
           // read data in line by line;
            while ((line = sr.ReadLine()) != null)
            {
                Console.WriteLine(line);
                line = sr.ReadLine();
            }
            // sr.Close();
            Console.ReadKey();
        }
    }
}


