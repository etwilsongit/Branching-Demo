using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("<Enter FIZZ>");
            int fizz = int.Parse(Console.ReadLine());
            Console.WriteLine("<Enter BUZZ>");
            int buzz = int.Parse(Console.ReadLine());
            Console.WriteLine("<Enter TEST>");
            int test = int.Parse(Console.ReadLine());

            if (fizz % test == 0 && buzz % test == 0)
            {
                Console.WriteLine("fizzbuzz");
            }
            else if (fizz % test == 0) 
            {
                Console.WriteLine("fizz");
            }
            else if (buzz % test == 0)
            {
                Console.WriteLine("buzz");
            }
            

        }
    }
}
