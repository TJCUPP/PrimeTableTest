using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PrimeNumberTable
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Please enter whole number that is equal or greater to 1");
            string primeAsString = Console.ReadLine();
            int Prime = int.Parse(primeAsString);
            

            if (Prime > 0)
            {
                var primeNum = PrimeNum.PrimeGen(Prime);
                PrimeNum.PrimeTable(primeNum);
            }

            else
            {
                Console.Write("Sorry but 0 isn't greater than one. Please reload and try again!. \n\n\n Goodbye! \n");
            }
            
        }
    }
}
