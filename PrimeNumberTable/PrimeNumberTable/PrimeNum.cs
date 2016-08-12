using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumberTable
{
    public class PrimeNum
    {
        public static List<int> PrimeGen(int Prime)
        {
           
            List<int> primes = new List<int>();

            primes.Add(2);
            int nextPrime = 3;
            while (primes.Count < Prime)
            {
                int sqrt = (int)Math.Sqrt(nextPrime);
                bool isPrime = true;
                for (int i = 0; (int)primes[i] <= sqrt; i++)
                {
                    if (nextPrime % primes[i] == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    primes.Add(nextPrime);
                }
                nextPrime += 2;
            }
            return primes;
        }

        public static void PrimeTable(List<int> primenumbers)
        {
            int largestNumber = primenumbers.ElementAt(primenumbers.Count - 1);
            string format = "{0," + ((largestNumber * largestNumber).ToString().Length + 1).ToString() + "} ";

            Console.Write(string.Format(format, ""));

            foreach (int x in primenumbers)
            {
                Console.Write(string.Format(format, x));
            }

            Console.WriteLine();
            foreach (int x in primenumbers)
            {
                Console.Write(string.Format(format, x));
                foreach (int y in primenumbers)
                { 
                    Console.Write(string.Format(format, x * y));
                }
                Console.WriteLine();
            }
        }
    }
}



