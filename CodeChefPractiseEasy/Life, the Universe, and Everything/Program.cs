using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Life__the_Universe__and_Everything
{
    class Program
    {
        static void Main()
        {
            while (true)
            {
                int num = int.Parse(Console.ReadLine());
                if (num == 42)
                    break;
                Console.WriteLine(num);
            }
        }
    }
}
