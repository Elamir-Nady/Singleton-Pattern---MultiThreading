using System;
using System.Threading.Tasks;

namespace Singleton_Pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task task1 = Task.Factory.StartNew(() =>
              {
                  Counter counter1 = Counter.GetInstance();
                  counter1.Addone();
                  Console.WriteLine("counter1 : " + counter1.count.ToString());
              });

            Task task2 = Task.Factory.StartNew(() =>
            {
                Counter counter2 = Counter.GetInstance();
                counter2.Addone();
                Console.WriteLine("counter2 : " + counter2.count.ToString());
                Console.WriteLine();
            });

        }
    }
}
