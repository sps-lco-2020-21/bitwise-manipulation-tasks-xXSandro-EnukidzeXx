using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Xml;

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
            /*int y = Convert.ToInt32(Console.ReadLine(), 2);
            int output = (y & 0b111);
            Console.WriteLine(Convert.ToString(output, 2));*/

            //Get the leftmost bit
            /*string z = Console.ReadLine();
            int leftMost = Convert.ToInt32(z.Substring(0, 1),2);
            int output = (leftMost & 0b1);
            Console.WriteLine(Convert.ToString(output, 2));*/

            //Get the 3 leftmost bits
            /*string z = Console.ReadLine();
            int leftMost = Convert.ToInt32(z.Substring(0, 3), 2);
            int output = (leftMost & 0b111);
            string binOutput = Convert.ToString(output, 2);
            while(binOutput.Length < 3)
            {
                binOutput = "0" + binOutput;
            }
            Console.WriteLine(binOutput);*/

            //remove the right most bit
            /*string input = Console.ReadLine();
            int output = Convert.ToInt32(input, 2) >> 1;
            Console.WriteLine(Convert.ToString(output, 2));
            */

            //remove t`he 3 rightmost bits
            /*string input = Console.ReadLine();
            int output = Convert.ToInt32(input, 2) >> 3;
            Console.WriteLine(Convert.ToString(output, 2));
            */

            //remove the leftmost bit of any input
            /*string input = Console.ReadLine();
            int andNo = Convert.ToInt32(new string('1', input.Length - 1), 2);
            int output = Convert.ToInt32(input, 2) & andNo;
            Console.WriteLine(Convert.ToString(output, 2));
            */

            //remove the 3 leftmost bits of any input
            /*string input = Console.ReadLine();
            int andNo = Convert.ToInt32(new string('1', input.Length - 3), 2);
            int output = Convert.ToInt32(input, 2) & andNo;
            Console.WriteLine(Convert.ToString(output, 2));
            */

            //get the 4 last most bits of any input then remove the last bit
            /*string input = Console.ReadLine();
            int inpM1= Convert.ToInt32(input, 2) >> 1;
            int output = (inpM1 & 0b111);
            Console.WriteLine(Convert.ToString(output, 2));
            */

            //Move the first bit of any input to the right
            /*string input = Console.ReadLine();
            int c1 = (Convert.ToInt32(input, 2) >> input.Length-1);
            input = input + Convert.ToString(c1,2);
            int andNo = Convert.ToInt32(new string('1', input.Length - 1), 2);
            int output = Convert.ToInt32(input, 2) & andNo;
            Console.WriteLine(Convert.ToString(output, 2));
            */

            //getbits
            Console.WriteLine(getbits("010110", 2, 1));
        }
        public static string getbits(string x, int n, int p)
        {
            string andNo = new string('1', n);
            int dec = Convert.ToInt32(andNo + new string('0', x.Length - p- andNo.Length + 1), 2);
            string output = Convert.ToString((Convert.ToInt32(x, 2) & dec), 2);
            output = Convert.ToString(Convert.ToInt32(output, 2) >> x.Length - n,2);
            while(output.Length<n)
            {
                output = "0" + output;
            }
            return (output);
        }
    }
}
