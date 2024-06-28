using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySpace
{
     class Program
    {
        private static IncrementNumbers incrementNumbers = new IncrementNumbers();

        static void Main(string[] args)
        {
            RunThreadPool runThreadpool = new RunThreadPool();

            runThreadpool.Task4();

            Console.WriteLine("End of writing");
            Console.ReadLine();
        }
    }
}
