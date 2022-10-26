using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMPE2800_ICA02_Iterator_usingYield
{
    class Program
    {
        static void Main(string[] args)
        {
            // shuffle
            Console.WriteLine("Shuffle List");
            foreach (var item in Utils.Shuffle(new List<int>() { 2, 4, 6, 8, 10 }))
                Console.Write($"{item}, ");
            Console.WriteLine();
            Console.WriteLine("Shuffle Step");
            foreach (var item in Utils.Shuffle(Utils.Step(1, 25, 1)))
                Console.Write($"{item}, ");
            Console.WriteLine("---");
            // supersort
            Console.WriteLine("SuperSort of Shuffled Step");
            foreach (var item in Utils.SuperSort(Utils.Shuffle(Utils.Step(10, 50, 5))))
                Console.Write($"{item}, ");
            Console.WriteLine("---");
            // demo for PullMin<T>
            string test = "hello, this is a test of the function you are testing";
            foreach (char ret in Utils.PullMin(test))
                Console.WriteLine(ret);
            Console.WriteLine("---");
            // demo for step
            foreach (int i in Utils.Step(1000, 1050, 3))
                Console.WriteLine($"Stepping by 3s (1000, 1050): {i}");
            Console.WriteLine("---");
            // demo for Primes
            Dictionary<long, List<ulong>> primes = new Dictionary<long, List<ulong>>();
            foreach ((ulong val, long t) x in Utils.Primes().Take(25000))
            {
                if (!primes.ContainsKey(x.t))
                {
                    primes.Add(x.t, new List<ulong>());
                    Console.WriteLine($"New category : {x}");
                }
                primes[x.t].Add(x.val);
            }
            foreach (KeyValuePair<long, List<ulong>> x in primes)
                Console.WriteLine($"{x.Key}ms : {x.Value.Count} elements");
            Console.WriteLine("---");
            Console.WriteLine("\n\nall done!");
            Console.ReadKey();
        }
    }
}
