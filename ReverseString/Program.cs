using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string reversestring = "";
            int length;

            length = stringInput.Length - 1;

            while (length >= 0)
            {
                reversestring = reversestring + stringInput[length];
                length--;
            }
            Console.WriteLine(reversestring);

            Console.ReadLine();

        }
        public static void Main(string[] args)
        {
            ReverseString("nutan");
        }
    }
    }

