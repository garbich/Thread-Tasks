using System.Threading;
using System;
using System.Collections.Generic;

namespace MySpace
{
    public class RunThreadPool
    {
        private int start;
        
        private int end;
        public void RunNameMutex()
        {

        }

        public void Task1()
        {
            Thread thread = new Thread(() =>
            {
                
                for (int i = 0; i < 50; i++)
                {
                    Console.WriteLine(i);
                    
                }
            });
            thread.Start();
            

            for (int i = 0; i < 50; i++)
            {
                thread.Join();
            }
        }
        public void Task2()
        {
            Console.Write("Input start of numbers: ");
            int start = int.Parse(Console.ReadLine());

            Console.Write("Input end of numbers: ");
            int end = Int32.Parse(Console.ReadLine());



            Thread thread = new Thread(() =>
            {
                for (int i = start; i <= end; i++)
                {
                    Console.WriteLine(i);

                }
            });
            thread.Start();


            for (int i = start; i <= end; i++)
            {
                thread.Join();
            }
        }

        public void Task3()
        {
            Console.Write("Input start of numbers: ");
             start = Int32.Parse(Console.ReadLine());

            Console.Write("Input end of numbers: ");
             end = Int32.Parse(Console.ReadLine());

            Console.Write("Input numbers of streams: ");
            int number = Int32.Parse(Console.ReadLine());


            Thread[] threads = new Thread[number];
            
                for (int i = 0; i < threads.Length; i++)
                {
                    
                threads[i] = new Thread(Run);
                threads[i].Start();
                }
                

            for (int i = 0; i < threads.Length; i++)
            {
                threads[i].Join();
            }


        }
        public void Run()
        {

            for (int i = start; i <= end; i++)
            {
                Console.WriteLine(i);
            }

        }

        public void Task4()
        {
           

            Console.Write("Input how many numbers generate: ");
            int count = Int32.Parse(Console.ReadLine());

            Random random = new Random();

            List<int> randomNum = new List<int>();

            int num = 0;

            for (int i = 0; i <= count; i++)
            {
                num = random.Next(1, 10000);
                randomNum.Add(num);
            }


            foreach (var item in randomNum)
            {
                Console.WriteLine(item);
            }

            Thread thread = new Thread(() =>
            {
                int maxNum = 0;
                foreach (var item in randomNum)
                {
                    if (maxNum < item)
                    {
                        maxNum = item;
                    }
                }
                
                Console.WriteLine("Max number: " + maxNum);

            });
            thread.Start();


            for (int i = 0; i <= randomNum.Count; i++)
            {
                thread.Join();
            }

            Thread thread1 = new Thread(() =>
            {
                int minNum = Int32.MaxValue;
                foreach (var item in randomNum)
                {
                    if (minNum > item)
                    {
                        minNum = item;
                    }
                }

                Console.WriteLine("Min number: " + minNum);

            });
            thread1.Start();


            for (int i = 0; i <= randomNum.Count; i++)
            {
                thread1.Join();
            }

            Thread thread2 = new Thread(() =>
            {
                double averageNum = 0;
                foreach (var item in randomNum)
                {
                    averageNum += item;
                }

                averageNum /= randomNum.Count;

                Console.WriteLine("Average number: " + averageNum);

            });
            thread2.Start();


            for (int i = 0; i <= randomNum.Count; i++)
            {
                thread2.Join();
            }


        }

        public void Task5()
        {
            string jsonString = System.

        }
    }
}