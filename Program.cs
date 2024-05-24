using System;
using System.Threading;

class exam_1_21
    {
        static int resource = 0;
        void Main(string[] args)
        {
            Thread thread1 = new Thread(IncrementResource);
            Thread thread2 = new Thread(DecrementResource);
            thread1.Start();
            thread2.Start();
            thread1.Join();
            thread2.Join();
            Console.WriteLine("Значение ресурса: " + resource);
        }
        void IncrementResource()
        {
            for (int i = 0; i < 1000000; i++)
            {
                resource++;
            }
        }
        void DecrementResource()
        {
            for (int i = 0; i < 1000000; i++)
            {
                resource--;
            }
        }
}