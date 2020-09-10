using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        public void getNumbers()
        {
            int a = 0;
            a = int.MaxValue;
            Console.WriteLine(a);
            checked
            {
                a++;
                Console.WriteLine(a);
            }
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            (new Program()).getNumbers();
        }
    }
}
