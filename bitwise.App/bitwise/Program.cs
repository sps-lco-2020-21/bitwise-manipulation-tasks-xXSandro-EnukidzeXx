using System;
using System.Security.Cryptography.X509Certificates;

namespace bitwise
{
    class Program
    {
        static void Main()
        {
            //Get the rightmost bit
            /*int x = Convert.ToInt32(Console.ReadLine(), 2);
            Console.WriteLine(Convert.ToString(x & 1),2);*/

            //Get the rightmost 3 bits
            int y = Convert.ToInt32(Console.ReadLine(), 2);
            Console.WriteLine(Convert.ToString(y & 111), 2);
        }
    }
}
